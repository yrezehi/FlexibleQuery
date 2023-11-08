using FlexibleQuery.Keywords.Abstracts;

namespace FlexibleQuery.Keywords
{
    public class Keyword : IKeyword
    {
        public IList<string> Abbreviations { get; set; }

        public Keyword(IList<string> abbreviations) =>
            (Abbreviations) = (abbreviations);
    }
}
