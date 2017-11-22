using System;

namespace Encapsulation
{
    class Program
    {
        /* this is just a sample program with using data encapsulation with the Animal class by creating Animal 
         * object and using property methods of setters/getters.
         */
        static void Main(string[] args)
        {
   
            Animal dog = new Animal();

            //dog.Age = -12;
            dog.Age = 2;
            dog.Color = "Biege";
            

            Console.WriteLine("The dog's age is: " + dog.Age);
            Console.WriteLine("The dog's fur color is: " + dog.Color);
            dog.move();


        }
    }
}