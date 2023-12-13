using Tokens;
using Nodes;
using Accessibility;

namespace ParserAnalize;
public class Parser
{
    private List<Token> Tokens { get; set; }
    private static List<FunctionDeclarationNode> fDN = new();
    private int currentTokenIndex = 0;

    private Token? CurrentToken => currentTokenIndex < Tokens.Count ? Tokens[currentTokenIndex] : null;

    public Parser(List<Token> tokens)
    {
        Tokens = tokens;
    }

    private Token ConsumeToken(TokenType type)
    {
        return CurrentToken?.Type == type
            ? Tokens[currentTokenIndex++]
            : throw new Exception($"Expected token {type}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
    }
    #region RecursiveDescentParser
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
                TokenType.DrawKeyword => ParseDraw,
                TokenType.MeasureKeyword => ParseMeasure,
                TokenType.FunctionKeyword => ParseFunctionDeclaration,
                TokenType.ColorKeyword => ParseColor,
                TokenType.RestoreKeyword => ParseRestore,
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
    #endregion
    #region Figures
    private Node ParseFigure()
    {
        var type = CurrentToken?.Value;
        return type switch
        {
            "line" => ParseLine,
            "segment" => ParseSegment,
            "ray" => ParseRay,
            "circle" => ParseCircle,
            "arc" => ParseArc,
            _ => throw new Exception($"It's not a figure {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}. How do you even get here?"),
        };
    }
    private Node ParseArc
    {
        get
        {
            // arc arc(p1, p2, p3) "It's an arc!";
            _ = ConsumeToken(TokenType.Figure);
            var name = ConsumeToken(TokenType.Identifier);

            if (CurrentToken?.Type != TokenType.LParen)
            {
                throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.LParen);
            var p1 = (PointNode)ParseExpression();
            if (p1 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            if (CurrentToken?.Type != TokenType.Comma)
            {
                throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.Comma);
            var p2 = (PointNode)ParseExpression();
            if (p2 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            if (CurrentToken?.Type != TokenType.Comma)
            {
                throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.Comma);
            var p3 = (PointNode)ParseExpression();
            if (p3 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.RParen);
            object comment = null!;
            if (CurrentToken?.Type == TokenType.StringLiteral)
            {
                comment = ParseStringLiteral;
            }

            LE.arcND.Add(new ArcNode(name.Value, p1, p2, p3, (Node)comment));
            return new EndNode();
        }

    }
    private Node ParseCircle
    {
        //circle cir(p1, r) "It's a circle!"
        get
        {
            _ = ConsumeToken(TokenType.Figure);
            var name = ConsumeToken(TokenType.Identifier);

            if (CurrentToken?.Type != TokenType.LParen)
            {
                throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.LParen);
            var p1 = (PointNode)ParseExpression();
            if (p1 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            if (CurrentToken?.Type != TokenType.Comma)
            {
                throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.Comma);
            var r = ParseExpression();

            _ = ConsumeToken(TokenType.RParen);
            object comment = null!;
            if (CurrentToken?.Type == TokenType.StringLiteral)
            {
                comment = ParseStringLiteral;
            }


            LE.cirND.Add(new CircleNode(name.Value, p1, r, (Node)comment));
            return new EndNode();
        }
    }
    private Node ParseRay
    {
        get
        {
            // ray ray(p1, p2) "It's a ray!";
            _ = ConsumeToken(TokenType.Figure);
            var name = ConsumeToken(TokenType.Identifier);

            if (CurrentToken?.Type != TokenType.LParen)
            {
                throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.LParen);
            var p1 = (PointNode)ParseExpression();
            if (p1 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            if (CurrentToken?.Type != TokenType.Comma)
            {
                throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.Comma);
            var p2 = (PointNode)ParseExpression();
            if (p2 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.RParen);
            object comment = null!;
            if (CurrentToken?.Type == TokenType.StringLiteral)
            {
                comment = ParseStringLiteral;
            }

            LE.rayND.Add(new RayNode(name.Value, p1, p2, (Node)comment));
            return new EndNode();
        }

    }
    private Node ParseSegment
    {
        get
        {
            // segment seg(p1, p2) "It's a segment!";
            _ = ConsumeToken(TokenType.Figure);
            var name = ConsumeToken(TokenType.Identifier);

            if (CurrentToken?.Type != TokenType.LParen)
            {
                throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.LParen);
            var p1 = (PointNode)ParseExpression();
            if (p1 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            if (CurrentToken?.Type != TokenType.Comma)
            {
                throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.Comma);
            var p2 = (PointNode)ParseExpression();
            if (p2 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.RParen);
            object comment = null!;
            if (CurrentToken?.Type == TokenType.StringLiteral)
            {
                comment = ParseStringLiteral;
            }

            LE.segND.Add(new SegmentNode(name.Value, p1, p2, (Node)comment));
            return new EndNode();

        }

    }
    private Node ParseLine
    {
        get
        {
            // line ln (p1, p2) "It's a line!";
            _ = ConsumeToken(TokenType.Figure);
            var name = ConsumeToken(TokenType.Identifier);

            if (CurrentToken?.Type != TokenType.LParen)
            {
                throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.LParen);
            var p1 = (PointNode)ParseExpression();
            if (p1 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            if (CurrentToken?.Type != TokenType.Comma)
            {
                throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.Comma);
            var p2 = (PointNode)ParseExpression();
            if (p2 is not PointNode)
            {
                throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }

            _ = ConsumeToken(TokenType.RParen);
            object comment = null!;
            if (CurrentToken?.Type == TokenType.StringLiteral)
            {
                comment = ParseStringLiteral;
            }

            LE.linND.Add(new LineNode(name.Value, p1, p2, (Node)comment));
            return new EndNode();
        }
    }
    private Node ParseColor
    {
        get
        {
            _ = ConsumeToken(TokenType.ColorKeyword);
            var name = ConsumeToken(TokenType.Identifier);
            LE.Color.Push(name.Value);
            return new EndNode();
        }
    }
    private Node ParseRestore
    {
        get
        {
            _ = ConsumeToken(TokenType.RestoreKeyword);
            LE.Color.Pop();
            return new EndNode();
        }
    }
    private Node ParseDraw
    {
        get
        {
            _ = ConsumeToken(TokenType.DrawKeyword);
            var toDraw = ParseExpression();

            return new DrawNode(toDraw);
        }
    }
    private Node ParseMeasure
    {
        get
        {
            //measure(p1, p2);
            _ = ConsumeToken(TokenType.MeasureKeyword);
            if (CurrentToken?.Type != TokenType.LParen)
            {
                throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            }
            //Point 1
            _ = ConsumeToken(TokenType.LParen);
            var p1 = (PointNode)ParseExpression();

            //Comma
            if (p1 is not PointNode) throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            if (CurrentToken?.Type != TokenType.Comma) throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");
            _ = ConsumeToken(TokenType.Comma);
            //Point 2 
            var p2 = (PointNode)ParseExpression();
            if (p2 is not PointNode) throw new Exception($"Expected token {TokenType.Point}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}");

            _ = ConsumeToken(TokenType.RParen);
            return new MeasureNode(p1, p2);

        }
    }
    #endregion
    #region Gsharp
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
                    if (CurrentToken?.Type == TokenType.Comma) { _ = ConsumeToken(TokenType.Comma); }
                }
                _ = ConsumeToken(TokenType.RParen);
                // Check if the function name is in the list of predefined functions
                return LE.predefinedFunctions.ContainsKey(token.Value)
                    ? new FunctionPredefinedNode(token.Value, args)
                    : FDN.Any(f => f.Name == token.Value)
                        ? (Node)new FunctionCallNode(token.Value, args)
                        : throw new Exception($"Undefined function {token.Value}");
            }
            else
            {
                return token.Value switch
                {
                    var value when LE.Seqs.Any(s => s.Identifier == value) => LE.Seqs.First(s => s.Identifier == value),
                    var value when LE.poiND.Any(p => p.Name == value) => LE.poiND.First(p => p.Name == value),
                    var value when LE.cirND.Any(c => c.Name == value) => LE.cirND.First(c => c.Name == value),
                    var value when LE.arcND.Any(a => a.Name == value) => LE.arcND.First(a => a.Name == value),
                    var value when LE.linND.Any(l => l.Name == value) => LE.linND.First(l => l.Name == value),
                    var value when LE.rayND.Any(r => r.Name == value) => LE.rayND.First(r => r.Name == value),
                    var value when LE.segND.Any(s => s.Name == value) => LE.segND.First(s => s.Name == value),
                    _ => new IdentifierNode(token.Value),// Parse an identifier
                };
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
            var left = ParseBinaryExpression();
            var operatorToken = ConsumeToken(TokenType.ComparisonOperator);
            var right = ParseExpression();
            _ = ConsumeToken(TokenType.RParen);
            return new BinaryExpressionNode(left, operatorToken.Value, right);
        }
    }
    private Node ParseBinaryExpression()
    {
        var left = ParseExpression();
        if (CurrentToken?.Type == TokenType.Operator)
        {
            var operatorToken = ConsumeToken(TokenType.Operator);
            var right = ParseExpression();
            return new BinaryExpressionNode(left, operatorToken.Value, right);
        }
        return left;
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
            var names = new List<Token>();
            do
            {
                names.Add(ConsumeToken(TokenType.Identifier));
                if (CurrentToken?.Type != TokenType.Comma)
                {
                    break;
                }
                _ = ConsumeToken(TokenType.Comma);
            } while (true);

            _ = ConsumeToken(TokenType.Operator);

            Node valueNode;

            if (CurrentToken?.Type == TokenType.LBrace)
            {
                valueNode = ParseSequence(names[0].Value);
            }
            else if (CurrentToken?.Type == TokenType.IntersectKeyword)
            {
                return ParseIntersect(names[0].Value);
            }
            else
            {
                valueNode = ParseExpression();
            }

            if (valueNode is SequenceNode sequenceNode)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    // Only create a ConstDeclarationNode if it's not the last identifier or if there are no remaining nodes
                    if (i < sequenceNode.Nodes.Count && (i != names.Count - 1 || i >= sequenceNode.Nodes.Count - 1))
                    {
                        LE.cDN.Insert(0, new ConstDeclarationNode(names[i].Value, sequenceNode.Nodes[i]));
                    }

                    // When we reach the last identifier and there are remaining nodes, create a new sequence with the remaining nodes
                    if (i == names.Count - 1 && i < sequenceNode.Nodes.Count - 1)
                    {
                        var remainingNodes = sequenceNode.Nodes.Skip(i).ToList();
                        LE.cDN.Insert(0, new ConstDeclarationNode(names[i].Value, new SequenceNode(remainingNodes, names[i].Value)));
                    }
                }
            }
            else
            {
                return new ConstDeclarationNode(names[0].Value, valueNode);
            }

            return new EndNode();
        }
    }
    private Node ParseSequence(string name)
    {
        _ = ConsumeToken(TokenType.LBrace);

        var values = new List<Node>();
        var constDeclarations = new List<ConstDeclarationNode>();

        while (CurrentToken?.Type != TokenType.RBrace)
        {
            Node valueNode;
            if (CurrentToken?.Type == TokenType.IntersectKeyword)
            {
                return null!;
            }
            else
            {
                valueNode = ParseExpression();
            }
            values.Add(valueNode);

            // Create a constant declaration for each value and add it to the list
            var constDeclaration = new ConstDeclarationNode(identifier: valueNode.ToString()!, value: valueNode);
            constDeclarations.Add(constDeclaration);

            if (CurrentToken?.Type == TokenType.Comma)
            {
                _ = ConsumeToken(TokenType.Comma);
            }
            else if (CurrentToken?.Type != TokenType.RBrace)
            {
                throw new Exception("Expected ',' or '}'");
            }
        }

        _ = ConsumeToken(TokenType.RBrace);

        // Create a unique identifier for the sequence
        LE.Seqs.Add(new SequenceNode(values, name));
        return new EndNode();
    }
    private Node ParseIntersect(string name)
    {

        _ = ConsumeToken(TokenType.IntersectKeyword);
        if (CurrentToken?.Type != TokenType.LParen)
        {
            throw new Exception($"Expected token {TokenType.LParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}  ");
        }
        _ = ConsumeToken(TokenType.LParen);
        var figure1 = ParseExpression();
        if (CurrentToken?.Type != TokenType.Comma)
        {
            throw new Exception($"Expected token {TokenType.Comma}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}  ");
        }
        _ = ConsumeToken(TokenType.Comma);
        var figure2 = ParseExpression();
        //ADDDDDDD IFFFFFFFFFFFF TOOOOOOOO
        if (CurrentToken?.Type != TokenType.RParen)
        {
            throw new Exception($"Expected token {TokenType.RParen}, but found {CurrentToken?.Type} at line {CurrentToken?.Line} and column {CurrentToken?.Column}  ");
        }
        _ = ConsumeToken(TokenType.RParen);
        return new IntersectNode(name, figure1, figure2, new List<PointNode>());

    }

    public static List<FunctionDeclarationNode> FDN { get => fDN; set => fDN = value; }
    #endregion
}