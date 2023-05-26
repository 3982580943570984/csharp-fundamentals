namespace Studying;

public static class TimeHelper
{
    public static async Task<DateTime> GetSystemTimeAsync() => await Task.Run(() => DateTime.Now);
}