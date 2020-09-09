﻿using System;

namespace Deliverable11
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string username, passwordInput;
            Console.Write("Input a username: ");
            username = Console.ReadLine();



            Console.Write("Input a password: ");
            passwordInput = Console.ReadLine();

            /*   if (passwordInput.Length < 7)
                   Console.Write("\nError\n\n");

               if (passwordInput.Length > 12)
                   Console.Write("\nError.\n\n");*/

            bool passwordResult = Password(passwordInput, 7, 12);

            if (passwordResult == false)
            {
                Console.Write("\nError\n\n");
            }
            else
            
                Console.Write("\nPassword valid and accepted\n\n");

            

        }


        private static bool Password(string input, int minimum, int maximum)
        {
            /*Console.WriteLine("Error");*/

            bool hasCap = false;
            bool hasLow = false;
            bool hasSpec = false;
            bool hasNum = false;
            char currentCharacter;

            if (input.Length < minimum)
            {
                return false;
            }
            if (input.Length > maximum)
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                currentCharacter = input[i];
                if (char.IsUpper(currentCharacter))
                {
                    hasCap = true;
                }
                else if (char.IsLower(currentCharacter))
                {
                    hasLow = true;
                }
                else if (char.IsDigit(currentCharacter))
                {
                    hasNum = true;
                }

                else if (currentCharacter == '!')
                {
                    hasSpec = true;
                }
            }

            if (hasCap && hasLow && hasSpec && hasNum)
            {
                return true;
                
     
        
            }
            
            {
                return false;
            }
        }
    }
}