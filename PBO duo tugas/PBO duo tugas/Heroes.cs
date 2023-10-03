using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    using Dota_Heroes;
    using System.Runtime.ConstrainedExecution;

    class Phantom_Assasin : Heroes, Skillusage
    {
        public Phantom_Assasin(string name, int health, string move, int level,int exp)
        {
            this.name = name;
            this.health = health;
            this.level = level;
            this.move = move;
            this.exp = exp;
        }
        public override void attack()
        {
            Console.WriteLine($"Phantom Assasin curent health : {health}");
            Console.WriteLine($"{name} Attacking {move}");
        }
        public void attack(string name, string move)
        {
            Console.WriteLine($"{name} Attacking the enemy hero {move}");
        }
        public void skill()
        {
            string skill;
            Console.WriteLine($"Choose between number 1/2/3 to use Phantom Assassin skill : ");
            Console.WriteLine();
            skill = Console.ReadLine();
            if (skill == "1")
            {
                if (level >= 6)
                {
                    Console.WriteLine("Using Stifling Dagger");
                    var random = new Random();
                    var list = new List<byte> { 1, 2, 3, 4 };
                    byte index = (byte)random.Next(list.Count);
                    int crits = index;

                    if (crits == 4)
                    {
                        Console.WriteLine("Your skill Trigger passive 'Coup de Grace'");
                        Console.WriteLine("CRITICAL !");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else 
                {
                    Console.WriteLine("Using Stifling Dagger");
                }
                
            }
            if (skill == "2")
            {
                if (level >= 6)
                {
                    Console.WriteLine("Using Phantom Strike !");
                    var random = new Random();
                    var list = new List<byte> { 1, 2, 3, 4 };
                    byte index = (byte)random.Next(list.Count);
                    int crits = index;

                    if (crits == 4)
                    {
                        Console.WriteLine("Your skill Trigger passive 'Coup de Grace'");
                        Console.WriteLine("CRITICAL !");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            if (skill == "3")
            {
                Console.WriteLine("Using Blur");
            }
        }
        public void Levelup()
        {
            string actions1;
            Console.WriteLine("Choose lane to farm 1/2/3");
            Console.WriteLine("1. Mid lane");
            Console.WriteLine("2. Bottom Lane");
            Console.WriteLine("3. Top Lane");
            actions1 = Console.ReadLine();
            var random = new Random();
            var list = new List<int> { 4, 8, 16, 32 };
            int index = (int)random.Next(list.Count);
            int creeps = list[index];
            int expx = creeps * 34;
            int totalexp = expx + exp;
            if (actions1 == "1")
            {
                
                Console.WriteLine("Phantom Assassin going into the Mid Lane");
                Console.WriteLine($"Phantom Assassin gaining total {expx} exp from farming {creeps} creeps");

            }
            if (actions1 == "2")
            {
             
                Console.WriteLine("Phantom Assassin going into the Bottom Lane");
                Console.WriteLine($"Phantom Assassin gaining total {expx} exp from farming {creeps} creeps");

            }
            if (actions1 == "3")
            {
           
                Console.WriteLine("Phantom Assassin going into the Top Lane");
                Console.WriteLine($"Phantom Assassin gaining total {expx} exp from farming {creeps} creeps");

            }
            if (totalexp == 1254 || totalexp > 1254)
            {
                level++;
                health += 100;
                Console.WriteLine($"{name} Level Up !");
                Console.WriteLine($"Now Phantom Assasin level {level} !");
                Console.WriteLine($"Current health : {health}");
                if (level == 6)
                {
                    Console.WriteLine("Passive skill unlocked 'Coup de Grace'");
                }
            }
            else 
            {
                Console.WriteLine($"Phantom Assasin curent exp {totalexp} / 1254");
            }
            
           
            
        }
    }
    class Actions : Heroes
    {
        public override void attack()
        {
            Console.WriteLine("Phantom assassin continue to farm on the lane");
        }
        public void attack(string move)
        {
            Console.WriteLine($"Phantom Assasin striking to the enemy {move}");
        }
        public virtual void use(string name)
        {
            Console.WriteLine($"Using {name}");
        }
        public virtual void actions()
        {
            Console.WriteLine("Choose your actions ");
            Console.WriteLine("1. Farm");
            Console.WriteLine("2. Enggaging the enemy");
            string act = Console.ReadLine();
            if (act == "1 ")
            {
                attack();
            }
            if (act == "2")
            {
                Console.WriteLine("Write down your target :");
                string act2 = Console.ReadLine();
                attack(act2);
            }
        }

    }
}