namespace Apstract_Virtual_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("BMW", "M5", new DateTime(2021, 11, 7), DateTime.Now);
            Truck MyTruck = new Truck ("MAN", "B37", new DateTime(2017, 2, 2), DateTime.Now);

            Console.WriteLine(MyCar.DisplayInfo());
            Console.WriteLine(MyCar.InstectionStatus());

            Console.WriteLine(MyTruck.DisplayInfo());
            Console.WriteLine(MyTruck.InstectionStatus());
        }
    }
}
