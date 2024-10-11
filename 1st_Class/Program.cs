namespace myapp
{
    class Program
    {
        static void Main() {

            Console.WriteLine("Enter Your Id");
            int id = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

              
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32 (Console.ReadLine());

            //1st Method Concatenation
            Console.WriteLine("Id is : " + id + "\n" + "Name Is : " + name + "\n" + "Age Is : " + age);

            //2nd Method Enterpulation
            //Console.WriteLine($"id is : {id} \n name is : {name}\n age is {age}");


        }
    }
}