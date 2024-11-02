    public class Soldier
    {
        public string soldiersname;
        public int soldiersrank;
        public int soldiershealth;
        public int x;
        public int y;
        public bool attack=false;
        public Soldier(string soldiersname, int soldiersrank, int soldiershealth, int x, int y, bool attack)

        {
            this.soldiersname = soldiersname;
            this.soldiersrank = soldiersrank;
            this.soldiershealth = soldiershealth;
            this.x = x;
            this.y = y;
            this.attack = attack;
        }
        public (int, int) getlocation(int x, int y)
        {
            Console.WriteLine($"The present location of the soldier is: {x}, {y}");
            if (x == 0 && y == 0)
            {
                Console.WriteLine($"The current location of soldier is at the center. The location is: {x}, {y}");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine($"The current location of soldier is in the 1st quadrant. The location is: {x}, {y}");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The current location of soldier is in the 2nd quadrant. The location is: {x}, {y}");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The current location of soldier is in the 3rd quadrant. The location is: {x}, {y}");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The current location of soldier is in the 4th quadrant. The location is: {x}, {y}");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine($"The current location of soldier is on the positive side of the x-axis. The location is: {x}, {y}");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine($"The current location of soldier is on the negative side of the x-axis. The location is: {x}, {y}");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine($"The current location of soldier is on the positive side of the y-axis. The location is: {x}, {y}");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine($"The current location of soldier is on the negative side of the y-axis. The location is: {x}, {y}");
            }
            return (x, y);
        }
        public string getsoldiersname()
        {
            return soldiersname;
        }
        public int GetSoldierRank(int soldiersrank)
        {
            if (soldiersrank == 1)
            {
                Console.WriteLine($"The soldier's rank is Lieutanent:{soldiersrank}");
            }
            else if (soldiersrank == 2)
            {
                Console.WriteLine($"The  soldier's rank is Captain:{soldiersrank}");
            }
            else if (soldiersrank == 3)
            {
                Console.WriteLine($"The  soldier's rank is Major:{soldiersrank}");
            }
            else if (soldiersrank == 4)
            {
                Console.WriteLine($"The  soldier's rank is Lieutanent cornel:{soldiersrank}");
            }
            else if (soldiersrank == 5)
            {
                Console.WriteLine($"The soldier's rank is Colonel:{soldiersrank}");
            }
            else if (soldiersrank == 6)
            {
                Console.WriteLine($"The soldier's rank is Brigredir:{soldiersrank}" );
            }
            else if (soldiersrank == 7)
            {
                Console.WriteLine($"The soldier's rank is Major General:{soldiersrank}");
            }
            else if (soldiersrank == 8)
            {
                Console.WriteLine($"The soldier's rank is Brigrediar General:{soldiersrank}");
            }
            else if (soldiersrank == 9)
            {
                Console.WriteLine($"The soldier's rank is General:{soldiersrank}");
            }
            else
            {
                Console.WriteLine("Invalid rank!");
            }
            return soldiersrank;
        }
        public int getsoldiershealth(int soldiershealth)
        {
            if (soldiershealth > 50 && soldiershealth < 70)
            {
                Console.WriteLine($"Good.The soldier's health is:{soldiershealth}");
            }
            if (soldiershealth > 70 && soldiershealth < 90)
            {
                Console.WriteLine($"Better.The soldier's health is:{soldiershealth}");
            }
            if (soldiershealth > 90)
            {
                Console.WriteLine($"Best.The soldier's health is:{soldiershealth}");
            }
            else
            {
                Console.WriteLine("Soldier is expired!");
            }
            return soldiershealth; 
        }
        public void getdamage(int soldiershealth,bool attack)
        {
            if (attack)
            {
                Console.WriteLine($"Not loss health.The present health of a soldier is:{soldiershealth}");
            }
            else
            {


                while (soldiershealth > 0)
                {


                    if (!attack)
                    {
                        soldiershealth--;
                        Console.WriteLine($"The present health is:{soldiershealth}");
                    }
                    if(soldiershealth ==0)
                    {
                        Console.WriteLine("Soldier is dead");
                    }
                }
            }
        }

    }
}

