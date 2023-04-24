using System;

namespace Inheritance
{
    class Program  
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var rumplessChicken = new Birb()
            {
                CanFly = false,
                FeatherColor = "wide variety",
                BeakType = "hard, sharp, and pointed beak",
                BeakLength = 1.2 
            };
            
            var blackHeron = new Birb();
            blackHeron.CanFly = true;
            blackHeron.FeatherColor = "black";
            blackHeron.BeakType = "long, sharp, and pointed beak";
            blackHeron.BeakLength = 13;
            blackHeron.CommonName = "black heron";
            blackHeron.GenusSpecies = "egretta ardesiaca";
            blackHeron.IsWarmBlooded = false;
            blackHeron.Population = "25 to 50,000";
            Console.WriteLine($"The {blackHeron.GenusSpecies} or more commonly know {blackHeron.CommonName} is a fairly rare bird with a \n" +
                $"population around {blackHeron.Population}. It has {blackHeron.FeatherColor} feathers and a {blackHeron.BeakType} \n" +
                $"that is {blackHeron.BeakLength} inches long. ");
            Console.WriteLine($"Warm blooded: {blackHeron.IsWarmBlooded}");
            Console.WriteLine($"Can fly: {blackHeron.CanFly}");

            var doDo = new Birb(true, "Grey and white", "Heavy and hooked", 6);

            var gilaMonster = new Repitle(true, false, false, false);

            var cropansBoa = new Repitle();
            cropansBoa.IsPoisoness = false;
            cropansBoa.IsLegless = true;
            cropansBoa.CanRegenerate = false;
            cropansBoa.InfraredVision = true;
            cropansBoa.CommonName = "cropan's boa";
            cropansBoa.GenusSpecies = "corallus cropanii";
            cropansBoa.IsWarmBlooded = false;
            cropansBoa.Population = "not known, thought to be extinct until 2017";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The {cropansBoa.GenusSpecies} or more commonly reffered to as the {cropansBoa.CommonName} is extremely endangered \n" +
                $"potentially extinct and it's populations is {cropansBoa.Population}.");
            Console.WriteLine($"Warm blooded: {cropansBoa.IsWarmBlooded}");
            Console.WriteLine($"Is poisoness: {cropansBoa.IsPoisoness}");
            Console.WriteLine($"Is legless: {cropansBoa.IsLegless}");
            Console.WriteLine($"Can regenerate: {cropansBoa.CanRegenerate}");

            var fijiCrestedIguana = new Repitle()
            {
                IsPoisoness = false,
                IsLegless = false,
                CanRegenerate = true,
                InfraredVision = false
            };
        }
    }
}
