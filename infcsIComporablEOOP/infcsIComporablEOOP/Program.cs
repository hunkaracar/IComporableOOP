using infcsIComporablEOOP;

//Nesneye karşılaştırlabilir olma özelliği kazandırma
namespace infcsIComporablEOOP;


class Program
{
    public static void Main()
    {
        var employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FullName = "Hunkar Acar",
                Salary = 35000
            },
            new Employee()
            {
                Id = 2,
                FullName = "Omer kasapoglu",
                Salary = 25000
            },
            new Employee()
            {
                Id = 3,
                FullName = "Semih Eseroglu",
                Salary = 27000
            },
            new Employee()
            {
                Id = 4,
                FullName = "Arda Yılmaz",
                Salary = 10000
            },
            new Employee()
              
            {
                Id = 5,
                FullName = "Semih Akça",
                Salary = 17000
            }
        };

        employees.Sort(); //bu method interfacesde kullandığımız IComporobleble dan geldi => comporobleto karşılasştıma işine yarar (cast işlemi yaptık) 

        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}

