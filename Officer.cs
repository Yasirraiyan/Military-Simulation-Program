    public class Officer
    {
        public string officersname;
        public int officersrank;
        public int officershealth;
        public int x;
        public int y;
        public bool officersattack = false;
        public string order;
        public Officer(string officersname, int officersrank, int officershealth, int x, int y, bool officersattack, string order)

        {
            this.officersname = officersname;
            this.officersrank = officersrank;
            this.officershealth = officershealth;
            this.x = x;
            this.y = y;
            this.officersattack = officersattack;
            this.order = order;
        }
        public (int, int) getofficerslocation(int x, int y)
        {
            Console.WriteLine($"The present location of the officer is: {x}, {y}");
            if (x == 0 && y == 0)
            {
                Console.WriteLine($"The current location of the officer is at the center. The location is: {x}, {y}");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine($"The current location of the officer  is in the 1st quadrant. The location is: {x}, {y}");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The current location of the officer is in the 2nd quadrant. The location is: {x}, {y}");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The current location of the officer is in the 3rd quadrant. The location is: {x}, {y}");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The current location of the officer is in the 4th quadrant. The location is: {x}, {y}");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine($"The current location of the officer is on the positive side of the x-axis. The location is: {x}, {y}");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine($"The current location of the officer is on the negative side of the x-axis. The location is: {x}, {y}");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine($"The current location of the officer is on the positive side of the y-axis. The location is: {x}, {y}");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine($"The current location of the officer is on the negative side of the y-axis. The location is: {x}, {y}");
            }
            return (x, y);
        }
        public string getofficersrsname()
        {
            return  officersname;
        }
        public int GetOfficcerRank(int officersrank)
        {
            if (officersrank == 1)
            {
                Console.WriteLine($"The officers's rank is Lieutanent.And it is rank:{officersrank}");
            }
            else if ( officersrank == 2)
            {
                Console.WriteLine($"The officer's Rank is Captain. And it is rank:{officersrank}");
            }
            else if (officersrank == 3)
            {
                Console.WriteLine($"The officer's Rank is Major.And it is rank: {officersrank}");
            }
            else if (officersrank == 4)
            {
                Console.WriteLine($"The officer's Rank is  Lieutenant Colonel.And it is rank:{officersrank}");
            }
            else if (officersrank == 5)
            {
                Console.WriteLine($"The officer's Rank is Colonel.And it is:{officersrank}");
            }
            else if (officersrank == 6)
            {
                Console.WriteLine($"The officer's Rank is Brigadier.And it is:{officersrank}");
            }
            else if (officersrank == 7)
            {
                Console.WriteLine($"The officer's Rank is Major General.And it is:{officersrank}");
            }
            else if (officersrank == 8)
            {
                Console.WriteLine($"THe officer's Rank is  Lieutenant General.And it is:{officersrank}");
            }
            else if (officersrank == 9)
            {
                Console.WriteLine($"The officer's Rank is General.And it is:{officersrank}");
                    
            }
            else
            {
                Console.WriteLine("Invalid officer's rank!");
            }
            return officersrank;
        }
        public int getofficershealth(int health)
        {
            if(health>50&&health<70)
            {
                Console.WriteLine($"Good.The officer's health is:{health}");
            }
            if (health > 70&&health<90)
            {
                Console.WriteLine($"Better.The officer's health is:{health}");
            }
            if (health > 90)
            {
                Console.WriteLine($"Best.The officer's health is:{health}");
            }
            else
            {
                Console.WriteLine("Officer is expired!");
            }
            return health;
        }
        public void getdamage(int health, bool attack)
        {
            if (attack)
            {
                Console.WriteLine($"Not loss health.The present health is:{health}");
            }
            else
            {


                while (health > 0)
                {


                    if (!attack)
                    {
                        health--;
                        Console.WriteLine($"The present health is:{health}");
                    }
                    if (health == 0)
                    {
                        Console.WriteLine("Officer is dead");
                    }
                }
            }
        }
        public string givingorder(string order)
        {
            Console.WriteLine($"The officer's order is:{order}");
            return order;
        }
    }
}
