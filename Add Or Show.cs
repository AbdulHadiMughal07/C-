namespace myapp
{
    class Program
    {
        static List<string> lisname = new List<string>();

        static void Main() { 
            while (true)
            {
                Console.WriteLine("1. Add Data\n 2. Show Data");

                int userinput = Convert.ToInt32(Console.ReadLine());
                
                if(userinput == 1)
                {
                    Adddata();
                }
                else
                {
                    Showdata();
                }

            }

        }

        static void Adddata()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            lisname.Add(name);
        }
        static void Showdata()
        {
            foreach (string names in lisname)
            {
                Console.WriteLine($"name is : {names}");
            }
        }
    }
}
