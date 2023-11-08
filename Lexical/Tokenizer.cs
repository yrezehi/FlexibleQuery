using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleQuery.Lexical
{
    public static class Tokenizer {

        private static readonly char[]? TOKEN_SEPARTOR = null;

        public static IEnumerable<string> Tokenize(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return Enumerable.Empty<string>();
            }

            var tokens = new List<string>();
            
            foreach(var character in query.Split(TOKEN_SEPARTOR))
            {
                
            }
            
            return tokens;
        }
    }
}
