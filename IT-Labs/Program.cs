using System.Text.Json;
public class Program
{
    public static void Main()
    {
        List<Person> a = new List<Person>();
        for (int i = 0; i < 5; i++)
            a.Add(new Person());
        foreach (var item in a)
        {
            Console.WriteLine(item.Id);
        }
        Console.Write($"insert Id: ");
        int SeID = int.Parse(Console.ReadLine());
        Person p = a.Find(x => x.Id == SeID);
        int idx = a.IndexOf(p);
        if (idx != -1)
            Console.WriteLine(idx);
        else
            Console.WriteLine("ID not found");
    }
}
public class Person
{
    public int Id;
    public Person() { Random r = new Random(); Id = r.Next(1000, 10000); }
}