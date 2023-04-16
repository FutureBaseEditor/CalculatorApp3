namespace CalculatorApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("ilk sayıyı giriniz");
            double sayi1=double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("yapmak istediğiniz işlemi giriniz");
            string islem = Console.ReadLine();
        }
    }
}