using FlexibleQuery.Keywords.Abstracts;
using System.Collections.Concurrent;

namespace FlexibleQuery.Keywords
{
    public class KeywordDictionary
    {
        private readonly ConcurrentDictionary<string, IKeyword> Keywords;

        public KeywordDictionary() =>
            Keywords = new();

        public void Register(IKeyword keyword) =>
            Keywords.TryAdd(keyword.Key, keyword);

        public void UnRegister(string keyword) =>
            Keywords.Remove(keyword, out _);
    }
}
