namespace IntroToC_
{

    class Vehicle : IDrivable
    {
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public string Brand { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Brand} moves at {Speed} MPH");
        }

        public Vehicle(string brand, int wheels, double speed)
        {
            Brand = brand;
            Speed = speed;
            Wheels = wheels;
        }
        public void Stop()
        {
            Console.WriteLine($"{Brand} stops");
            Speed = 0;
        }
    }
}
