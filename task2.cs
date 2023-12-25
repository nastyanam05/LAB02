using System;

namespace task2
{
    // Базовый класс Vehicle
    class Vehicle
    {
        private double[] coordinates = new double[2];
        private int price, speed, year;

        public Vehicle(double[] coordinates, int price, int speed, int year)
        {
            this.coordinates = coordinates;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public void Info()
        {
            Console.WriteLine($"Coordinates: ({coordinates[0]}, {coordinates[1]})");
            Console.WriteLine($"Price: {price}$");
            Console.WriteLine($"Speed: {speed} km/h");
            Console.WriteLine($"Year of manufacture: {year}");
        }
    }

    // Производный класс Plane
    class Plane : Vehicle
    {
        private double altitude;
        private int passengers;

        public Plane(double[] coordinates, int price, int speed, int year, double altitude, int passengers)
            : base(coordinates, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Altitude: {altitude} m");
            Console.WriteLine($"Number of passengers: {passengers}");
        }
    }

    // Производный класс Car
    class Car : Vehicle
    {
        public Car(double[] coordinates, int price, int speed, int year)
            : base(coordinates, price, speed, year)
        {
        }
    }

    // Производный класс Ship
    class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship(double[] coordinates, int price, int speed, int year, int passengers, string port)
            : base(coordinates, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Number of passengers: {passengers}");
            Console.WriteLine($"Port pripiski: {port}");
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            // Создание экземпляров различных транспортных средств
            Plane plane = new Plane(new double[] { 1000, 2000 }, 1000000, 900, 2020, 10000, 200);
            Car car = new Car(new double[] { 500, 1000 }, 30000, 180, 2022);
            Ship ship = new Ship(new double[] { 3000, 4000 }, 2000000, 50, 2018, 1500, "Port");

            Console.WriteLine("Information about the plane:");
            plane.Info();

            Console.WriteLine("\nInformation about the car:");
            car.Info();

            Console.WriteLine("\nInformation about the ship:");
            ship.Info();
        }
    }
}
