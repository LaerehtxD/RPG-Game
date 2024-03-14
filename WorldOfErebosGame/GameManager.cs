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
         
            Console.WriteLine("Welcome to The World of Erebos!");
            Console.WriteLine("Create you Character:");
            Console.Write("Character name:");
            string characName = Console.ReadLine();
            Mc mC = new Mc(characName,100,4,50);
            Console.WriteLine("Welcome to the game {0},",mC.name);
            Console.WriteLine("Game Story here");
    
            
        }
    }

    public int SkillDecision() 
    {
        while (true)
        {
            Console.WriteLine("What skill will you use:");
            Console.WriteLine("1. Basic attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. SwordDash");
            Console.WriteLine("4. Sword Dance");
            Console.WriteLine("5. Ultimate");

            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput > 5 || userInput<1)
            {
                Console.WriteLine("Invalid Iput");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            return userInput;
        }
    
    }
    
}