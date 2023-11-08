using FlexibleQuery.Keywords.Abstracts;

namespace FlexibleQuery.Keywords
{
    public class Keyword : IKeyword
    {
        public string Key { get; set; }
        public IList<string> Abbreviations { get; set; }

        public Keyword(string key, IList<string> abbreviations) =>
            (Key, Abbreviations) = (key, abbreviations);
    }
}
