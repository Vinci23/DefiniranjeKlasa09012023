using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniranjeKlase
{

    class FoodType
    {
        private string name;
        private int protein;
        private int carbs;
        private int fat;
        private static int counter;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter = counter++;

        }

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }


        public override string ToString()
        {
            string ispis = Name + ": p - " + protein + "%, " + "c - " + carbs + "%, " + "f - " + fat + "%.";
            return ispis;
            
        }

       
        public static int getNumberOfCreatedInstances()
        {
            return counter;
        }



    }

    class Food
    {
        FoodType type;
        double weight;

        public Food(FoodType type, double weight)
        {
            this.type = type;
            this.weight = weight;
            
        }

        public double Weight { get => weight; set => weight = value; }

        internal FoodType Type { get => type; set => type = value; }

        public string toStringInGrams()
        {
            double ProteinGram = (weight * type.Protein)/100;
            double CarbsGram = (weight * type.Carbs)/100;
            double FatGram = (weight * type.Fat)/100;

            string ispis2 = type.Name + ": protein: " + ProteinGram + " \ncarbs:" + CarbsGram + "\nfat:" + FatGram;
            return ispis2;
        }
    }   
        
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine(food.toStringInGrams());
            Console.ReadKey();
        }
    }
}
