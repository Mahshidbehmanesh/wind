namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Prson number:");
            int Numbers = Convert.ToInt32(Console.ReadLine());
            string[] Nams = new string[Numbers];


            for(int i=0;i<Numbers; i++)
            {
                Console.WriteLine("Please Enter Name:"+(i+1));
                Console.ReadKey();
            }
        }
    }
}