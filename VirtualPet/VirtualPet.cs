using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        public class Animal
        {
            //Fields
            private int hungry;
            private int waste;
            private int shop;
            private int exercise;
            private string nothing;

            //Properties

            public int Hunger 
            {
                get { return this.Hunger; }
                set { this.Hunger = value; }
            }

            public int Waste
            {
                get { return this.waste; }
                set { this.waste = value; }
            }

            public int Shop
            {
                get { return this.Shop; }
                set { this.shop = value; }
            }

            public int Exercise
            {
                get { return this.exercise; }
                set { this.exercise = value; }
            }

            public string DoNothing
            {
                get { return this.DoNothing; }
                set { this.DoNothing = value; }
            }

            //Contructors
            public Animal()
            {
                this.Hunger = 90;
                this.waste = 50;
                this.shop = 45;
                this.exercise = 60;
                this.DoNothing = ""; 
            }

            //Methods
            public void Eat()
            {
                Hunger = Hunger + 40;
            }
            public void Play()
            {
                exercise = exercise + 120;
            }
            public void Spend()
            {
                shop = shop - 15;
            }
            public void PrintStats()
            {
                Console.WriteLine("Hunger" + this.Hunger);
                Console.WriteLine("Exercise" + this.exercise);
                Console.WriteLine("Shop" + this.shop);
            }
            public void Tick()
            {
                Hunger = Hunger + 70;
                exercise = exercise + 120;
                shop = shop - 20;

            }
            }
        }
    }






