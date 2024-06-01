# Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`namespace`[`EvaluatorAnalize`](#namespaceEvaluatorAnalize) |
`namespace`[`FormsTest1`](#namespaceFormsTest1) |
`namespace`[`InterpreterAnalizer`](#namespaceInterpreterAnalizer) |
`namespace`[`LexerAnalize`](#namespaceLexerAnalize) |
`namespace`[`Lists`](#namespaceLists) |
`namespace`[`Nodes`](#namespaceNodes) |
`namespace`[`ParserAnalize`](#namespaceParserAnalize) |
`namespace`[`Tokens`](#namespaceTokens) |
`namespace`[`WaLI`](#namespaceWaLI) |
`namespace`[`WaLI::backend`](#namespaceWaLI_1_1backend) |
`namespace`[`WaLI::backend::src::extras`](#namespaceWaLI_1_1backend_1_1src_1_1extras) |
`namespace`[`WaLI::backend::src::semantic`](#namespaceWaLI_1_1backend_1_1src_1_1semantic) |
`struct`[`Lists::ListExtrasScoper::ToDraw`](#structLists_1_1ListExtrasScoper_1_1ToDraw) | Represents a structure that holds information about a figure to be drawn.

# namespace `EvaluatorAnalize`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`EvaluatorAnalize::Evaluator`](#classEvaluatorAnalize_1_1Evaluator) | Represents an evaluator for the abstract syntax tree (AST) of a program.

# class `EvaluatorAnalize::Evaluator`

Represents an evaluator for the abstract syntax tree (AST) of a program.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`AST`](#classEvaluatorAnalize_1_1Evaluator_1a1cbb637db441b1804c11398467f578f2) | Represents a node in the abstract syntax tree (AST).
`public`[`ListExtrasScoper`](#classLists_1_1ListExtrasScoper)``[`scope`](#classEvaluatorAnalize_1_1Evaluator_1a209a287e2938d8e0eec736165a1f91bd) |
`public`[`Evaluator`](#classEvaluatorAnalize_1_1Evaluator_1a5e5ccfdd727f036888a1166f75312517)`(List<`[`Node`](#classNodes_1_1Node)`> ast)` | Initializes a new instance of the [Evaluator](#classEvaluatorAnalize_1_1Evaluator) class.
`public inline IEnumerable< object >`[`Evaluate`](#classEvaluatorAnalize_1_1Evaluator_1aeea05a9dfa26648a73021f1a4f14ed4e)`(`[`ListExtrasScoper`](#classLists_1_1ListExtrasScoper)`Scope)` | Evaluates the abstract syntax tree (AST) and returns the result.
`public inline object`[`Draw`](#classEvaluatorAnalize_1_1Evaluator_1a77ca6ca366b69e39e6c461afc8e1d6a8)`(`[`DrawNode`](#classNodes_1_1DrawNode)`drawNode)` | Draws the specified DrawNode and returns a list of ToDraw objects.

## Members

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`AST`](#classEvaluatorAnalize_1_1Evaluator_1a1cbb637db441b1804c11398467f578f2)

Represents a node in the abstract syntax tree (AST).

#### `public`[`ListExtrasScoper`](#classLists_1_1ListExtrasScoper)``[`scope`](#classEvaluatorAnalize_1_1Evaluator_1a209a287e2938d8e0eec736165a1f91bd)

#### `public`[`Evaluator`](#classEvaluatorAnalize_1_1Evaluator_1a5e5ccfdd727f036888a1166f75312517)`(List<`[`Node`](#classNodes_1_1Node)`> ast)`

Initializes a new instance of the [Evaluator](#classEvaluatorAnalize_1_1Evaluator) class.

#### Parameters

* `ast` The abstract syntax tree representing the program.

#### `public inline IEnumerable< object >`[`Evaluate`](#classEvaluatorAnalize_1_1Evaluator_1aeea05a9dfa26648a73021f1a4f14ed4e)`(`[`ListExtrasScoper`](#classLists_1_1ListExtrasScoper)`Scope)`

Evaluates the abstract syntax tree (AST) and returns the result.

#### Returns

The result of the evaluation.

#### `public inline object`[`Draw`](#classEvaluatorAnalize_1_1Evaluator_1a77ca6ca366b69e39e6c461afc8e1d6a8)`(`[`DrawNode`](#classNodes_1_1DrawNode)`drawNode)`

Draws the specified DrawNode and returns a list of ToDraw objects.

#### Parameters

* `node` The DrawNode to be drawn.

#### Returns

A list of ToDraw objects representing the figures to be drawn.

# namespace `FormsTest1`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`FormsTest1::MainForm`](#classFormsTest1_1_1MainForm) |

# class `FormsTest1::MainForm`

```
class FormsTest1::MainForm
  : public Form
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`public inline`[`MainForm`](#classFormsTest1_1_1MainForm_1a7c732a29ac81fe7ee9cc7d1e0b7722d7)`()` | Initializes a new instance of the [MainForm](#classFormsTest1_1_1MainForm) class.
`protected inline override void`[`Dispose`](#classFormsTest1_1_1MainForm_1ab0a3b52a723c676c4cbf1ffecf3feb15)`(bool disposing)` | Clean up any resources being used.

## Members

#### `public inline`[`MainForm`](#classFormsTest1_1_1MainForm_1a7c732a29ac81fe7ee9cc7d1e0b7722d7)`()`

Initializes a new instance of the [MainForm](#classFormsTest1_1_1MainForm) class.

#### `protected inline override void`[`Dispose`](#classFormsTest1_1_1MainForm_1ab0a3b52a723c676c4cbf1ffecf3feb15)`(bool disposing)`

Clean up any resources being used.

#### Parameters

* `disposing` true if managed resources should be disposed; otherwise, false.

# namespace `InterpreterAnalizer`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`InterpreterAnalizer::Interpreter`](#classInterpreterAnalizer_1_1Interpreter) |

# class `InterpreterAnalizer::Interpreter`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------

## Members

# namespace `LexerAnalize`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`LexerAnalize::Lexer`](#classLexerAnalize_1_1Lexer) |

# class `LexerAnalize::Lexer`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Text`](#classLexerAnalize_1_1Lexer_1ad47e0c48043c2853bf9ae0a1f6cf548d) |
`{property} int`[`Position`](#classLexerAnalize_1_1Lexer_1a71905bacb950f3c3c35a4e6e5dee4b1c) |
`{property} int`[`Column`](#classLexerAnalize_1_1Lexer_1aef5847425246cd401c5456b26c8d444a) |
`{property} int`[`Line`](#classLexerAnalize_1_1Lexer_1acc2413c8c8e684e8f431e577f366f09b) |
`{property} char`[`CurrentChar`](#classLexerAnalize_1_1Lexer_1a47cd7eb082b24bb98cd531f4e5ce7879) |
`public readonly List<`[`Token`](#classTokens_1_1Token)` > `[`LexTokens`](#classLexerAnalize_1_1Lexer_1a0fa4e956f435b53de72879267c74bbc8) |
`public inline`[`Lexer`](#classLexerAnalize_1_1Lexer_1a152e0873d29081cccad73c0267a52fba)`(string input)` |
`public inline char`[`Peek`](#classLexerAnalize_1_1Lexer_1a054f57f5a48c4c65eb746d3dbad341cc)`()` | Returns the next character in the input string without consuming it.
`public inline char`[`Peek2`](#classLexerAnalize_1_1Lexer_1ab1d3b2a58ee9c23fcf485434ce9b91ae)`()` | Returns the character at the position two steps ahead of the current position. If the position is out of range, returns '\0'.
`public inline void`[`Tokenize`](#classLexerAnalize_1_1Lexer_1a6b997f15945f544d135dc2840e9a64f9)`()` |

## Members

#### `{property} string`[`Text`](#classLexerAnalize_1_1Lexer_1ad47e0c48043c2853bf9ae0a1f6cf548d)

#### `{property} int`[`Position`](#classLexerAnalize_1_1Lexer_1a71905bacb950f3c3c35a4e6e5dee4b1c)

#### `{property} int`[`Column`](#classLexerAnalize_1_1Lexer_1aef5847425246cd401c5456b26c8d444a)

#### `{property} int`[`Line`](#classLexerAnalize_1_1Lexer_1acc2413c8c8e684e8f431e577f366f09b)

#### `{property} char`[`CurrentChar`](#classLexerAnalize_1_1Lexer_1a47cd7eb082b24bb98cd531f4e5ce7879)

#### `public readonly List<`[`Token`](#classTokens_1_1Token)` > `[`LexTokens`](#classLexerAnalize_1_1Lexer_1a0fa4e956f435b53de72879267c74bbc8)

#### `public inline`[`Lexer`](#classLexerAnalize_1_1Lexer_1a152e0873d29081cccad73c0267a52fba)`(string input)`

#### `public inline char`[`Peek`](#classLexerAnalize_1_1Lexer_1a054f57f5a48c4c65eb746d3dbad341cc)`()`

Returns the next character in the input string without consuming it.

#### Returns

The next character in the input string, or '\0' if there are no more characters.

#### `public inline char`[`Peek2`](#classLexerAnalize_1_1Lexer_1ab1d3b2a58ee9c23fcf485434ce9b91ae)`()`

Returns the character at the position two steps ahead of the current position. If the position is out of range, returns '\0'.

#### Returns

The character at the position two steps ahead of the current position, or '\0' if out of range.

#### `public inline void`[`Tokenize`](#classLexerAnalize_1_1Lexer_1a6b997f15945f544d135dc2840e9a64f9)`()`

# namespace `Lists`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`Lists::ListExtrasScoper`](#classLists_1_1ListExtrasScoper) |

# class `Lists::ListExtrasScoper`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} Stack< Brush >`[`Color`](#classLists_1_1ListExtrasScoper_1aa4be157b537de0bf65a97af9b5f2d2bc) |
`public readonly List<`[`ToDraw`](#structLists_1_1ListExtrasScoper_1_1ToDraw)` > `[`toDraws`](#classLists_1_1ListExtrasScoper_1a128a9ef0ccba0531a8b02fc37a414e48) |
`public readonly Dictionary< string, PointF >`[`poiND`](#classLists_1_1ListExtrasScoper_1add7d54d9d2e88c81131f12a85bbef5dd) |
`public readonly List<`[`DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode)` > `[`Seqs`](#classLists_1_1ListExtrasScoper_1ad3fa2798f534e91c45e2ddc2f7aed6e3) |
`public readonly List<`[`FunctionDeclarationNode`](#classNodes_1_1FunctionDeclarationNode)` > `[`Funcs`](#classLists_1_1ListExtrasScoper_1a2ed1b43b292c66b1300748e0843c6689) |
`public readonly Dictionary< string, object >`[`infiniteSequenceNodes`](#classLists_1_1ListExtrasScoper_1a96a9244c9ab080c2a7145e8342614423) |
`public readonly Dictionary< string, Func< double[], double > >`[`predefinedFunctions`](#classLists_1_1ListExtrasScoper_1a6ff75dab06f13c827de5780b4c6e7e73) |
`public readonly List<`[`ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode)` > `[`cDN`](#classLists_1_1ListExtrasScoper_1a6e7448481782ed8537f3a20a87cb10f3) |
`public readonly List<`[`GlobalConstNode`](#classNodes_1_1GlobalConstNode)` > `[`DeclaredConst`](#classLists_1_1ListExtrasScoper_1a57688f7e2330062bb4c07b6011c4b791) |

## Members

#### `{property} Stack< Brush >`[`Color`](#classLists_1_1ListExtrasScoper_1aa4be157b537de0bf65a97af9b5f2d2bc)

#### `public readonly List<`[`ToDraw`](#structLists_1_1ListExtrasScoper_1_1ToDraw)` > `[`toDraws`](#classLists_1_1ListExtrasScoper_1a128a9ef0ccba0531a8b02fc37a414e48)

#### `public readonly Dictionary< string, PointF >`[`poiND`](#classLists_1_1ListExtrasScoper_1add7d54d9d2e88c81131f12a85bbef5dd)

#### `public readonly List<`[`DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode)` > `[`Seqs`](#classLists_1_1ListExtrasScoper_1ad3fa2798f534e91c45e2ddc2f7aed6e3)

#### `public readonly List<`[`FunctionDeclarationNode`](#classNodes_1_1FunctionDeclarationNode)` > `[`Funcs`](#classLists_1_1ListExtrasScoper_1a2ed1b43b292c66b1300748e0843c6689)

#### `public readonly Dictionary< string, object >`[`infiniteSequenceNodes`](#classLists_1_1ListExtrasScoper_1a96a9244c9ab080c2a7145e8342614423)

#### `public readonly Dictionary< string, Func< double[], double > >`[`predefinedFunctions`](#classLists_1_1ListExtrasScoper_1a6ff75dab06f13c827de5780b4c6e7e73)

#### `public readonly List<`[`ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode)` > `[`cDN`](#classLists_1_1ListExtrasScoper_1a6e7448481782ed8537f3a20a87cb10f3)

#### `public readonly List<`[`GlobalConstNode`](#classNodes_1_1GlobalConstNode)` > `[`DeclaredConst`](#classLists_1_1ListExtrasScoper_1a57688f7e2330062bb4c07b6011c4b791)

# namespace `Nodes`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`Nodes::ArcNode`](#classNodes_1_1ArcNode) |
`class`[`Nodes::BinaryExpressionNode`](#classNodes_1_1BinaryExpressionNode) |
`class`[`Nodes::CircleNode`](#classNodes_1_1CircleNode) |
`class`[`Nodes::ColorNode`](#classNodes_1_1ColorNode) |
`class`[`Nodes::ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode) |
`class`[`Nodes::DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode) | Represents a declared sequence of nodes.
`class`[`Nodes::DrawNode`](#classNodes_1_1DrawNode) |
`class`[`Nodes::EndNode`](#classNodes_1_1EndNode) | Represents an end node in the parser.
`class`[`Nodes::Figure`](#classNodes_1_1Figure) |
`class`[`Nodes::FunctionCallNode`](#classNodes_1_1FunctionCallNode) |
`class`[`Nodes::FunctionDeclarationNode`](#classNodes_1_1FunctionDeclarationNode) |
`class`[`Nodes::FunctionPredefinedNode`](#classNodes_1_1FunctionPredefinedNode) |
`class`[`Nodes::GlobalConstNode`](#classNodes_1_1GlobalConstNode) |
`class`[`Nodes::IdentifierNode`](#classNodes_1_1IdentifierNode) | Represents a node that represents an identifier.
`class`[`Nodes::IfExpressionNode`](#classNodes_1_1IfExpressionNode) |
`class`[`Nodes::ImportNode`](#classNodes_1_1ImportNode) |
`class`[`Nodes::InfiniteSequenceNode`](#classNodes_1_1InfiniteSequenceNode) |
`class`[`Nodes::IntersectNode`](#classNodes_1_1IntersectNode) | Represents a node that represents the intersection of two figures.
`class`[`Nodes::LineNode`](#classNodes_1_1LineNode) |
`class`[`Nodes::MeasureNode`](#classNodes_1_1MeasureNode) |
`class`[`Nodes::MultiAssignmentNode`](#classNodes_1_1MultiAssignmentNode) |
`class`[`Nodes::MultipleVariableDeclarationNode`](#classNodes_1_1MultipleVariableDeclarationNode) |
`class`[`Nodes::Node`](#classNodes_1_1Node) | Represents an abstract base class for nodes in the parser.
`class`[`Nodes::PointNode`](#classNodes_1_1PointNode) |
`class`[`Nodes::RayNode`](#classNodes_1_1RayNode) |
`class`[`Nodes::RestoreNode`](#classNodes_1_1RestoreNode) |
`class`[`Nodes::ReturnToDrawNode`](#classNodes_1_1ReturnToDrawNode) |
`class`[`Nodes::SegmentNode`](#classNodes_1_1SegmentNode) |
`class`[`Nodes::SequenceNode`](#classNodes_1_1SequenceNode) | Represents a sequence of nodes.
`class`[`Nodes::UndefinedNode`](#classNodes_1_1UndefinedNode) | Represents a node that holds an undefined value.
`class`[`Nodes::ValueNode`](#classNodes_1_1ValueNode) | Represents a node that holds a value.
`class`[`Nodes::VariableDeclarationNode`](#classNodes_1_1VariableDeclarationNode) |

# class `Nodes::ArcNode`

```
class Nodes::ArcNode
  : public Nodes.Figure
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1ArcNode_1a5f5813cef3b5229b99822ddab8fe1042) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Center`](#classNodes_1_1ArcNode_1a88219d4ce559134d80ef04d425258de7) |
`{property}`[`Node`](#classNodes_1_1Node)``[`P1`](#classNodes_1_1ArcNode_1a1dcc4e2c9cbfacdc8e82496eed0cbda3) |
`{property}`[`Node`](#classNodes_1_1Node)``[`P2`](#classNodes_1_1ArcNode_1a8c3b50b1c226b8f20066df5bcfc989ac) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Measure`](#classNodes_1_1ArcNode_1a937ac18c4dcb6dfd16b0bd2d3f474cfb) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1ArcNode_1a82163084c689c87d37f4d33e4f6c61fa) |
`public inline`[`ArcNode`](#classNodes_1_1ArcNode_1ab1a999036ca82c3bdb92c01128b65071)`(string name,`[`Node`](#classNodes_1_1Node)`center,`[`Node`](#classNodes_1_1Node)`p1,`[`Node`](#classNodes_1_1Node)`p2,`[`Node`](#classNodes_1_1Node)`measure,`[`Node`](#classNodes_1_1Node)`comment)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1ArcNode_1a5f5813cef3b5229b99822ddab8fe1042)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Center`](#classNodes_1_1ArcNode_1a88219d4ce559134d80ef04d425258de7)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`P1`](#classNodes_1_1ArcNode_1a1dcc4e2c9cbfacdc8e82496eed0cbda3)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`P2`](#classNodes_1_1ArcNode_1a8c3b50b1c226b8f20066df5bcfc989ac)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Measure`](#classNodes_1_1ArcNode_1a937ac18c4dcb6dfd16b0bd2d3f474cfb)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1ArcNode_1a82163084c689c87d37f4d33e4f6c61fa)

#### `public inline`[`ArcNode`](#classNodes_1_1ArcNode_1ab1a999036ca82c3bdb92c01128b65071)`(string name,`[`Node`](#classNodes_1_1Node)`center,`[`Node`](#classNodes_1_1Node)`p1,`[`Node`](#classNodes_1_1Node)`p2,`[`Node`](#classNodes_1_1Node)`measure,`[`Node`](#classNodes_1_1Node)`comment)`

# class `Nodes::BinaryExpressionNode`

```
class Nodes::BinaryExpressionNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Left`](#classNodes_1_1BinaryExpressionNode_1a4f358a17fdcaeea98fa0d2e5187ddc1d) |
`{property} string`[`Operator`](#classNodes_1_1BinaryExpressionNode_1a6b9afc9f3d6f678cb64b21173c5e75be) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Right`](#classNodes_1_1BinaryExpressionNode_1aab7b11d4bf76e60773abfed4b3ffddbf) |
`public inline`[`BinaryExpressionNode`](#classNodes_1_1BinaryExpressionNode_1a56ebf2016cb3e29ae282fa9cba71f6e8)`(`[`Node`](#classNodes_1_1Node)`left,string @ operator,`[`Node`](#classNodes_1_1Node)`right)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Left`](#classNodes_1_1BinaryExpressionNode_1a4f358a17fdcaeea98fa0d2e5187ddc1d)

#### `{property} string`[`Operator`](#classNodes_1_1BinaryExpressionNode_1a6b9afc9f3d6f678cb64b21173c5e75be)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Right`](#classNodes_1_1BinaryExpressionNode_1aab7b11d4bf76e60773abfed4b3ffddbf)

#### `public inline`[`BinaryExpressionNode`](#classNodes_1_1BinaryExpressionNode_1a56ebf2016cb3e29ae282fa9cba71f6e8)`(`[`Node`](#classNodes_1_1Node)`left,string @ operator,`[`Node`](#classNodes_1_1Node)`right)`

# class `Nodes::CircleNode`

```
class Nodes::CircleNode
  : public Nodes.Figure
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Center`](#classNodes_1_1CircleNode_1add3b73691a582b0f73a47e20eeb0d524) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Radius`](#classNodes_1_1CircleNode_1a9bcc3d48ab3ee86108c90d12e52c34a9) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1CircleNode_1a8c0eb249fe9a9531beae77882ca5c976) |
`public inline`[`CircleNode`](#classNodes_1_1CircleNode_1a5e9d0e707ed2c28da236e22fde6041ff)`(string nameX,`[`Node`](#classNodes_1_1Node)`cen,`[`Node`](#classNodes_1_1Node)`rad,`[`Node`](#classNodes_1_1Node)`comment)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Center`](#classNodes_1_1CircleNode_1add3b73691a582b0f73a47e20eeb0d524)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Radius`](#classNodes_1_1CircleNode_1a9bcc3d48ab3ee86108c90d12e52c34a9)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1CircleNode_1a8c0eb249fe9a9531beae77882ca5c976)

#### `public inline`[`CircleNode`](#classNodes_1_1CircleNode_1a5e9d0e707ed2c28da236e22fde6041ff)`(string nameX,`[`Node`](#classNodes_1_1Node)`cen,`[`Node`](#classNodes_1_1Node)`rad,`[`Node`](#classNodes_1_1Node)`comment)`

# class `Nodes::ColorNode`

```
class Nodes::ColorNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Value`](#classNodes_1_1ColorNode_1aa72cc956780f66d5bba6a0d12b78d809) |
`public inline`[`ColorNode`](#classNodes_1_1ColorNode_1a6330999772ff41ae3541ae731f811e05)`(string value)` |

## Members

#### `{property} string`[`Value`](#classNodes_1_1ColorNode_1aa72cc956780f66d5bba6a0d12b78d809)

#### `public inline`[`ColorNode`](#classNodes_1_1ColorNode_1a6330999772ff41ae3541ae731f811e05)`(string value)`

# class `Nodes::ConstDeclarationNode`

```
class Nodes::ConstDeclarationNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Identifier`](#classNodes_1_1ConstDeclarationNode_1a8540773e1d9614300077ed5973c14e9a) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Value`](#classNodes_1_1ConstDeclarationNode_1a69e301571e480165492526de74ebd606) |
`public inline`[`ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode_1a9428cd706d8b88d259e8da75d2cb1785)`(string identifier,`[`Node`](#classNodes_1_1Node)`value)` |

## Members

#### `{property} string`[`Identifier`](#classNodes_1_1ConstDeclarationNode_1a8540773e1d9614300077ed5973c14e9a)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Value`](#classNodes_1_1ConstDeclarationNode_1a69e301571e480165492526de74ebd606)

#### `public inline`[`ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode_1a9428cd706d8b88d259e8da75d2cb1785)`(string identifier,`[`Node`](#classNodes_1_1Node)`value)`

# class `Nodes::DeclaredSequenceNode`

```
class Nodes::DeclaredSequenceNode
  : public Nodes.Node
```  

Represents a declared sequence of nodes.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Identifier`](#classNodes_1_1DeclaredSequenceNode_1a660a9e1e1d987bcd61cd312c445ad024) |
`{property} List< object >`[`Nodes`](#classNodes_1_1DeclaredSequenceNode_1ae3eea0e2ff9c796a8826731dac69a28e) |
`public inline`[`DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode_1a2f7dc0b093cd6d3046684688cabe07e2)`(List< object > nodes,string identifier)` |

## Members

#### `{property} string`[`Identifier`](#classNodes_1_1DeclaredSequenceNode_1a660a9e1e1d987bcd61cd312c445ad024)

#### `{property} List< object >`[`Nodes`](#classNodes_1_1DeclaredSequenceNode_1ae3eea0e2ff9c796a8826731dac69a28e)

#### `public inline`[`DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode_1a2f7dc0b093cd6d3046684688cabe07e2)`(List< object > nodes,string identifier)`

# class `Nodes::DrawNode`

```
class Nodes::DrawNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Figures`](#classNodes_1_1DrawNode_1ac173c52149bdcadba62506bdedbab786) |
`public bool`[`decl`](#classNodes_1_1DrawNode_1a4e3724c3e462fa12d0dd6209cd78c6bc) |
`public inline`[`DrawNode`](#classNodes_1_1DrawNode_1a03d44cc730403544c85e41624d9c1c0a)`(`[`Node`](#classNodes_1_1Node)`figures,bool declare)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Figures`](#classNodes_1_1DrawNode_1ac173c52149bdcadba62506bdedbab786)

#### `public bool`[`decl`](#classNodes_1_1DrawNode_1a4e3724c3e462fa12d0dd6209cd78c6bc)

#### `public inline`[`DrawNode`](#classNodes_1_1DrawNode_1a03d44cc730403544c85e41624d9c1c0a)`(`[`Node`](#classNodes_1_1Node)`figures,bool declare)`

# class `Nodes::EndNode`

```
class Nodes::EndNode
  : public Nodes.Node
```  

Represents an end node in the parser.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------

## Members

# class `Nodes::Figure`

```
class Nodes::Figure
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`public string`[`name`](#classNodes_1_1Figure_1a9694e3161124d730f2719b070a207a1e) |
`public inline`[`Figure`](#classNodes_1_1Figure_1a7647c221ec1d603f9d9467644dff2240)`(string nameX)` |

## Members

#### `public string`[`name`](#classNodes_1_1Figure_1a9694e3161124d730f2719b070a207a1e)

#### `public inline`[`Figure`](#classNodes_1_1Figure_1a7647c221ec1d603f9d9467644dff2240)`(string nameX)`

# class `Nodes::FunctionCallNode`

```
class Nodes::FunctionCallNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1FunctionCallNode_1a3e3d658470d7a2958dbadc7502218bca) |
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Args`](#classNodes_1_1FunctionCallNode_1a561ec9a128e15c137db47d08cc7b1eb8) |
`public inline`[`FunctionCallNode`](#classNodes_1_1FunctionCallNode_1a4fa45e3323f96f1e12bfc15ffc6ab714)`(string name,List<`[`Node`](#classNodes_1_1Node)`> args)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1FunctionCallNode_1a3e3d658470d7a2958dbadc7502218bca)

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Args`](#classNodes_1_1FunctionCallNode_1a561ec9a128e15c137db47d08cc7b1eb8)

#### `public inline`[`FunctionCallNode`](#classNodes_1_1FunctionCallNode_1a4fa45e3323f96f1e12bfc15ffc6ab714)`(string name,List<`[`Node`](#classNodes_1_1Node)`> args)`

# class `Nodes::FunctionDeclarationNode`

```
class Nodes::FunctionDeclarationNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1FunctionDeclarationNode_1a9d5c3ac808e49a39126bb3058bfa0a9d) |
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Args`](#classNodes_1_1FunctionDeclarationNode_1ae0c907e43e74eea2481c1959ccf89534) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Body`](#classNodes_1_1FunctionDeclarationNode_1afdcea112cb2804e3d2ae2427dc9cf960) |
`public inline`[`FunctionDeclarationNode`](#classNodes_1_1FunctionDeclarationNode_1ab9558d33b672d4bb5c8c5b60f48de08e)`(string name,List<`[`Node`](#classNodes_1_1Node)`> args,`[`Node`](#classNodes_1_1Node)`body)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1FunctionDeclarationNode_1a9d5c3ac808e49a39126bb3058bfa0a9d)

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Args`](#classNodes_1_1FunctionDeclarationNode_1ae0c907e43e74eea2481c1959ccf89534)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Body`](#classNodes_1_1FunctionDeclarationNode_1afdcea112cb2804e3d2ae2427dc9cf960)

#### `public inline`[`FunctionDeclarationNode`](#classNodes_1_1FunctionDeclarationNode_1ab9558d33b672d4bb5c8c5b60f48de08e)`(string name,List<`[`Node`](#classNodes_1_1Node)`> args,`[`Node`](#classNodes_1_1Node)`body)`

# class `Nodes::FunctionPredefinedNode`

```
class Nodes::FunctionPredefinedNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1FunctionPredefinedNode_1a60c9a1411870f92fed8d4ffb25a360ee) |
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Args`](#classNodes_1_1FunctionPredefinedNode_1aaae39d24b65344dd46658864e11b6364) |
`public inline`[`FunctionPredefinedNode`](#classNodes_1_1FunctionPredefinedNode_1a8bdac7e1dd28c4881bd7f84498efbc8c)`(string name,List<`[`Node`](#classNodes_1_1Node)`> args)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1FunctionPredefinedNode_1a60c9a1411870f92fed8d4ffb25a360ee)

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Args`](#classNodes_1_1FunctionPredefinedNode_1aaae39d24b65344dd46658864e11b6364)

#### `public inline`[`FunctionPredefinedNode`](#classNodes_1_1FunctionPredefinedNode_1a8bdac7e1dd28c4881bd7f84498efbc8c)`(string name,List<`[`Node`](#classNodes_1_1Node)`> args)`

# class `Nodes::GlobalConstNode`

```
class Nodes::GlobalConstNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Identifier`](#classNodes_1_1GlobalConstNode_1a37b680a8f5b00902c5d3416167991618) |
`{property} object`[`Value`](#classNodes_1_1GlobalConstNode_1a17d5582abf3d3b0529b165f57f1abe46) |
`public inline`[`GlobalConstNode`](#classNodes_1_1GlobalConstNode_1ac7b9d8a6513f280550849408b3427aa8)`(string identifier,object value)` |

## Members

#### `{property} string`[`Identifier`](#classNodes_1_1GlobalConstNode_1a37b680a8f5b00902c5d3416167991618)

#### `{property} object`[`Value`](#classNodes_1_1GlobalConstNode_1a17d5582abf3d3b0529b165f57f1abe46)

#### `public inline`[`GlobalConstNode`](#classNodes_1_1GlobalConstNode_1ac7b9d8a6513f280550849408b3427aa8)`(string identifier,object value)`

# class `Nodes::IdentifierNode`

```
class Nodes::IdentifierNode
  : public Nodes.Node
```  

Represents a node that represents an identifier.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Identifier`](#classNodes_1_1IdentifierNode_1a8fa91e4ea9d862c2d8f4ed336cecea7a) | Gets the identifier value.
`public inline`[`IdentifierNode`](#classNodes_1_1IdentifierNode_1a6b27db8079db03d5d4743a37fb3f0a4f)`(string identifier)` | Initializes a new instance of the [IdentifierNode](#classNodes_1_1IdentifierNode) class with the specified identifier.

## Members

#### `{property} string`[`Identifier`](#classNodes_1_1IdentifierNode_1a8fa91e4ea9d862c2d8f4ed336cecea7a)

Gets the identifier value.

#### `public inline`[`IdentifierNode`](#classNodes_1_1IdentifierNode_1a6b27db8079db03d5d4743a37fb3f0a4f)`(string identifier)`

Initializes a new instance of the [IdentifierNode](#classNodes_1_1IdentifierNode) class with the specified identifier.

#### Parameters

* `identifier` The identifier value.

# class `Nodes::IfExpressionNode`

```
class Nodes::IfExpressionNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Condition`](#classNodes_1_1IfExpressionNode_1a86ecbca1d388cb108f63a97bc16615c1) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ThenBody`](#classNodes_1_1IfExpressionNode_1a047702570c6c093339bbc3e31f456e14) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ElseBody`](#classNodes_1_1IfExpressionNode_1aaa274b3fd942feee3f228ad73b7c0b9c) |
`public inline`[`IfExpressionNode`](#classNodes_1_1IfExpressionNode_1a7d051e08e0cf7638fd6e1d6c29341bef)`(`[`Node`](#classNodes_1_1Node)`condition,`[`Node`](#classNodes_1_1Node)`thenBody,`[`Node`](#classNodes_1_1Node)`elseBody)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Condition`](#classNodes_1_1IfExpressionNode_1a86ecbca1d388cb108f63a97bc16615c1)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ThenBody`](#classNodes_1_1IfExpressionNode_1a047702570c6c093339bbc3e31f456e14)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ElseBody`](#classNodes_1_1IfExpressionNode_1aaa274b3fd942feee3f228ad73b7c0b9c)

#### `public inline`[`IfExpressionNode`](#classNodes_1_1IfExpressionNode_1a7d051e08e0cf7638fd6e1d6c29341bef)`(`[`Node`](#classNodes_1_1Node)`condition,`[`Node`](#classNodes_1_1Node)`thenBody,`[`Node`](#classNodes_1_1Node)`elseBody)`

# class `Nodes::ImportNode`

```
class Nodes::ImportNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`FilePath`](#classNodes_1_1ImportNode_1a19da28115461cd051b08d6661a06f535) |
`public inline`[`ImportNode`](#classNodes_1_1ImportNode_1a507ecebfdfe17a49591e1a8e3638fca0)`(string filePath)` |

## Members

#### `{property} string`[`FilePath`](#classNodes_1_1ImportNode_1a19da28115461cd051b08d6661a06f535)

#### `public inline`[`ImportNode`](#classNodes_1_1ImportNode_1a507ecebfdfe17a49591e1a8e3638fca0)`(string filePath)`

# class `Nodes::InfiniteSequenceNode`

```
class Nodes::InfiniteSequenceNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1InfiniteSequenceNode_1ad181896a4ce4f86e3b39ae283a058005) |
`{property}`[`Node`](#classNodes_1_1Node)``[`StartValueNode`](#classNodes_1_1InfiniteSequenceNode_1a68796eda5d6b628e99b15a09f88f081b) |
`public inline`[`InfiniteSequenceNode`](#classNodes_1_1InfiniteSequenceNode_1a5a482c0f6baad93cb7a8f805982bc2a8)`(`[`Node`](#classNodes_1_1Node)`startValueNode,string name)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1InfiniteSequenceNode_1ad181896a4ce4f86e3b39ae283a058005)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`StartValueNode`](#classNodes_1_1InfiniteSequenceNode_1a68796eda5d6b628e99b15a09f88f081b)

#### `public inline`[`InfiniteSequenceNode`](#classNodes_1_1InfiniteSequenceNode_1a5a482c0f6baad93cb7a8f805982bc2a8)`(`[`Node`](#classNodes_1_1Node)`startValueNode,string name)`

# class `Nodes::IntersectNode`

```
class Nodes::IntersectNode
  : public Nodes.Node
```  

Represents a node that represents the intersection of two figures.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Figure1`](#classNodes_1_1IntersectNode_1a0616179a1913847b7f4ba87b66172591) | Gets the first figure node.
`{property}`[`Node`](#classNodes_1_1Node)``[`Figure2`](#classNodes_1_1IntersectNode_1a38f70249205ca6f7f9220f049417df24) | Gets the second figure node.
`public inline`[`IntersectNode`](#classNodes_1_1IntersectNode_1ad93986ac85a5614e77ee494d8ec8a81a)`(`[`Node`](#classNodes_1_1Node)`figure1,`[`Node`](#classNodes_1_1Node)`figure2)` | Initializes a new instance of the [IntersectNode](#classNodes_1_1IntersectNode) class.

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Figure1`](#classNodes_1_1IntersectNode_1a0616179a1913847b7f4ba87b66172591)

Gets the first figure node.

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Figure2`](#classNodes_1_1IntersectNode_1a38f70249205ca6f7f9220f049417df24)

Gets the second figure node.

#### `public inline`[`IntersectNode`](#classNodes_1_1IntersectNode_1ad93986ac85a5614e77ee494d8ec8a81a)`(`[`Node`](#classNodes_1_1Node)`figure1,`[`Node`](#classNodes_1_1Node)`figure2)`

Initializes a new instance of the [IntersectNode](#classNodes_1_1IntersectNode) class.

#### Parameters

* `figure1` The first figure.

* `figure2` The second figure.

# class `Nodes::LineNode`

```
class Nodes::LineNode
  : public Nodes.Figure
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1LineNode_1a8bd8b15b4e2267247f0fdf7d5f0b7a43) |
`{property}`[`Node`](#classNodes_1_1Node)``[`A`](#classNodes_1_1LineNode_1a167d14e120b93b605f66114e3471fc3c) |
`{property}`[`Node`](#classNodes_1_1Node)``[`B`](#classNodes_1_1LineNode_1ac0b4e4bab949fa7d3f7249c874716805) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1LineNode_1ab06482e440cb18c8927a64e1c6204704) |
`public inline`[`LineNode`](#classNodes_1_1LineNode_1ad1b6521339405eb99d42eabdeb462c0b)`(string name,`[`Node`](#classNodes_1_1Node)`A,`[`Node`](#classNodes_1_1Node)`B,`[`Node`](#classNodes_1_1Node)`Comment)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1LineNode_1a8bd8b15b4e2267247f0fdf7d5f0b7a43)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`A`](#classNodes_1_1LineNode_1a167d14e120b93b605f66114e3471fc3c)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`B`](#classNodes_1_1LineNode_1ac0b4e4bab949fa7d3f7249c874716805)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1LineNode_1ab06482e440cb18c8927a64e1c6204704)

#### `public inline`[`LineNode`](#classNodes_1_1LineNode_1ad1b6521339405eb99d42eabdeb462c0b)`(string name,`[`Node`](#classNodes_1_1Node)`A,`[`Node`](#classNodes_1_1Node)`B,`[`Node`](#classNodes_1_1Node)`Comment)`

# class `Nodes::MeasureNode`

```
class Nodes::MeasureNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`P1`](#classNodes_1_1MeasureNode_1abfd5ae1f85eae81760adf56c6e61a5a0) |
`{property}`[`Node`](#classNodes_1_1Node)``[`P2`](#classNodes_1_1MeasureNode_1ac3903c7ce49c27d1594dde111e792f32) |
`public inline`[`MeasureNode`](#classNodes_1_1MeasureNode_1aa3ae7b69155bbd54fd24d111f1c8943a)`(`[`Node`](#classNodes_1_1Node)`p1,`[`Node`](#classNodes_1_1Node)`p2)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`P1`](#classNodes_1_1MeasureNode_1abfd5ae1f85eae81760adf56c6e61a5a0)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`P2`](#classNodes_1_1MeasureNode_1ac3903c7ce49c27d1594dde111e792f32)

#### `public inline`[`MeasureNode`](#classNodes_1_1MeasureNode_1aa3ae7b69155bbd54fd24d111f1c8943a)`(`[`Node`](#classNodes_1_1Node)`p1,`[`Node`](#classNodes_1_1Node)`p2)`

# class `Nodes::MultiAssignmentNode`

```
class Nodes::MultiAssignmentNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} List< string >`[`Identifiers`](#classNodes_1_1MultiAssignmentNode_1a65b06ebfc917730953944ef0ec6d111d) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Sequence`](#classNodes_1_1MultiAssignmentNode_1ab55948d8e639b4a5ce75bed8f4c69b06) |
`public inline`[`MultiAssignmentNode`](#classNodes_1_1MultiAssignmentNode_1a9ce743f87cd93b79ca8a0db929c2dac8)`(List< string > identifiers,`[`Node`](#classNodes_1_1Node)`sequence)` |

## Members

#### `{property} List< string >`[`Identifiers`](#classNodes_1_1MultiAssignmentNode_1a65b06ebfc917730953944ef0ec6d111d)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Sequence`](#classNodes_1_1MultiAssignmentNode_1ab55948d8e639b4a5ce75bed8f4c69b06)

#### `public inline`[`MultiAssignmentNode`](#classNodes_1_1MultiAssignmentNode_1a9ce743f87cd93b79ca8a0db929c2dac8)`(List< string > identifiers,`[`Node`](#classNodes_1_1Node)`sequence)`

# class `Nodes::MultipleVariableDeclarationNode`

```
class Nodes::MultipleVariableDeclarationNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`VariableDeclarations`](#classNodes_1_1MultipleVariableDeclarationNode_1a90b7e7fe7cdac045b0fbe1cedb9e2b65) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Body`](#classNodes_1_1MultipleVariableDeclarationNode_1a464b0f8ef51d05373bf58a31575b380c) |
`public inline`[`MultipleVariableDeclarationNode`](#classNodes_1_1MultipleVariableDeclarationNode_1aebfaaab45d01bfda0da21467cfa3b888)`(List<`[`Node`](#classNodes_1_1Node)`> variableDeclarations,`[`Node`](#classNodes_1_1Node)`body)` |

## Members

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`VariableDeclarations`](#classNodes_1_1MultipleVariableDeclarationNode_1a90b7e7fe7cdac045b0fbe1cedb9e2b65)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Body`](#classNodes_1_1MultipleVariableDeclarationNode_1a464b0f8ef51d05373bf58a31575b380c)

#### `public inline`[`MultipleVariableDeclarationNode`](#classNodes_1_1MultipleVariableDeclarationNode_1aebfaaab45d01bfda0da21467cfa3b888)`(List<`[`Node`](#classNodes_1_1Node)`> variableDeclarations,`[`Node`](#classNodes_1_1Node)`body)`

# class `Nodes::Node`

Represents an abstract base class for nodes in the parser.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------

## Members

# class `Nodes::PointNode`

```
class Nodes::PointNode
  : public Nodes.Figure
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1PointNode_1a0f4703ea41b84b2f6ee503e81a84ca22) |
`{property}`[`Node`](#classNodes_1_1Node)``[`X`](#classNodes_1_1PointNode_1a989d4ca1d1f11a062b1a871164afc87f) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Y`](#classNodes_1_1PointNode_1ac1facdee9e777f2999d6f95a29a9779b) |
`public inline`[`PointNode`](#classNodes_1_1PointNode_1af99e87c66c1cc6c5db47859e92dd7eca)`(string name,`[`Node`](#classNodes_1_1Node)`x,`[`Node`](#classNodes_1_1Node)`y)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1PointNode_1a0f4703ea41b84b2f6ee503e81a84ca22)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`X`](#classNodes_1_1PointNode_1a989d4ca1d1f11a062b1a871164afc87f)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Y`](#classNodes_1_1PointNode_1ac1facdee9e777f2999d6f95a29a9779b)

#### `public inline`[`PointNode`](#classNodes_1_1PointNode_1af99e87c66c1cc6c5db47859e92dd7eca)`(string name,`[`Node`](#classNodes_1_1Node)`x,`[`Node`](#classNodes_1_1Node)`y)`

# class `Nodes::RayNode`

```
class Nodes::RayNode
  : public Nodes.Figure
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1RayNode_1aae6699a7a6ca48c09e73901eaf165cc9) |
`{property}`[`Node`](#classNodes_1_1Node)``[`P1`](#classNodes_1_1RayNode_1ac5a00bd16647aeeefd6d2ec7ee85d926) |
`{property}`[`Node`](#classNodes_1_1Node)``[`P2`](#classNodes_1_1RayNode_1a4437fa9c5c79fd6db37f48bdb0d93656) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1RayNode_1a194b7470aea7583024d434649952c84e) |
`public inline`[`RayNode`](#classNodes_1_1RayNode_1ab24a28b5f458487aba3e7bd2480df801)`(string name,`[`Node`](#classNodes_1_1Node)`p1,`[`Node`](#classNodes_1_1Node)`p2,`[`Node`](#classNodes_1_1Node)`comment)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1RayNode_1aae6699a7a6ca48c09e73901eaf165cc9)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`P1`](#classNodes_1_1RayNode_1ac5a00bd16647aeeefd6d2ec7ee85d926)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`P2`](#classNodes_1_1RayNode_1a4437fa9c5c79fd6db37f48bdb0d93656)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1RayNode_1a194b7470aea7583024d434649952c84e)

#### `public inline`[`RayNode`](#classNodes_1_1RayNode_1ab24a28b5f458487aba3e7bd2480df801)`(string name,`[`Node`](#classNodes_1_1Node)`p1,`[`Node`](#classNodes_1_1Node)`p2,`[`Node`](#classNodes_1_1Node)`comment)`

# class `Nodes::RestoreNode`

```
class Nodes::RestoreNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`public inline`[`RestoreNode`](#classNodes_1_1RestoreNode_1a739a549a84350597d10c5245b418d239)`()` |

## Members

#### `public inline`[`RestoreNode`](#classNodes_1_1RestoreNode_1a739a549a84350597d10c5245b418d239)`()`

# class `Nodes::ReturnToDrawNode`

```
class Nodes::ReturnToDrawNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Figures`](#classNodes_1_1ReturnToDrawNode_1a517a8e52f4a5b300197b7f454d11ff4a) |
`{property} string`[`Color`](#classNodes_1_1ReturnToDrawNode_1ae794d27e0c2adc67d00707a5b2bf17cb) |
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Coords`](#classNodes_1_1ReturnToDrawNode_1a881ab03ca1f7d79548a7df9582f5d669) |
`public inline`[`ReturnToDrawNode`](#classNodes_1_1ReturnToDrawNode_1a3d91c7e758e648b6c871df26f6329e3f)`(`[`Node`](#classNodes_1_1Node)` figures,string color,List< `[`Node`](#classNodes_1_1Node)`> coords)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Figures`](#classNodes_1_1ReturnToDrawNode_1a517a8e52f4a5b300197b7f454d11ff4a)

#### `{property} string`[`Color`](#classNodes_1_1ReturnToDrawNode_1ae794d27e0c2adc67d00707a5b2bf17cb)

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Coords`](#classNodes_1_1ReturnToDrawNode_1a881ab03ca1f7d79548a7df9582f5d669)

#### `public inline`[`ReturnToDrawNode`](#classNodes_1_1ReturnToDrawNode_1a3d91c7e758e648b6c871df26f6329e3f)`(`[`Node`](#classNodes_1_1Node)` figures,string color,List< `[`Node`](#classNodes_1_1Node)`> coords)`

# class `Nodes::SegmentNode`

```
class Nodes::SegmentNode
  : public Nodes.Figure
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Name`](#classNodes_1_1SegmentNode_1aa13bda2e83048df6d6e01b73a839803b) |
`{property}`[`Node`](#classNodes_1_1Node)``[`A`](#classNodes_1_1SegmentNode_1ae87f9dca541237bd41a3332d65b8ae51) |
`{property}`[`Node`](#classNodes_1_1Node)``[`B`](#classNodes_1_1SegmentNode_1a91f1767a4a799d5a87b60339a93ed52f) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1SegmentNode_1a0dd638bf18b2e370cfc9337b11281410) |
`public inline`[`SegmentNode`](#classNodes_1_1SegmentNode_1a4b9a505d06ff1021b9b23d5fde930965)`(string name,`[`Node`](#classNodes_1_1Node)`A,`[`Node`](#classNodes_1_1Node)`B,`[`Node`](#classNodes_1_1Node)`Comment)` |

## Members

#### `{property} string`[`Name`](#classNodes_1_1SegmentNode_1aa13bda2e83048df6d6e01b73a839803b)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`A`](#classNodes_1_1SegmentNode_1ae87f9dca541237bd41a3332d65b8ae51)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`B`](#classNodes_1_1SegmentNode_1a91f1767a4a799d5a87b60339a93ed52f)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Comment`](#classNodes_1_1SegmentNode_1a0dd638bf18b2e370cfc9337b11281410)

#### `public inline`[`SegmentNode`](#classNodes_1_1SegmentNode_1a4b9a505d06ff1021b9b23d5fde930965)`(string name,`[`Node`](#classNodes_1_1Node)`A,`[`Node`](#classNodes_1_1Node)`B,`[`Node`](#classNodes_1_1Node)`Comment)`

# class `Nodes::SequenceNode`

```
class Nodes::SequenceNode
  : public Nodes.Node
```  

Represents a sequence of nodes.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} string`[`Identifier`](#classNodes_1_1SequenceNode_1a8319275d9735bc064bb05fbf8a8333b0) |
`{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Nodes`](#classNodes_1_1SequenceNode_1a0f9365f868ac5f9e3cfd6f36022686ac) |
`public inline`[`SequenceNode`](#classNodes_1_1SequenceNode_1aed6e3dc77b23357e55d9da4b50297ee7)`(List<`[`Node`](#classNodes_1_1Node)`> nodes,string identifier)` |

## Members

#### `{property} string`[`Identifier`](#classNodes_1_1SequenceNode_1a8319275d9735bc064bb05fbf8a8333b0)

#### `{property} List<`[`Node`](#classNodes_1_1Node)` > `[`Nodes`](#classNodes_1_1SequenceNode_1a0f9365f868ac5f9e3cfd6f36022686ac)

#### `public inline`[`SequenceNode`](#classNodes_1_1SequenceNode_1aed6e3dc77b23357e55d9da4b50297ee7)`(List<`[`Node`](#classNodes_1_1Node)`> nodes,string identifier)`

# class `Nodes::UndefinedNode`

```
class Nodes::UndefinedNode
  : public Nodes.Node
```  

Represents a node that holds an undefined value.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------

## Members

# class `Nodes::ValueNode`

```
class Nodes::ValueNode
  : public Nodes.Node
```  

Represents a node that holds a value.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} object`[`Value`](#classNodes_1_1ValueNode_1a2675f90fb33600f851716f8ed6c43a67) | Gets the value of the node.
`public inline`[`ValueNode`](#classNodes_1_1ValueNode_1a20324fe8ae6ff7321e7864bd18c9ec83)`(object value)` | Initializes a new instance of the [ValueNode](#classNodes_1_1ValueNode) class with the specified value.

## Members

#### `{property} object`[`Value`](#classNodes_1_1ValueNode_1a2675f90fb33600f851716f8ed6c43a67)

Gets the value of the node.

#### `public inline`[`ValueNode`](#classNodes_1_1ValueNode_1a20324fe8ae6ff7321e7864bd18c9ec83)`(object value)`

Initializes a new instance of the [ValueNode](#classNodes_1_1ValueNode) class with the specified value.

#### Parameters

* `value` The value to be stored in the node.

# class `Nodes::VariableDeclarationNode`

```
class Nodes::VariableDeclarationNode
  : public Nodes.Node
```  

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`Node`](#classNodes_1_1Node)``[`Identifier`](#classNodes_1_1VariableDeclarationNode_1a31b12dd89bb33e9b112c44506babd6c0) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Value`](#classNodes_1_1VariableDeclarationNode_1a337486be4d96dba4a98560aa0c35df07) |
`{property}`[`Node`](#classNodes_1_1Node)``[`Body`](#classNodes_1_1VariableDeclarationNode_1a6112d693ecc4bb58bd4ed2b96aa3ef9e) |
`public inline`[`VariableDeclarationNode`](#classNodes_1_1VariableDeclarationNode_1a1fc00851b8a4864a785da3302e5fc1b4)`(`[`Node`](#classNodes_1_1Node)`identifier,`[`Node`](#classNodes_1_1Node)`value,`[`Node`](#classNodes_1_1Node)`body)` |

## Members

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Identifier`](#classNodes_1_1VariableDeclarationNode_1a31b12dd89bb33e9b112c44506babd6c0)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Value`](#classNodes_1_1VariableDeclarationNode_1a337486be4d96dba4a98560aa0c35df07)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`Body`](#classNodes_1_1VariableDeclarationNode_1a6112d693ecc4bb58bd4ed2b96aa3ef9e)

#### `public inline`[`VariableDeclarationNode`](#classNodes_1_1VariableDeclarationNode_1a1fc00851b8a4864a785da3302e5fc1b4)`(`[`Node`](#classNodes_1_1Node)`identifier,`[`Node`](#classNodes_1_1Node)`value,`[`Node`](#classNodes_1_1Node)`body)`

# namespace `ParserAnalize`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`ParserAnalize::Parser`](#classParserAnalize_1_1Parser) |

# class `ParserAnalize::Parser`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} List<`[`Token`](#classTokens_1_1Token)` > `[`Tokens`](#classParserAnalize_1_1Parser_1a4db9c343718172dd2d5ca6bf7fd3663c) |
`{property}`[`Token`](#classTokens_1_1Token)`?`[`CurrentToken`](#classParserAnalize_1_1Parser_1af30bb0c214826c54da1c053b417d2a51) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseEol`](#classParserAnalize_1_1Parser_1af172543707a6fb4d34d2843dc453d7f9) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParsePointExpression`](#classParserAnalize_1_1Parser_1a0436265ac92d180eea2eb1bc50f73585) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseArc`](#classParserAnalize_1_1Parser_1afc287a717179a346b9d479891b1396ce) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseCircle`](#classParserAnalize_1_1Parser_1af5a314747a55dfaca91ea09e1094177c) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseRay`](#classParserAnalize_1_1Parser_1a536fbfccad801dde1a30d579c4b34401) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseSegment`](#classParserAnalize_1_1Parser_1aeb44208f08896c06cad2223fd37ed47e) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseLine`](#classParserAnalize_1_1Parser_1ae4be41fb6837c07e6aa656de2a4be369) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseColor`](#classParserAnalize_1_1Parser_1ad8cf3aba4e1e5048641ff87fabdd39ee) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseRestore`](#classParserAnalize_1_1Parser_1a5a1218f89cbcb222b78bae787ec77b81) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseDraw`](#classParserAnalize_1_1Parser_1a6ef0c1b7cb2af4c33b89ba971a945fbf) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseMeasure`](#classParserAnalize_1_1Parser_1ae16ab788ef95663ab5843e64e3959a82) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseIntersect`](#classParserAnalize_1_1Parser_1adf0f8f77223d2610754d1560081a6908) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseNumber`](#classParserAnalize_1_1Parser_1a69073ec20dc1ac1da491f0397c0203fe) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseIdentifier`](#classParserAnalize_1_1Parser_1a8271c84123fe227b9814c2a7408668f0) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseVariableDeclaration`](#classParserAnalize_1_1Parser_1a8d26d46b0ed8cabb32d40858fd77c84d) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseIfExpression`](#classParserAnalize_1_1Parser_1a04725eed28fe3e11480bb4fc0b5369f8) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseCondition`](#classParserAnalize_1_1Parser_1af5ab0d8a132bd255e11a4a51af65e0b9) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseStringLiteral`](#classParserAnalize_1_1Parser_1a904156230b14cfba9edd1b1effbf0cfc) |
`{property}`[`Node`](#classNodes_1_1Node)``[`ParseImport`](#classParserAnalize_1_1Parser_1a73a06b0a75e2f103f163bc05bb4c0823) |
`public inline`[`Parser`](#classParserAnalize_1_1Parser_1a322874b4f9a816c99e49e7ab178b8303)`(List<`[`Token`](#classTokens_1_1Token)`> tokens)` | Represents a parser that processes a list of tokens.
`public inline List<`[`Node`](#classNodes_1_1Node)` > `[`Parse`](#classParserAnalize_1_1Parser_1a60af3f15a5bc9a88ec2cb1147d7735c2)`()` | Represents a node in the parse tree.

## Members

#### `{property} List<`[`Token`](#classTokens_1_1Token)` > `[`Tokens`](#classParserAnalize_1_1Parser_1a4db9c343718172dd2d5ca6bf7fd3663c)

#### `{property}`[`Token`](#classTokens_1_1Token)`?`[`CurrentToken`](#classParserAnalize_1_1Parser_1af30bb0c214826c54da1c053b417d2a51)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseEol`](#classParserAnalize_1_1Parser_1af172543707a6fb4d34d2843dc453d7f9)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParsePointExpression`](#classParserAnalize_1_1Parser_1a0436265ac92d180eea2eb1bc50f73585)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseArc`](#classParserAnalize_1_1Parser_1afc287a717179a346b9d479891b1396ce)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseCircle`](#classParserAnalize_1_1Parser_1af5a314747a55dfaca91ea09e1094177c)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseRay`](#classParserAnalize_1_1Parser_1a536fbfccad801dde1a30d579c4b34401)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseSegment`](#classParserAnalize_1_1Parser_1aeb44208f08896c06cad2223fd37ed47e)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseLine`](#classParserAnalize_1_1Parser_1ae4be41fb6837c07e6aa656de2a4be369)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseColor`](#classParserAnalize_1_1Parser_1ad8cf3aba4e1e5048641ff87fabdd39ee)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseRestore`](#classParserAnalize_1_1Parser_1a5a1218f89cbcb222b78bae787ec77b81)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseDraw`](#classParserAnalize_1_1Parser_1a6ef0c1b7cb2af4c33b89ba971a945fbf)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseMeasure`](#classParserAnalize_1_1Parser_1ae16ab788ef95663ab5843e64e3959a82)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseIntersect`](#classParserAnalize_1_1Parser_1adf0f8f77223d2610754d1560081a6908)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseNumber`](#classParserAnalize_1_1Parser_1a69073ec20dc1ac1da491f0397c0203fe)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseIdentifier`](#classParserAnalize_1_1Parser_1a8271c84123fe227b9814c2a7408668f0)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseVariableDeclaration`](#classParserAnalize_1_1Parser_1a8d26d46b0ed8cabb32d40858fd77c84d)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseIfExpression`](#classParserAnalize_1_1Parser_1a04725eed28fe3e11480bb4fc0b5369f8)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseCondition`](#classParserAnalize_1_1Parser_1af5ab0d8a132bd255e11a4a51af65e0b9)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseStringLiteral`](#classParserAnalize_1_1Parser_1a904156230b14cfba9edd1b1effbf0cfc)

#### `{property}`[`Node`](#classNodes_1_1Node)``[`ParseImport`](#classParserAnalize_1_1Parser_1a73a06b0a75e2f103f163bc05bb4c0823)

#### `public inline`[`Parser`](#classParserAnalize_1_1Parser_1a322874b4f9a816c99e49e7ab178b8303)`(List<`[`Token`](#classTokens_1_1Token)`> tokens)`

Represents a parser that processes a list of tokens.

#### Parameters

* `tokens` The list of tokens to be processed.

#### `public inline List<`[`Node`](#classNodes_1_1Node)` > `[`Parse`](#classParserAnalize_1_1Parser_1a60af3f15a5bc9a88ec2cb1147d7735c2)`()`

Represents a node in the parse tree.

#### Returns

The parsed node.

# namespace `Tokens`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`enum`[`TokenType`](#namespaceTokens_1ab43080328a5695cff2a2e7b23e8a3e3a)            | Represents the different types of tokens in the program.
`class`[`Tokens::Token`](#classTokens_1_1Token) | Represents a token in the program.

## Members

#### `enum`[`TokenType`](#namespaceTokens_1ab43080328a5695cff2a2e7b23e8a3e3a)

 Values                         | Descriptions
--------------------------------|---------------------------------------------
Flinq            |
LLinq            |
LParen            |
RParen            |
LBrace            |
RBrace            |
LBracket            |
RBracket            |
Operator            |
Punctuation            |
Point            |
Comma            |
ComparisonOperator            |
Identifier            |
FIdentifier            |
Number            |
Parameter            |
StringLiteral            |
LetKeyword            |
IfKeyword            |
ThenKeyword            |
ElseKeyword            |
InKeyword            |
FunctionKeyword            |
DrawKeyword            |
MeasureKeyword            |
EOL            |
EOF            |
Figure            |
ColorKeyword            |
RestoreKeyword            |
IntersectKeyword            |
DotDotDot            |
ImportKeyword            |

Represents the different types of tokens in the program.

# class `Tokens::Token`

Represents a token in the program.

#### Parameters

* `type` The type of the token.

* `value` The value of the token.

* `line` The line number where the token appears.

* `column` The column number where the token appears.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property}`[`TokenType`](#namespaceTokens_1ab43080328a5695cff2a2e7b23e8a3e3a)``[`Type`](#classTokens_1_1Token_1a10ac72aae94b8d2b1373d4d38cc97d5e) |
`{property} string`[`Value`](#classTokens_1_1Token_1aa8c7dfb126acac364ac314f486382785) |
`{property} int`[`Line`](#classTokens_1_1Token_1afb4d684efc311ef4da52c07551ab2f7b) |
`{property} int`[`Column`](#classTokens_1_1Token_1ac3549008fcfe7cc41745f4e2680ee1c5) |
`public inline`[`Token`](#classTokens_1_1Token_1a5c8d2e3ee59c381649f02c93399bfb74)`(`[`TokenType`](#namespaceTokens_1ab43080328a5695cff2a2e7b23e8a3e3a)`type,string value,int line,int column)` | Represents a token in the program.

## Members

#### `{property}`[`TokenType`](#namespaceTokens_1ab43080328a5695cff2a2e7b23e8a3e3a)``[`Type`](#classTokens_1_1Token_1a10ac72aae94b8d2b1373d4d38cc97d5e)

#### `{property} string`[`Value`](#classTokens_1_1Token_1aa8c7dfb126acac364ac314f486382785)

#### `{property} int`[`Line`](#classTokens_1_1Token_1afb4d684efc311ef4da52c07551ab2f7b)

#### `{property} int`[`Column`](#classTokens_1_1Token_1ac3549008fcfe7cc41745f4e2680ee1c5)

#### `public inline`[`Token`](#classTokens_1_1Token_1a5c8d2e3ee59c381649f02c93399bfb74)`(`[`TokenType`](#namespaceTokens_1ab43080328a5695cff2a2e7b23e8a3e3a)`type,string value,int line,int column)`

Represents a token in the program.

#### Parameters

* `type` The type of the token.

* `value` The value of the token.

* `line` The line number where the token appears.

* `column` The column number where the token appears.

# namespace `WaLI`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`WaLI::Program`](#classWaLI_1_1Program) |

# class `WaLI::Program`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------

## Members

# namespace `WaLI::backend`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`WaLI::backend::MiddleEnd`](#classWaLI_1_1backend_1_1MiddleEnd) | Provides functionality for executing GSharp code.

# class `WaLI::backend::MiddleEnd`

Provides functionality for executing GSharp code.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------

## Members

# namespace `WaLI::backend::src::extras`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`WaLI::backend::src::extras::Scope`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope) |

# class `WaLI::backend::src::extras::Scope`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`{property} Dictionary< string, PointF >`[`poiND`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a8b747069618c8c71a75eeb91572e7f33) |
`{property} List<`[`DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode)` > `[`Seqs`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1adeba857b47750fa2ab4904e3273e9184) |
`{property} Dictionary< string, Func< double[], double > >`[`predefinedFunctions`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a8de76322d2b87119afe15e6c3f24d537) |
`{property} List<`[`ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode)` > `[`cDN`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a210ed0bd52b6d99b45cd08c1b76e310c) |
`{property} List<`[`GlobalConstNode`](#classNodes_1_1GlobalConstNode)` > `[`DeclaredConst`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1ae52ee20523464923a703ecbda38ab1ce) |
`{property} Stack< Brush >`[`Color`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a465718f43a2ce1422000faa470f82192) |
`public inline`[`Scope`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a210c22943a21bf28a25781e13cc64cd3)`()` |

## Members

#### `{property} Dictionary< string, PointF >`[`poiND`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a8b747069618c8c71a75eeb91572e7f33)

#### `{property} List<`[`DeclaredSequenceNode`](#classNodes_1_1DeclaredSequenceNode)` > `[`Seqs`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1adeba857b47750fa2ab4904e3273e9184)

#### `{property} Dictionary< string, Func< double[], double > >`[`predefinedFunctions`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a8de76322d2b87119afe15e6c3f24d537)

#### `{property} List<`[`ConstDeclarationNode`](#classNodes_1_1ConstDeclarationNode)` > `[`cDN`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a210ed0bd52b6d99b45cd08c1b76e310c)

#### `{property} List<`[`GlobalConstNode`](#classNodes_1_1GlobalConstNode)` > `[`DeclaredConst`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1ae52ee20523464923a703ecbda38ab1ce)

#### `{property} Stack< Brush >`[`Color`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a465718f43a2ce1422000faa470f82192)

#### `public inline`[`Scope`](#classWaLI_1_1backend_1_1src_1_1extras_1_1Scope_1a210c22943a21bf28a25781e13cc64cd3)`()`

# namespace `WaLI::backend::src::semantic`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`class`[`WaLI::backend::src::semantic::SemanticAnalyzer`](#classWaLI_1_1backend_1_1src_1_1semantic_1_1SemanticAnalyzer) |

# class `WaLI::backend::src::semantic::SemanticAnalyzer`

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`public inline void`[`Analyze`](#classWaLI_1_1backend_1_1src_1_1semantic_1_1SemanticAnalyzer_1aeb6a568a2110189c46565ee08dda6e8d)`(`[`Node`](#classNodes_1_1Node)`node)` |

## Members

#### `public inline void`[`Analyze`](#classWaLI_1_1backend_1_1src_1_1semantic_1_1SemanticAnalyzer_1aeb6a568a2110189c46565ee08dda6e8d)`(`[`Node`](#classNodes_1_1Node)`node)`

# struct `Lists::ListExtrasScoper::ToDraw`

Represents a structure that holds information about a figure to be drawn.

## Summary

 Members                        | Descriptions
--------------------------------|---------------------------------------------
`public string`[`name`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1ac7d3993d130d5d85d2eb98461b970c9b) |
`public string`[`figure`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1afddad1d0e0de2e3a028843f3d5e4a2b5) | The name of the figure.
`public Brush`[`color`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1ab3b3b2606095d4cfa56ec7183e1fef29) | The color of the figure.
`public PointF[]`[`points`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1ae0caaacd4f618f23c7c7873e9f5f79d5) | The array of points that define the figure.
`public double`[`rad`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1aab0e31931f61f5af31c94867eba26762) | The radius of the figure (if applicable).
`public string`[`comment`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1a4c9282cbd14480209bf0caf5f3eea21d) | A comment associated with the figure.

## Members

#### `public string`[`name`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1ac7d3993d130d5d85d2eb98461b970c9b)

#### `public string`[`figure`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1afddad1d0e0de2e3a028843f3d5e4a2b5)

The name of the figure.

#### `public Brush`[`color`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1ab3b3b2606095d4cfa56ec7183e1fef29)

The color of the figure.

#### `public PointF[]`[`points`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1ae0caaacd4f618f23c7c7873e9f5f79d5)

The array of points that define the figure.

#### `public double`[`rad`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1aab0e31931f61f5af31c94867eba26762)

The radius of the figure (if applicable).

#### `public string`[`comment`](#structLists_1_1ListExtrasScoper_1_1ToDraw_1a4c9282cbd14480209bf0caf5f3eea21d)

A comment associated with the figure.

Generated by [Moxygen](https://sourcey.com/moxygen)
