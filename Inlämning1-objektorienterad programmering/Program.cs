using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämning1_objektorienterad_programmering
{
    class Program
    {
        static void Main(string[] args)
        {   
            //EMPTY LIST CREATED
            List<int> resultList = new List<int>();
            
            do
            {

            Console.WriteLine("I want you to enter a couple of operators");

            Console.WriteLine("Enter first operator: ");
            string firstOperatorInString = Console.ReadLine();
            int firstOperatorInChar = Convert.ToChar(firstOperatorInString);

            Console.WriteLine("Enter second operator: ");
            string secondOperatorInString = Console.ReadLine();
            int secondOperatorInChar = Convert.ToChar(secondOperatorInString);

            Console.WriteLine("I also want you to enter a couple of terms");

            Console.WriteLine("Enter first term");
            string firstTermInString = Console.ReadLine();
            int firstTermInInt = Convert.ToInt32(firstTermInString);

            Console.WriteLine("Enter second term");
            string secondTermInString = Console.ReadLine();
            int secondTermInInt = Convert.ToInt32(secondTermInString);

            Console.WriteLine("Enter third term");
            string thirdTermInString = Console.ReadLine();
            int thirdTermInInt = Convert.ToInt32(thirdTermInString);
            Console.WriteLine("Equation: " + firstTermInString + firstOperatorInString + secondTermInString + secondOperatorInString + thirdTermInString);



            //VALID CODE IF OPERATOR 1 IS +
            if (firstOperatorInChar == '+' && secondOperatorInChar== '+')
            {
               int result = AdditionAddition(firstTermInInt, secondTermInInt, thirdTermInInt);
               Console.WriteLine("Result: " + result);
               resultList.Add(result);
               Console.WriteLine (messageToUser(result));
            }

            else if (firstOperatorInChar == '+' && secondOperatorInChar == '-')
            {
                int result = AdditionSubtraction(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '+' && secondOperatorInChar == '*')
            {
                int result = AdditionTimes(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);            
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '+' && secondOperatorInChar == '/')
            {
                int result = AdditionDivided(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

            //VALID CODE IF OPERATOR 1 IS -
            if (firstOperatorInChar == '-' && secondOperatorInChar == '+')
            {
                int result = SubtractionAddition(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

            else if (firstOperatorInChar == '-' && secondOperatorInChar == '-')
            {
                int result = SubtractionSubtraction(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '-' && secondOperatorInChar == '*')
            {
                int result = SubtractionTimes(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '-' && secondOperatorInChar == '/')
            {
                int result = SubtractionDivided(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

            //VALID CODE IF OPERATOR 1 IS *
            if (firstOperatorInChar == '*' && secondOperatorInChar == '+')
            {
                int result = TimesAddition(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

            else if (firstOperatorInChar == '*' && secondOperatorInChar == '-')
            {
                int result = TimesSubtraction(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '*' && secondOperatorInChar == '*')
            {
                int result = TimesTimes(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '*' && secondOperatorInChar == '/')
            {
                int result = TimesDivided(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

            //VALID CODE IF OPERATOR 1 IS /
            if (firstOperatorInChar == '/' && secondOperatorInChar == '+')
            {
                int result = DividedAddition(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

            else if (firstOperatorInChar == '/' && secondOperatorInChar == '-')
            {
                int result = DividedSubtraction(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));

            }
            else if (firstOperatorInChar == '/' && secondOperatorInChar == '*')
            {
                int result = DividedTimes(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }
            else if (firstOperatorInChar == '/' && secondOperatorInChar == '/')
            {
                int result = DividedDivided(firstTermInInt, secondTermInInt, thirdTermInInt);
                Console.WriteLine("Result: " + result);
                resultList.Add(result);
                Console.WriteLine(messageToUser(result));
            }

                

            Console.WriteLine("Want another round?", "Yes/No");
            string answerInString = Console.ReadLine();
                

            if (answerInString == "Yes" || answerInString == "Yes")
            {
                Console.WriteLine("OK, here we go again!");
            }

            else if (answerInString == "No" || answerInString == "no")
            {
                Console.WriteLine("Thanks for playing, sum of all rounds is: ");
                Console.WriteLine(resultList.Sum());
                Console.WriteLine("All of your equation results:");
                Console.WriteLine(string.Join(',', resultList));
                
                break;
            }
        } while (true);



            //BELOW CODE ARE METHODS//

            //ADDITON METHODS

            static int AdditionAddition(int x, int y, int z)
            {
                int result = x + y + z;
                return result;

            }
            static int AdditionSubtraction(int x, int y, int z)
            {
                int result = x + y - z;
                return result;
            }
            static int AdditionTimes(int x, int y, int z)
            {
                int result = x + y * z;
                return result;
            }
            static int AdditionDivided(int x, int y, int z)
            {
                int result = x + y / z;
                return result;
            }
           

            //SUBTRACTION METHODS
            static int SubtractionSubtraction(int x, int y, int z)
            {
                int result= x - y -z;
                return result;
            }
            static int SubtractionAddition(int x, int y, int z)
            {
                int result = x - y + z;
                return result;
            }
            static int SubtractionTimes(int x, int y, int z)
            {
                int result = x - y * z;
                return result;
            }
            static int SubtractionDivided(int x, int y, int z)
            {
                int result = x - y / z;
                return result;
            }

            //TIMES METHODS
            static int TimesTimes(int x, int y, int z)
            {
                int result = x * y * z;
                return result;
            }

            static int TimesSubtraction(int x, int y, int z)
            {
                int result = x * y - z;
                return result;
            }
            static int TimesAddition(int x, int y, int z)
            {
                int result = x * y + z;
                return result;
            }
            static int TimesDivided(int x, int y, int z)
            {
                int result = x * y / z;
                return result;
            }

            //DIVISION METHODS 
            static int DividedDivided(int x, int y, int z)
            {
                int result = x / y / z;
                return result;
            }
            static int DividedTimes(int x, int y, int z)
            {
                int result = x / y * z;
                return result;
            }
            static int DividedSubtraction(int x, int y, int z)
            {
                int result = x / y - z;
                return result;
            }
            static int DividedAddition(int x, int y, int z)
            {
                int result = x / y + z;
                return result;
            }

            //METHOD TO SHOW DIFFERENT MESSAGES DEPENDING ON EQUATION RESULT

           static string messageToUser(int equationResult)
            {
                
                if (equationResult == 100)
                {
                    string messageHundred = "Cool, you now have a hundred";
                    return messageHundred;
                }
                else if (equationResult<100)
                {
                    string messageLess = "Less than a hundred";
                    return messageLess;
                }
                else if (equationResult> 100)
                {
                    string messageMore = "More than a hundred";
                    return messageMore;
                }
                string messageDefault = "Nothing";//MESSAGE ADDED ONLY TO SOLVE CS0161, THIS CODE WILL NEVER RUN
                return messageDefault;

            }
                 
            }

            
            
        }   
    } 

