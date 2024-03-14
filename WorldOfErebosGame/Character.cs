using System.Runtime.CompilerServices;

class Character
{
    
    public string name;
    public float health;
    public float attackPower;
    public float Mana;

    public Character(string Name, float AttackPower, float Health, float Mana)
    {
        name = Name;
        attackPower = AttackPower;
        health = Health;
    }
    public void ShowCurrentStats()
    {
        Console.WriteLine("Your current stats:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Attack Power" + attackPower);
        Console.WriteLine("Health: " + health);
    }

}
class Mc:Character
{
    Random rand = new Random();
    public Mc(string Name, float AttackPower, float Health, float Mana): base(Name ,AttackPower, Health, Mana){}
    public float healValue = 1.2f;
    public float overHeal = 50f;

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
        Mana *= healValue;
    }
    public void SwordDash(Enemy enemy)
    {
        enemy.health -= attackPower+ rand.Next(10,15);
        Mana -= 10;
  
    }
    public void SwordDance(Enemy enemy)
    {
        enemy.health -= attackPower+ rand.Next(20,45);
        Mana -= 20;
        
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

        if (skill == 2)
        {
            Console.WriteLine("You recovered your health, health added: " , healValue * health);
            SelfHeal();
        }

        if (skill == 3)
        {
            SwordDash(enemy);
            Console.WriteLine("You Sword Dashed to the enemy!");
        }

        if (skill == 4)
        {
            SwordDance(enemy);
            Console.WriteLine("You used Sword Dance against the enemy!");
        }

        if (skill == 5)
        {
            Ultimate(enemy);
            Console.WriteLine("You used your ultimate!");
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


