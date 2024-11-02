    public class Vehicle
    {
        public string vehiclesname;
        public int x;
        public int y;
        public int health;
        public int speed;  
        public bool atack=false;
        public Vehicle(string vehiclesname, int x, int y, int health, int speed,bool attack)
        {
            this.vehiclesname = vehiclesname;
            this.x = x;
            this.y = y;
            this.health = health;
            this.speed = speed;
            this.atack = attack;    
        }
        public (int, int) getvehicleslocation(int x, int y)
        {
            Console.WriteLine($"The present location of the vehicle is: {x}, {y}");
            if (x == 0 && y == 0)
            {
                Console.WriteLine($"The current location of the vehicle is at the center. The location is: {x}, {y}");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine($"The current location of the vehicle  is in the 1st quadrant. The location is: {x}, {y}");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The current location of the vehicle is in the 2nd quadrant. The location is: {x}, {y}");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The current location of the vehicle is in the 3rd quadrant. The location is: {x}, {y}");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The current location of the vehicle is in the 4th quadrant. The location is: {x}, {y}");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine($"The current location of the vehicle is on the positive side of the x-axis. The location is: {x}, {y}");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine($"The current location of the vehicle is on the negative side of the x-axis. The location is: {x}, {y}");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine($"The current location of the vehicle is on the positive side of the y-axis. The location is: {x}, {y}");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine($"The current location of the vehicle is on the negative side of the y-axis. The location is: {x}, {y}");
            }
            return (x, y);
        }
        public int getvehileshealth(int health)
        {
            if (health > 50 && health < 70)
            {
                Console.WriteLine($"Good.The vehicle's health is:{health}");
            }
            if (health > 70 && health < 90)
            {
                Console.WriteLine($"Better.The vehicle's health is:{health}");
            }
            if (health > 90)
            {
                Console.WriteLine($"Best.The vehicle's health is:{health}");
            }
            else
            {
                Console.WriteLine("Vehicle is expired!");
            }
            return health;
        }
        public string getvehiclesname()
        {
            return vehiclesname;
        }
        public void getvehiclestype(int speed)
        {
            if(speed>80)
            {
                Console.WriteLine($"The vehicle is first type vehicle:{speed}");
            }
            if (speed > 60)
            {
                Console.WriteLine($"The vehicle is second type vehicle:{speed}");
            }
            if (speed > 40)
            {
                Console.WriteLine($"The vehicle is third type vehicle:{speed}");
            }
            else
            {
                Console.WriteLine("The vehicle is Expired!");
            }
        }
        public void getvehicledamage(int health, bool attack)
        {
            if (attack)
            {
                Console.WriteLine($"Not loss health.The present health of a soldier is:{health}");
            }
            else
            {


                while (health > 0)
                {


                    if (!attack)
                    {
                        health--;
                        Console.WriteLine($"The present health of vehicle is:{health}");
                    }
                    if (health == 0)
                    {
                        Console.WriteLine("Vehicle is expired!");
                    }
                }
            }
        }
    }
}
