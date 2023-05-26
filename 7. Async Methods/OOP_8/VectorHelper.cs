namespace Studying;

public static class VectorHelper
{
    public const int VectorSize = 1000000;

    public static int[] GenerateVector()
    {
        Random random = new();
        return Enumerable.Repeat(0, VectorSize)
                         .Select(x => random.Next())
                         .ToArray();
    }
    public static async Task<int> FindMaxAsync(int[] vector)
    {
        return await Task.Run(() =>
        {
            int max = int.MinValue;
            foreach (int x in vector)
                if (x > max)
                    max = x;
            return max;
        });
    }
    public static async Task<int> FindMaxAsync(int[] vector, Action<int> progressCallback)
    {
        return await Task.Run(() =>
        {
            int max = int.MinValue;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > max)
                    max = vector[i];

                if (i % (vector.Length / 100) == 0)
                    progressCallback(i * 100 / vector.Length);
            }
            return max;
        });
    }
}