using System;

namespace RefresherDayOff
{
    internal class Program
    {
        //Player Health
        static int playerHealth;
        static int currPlayerHealth;
        //Lives
        static int lives; //The amount the lives increase
        static int currLives;
        //Enemy Health
        static int enemyHealth;
        static int currEnemyHealth;
        //Global Health Status
        static string HealthStatus;
        static void Main()
        {
            //Player Health
            playerHealth = 100;
            currPlayerHealth = playerHealth;
            //Lives
            lives = 3;
            currLives = lives;
            //Enemy Health
            enemyHealth = 100;
            currEnemyHealth = enemyHealth;
            HealthStatus = "Healthy";

            Console.ForegroundColor = ConsoleColor.Gray;

            PlayerStats();
            EnemyStats();
            EnemyTakeDamage(25);
            PlayerTakeDamage(10);
            EnemyTakeDamage(25);
            PlayerTakeDamage(10);
        }

        static void PlayerStats()
        {
            //Check status of player first
            CheckPlayerHealthStatus();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n---- Player Stats ----");
            Console.WriteLine("Health : " + currPlayerHealth);
            Console.WriteLine("Lives : " + currLives);
            Console.WriteLine("Health Status : " + HealthStatus);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void EnemyStats()
        {
            //Check status of enemy first
            CheckEnemyHealthStatus();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n---- Enemy Stats ----");
            Console.WriteLine("Health : " + currEnemyHealth);
            Console.WriteLine("Health Status : " + HealthStatus);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void PlayerTakeDamage(int dmg)
        {
            currPlayerHealth = currPlayerHealth - dmg;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nPlayer");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" took " + dmg + " damage.");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Display Stats
            PlayerStats();
        }

        static void EnemyTakeDamage(int dmg)
        {
            currEnemyHealth = currEnemyHealth - dmg;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEnemy");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" took " + dmg + " damage.");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Display Stats
            EnemyStats();
        }


        //This has to be different i think
        static void CheckPlayerHealthStatus()
        {
            if (currPlayerHealth > 75)
            {
                HealthStatus = "Healthy";
            }
            else if (currPlayerHealth > 50)
            {
                HealthStatus = "Hurt";
            }
            else if (currPlayerHealth > 25)
            {
                HealthStatus = "Badly Hurt";
            }
            else if (currPlayerHealth > 10)
            {
                HealthStatus = "Imminenet Danger";
            }
            else
            {
                HealthStatus = "Dead.";
            }
        }

        static void CheckEnemyHealthStatus()
        {
            if (currEnemyHealth > 75)
            {
                HealthStatus = "Healthy";
            }
            else if (currEnemyHealth > 50)
            {
                HealthStatus = "Hurt";
            }
            else if (currEnemyHealth > 25)
            {
                HealthStatus = "Badly Hurt";
            }
            else if (currEnemyHealth > 10)
            {
                HealthStatus = "Imminenet Danger";
            }
            else
            {
                HealthStatus = "Dead.";
            }
        }
    }
}
