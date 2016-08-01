using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            ///("|\_/|");
            ///("/ @ @ \");
            //("( > o < )");
            //(" `>>X<<'  /"); 
            //   (     ) /       
            //    |   |


            VirtualPet Animal = new VirtualPet();
            string play;
            do
            {
                Animal.Tick();
                Animal.PrintStats();

                Console.WriteLine("What do you want to do? Eat, exercise or shop");
                string answer = Console.ReadLine();
                if (answer == "Hunger")
                {
                    Animal.Eat();
                }
                else
                {
                    Animal.Play();
                }

                else
                {
                    Animal.Spend();
                }

                Animal.PrintStats();

                Console.WriteLine("Do you want to go again?");
                play = Console.ReadLine();

            } while (play == "yes");
            }
    }
    }
