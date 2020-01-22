using System;

/*  Task: You are given the noises made by different animals that you can hear in the dark, evaluate each noise to determine which animal it belongs to. Lions say 'Grr', Tigers say 'Rawr', Snakes say 'Ssss', and Birds say 'Chirp'.

    Input Format: A string that represents the noises that you hear with a space between them.

    Output Format: A string that includes each animal that you hear with a space after each one. (animals can repeat)

    Sample Input: Rawr Chirp Rawr Ssss

    Sample Output: Tiger Bird Tiger Snake
 */

namespace AnimalSound
{
    class Program
    {
        static void Main(string[] args)
        {
            //i did use var for auto cast, what i mean is the c# compiler will automatically detect the data type for such declaration
            var animalSound = new string[] { "Grr", "Rawr", "Ssss", "Chirp" };          // this array will be our matching parameters for user input (that matching is looping below)
            var animals = new string[] { "Lions", "Tigers", "Snakes", "Birds" };        // this array will be reference based from the sound of animals

            Console.Write("Input: ");
            var input = Console.ReadLine();             // Get user input from ReadLine() method and the value to input variable
                                                        //Example Input: Grr Ssss Ssss Rawr                       
            var inputtedAnimals = input.Split(' ');     //convert the value of input variable into an array value separated by ' ' or space character as the value of inputtedAnimals                      
                                                        //No2 the value of inputtedAnimals = {"Grr","Ssss","Ssss","Rawr"}
            Console.Write("Output: ");
            for (int i = 0; i < inputtedAnimals.Length; i++)        //Iterate through all the values of inputtedAnimals
            {
                for (int j = 0; j < animalSound.Length; j++)        //Iterate through all the values of animalSound
                {
                    if (inputtedAnimals[i].Equals(animalSound[j]))  //Match the sound (value). check comment at the end of the namespace block
                    {
                        Console.Write($"{animals[j]} ");            //if match, print the animal that makes the sound
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
/* i, j         inputtedAnimals      animalSound    Result
 * i=0, j=0     Grr             =    Grr            True, then the console will display the value of animals[j] which is Lion, then BREAK
 * i=1, j=0     Ssss            =    Grr            False
 * i=1, j=1     Ssss            =    Rawr           false
 * i=1, j=2     Ssss            =    Ssss           true, then the console will display the value of animals[j] which is Snakes, then BREAK
 * i=2, j=0     Ssss            =    Grr            false
 * i=2, j=1     Ssss            =    Rawr           false
 * i=2, j=2     Ssss            =    Ssss           true, then the console will display the value of animals[j] which is Snakes, then BREAK
 * i=3, j=0     Rawr            =    Grr            false
 * i=3, j=1     Rawr            =    Rawr           true, then the console will display the value of animals[j] which is Tigers, then BREAK End of Loop
 */
