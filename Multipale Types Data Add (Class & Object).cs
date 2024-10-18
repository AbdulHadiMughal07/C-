namespace myapp
{
    class Program
    {
        static List<Student> listname = new List<Student>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Add Data\n 2. Show Data");

                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput == 1)
                {
                    Student.Adddata();
                }
                else
                {
                    Student.Showdata();
                }

            }

        }
        class Student
        {


            public int id { get; set; }
            public string name { get; set; }

            public static void Adddata()
            {

                Student std = new Student();

                Console.WriteLine("Enter ID");
                std.id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                std.name = Console.ReadLine();

                listname.Add(std);
            }

            public static void Showdata()
            {
                foreach (Student abc in listname)
                {
                    Console.WriteLine($"ID is : {abc.id}\n name is : {abc.name}");
                }
            }
        }

   
    }
}
