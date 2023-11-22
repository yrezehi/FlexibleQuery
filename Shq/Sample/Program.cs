using Sample.Entity;
using Shq.Lexical;
using Shq.Predicates;

string query = "Username = AKHMED";

var tokenizedQuery = Tokenizer.Tokenize(query);
var predicates = PredicateBuilder.BuildPredicate<SampleEntity, string>(tokenizedQuery);

Console.WriteLine("Program Finished Execution!");