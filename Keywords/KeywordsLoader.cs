using System.Text.Json;

namespace FlexibleQuery.Keywords
{
    public class KeywordsLoader
    {
        public string Path { get; set; }
        public IDictionary<string, Keyword> Keywords { get; set; }

        public KeywordsLoader(string path)
        {
            Path = path;
            Keywords = this.Load();
        }

        private IDictionary<string, Keyword> Load()
        {
            if (File.Exists(Path))
            {
                throw new FileNotFoundException(Path);
            }

            return JsonSerializer.Deserialize<IDictionary<string, Keyword>>(File.ReadAllText(Path))!;
        }

        public Keyword Of(string key) =>
            Keywords.TryGetValue(key, out Keyword? keyword) ? keyword : throw new KeyNotFoundException($"Couldn't find a keyword for key {key}");
    }
}
