public class Student
{
	public string Name { get; }
	public double Score { get; }
	
	public Student() { Console.WriteLine("test"); }

	public Student(string name, double score)
	{
		Name = name;
		Score = score;
	}
}

static class EnumerableExtensions
{
	public static int Count<T>(this IEnumerable<T> collection, Predicate<T> predicate)
	{
		var counter = 0;
		
		foreach (var item in collection)
		{
			if (predicate(item))
				counter++;
		}
		
		return counter;
	}
}

void Main()
{
	var students = new []
	{
	  new Student(score: 4, name: "Иванов"),
	  new Student(name: "Петров", score: 3),
	  new Student(name: "Сидоров", score: 3.5f)
	};
	
	Console.WriteLine(students.Count(student => student.Score >= 3.5));
	Console.WriteLine(new[] { 1, 2, 3 }.Count(o => o > 2));
}
