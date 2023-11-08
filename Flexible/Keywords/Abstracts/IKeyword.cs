namespace FlexibleQuery.Keywords.Abstracts
{
    public interface IKeyword
    {
        public string Key { get; set; }
        public IList<string> Abbreviations { get; set; }
    }
}
