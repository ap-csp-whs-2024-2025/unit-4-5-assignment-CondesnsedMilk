namespace unit_4_5_assignment_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        List<int> firstlist = new List<int>();

        firstlist.Add(1);
        firstlist.Add(2);
        firstlist.Add(3);
        firstlist.Add(3);


        Console.WriteLine("Capacity Is: " + firstlist.Capacity);

        Console.WriteLine("Count Is: " + firstlist.Count);

        firstlist.Add(5);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);
        firstlist.Add(3);


        firstlist.TrimExcess();

        Console.WriteLine("Capacity Is: " + firstlist.Capacity);


        Console.WriteLine("Count Is: " + firstlist.Count);

        firstlist.ForEach(Console.WriteLine);
    }
}
