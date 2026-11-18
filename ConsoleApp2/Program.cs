using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string sr1 = "clean code";
        string sr2 = "clean code";

        Console.WriteLine(object.ReferenceEquals(sr1, sr2));
    }
}
