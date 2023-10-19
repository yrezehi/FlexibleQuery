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
            ["OR"] = Keyword.Of("OR"),
            ["AND"] = Keyword.Of("AND"),

            ["LESS-THAN"] = Keyword.Of("LESS-THAN"),
            ["MORE-THAN"] = Keyword.Of("MORE-THAN"),

            ["EQUAL"] = Keyword.Of("EQUAL")
        };
    }
}
