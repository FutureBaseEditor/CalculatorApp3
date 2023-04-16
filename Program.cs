namespace CalculatorApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("İlk sayıyı giriniz");
            double sayi1=double.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
            string islem = Console.ReadLine();
        }
    }
}