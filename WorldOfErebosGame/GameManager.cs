using System.Security.Cryptography.X509Certificates;

class GameManager
{

    World location = new World();
    public void StartGame()
    {
        // Initialize game components
        // Set up game world, characters, etc.
        string currLocation = location.setting();
       
        while (true) 
        {
            Enemy1 gobby = new Enemy1("Gobby", 2, 50, 0);
         
            Console.WriteLine("Welcome to The World of Erebos!");
            Console.WriteLine("Create you Character:");
            Console.Write("Character name:");
            string characName = Console.ReadLine();
            Mc mC = new Mc(characName, 4, 100, 50);
            Console.WriteLine("Welcome to the game {0},",mC.name);
            Console.WriteLine("Game Story here");

            TurnBasedBattle.EnemyFight(mC, gobby);
    
            
        }
    }

    public int SkillDecision() 
    {
        while (true)
        {
            Console.WriteLine("What skill will you use:");
            Console.WriteLine("1. Basic attack ");
            Console.WriteLine("2. Heal ");
            Console.WriteLine("3. SwordDash | mana cost : 10");
            Console.WriteLine("4. Sword Dance | mana cost : 20 ");
            Console.WriteLine("5. Ultimate ");

            Console.Write("Which skil do you want to use? ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput > 5 || userInput<1)
            {
                Console.WriteLine("Invalid Input");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            return userInput;
        }
    
    }
    
}