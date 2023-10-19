using FlexibleQuery.Keywords.Abstracts;
using System.Collections.Concurrent;

namespace FlexibleQuery.Keywords
{
    public class KeywordDictionary
    {
        private readonly IDictionary<string, IKeyword> Keywords;
        private readonly KeywordsLoader KeywordsLoader;

        public KeywordDictionary(string keywordsPath) =>
            (Keywords, KeywordsLoader) = (CreateKeywords(), new KeywordsLoader(keywordsPath));

        public void Register(IKeyword keyword) =>
            Keywords.TryAdd(keyword.Key, keyword);

        public void UnRegister(string keyword) =>
            Keywords.Remove(keyword, out _);

        private ConcurrentDictionary<string, IKeyword> CreateKeywords() => new()
        {
            ["OR"] = KeywordsLoader.Of("OR"),
            ["AND"] = KeywordsLoader.Of("AND"),

            ["LESS-THAN"] = KeywordsLoader.Of("LESS-THAN"),
            ["MORE-THAN"] = KeywordsLoader.Of("MORE-THAN"),

            ["EQUAL"] = KeywordsLoader.Of("EQUAL")
        };

        public string GetByAbbreviations(string key) =>
            Keywords.FirstOrDefault(keyword => keyword.Value.Abbreviations.Contains(key)).Key;
    }
}
