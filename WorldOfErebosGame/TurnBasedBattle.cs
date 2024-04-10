class TurnBasedBattle
{

    public static void GameOver(Mc mC) 
    {
    if (mC.health <= 0)
    {
        Console.WriteLine("GG! Your character has been defeated.");
        Console.WriteLine("Do you want to play again? (yes/no)");
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

    }
        public static void ShowStats(Character char1, Character char2)
    {
        Console.WriteLine("Your current stats: ");
        char1.ShowCurrentStats();
        Console.WriteLine();
        Console.WriteLine("Enemy stats: ");
        char2.ShowCurrentStats();
        Console.WriteLine();
    }

    public static void EnemyFight(Mc mC , Enemy1 enemy)
    {
        GameManager game = new GameManager();


        while (enemy.health > 0 || mC.health > 0)
        {   
            ShowStats(mC, enemy);
            mC.Fight(game.SkillDecision(), enemy);
            
            if (enemy.health > 0)
                {
                    enemy.enemyFight1(enemy.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("You killed the enemy" );

    }


        public static void Enemy1Fight(Mc mC , Enemy1 enemy1)
    {
        GameManager game = new GameManager();

        while (enemy1.health > 0 || mC.health > 0)
        {   
            ShowStats(mC, enemy1);
            mC.Fight(game.SkillDecision(), enemy1);
            
            if (enemy1.health > 0)
                {
                    enemy1.enemyFight1(enemy1.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("You killed the enemy" );

        
    }

        public static void Enemy2Fight(Mc mC , Enemy2 enemy2)
    {
                GameManager game = new GameManager();


        while (enemy2.health > 0 || mC.health > 0)
        {   
            ShowStats(mC, enemy2);
            mC.Fight(game.SkillDecision(), enemy2);
            
            if (enemy2.health > 0)
                {
                    enemy2.enemyFight2(enemy2.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("You killed the enemy" );
    }

        public static void Enemy3Fight(Mc mC , Enemy3 enemy3)
    {
                GameManager game = new GameManager();


        while (enemy3.health > 0 || mC.health > 0)
        {   
            ShowStats(mC, enemy3);
            mC.Fight(game.SkillDecision(), enemy3);
            
            if (enemy3.health > 0)
                {
                    enemy3.enemyFight3(enemy3.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("You killed the enemy" );
    }

        public static void Enemy4Fight(Mc mC , Enemy4 enemy4)
    {
                GameManager game = new GameManager();


        while (enemy4.health > 0 || mC.health > 0)
        {   
            ShowStats(mC, enemy4);
            mC.Fight(game.SkillDecision(), enemy4);
            
            if (enemy4.health > 0)
                {
                    enemy4.enemyFight4(enemy4.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("You killed the enemy" );
    }
        public static void Enemy5Fight(Mc mC , Enemy5 enemy5)
    {
                GameManager game = new GameManager();


        while (enemy5.health > 0 || mC.health > 0)
        {   
            ShowStats(mC, enemy5);
            mC.Fight(game.SkillDecision(), enemy5);
            
            if (enemy5.health > 0)
                {
                    enemy5.enemyFight5(enemy5.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("You killed the enemy" );

        
    }

}