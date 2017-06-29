using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Rebecca";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);

            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers";
            //Console.WriteLine(myFaveQuote);

            //string escapeString = "I want a tab after this line\t I want a new line without WriteLine \nHi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput == userTwoInput)
            //{
            //    Console.WriteLine("User 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            ////instead of using ==, use .Equals() which is a method
            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}


            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Michelle.";
            //string fullSentence = startOfSentence + endOfSentence;
            ////another way to concatenate - rarely used this way
            ////string fullSentence = string.Concat(startUpSentence, endOfSentence);
            ////example of concatenation
            //Console.WriteLine(startOfSentence + endOfSentence);
            //Console.WriteLine(fullSentence);

            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            ////user way to do this
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);

            ////Example of array
            //Console.WriteLine("The first part of my sentence was {0}, and the second was {1}, and the third was {3}", startOfSentence, endOfSentence, fullSentence);

            //Inclass work
            //Console.WriteLine("This is a tab. \t \nThis is a backslash \\. \nAnd this us a bell sound\a.");

            //Inclass work with House
            //string firstName = "Rebecca";
            //string lastName = "Seel";
            //int lengthFirstName = firstName.Length;
            //int lengthLastName = lastName.Length;

            //Console.WriteLine("What is your first name?");
            //firstName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //firstName = Console.ReadLine();

            //if (lengthFirstName > lengthLastName)
            //{
            //    Console.WriteLine("First is longer");
            //}
            //else if (lengthFirstName == lengthLastName)
            //{
            //    Console.WriteLine("Samesies!");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}

            //next problem
            //string name1 = "Justin";
            //string name2 = "Justin";

            //Console.WriteLine(name1);
            //Console.WriteLine(name2);

            //if (name1 == name2)
            //{
            //    Console.WriteLine("The names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}

            //same problem using .Equals instead of ==
            string name1 = "Justin";
            string name2 = "Mary";

            Console.WriteLine(name1);
            Console.WriteLine(name2);

            if (name1.Equals(name2))
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

        }
    }
}
