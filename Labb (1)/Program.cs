namespace Labb__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter person 1:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Hur gammal är person 1:");
            int age1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Vad heter person 2:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Hur gammal är person 2:");
            int age2 = Convert.ToInt32(Console.ReadLine());
             

            Console.WriteLine("Vad heter person 3:");
            string name3 = Console.ReadLine();
            Console.WriteLine("Hur gammal är person 3:");
            int age3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Vad heter person 4:");
            string name4 = Console.ReadLine();
            Console.WriteLine("Hur gammal är person 4:");
            int age4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name1 + " är " + age1 + " år gammal. ");
            Console.WriteLine(name2 + " är " + age2 + " år gammal. ");
            Console.WriteLine(name3 + " är " + age3 + " år gammal. ");
            Console.WriteLine(name4 + " är " + age4 + " år gammal. ");


            double totalage = age1 + age2 + age3 + age4;
            double middleage = totalage  /4;
            Console.WriteLine("Sammanlagda ålder är " + totalage);
            Console.WriteLine("Medelvärdet är: " + middleage.ToString("0.00"));
            
        }
    }
}