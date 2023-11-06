using lab7._3;

class Program
{
    static void Main()
    {
        FunctionCache<int, string> cache = new FunctionCache<int, string>();

        Func<int, string> expensiveFunction = key =>
        {
            Console.WriteLine($"Calculating for key {key}");
            return $"Result for key {key}";
        };

        string result1 = cache.GetOrAdd(1, (int key) =>
        {
            Console.WriteLine($"Calculating for key {key}");
            return $"Result for key {key}";
        }, TimeSpan.FromMinutes(1));
        Console.WriteLine(result1);

        string result2 = cache.GetOrAdd(4, (int key) =>
        {
            Console.WriteLine($"Calculating for key {key}");
            return $"Result for key {key}";
        }, TimeSpan.FromMinutes(1));
        Console.WriteLine(result2);

        string result3 = cache.GetOrAdd(4, (int key) =>
        {
            Console.WriteLine($"Calculating for key {key}");
            return $"Result for key {key}";
        }, TimeSpan.FromMinutes(2));
        Console.WriteLine(result3);
    }
}