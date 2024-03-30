class TurnBasedBattle
{
    
    public static void GameOver(Mc mC) 
    {
        if (mC.health <= 0)
        {
            Console.WriteLine("GG go next...");
            Console.ReadLine();
            Environment.Exit(0);
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
                    enemy.enemyFight(enemy.RandomEnemyAttack() , mC);
                    GameOver(mC);
                }
            else
                {
                    break;
                }
        }
        Console.WriteLine("ya killed the enemy" );

    }


        public static void Enemy1Fight(Mc mC , Enemy enemy1)
    {
        
    }

        public static void Enemy2Fight(Mc mC , Enemy enemy2)
    {
        
    }

        public static void Enemy3Fight(Mc mC , Enemy enemy3)
    {
        
    }

        public static void Enemy4Fight(Mc mC , Enemy enemy4)
    {
        
    }
        public static void Enemy5Fight(Mc mC , Enemy enemy5)
    {
        
    }

}