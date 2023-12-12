using LexerAnalize;
using ParserAnalize;
using EvaluatorAnalize;

namespace InterpreterAnalizer;
public class Interpreter
{
    public static object Interpret(string input)
    {
        List<ToDraw> toDraws = [];
        // Split the string into lines
        var lines = input.Split(";\r", StringSplitOptions.RemoveEmptyEntries);
        foreach (var line in lines)
        {
            try
            {
                var lexer = new Lexer(line);
                var parser = new Parser(lexer.LexTokens);
                var evaluator = new Evaluator(parser.Parse());
                object? lineResult = evaluator.Evaluate();
                if (lineResult is not null && lineResult is ToDraw)
                {
                    toDraws.Add((ToDraw)lineResult);
                }
            }
            catch (Exception e) { return e.Message; }
        }
        return toDraws;
    }
}