using System.ComponentModel;
using System.Runtime.CompilerServices;

class Character
{
    
    public string name;
    public float health;
    public int maxHealth = 100;
    public float attackPower;
    public float mana;
    
    public int level = 1;


    public Character(string Name, float AttackPower, float Health, float Mana)
    {
        name = Name;
        attackPower = AttackPower;
        health = Health;
        mana = Mana;
    }
    public void ShowCurrentStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Attack Power: " + attackPower);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Mana: " + mana);
    }

}
class Mc:Character
{
    Random rand = new Random();
    public Mc(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}
    public float healValue = 1.2f;
    public float overHeal = 150f;

    public int exp;
    public void GainExp(int xp)
    {
        exp += xp;
        CheckLevelUp();
    }
    public void CheckLevelUp()
    {
        if (exp >= 100)
        {
            level++;
            LevelUp();
        }
    }

    public void LevelUp()
    {
        maxHealth += 50;
        health = maxHealth;
        attackPower += 2;
        mana += 20;
        overHeal += 150;

    }
    public void BasicAttack(Enemy enemy)
    {
        enemy.health-=attackPower;
    }

    public void SelfHeal()
    {
        health *= healValue;
        if (health > overHeal)
        {
            health = overHeal;
        }
        mana += 5;
    }
    public void SwordDash(Enemy enemy)
    {
        enemy.health -= attackPower+ rand.Next(10,15);
        mana -= 10;
  
    }
    public void SwordDance(Enemy enemy)
    {
        enemy.health -= attackPower+ rand.Next(20,45);
        mana -= 20;
        
    }
    public void Ultimate(Enemy enemy)
    {
        health -= 10;
        enemy.health -= attackPower* rand.Next(10,15);
        
    }
    public void Fight(int skill , Enemy enemy)
    {
        if (skill == 1)
        {
            BasicAttack(enemy);
            Console.WriteLine("You hit the enemy!");
        }


        if (skill == 2 && mana > 0)
        {
            Console.WriteLine("You recovered your health, health added: " , healValue * health);
            SelfHeal();
        }else if(mana <= 0){
            Console.WriteLine("Not enough mana! You missed your turn.");
        }

        if (skill == 3 && mana > 0)
        {
            SwordDash(enemy);
            Console.WriteLine("You Sword Dashed to the enemy!");
        }else if(mana <= 0){
            Console.WriteLine("Not enough mana! You missed your turn.");
        }

        if (skill == 4 && mana > 0)
        {
            SwordDance(enemy);
            Console.WriteLine("You used Sword Dance against the enemy!");
        }else if(mana <= 0){
            Console.WriteLine("Not enough mana! You missed your turn.");
        }

        if (skill == 5 && mana > 0)
        {
            Ultimate(enemy);
            Console.WriteLine("You used your ultimate!");
        }else if(mana <= 0){
            Console.WriteLine("Not enough mana! You missed your turn.");
        }

    }
}

class Enemy:Character
{
    public Enemy(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}
    public int RandomEnemyAttack(){
        Random rand = new Random();
        int randomAttack = rand.Next(1,4);
        return randomAttack;
    }
    
    public void Charge(Mc mc)
    {
        mc.health -= attackPower*2;
    }
    public void Heal()
    {
        Random rand = new Random();
        health += rand.Next(10,30);
    }

}
class Enemy1:Enemy{
    public Enemy1(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}
    Random rand = new Random();
    public void Bonk(Mc mc)
    {
        mc.health -= attackPower * 3;
    }
    public void Scream(Mc mc)
    {
        mc.health -= rand.Next(10,20);
    }


    public void enemyFight(int randomSkill, Mc mC)
    {

        if (randomSkill == 1)
        {
            Charge(mC);
            Console.WriteLine("Enemy blah blah blah");

        }
        if (randomSkill == 2)
        {
            Heal();
            Console.WriteLine("Enemy healed!");

        }

        if (randomSkill == 3)
        {
            Bonk(mC);
            Console.WriteLine("The enemy bonked you!");

        }
        if (randomSkill == 4)
        {
            Scream(mC);
            Console.WriteLine("The enemy screamed at you!");

        }
    }


}
class Enemy2:Enemy{
    public Enemy2(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}


}
class Enemy3:Enemy{
    public Enemy3(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}


}
class Enemy4:Enemy{
    public Enemy4(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}


}
class Enemy5:Enemy{
    public Enemy5(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}


}


