namespace FlexibleQuery.Query
{
    public static class QueryParser
    {
        // for simplicity input sample: Level = 11
        private static bool IsValid(string query)
        {
            IList<string> toknized = QueryParser.Toknize(query);

            return toknized.Any();
        }

        private static IList<string> Toknize(string query) =>
            query.Split(new char[] { ' ' });

    }
}
