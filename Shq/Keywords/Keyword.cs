using Shq.Shq.Keywords.Abstracts;

namespace Shq.Shq.Keywords
{
    public class Keyword : IKeyword
    {
        public IList<string> Abbreviations { get; set; }

        public Keyword(IList<string> abbreviations) =>
            Abbreviations = abbreviations;
    }
}
