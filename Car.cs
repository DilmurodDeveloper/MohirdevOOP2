namespace MohirdevOOP2
{
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
}