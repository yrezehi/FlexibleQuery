using FlexibleQuery.Keywords.Abstracts;

namespace FlexibleQuery.Keywords
{
    public class Keyword : IKeyword
    {
        public string Key { get; set; }
        public IList<string> Abbreviations { get; set; }

        public Keyword(string key)
        {
            Key = key;
            Abbreviations;
        }

        public static IKeyword Of(string key) =>
            new Keyword(key);
    }
}
