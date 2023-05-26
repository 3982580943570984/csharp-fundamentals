namespace Studying
{
    internal interface IAdapter
    {
        string GetJSON();
        string GetXML();
        string GetYAML();
        string GetCSV();
    }
}
