namespace LinqPractices
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinqDbContext _context = new();
            HashSet<Student> students = _context.Students.ToHashSet();
            Console.WriteLine("*****FIND*****");
            var student = _context.Students.Find(1);
            Console.WriteLine(student?.Name);
            Console.ReadKey();
        }
    }
}