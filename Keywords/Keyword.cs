using FlexibleQuery.Keywords.Abstracts;

namespace FlexibleQuery.Keywords
{
    public class Keyword : IKeyword
    {
        public string Key { get; set; }

        public Keyword(string key)
        {
            Key = key;
        }

        public static IKeyword Of(string key) =>
            new Keyword(key);
    }
}
