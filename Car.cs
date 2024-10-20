public class Car
{
    private string model;
    private int year;   
    private decimal price;
    private decimal speed;

    public Car(string model, int year, decimal price, decimal speed)
    {
        this.model = model;
        this.year = year;
        this.price = price;
        this.speed = speed;
    }

    public string Model
    {
        get { return Model; }
        set { Model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public decimal Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public string GetCarInfo()
    {
        return $"\nModeli: {model} \nYili: {year}-yil \nNarxi: {price} $ \nTezligi: {speed} km/soat";
    }

    public decimal CalculateDepreciation(int years)
    {
        decimal yillikKamayish = 0.10m;
        decimal joriyQiymat = price;

        for (int i = 0; i < years; i++)
        {
            joriyQiymat -= joriyQiymat * yillikKamayish;
        }

        return joriyQiymat;
    }
}

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