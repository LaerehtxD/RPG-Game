using System.Security.Cryptography.X509Certificates;

class GameManager
{

    World location = new World();
    Storyline story = new Storyline();
   public void StartGame()
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

        Console.WriteLine("Welcome to the game {0},", mC.name);
        story.GameIntroduction();

       
            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");

            Console.WriteLine("Fight Goblin");
            TurnBasedBattle.EnemyFight(mC, gobby);
            mC.GainExp(60);

            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");
            story.scene1();

            Console.WriteLine("Fight bandit");
            TurnBasedBattle.Enemy2Fight(mC, ibrahim);
            mC.GainExp(70);

            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");
            story.scene2();

            Console.WriteLine("Fight orc");
            TurnBasedBattle.Enemy3Fight(mC, gibby);
            mC.GainExp(80);

            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");
            story.scene3();

            Console.WriteLine("Fight golem");
            TurnBasedBattle.Enemy4Fight(mC, omega);
            mC.GainExp(100);

            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");
            story.scene4();

            Console.WriteLine("Fight dragon");
            TurnBasedBattle.Enemy5Fight(mC, crimson);

            story.scene5();
            
            string userInput = Console.ReadLine().ToLower();
            
            while (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                userInput = Console.ReadLine().ToLower();
            }

            if (userInput == "yes")
            {
                GameManager gameManager = new GameManager();
                gameManager.StartGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }


}


    public int SkillDecision()
{
    int userInput;
    while (true)
    {
        Console.WriteLine("What skill will you use:");
        Console.WriteLine("1. Basic attack ");
        Console.WriteLine("2. Heal ");
        Console.WriteLine("3. SwordDash | mana cost : 10");
        Console.WriteLine("4. Sword Dance | mana cost : 20 ");
        Console.WriteLine("5. Ultimate ");

        Console.Write("Which skill do you want to use? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out userInput))
        {
            if (userInput >= 1 && userInput <= 5)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a number between 1 and 5.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input. Please enter a valid input.");
        }
    }
}
    
}