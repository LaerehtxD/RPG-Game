using System.Security.Cryptography.X509Certificates;

class GameManager
{

    World location = new World();
    Storyline story = new Storyline();
    public void StartGame()
    {
        // Initialize game components
        // Set up game world, characters, etc.
        string currLocation = location.setting();
       
        while (true) 
        {
            Enemy1 gobby = new Enemy1("Gobby", 2, 50, 0);
            Enemy2 ibrahim = new Enemy2("Ibrahim", 4, 100, 0);
            Enemy3 gibby = new Enemy3("Gibby", 5, 150, 0);
            Enemy4 omega = new Enemy4("Omega", 4, 500, 0);
            Enemy5 crimson = new Enemy5("Crimson", 9, 1000, 0);
         
            Console.WriteLine("Welcome to The World of Erebos!");
            Console.WriteLine("Create you Character:");
            Console.Write("Character name:");

            string characName = Console.ReadLine();

            Mc mC = new Mc(characName, 6, 100, 150);

            Console.WriteLine("Welcome to the game {0},",mC.name);
            story.GameIntroduction();

            Console .WriteLine("");
            Console .WriteLine("**************************************");
            Console .WriteLine("");

            Console.WriteLine("Fight Goblin");
            TurnBasedBattle.EnemyFight(mC, gobby);

            Console .WriteLine("");
            Console .WriteLine("**************************************");
            Console .WriteLine("");

            Console.WriteLine("Fight bandit");
            TurnBasedBattle.Enemy2Fight(mC, ibrahim);

            Console .WriteLine("");
            Console .WriteLine("**************************************");
            Console .WriteLine("");

            Console.WriteLine("Fight orc");
            TurnBasedBattle.Enemy3Fight(mC, gibby);

            Console .WriteLine("");
            Console .WriteLine("**************************************");
            Console .WriteLine("");

            Console.WriteLine("Fight golem");
            TurnBasedBattle.Enemy4Fight(mC, omega);

            Console .WriteLine("");
            Console .WriteLine("**************************************");
            Console .WriteLine("");
            
            Console.WriteLine("Fight dragon");
            TurnBasedBattle.Enemy5Fight(mC, crimson);


            //first enemy goblin
            //second enemy bandit
            //third enemy orc
            //fourth enemy golem
            //fifth enemy dragon
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