using FlexibleQuery.Keywords.Abstracts;
using System.Collections.Concurrent;

namespace FlexibleQuery.Keywords
{
    public static class KeywordDictionary
    {
        private static string KEYWORDS_PATH = "Keywords\\Locals\\keywords.json";

        private static readonly KeywordsLoader KeywordsLoader = new KeywordsLoader(KEYWORDS_PATH);
        private static readonly IDictionary<string, IKeyword> Keywords = CreateKeywords;

        public static void Register(IKeyword keyword) =>
            Keywords.TryAdd(keyword.Key, keyword);

        public static void UnRegister(string keyword) =>
            Keywords.Remove(keyword, out _);

        private static ConcurrentDictionary<string, IKeyword> CreateKeywords => new()
        {
            ["OR"] = KeywordsLoader.Of("OR"),
            ["AND"] = KeywordsLoader.Of("AND"),

            ["LESS-THAN"] = KeywordsLoader.Of("LESS-THAN"),
            ["MORE-THAN"] = KeywordsLoader.Of("MORE-THAN"),

            ["EQUAL"] = KeywordsLoader.Of("EQUAL")
        };

        public static KeyValuePair<string, IKeyword>? GetByAbbreviations(string key) =>
            Keywords.FirstOrDefault(keyword => keyword.Value.Abbreviations.Contains(key));
    }
}
