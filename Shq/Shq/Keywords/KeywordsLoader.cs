using System.IO;
using System.Text.Json;

namespace Shq.Keywords
{
    public class KeywordsLoader
    {
        public IDictionary<string, Keyword> Keywords { get; set; }

        public KeywordsLoader(string path) =>
            Keywords = Load(path);


        private IDictionary<string, Keyword> Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(path);
            }

            return JsonSerializer.Deserialize<IDictionary<string, Keyword>>(File.ReadAllText(path))!;
        }

        public Keyword Of(string key) =>
            Keywords.TryGetValue(key, out Keyword? keyword) ? keyword : throw new KeyNotFoundException($"Couldn't find a keyword for key {key}");
    }
}
