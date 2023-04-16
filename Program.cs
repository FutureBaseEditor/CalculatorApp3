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
            string islem = Console.ReadLine().ToLower();

            if (islem == "topla" || islem == "+")
            {
                Console.WriteLine(sayi1 + sayi2);
            }
            else if (islem == "çıkar" || islem == "-")
            {
                Console.WriteLine(sayi1 - sayi2);
            }
            else if (islem == "çarp" || islem == "*")
            {
                Console.WriteLine(sayi1 * sayi2);
            }
            else if (islem == "bol" || islem == "/")
            {
                Console.WriteLine(sayi1 / sayi2);
            }
            else if (islem == "mod" || islem == "%")
            {
                Console.WriteLine(sayi1 % sayi2);
            }
            else Console.WriteLine("Hatalı İşlem");
        }
    }
}