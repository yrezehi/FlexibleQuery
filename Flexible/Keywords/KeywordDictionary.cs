using FlexibleQuery.Keywords.Abstracts;
using System.Collections.Concurrent;

namespace FlexibleQuery.Keywords
{
    public static class KeywordDictionary
    {
        private static string KEYWORDS_PATH = "Keywords\\Locals\\keywords.json";

        private static readonly KeywordsLoader KeywordsLoader = new KeywordsLoader(KEYWORDS_PATH);
        private static readonly IDictionary<string, Keyword> Keywords = CreateKeywords;

        private static ConcurrentDictionary<string, Keyword> CreateKeywords => new()
        {
            ["OR"] = KeywordsLoader.Of("OR"),
            ["AND"] = KeywordsLoader.Of("AND"),

            ["LESS-THAN"] = KeywordsLoader.Of("LESS-THAN"),
            ["MORE-THAN"] = KeywordsLoader.Of("MORE-THAN"),

            ["EQUAL"] = KeywordsLoader.Of("EQUAL")
        };

        public static KeyValuePair<string, Keyword>? GetByAbbreviations(string key) =>
            Keywords.FirstOrDefault(keyword => keyword.Value.Abbreviations.Contains(key));

        public static bool Contains(string key) =>
            Keywords.ContainsKey(key);
    }
}
