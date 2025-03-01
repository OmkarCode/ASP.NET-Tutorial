using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SingelLine comment

            /*
             Understande multiline comment.
             */

            /*

             ========================> DATATYPE'S OF C# <========================

             1) Integer -> int number = 5; [Data-Type Size = 4 bytes]

             2) Floatin Integer -> float floatingNumber = 2.21; [Data-Type Size = 4 bytes]

             3) String -> string name = "kashyap" [Data-Type Size = 2 bytes per character]

             4) Character -> char character = 'K' [Data-Type Size = 2 bytes]

             5) Blooean -> bool isActive = true [Data-Type Size = 1 bit]

             6) Long -> long number = 90123490123456648950 [Data-Type Size = 8 bytes] (Good presition form Integer)

             7) Double -> double number = 9.490123456648950 [Data-Type Size = 8 bytes] (Good presition form Float)

             */

            // Usage of DATATYPE'S as per above we write (Examples)

            Console.WriteLine("========================> DATATYPE'S OF C# <========================");

            int number1 = 5;

            float number2 = 5.20F;

            string name = "kashyap";

            char firstLatterOfName = 'k';

            bool isActive = true;

            double sumOfTwoNumbers = number1 + number2;

            Console.WriteLine("Hello World!" + number1 + " " + number2);

            Console.WriteLine("1) Person Name is: " + name + " 2) First Latter Of Name is: " + firstLatterOfName + " 3) Person is active or not: " + isActive);

            Console.WriteLine("Sum of Two Numbers: " + sumOfTwoNumbers);

            //Type Casting

            Console.WriteLine("========================> TYPE-CASTING In C# <========================");

            /*
             There are a two type's of type casting in C#.

             1) Implicit type-casting.
                char <-> int <-> float <-> long <-> double

             2) Explicit type-casting.

             */

            // 1) Implicit type-casting.

            int typeCastingNumber = 5;

            double intToDouble = typeCastingNumber;

            int intToCharacter = 'n';

            Console.WriteLine("Implicit Type Casting Integer To Dobule: " + intToDouble);

            Console.WriteLine("Implicit Type Casting Integer To Character: " + intToCharacter); // here we get answer 110 becuse compiler give us ASCII value of the character.

            //2) Explicit type-casting.

            double coverIntToDobule = (int)30.90;

            Console.WriteLine(coverIntToDobule);

            //Take Input From User

            Console.WriteLine("========================> TAKING-INPUT-FROM-USER In C# <========================");

            Console.WriteLine("Please, enter your name: ");
            // string personName = Console.ReadLine();
            // Console.WriteLine("Hello, welcome Mr/Miss: " + personName);

            Console.WriteLine("How many candies do you want: ");
            // string cadiesNumber = Console.ReadLine();
            // Console.WriteLine("You will get 5 more candies from use: " + (Convert.ToInt32(cadiesNumber) + 5));

            // Operator in c# 

            /*
                1)  Arithmetic Operator
                2)  Assignmet Operator 
                3)  Logical Operator
                4)  Comparison Operator
            */

            Console.WriteLine("========================> ARITHMATIC-OPERATOR In C# <========================");

            Console.WriteLine("Additino of two numbers: " + (5 + 2));
            Console.WriteLine("Subtraction of two numbers: " + (5 - 2));
            Console.WriteLine("Divition of two numbers: " + (5 / 2));
            Console.WriteLine("Multiplication of two numbers: " + (5 * 2));

            Console.WriteLine("========================> ASSIGNMENT-OPERATOR In C# <========================");

            int number3 = 5;
            int number4 = 2;

            Console.WriteLine("Additino of two numbers: " + (number3 += number4)); // number4 = number4 + number3;
            Console.WriteLine("Subtraction of two numbers: " + (number3 -= number4)); // number4 = number4 - number3;
            Console.WriteLine("Divition of two numbers: " + (number3 /= number4)); // number4 = number4 / number3;
            Console.WriteLine("Multiplication of two numbers: " + (number3 *= number4)); // number4 = number4 * number3;

            Console.WriteLine("========================> LOGICAL-OPERATOR In C# <========================");

            // AND Operator
            Console.WriteLine(true && false); // if both condition will be true then it's return a true.

            // OR Operator
            Console.WriteLine(true || false); // in given condition anyone come true then this return true.

            // NOT Operator
            Console.WriteLine(!false); // this is return a true when we will do vice-versa of any condition then we use this operator
            Console.WriteLine(!true); // this is return a false when we will do vice-versa of any condition then we use this operator

            Console.WriteLine("========================> COMPARISON-OPERATOR In C# <========================");

            Console.WriteLine("Grater Than or not: " + (number3 > number4));
            Console.WriteLine("Less Than or not: " + (number3 < number4));
            Console.WriteLine("Grater Than Equal to or not: " + (number3 >= number4));
            Console.WriteLine("Less Than Equal to or not: " + (number3 <= number4));
            Console.WriteLine("Equal to or not: " + (number3 == number4));
            Console.WriteLine("Not Equal to: " + (number3 != number4));

            Console.WriteLine("========================> MATH-CLASS In C# <========================");

            double mathNumber = 20.344546563445;

            double roundedNumber = Math.Floor(Math.Round(mathNumber));

            double squarNumber = Math.Sqrt(mathNumber);

            double abbsaluteNumber = Math.Abs(mathNumber);

            Console.WriteLine(roundedNumber + " " + squarNumber + " " + abbsaluteNumber);

            //  String Methos in c#

            Console.WriteLine("========================> STRING-METHODS In C# <========================");

            string personInfo = "Hello, my name is kapdi kashyap and i am a student of C#";

            Console.WriteLine(personInfo.Length); // this is return a length of the string.
            Console.WriteLine(personInfo.ToUpper()); // this is return a string in upper case.
            Console.WriteLine(personInfo.ToLower()); // this is return a string in lower case.
            Console.WriteLine(personInfo + " Kashyap is good person."); // this is return a string concatination.
            Console.WriteLine(string.Concat(personInfo, " Kashyap is good person.")); // this is return a string concatination.

            Console.WriteLine(personInfo[0]); // this is return a character of the string.
            Console.WriteLine(personInfo.IndexOf('i')); // this is return a index of the character.
            Console.WriteLine(personInfo.Substring(7)); // this is return a substring of the string.

            // string productName = Console.ReadLine();
            // string productQuantity = Console.ReadLine();

            // Console.WriteLine($"Product Name: {productName}  Product Quantity: {productQuantity}"); // this is return a string concatination.

            string escapeString = "This is a \"escape\" string. \nThis is a new line. \tThis is a tab.";
            Console.WriteLine(escapeString);

            //  If-Else Statement in c#

            Console.WriteLine("========================> IF-ELSE In C# <========================");

            /* 
            Console.WriteLine("Please, enter your age: ");
            string personAge = Console.ReadLine();
            int age = Convert.ToInt32(personAge);

            if (age < 2)
            {
                Console.WriteLine("You are new born baby can't drive.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teenager can't drive.");
            }
            else if (age < 75)
            {
                Console.WriteLine("You are a adult you can drive.");
            }
            else
            {
                Console.WriteLine("You can't drive.");
            }
            */

            //  Switch Statement in c#
            Console.WriteLine("========================> SWITCH-STATEMENT In C# <========================");

            /* 

            Console.WriteLine("Please, enter your age: ");
            string personAge2 = Console.ReadLine();
            int age2 = Convert.ToInt32(personAge2);

            switch (age2)
            {
                case int n when age2 < 18:
                    Console.WriteLine("You are a teenager can't drive.");
                    break;

                case int n when age2 > 18:
                    Console.WriteLine("You can drive.");
                    break;
                default:
                    Console.WriteLine("You can't drive.");
                    break;
            }

            */

            // Loop's in c#

            Console.WriteLine("========================> WHILE-LOOP In C# <========================");
            int whileLoopNumber = 0;

            while (whileLoopNumber < 10)
            {
                Console.WriteLine(whileLoopNumber);
                whileLoopNumber++;
            }

            Console.WriteLine("========================> DO-WHILE-LOOP In C# <========================");
            int doWhileLoopNumber = 0;

            do
            {
                Console.WriteLine(doWhileLoopNumber);
                doWhileLoopNumber++;
            } while (doWhileLoopNumber < 10);

            Console.WriteLine("========================> FOR-LOOP In C# <========================");

            /*
                1) Break: this is break the loop (Leave the loop forever).
                2) Continue: this is continue the loop (Leave the loop and continue to the next iteration).
            */

            for (int forLoopNumber = 0; forLoopNumber < 10; forLoopNumber++)
            {

                if (forLoopNumber == 0)
                {
                    continue; // this is continue the loop.
                }

                Console.WriteLine(forLoopNumber);
                // break;  // this is break the loop.
            }

            Greeting(name);
            Console.WriteLine(Avrage(20, 10));

            // OOPS - Object Oriented Programming in C# 

            Console.WriteLine("========================> OOPS-IN C# <========================");

            Players Kashyap = new Players();


            Console.WriteLine(Kashyap.getAge());    // this is return a age of the player.
            Kashyap.setAge(20); // this is set a age of the player.
            Console.WriteLine(Kashyap.getAge());    // this is return a age of the player (After setting a age).
        }

        static void Greeting(string name)
        {
            Console.WriteLine($"Hello Greeting {name}");
        }

        static double Avrage(double number1, double number2)
        {
            double avrage = (number1 + number2);
            return Math.Floor(Math.Round(avrage / 2));
        }

    }
}
