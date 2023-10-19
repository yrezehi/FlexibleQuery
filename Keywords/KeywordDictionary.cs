using FlexibleQuery.Keywords.Abstracts;
using System.Collections.Concurrent;

namespace FlexibleQuery.Keywords
{
    public class KeywordDictionary
    {
        private readonly IDictionary<string, IKeyword> Keywords;

        public KeywordDictionary() =>
            Keywords = CreateKeywords();

        public void Register(IKeyword keyword) =>
            Keywords.TryAdd(keyword.Key, keyword);

        public void UnRegister(string keyword) =>
            Keywords.Remove(keyword, out _);

        private ConcurrentDictionary<string, IKeyword> CreateKeywords() => new()
        {
            ["<"] = Keyword.Of("<"),
            ["<="] = Keyword.Of("<="),

            [">"] = Keyword.Of(">"),
            [">="] = Keyword.Of(">="),

            ["=="] = Keyword.Of("=="),
            ["!="] = Keyword.Of("!="),

            ["OR"] = Keyword.Of("OR"),
            ["AND"] = Keyword.Of("AND"),
            ["NOT"] = Keyword.Of("NOT")
        };
    }
}
