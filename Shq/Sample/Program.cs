using Shq.Lexical;
using Shq.Predicates;

string query = "USER = 10";

var tokenizedQuery = Tokenizer.Tokenize(query);
var predicates = PredicateBuilder.BuildPredicate<string>(tokenizedQuery);

Console.WriteLine("Program Finished Execution!");