namespace Studying;

public static class QuoteHelper
{
    public static async Task<string> GetQuoteAsync()
    {
        using HttpClient client = new();
        string quoteText = await client.GetStringAsync("http://api.forismatic.com/api/1.0/?method=getQuote&lang=ru&format=text");
        return quoteText;
    }
}
