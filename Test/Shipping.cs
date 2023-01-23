using System;

public static class Shipping
{
    public static int MinimalNumberOfPackages(int items, int availableLargePackages, int availableSmallPackages)
    {
        int largePackages = items / 5;
        if (largePackages > availableLargePackages) largePackages = availableLargePackages;
        items = items - largePackages * 5;
        if (items > availableSmallPackages) return -1;
        return items + largePackages;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Shipping.MinimalNumberOfPackages(16, 2, 10));
    }
}
