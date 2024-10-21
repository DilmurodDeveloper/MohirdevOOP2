using MohirdevOOP2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mashina modelini kiriting:");
        string model = Console.ReadLine();

        Console.WriteLine("Mashina yilini kiriting:");
        int year = int.Parse(Console.ReadLine());  

        Console.WriteLine("Mashina narxini kiriting ($):");
        decimal price = decimal.Parse(Console.ReadLine()); 

        Console.WriteLine("Mashina tezligini kiriting (km/soat):");
        decimal speed = decimal.Parse(Console.ReadLine());

        Car myCar = new Car(model, year, price, speed);

        Console.WriteLine("\nKiritilgan mashina haqida ma'lumotlar:");
        Console.WriteLine(myCar.GetCarInfo());

        Console.WriteLine("\nMashinaning qiymatini hisoblash uchun yillar sonini kiriting:");
        int years = int.Parse(Console.ReadLine());  

        decimal newPrice = myCar.CalculateDepreciation(years);
        Console.WriteLine($"{years} yildan keyin mashinaning narxi quyidagicha bo'ladi: ${newPrice}");
    }
}