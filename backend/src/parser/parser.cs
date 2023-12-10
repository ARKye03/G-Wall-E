using Tokens;
using Nodes;

namespace ParserAnalize;
public class Parser(List<Token> tokens)
{
    private List<Token> Tokens { get; set; } = tokens;
    public static List<FunctionDeclarationNode> FDN { get => fDN; set => fDN = value; }
    private static List<FunctionDeclarationNode> fDN = [];
    private int currentTokenIndex = 0;

    private Token? CurrentToken => currentTokenIndex < Tokens.Count ? Tokens[currentTokenIndex] : null;

    private Token ConsumeToken(TokenType type)
    {
        return CurrentToken?.Type == type
            ? Tokens[currentTokenIndex++]
            : throw new Exception($"Expected token {type}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
    }
    public Node Parse()
    {
        return ParseExpression();
    }
    private Node ParseExpression()
    {
        Node left = ParseTerm();

        while (CurrentToken?.Type == TokenType.Operator && (CurrentToken.Value == "+" || CurrentToken.Value == "-"))
        {
            var operatorToken = CurrentToken;
            ConsumeToken(TokenType.Operator);
            Node right = ParseTerm();
            left = new BinaryExpressionNode(left, operatorToken.Value, right);
        }

        return left;
    }
    private Node ParseTerm()
    {
        Node left = ParseFactor();

        while (CurrentToken?.Type == TokenType.Operator && (CurrentToken.Value == "*" || CurrentToken.Value == "/"))
        {
            var operatorToken = CurrentToken;
            ConsumeToken(TokenType.Operator);
            Node right = ParseFactor();
            left = new BinaryExpressionNode(left, operatorToken.Value, right);
        }
        return left;
    }
    private Node ParseFactor()
    {
        Node left = ParsePrimary();

        while (CurrentToken?.Type == TokenType.Operator && CurrentToken.Value == "^")
        {
            var operatorToken = CurrentToken;
            ConsumeToken(TokenType.Operator);
            Node right = ParsePrimary();
            left = new BinaryExpressionNode(left, operatorToken.Value, right);
        }

        return left;
    }
    private Node ParsePrimary()
    {
        if (CurrentToken?.Type == TokenType.LParen)
        {
            ConsumeToken(TokenType.LParen);
            var node = ParseExpression();
            _ = ConsumeToken(TokenType.RParen);
            return node;
        }
        else if (CurrentToken?.Type == TokenType.Operator && CurrentToken?.Value == "-")
        {
            ConsumeToken(TokenType.Operator);
            var node = ParsePrimary();
            return new BinaryExpressionNode(new ValueNode(0.0), "-", node);
        }
        else if (CurrentToken?.Type == TokenType.Number)
        {
            var numberToken = CurrentToken;
            ConsumeToken(TokenType.Number);
            return new ValueNode(double.Parse(numberToken.Value));
        }
        else
        {
            return (CurrentToken?.Type) switch
            {
                TokenType.Figure => ParseFigure(),
                TokenType.FunctionKeyword => ParseFunctionDeclaration,
                TokenType.Color => ParseColor,
                TokenType.Restore => ParseRestore,
                TokenType.Const => ParseConstDeclaration,
                TokenType.LetKeyword => ParseVariableDeclaration(),
                TokenType.Point => ParsePointExpression,
                TokenType.IfKeyword => ParseIfExpression,
                TokenType.Number => ParseNumber,
                TokenType.StringLiteral => ParseStringLiteral,
                TokenType.Identifier => ParseIdentifier,
                _ => throw new Exception($"Unexpected token {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}"),
            };
        }
    }

    private Node ParseFigure()
    {
        var type = CurrentToken?.Value;
        return type switch
        {
            "line" => ParseLine,
            "segment" => ParseSegment(),
            "ray" => ParseRay(),
            "circle" => ParseCircle(),
            "arc" => ParseArc(),
            _ => throw new Exception($"It's not a figure {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}. How do you even get here?"),
        };
    }

    private Node ParseArc()
    {
        throw new NotImplementedException();
    }

    private Node ParseCircle()
    {
        throw new NotImplementedException();
    }

    private Node ParseRay()
    {
        throw new NotImplementedException();
    }

    private Node ParseSegment()
    {
        throw new NotImplementedException();
    }

    private Node ParseLine
    {
        get
        {
            // line ln (p1, p2) "It's a line!";
            _ = ConsumeToken(TokenType.Figure);
            var name = ConsumeToken(TokenType.Identifier);
            _ = ConsumeToken(TokenType.LParen);
            var p1 = ParseExpression();
            _ = ConsumeToken(TokenType.Comma);
            var p2 = ParseExpression();
            _ = ConsumeToken(TokenType.RParen);
            var comment = ParseStringLiteral;
            LE.linND.Add(new LineNode(name.Value, A: (PointNode)p1, B: (PointNode)p2, comment));
            return new EndNode();
        }
    }

    private Node ParseNumber
    {
        get
        {
            var token = ConsumeToken(TokenType.Number);
            return new ValueNode(double.Parse(token.Value));
        }
    }

    private Node ParseIdentifier
    {
        get
        {
            var token = ConsumeToken(TokenType.Identifier);
            // If the identifier is followed by a left parenthesis, treat it as a function call
            if (CurrentToken?.Type == TokenType.LParen)
            {
                // Parse a function call
                var args = new List<Node>();
                _ = ConsumeToken(TokenType.LParen);
                while (CurrentToken?.Type != TokenType.RParen)
                {
                    args.Add(ParseExpression());
                    if (CurrentToken?.Type == TokenType.Comma)
                    {
                        _ = ConsumeToken(TokenType.Comma);
                    }
                }
                _ = ConsumeToken(TokenType.RParen);
                // Check if the function name is in the list of predefined functions
                if (LE.predefinedFunctions.ContainsKey(token.Value))
                {
                    return new FunctionPredefinedNode(token.Value, args);
                }
                // Check if the function name is in the list of declared functions
                else
                {
                    if (FDN.Any(f => f.Name == token.Value))
                    {
                        return new FunctionCallNode(token.Value, args);
                    }
                    else
                    {
                        throw new Exception($"Undefined function {token.Value}");
                    }
                }
            }
            else if (LE.poiND.Any(p => p.Name == token.Value))
            {
                return LE.poiND.First(p => p.Name == token.Value);
            }
            else
            {
                // Parse an identifier
                return new IdentifierNode(token.Value);
            }
        }
    }
    private Node ParseVariableDeclaration()
    {
        _ = ConsumeToken(TokenType.LetKeyword);

        return CurrentToken?.Type == TokenType.LLinq ? ParseMultipleVariableDeclaration : ParseSingleVariableDeclaration;
    }
    private Node ParseSingleVariableDeclaration
    {
        get
        {
            var identifier = ConsumeToken(TokenType.Identifier);
            _ = ConsumeToken(TokenType.Operator);
            var value = ParseExpression();
            _ = ConsumeToken(TokenType.InKeyword);
            var body = ParseExpression();
            return new VariableDeclarationNode(identifier.Value, value, body);
        }
    }
    private Node ParseMultipleVariableDeclaration
    {
        get
        {
            _ = ConsumeToken(TokenType.LLinq);
            _ = ConsumeToken(TokenType.LBrace);

            var declarations = new List<VariableDeclarationNode>();

            while (CurrentToken?.Type != TokenType.RBrace)
            {
                var identifier = ConsumeToken(TokenType.Identifier);
                _ = ConsumeToken(TokenType.Operator);
                var value = ParseExpression();
                declarations.Add(new VariableDeclarationNode(identifier.Value, value, null!));

                if (CurrentToken?.Type == TokenType.Comma)
                {
                    _ = ConsumeToken(TokenType.Comma);
                }
            }

            _ = ConsumeToken(TokenType.RBrace);
            _ = ConsumeToken(TokenType.InKeyword);
            var body = ParseExpression();

            return new MultipleVariableDeclarationNode(declarations, body);
        }
    }
    private Node ParsePointExpression
    {
        get
        {
            _ = ConsumeToken(TokenType.Point);
            var name = ConsumeToken(TokenType.Identifier);
            var x = new Random().Next(0, 100);
            var y = new Random().Next(0, 100);
            LE.poiND.Add(new PointNode(name.Value, x, y));

            return new EndNode();
        }

    }
    private Node ParseIfExpression
    {
        get
        {
            _ = ConsumeToken(TokenType.IfKeyword);
            var condition = ParseCondition;
            _ = ConsumeToken(TokenType.ThenKeyword);
            var thenExpression = ParseExpression();
            _ = ConsumeToken(TokenType.ElseKeyword);
            var elseExpression = ParseExpression();
            return new IfExpressionNode(condition, thenExpression, elseExpression);
        }
    }
    private Node ParseCondition
    {
        get
        {
            _ = ConsumeToken(TokenType.LParen);
            var left = ParseExpression();
            var operatorToken = ConsumeToken(TokenType.ComparisonOperator);
            var right = ParseExpression();
            _ = ConsumeToken(TokenType.RParen);
            return new BinaryExpressionNode(left, operatorToken.Value, right);
        }
    }
    private Node ParseStringLiteral
    {
        get
        {
            var token = ConsumeToken(TokenType.StringLiteral);
            return new ValueNode(token.Value);
        }
    }
    private Node ParseFunctionDeclaration
    {
        get
        {
            _ = ConsumeToken(TokenType.FunctionKeyword);
            var name = ConsumeToken(TokenType.FIdentifier);
            var args = new List<string>();
            while (CurrentToken?.Type != TokenType.Flinq)
            {
                var arg = ConsumeToken(TokenType.Parameter);
                args.Add(arg.Value);
            }
            _ = ConsumeToken(TokenType.Flinq);
            var body = ParseExpression();
            FDN.Add(new FunctionDeclarationNode(name.Value, args, body));
            return new EndNode();
        }
    }
    private Node ParseConstDeclaration
    {
        get
        {
            _ = ConsumeToken(TokenType.Const);
            var name = ConsumeToken(TokenType.Identifier);
            _ = ConsumeToken(TokenType.Operator);
            var valueNode = ParseExpression();

            LE.cDN.Insert(0, new ConstDeclarationNode(name.Value, valueNode)); // Store the valueNode at the beginning of the list
            return new EndNode();
        }
    }

    private Node ParseColor
    {
        get
        {
            _ = ConsumeToken(TokenType.Color);
            var name = ConsumeToken(TokenType.Identifier);
            LE.Color = name.Value;
            return new EndNode();
        }
    }

    private Node ParseRestore
    {
        get
        {
            _ = ConsumeToken(TokenType.Restore);
            LE.Color = "default";
            return new EndNode();
        }
    }
}