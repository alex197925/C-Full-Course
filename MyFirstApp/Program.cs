using System.Security.Cryptography.X509Certificates;

/* namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomthing();
            WriteSomthingSpecific("I am an argument and am called from a method");
            Console.Read();
        }

        // access modifire (static) return type method name (parameter1, parameter2)
        public static void WriteSomthing()
        {

            Console.WriteLine("I am called from method");
         
        
        
        }
        public static void WriteSomthingSpecific(string myText)
        {
            Console.WriteLine(myText);
         
        }
    }





}
*/

/* namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(20, 15));
            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Divide(25, 13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}*/



// Read values from the user 
/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Culculate());
            Console.Read();
        }


        public static int Culculate()
        {
            Console.WriteLine("Please enter the first number!");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number!");
            string number2Input = Console.ReadLine();


            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input); 

            int result = num1 + num2;
            return result;
      
        }
    }
}
*/

/*
namespace TryAndCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!!"); // Promt
            string userInput = Console.ReadLine();


            try
            {
                int userInputNumber = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, please enter the correct type next time!!!");
            }
            catch(OverflowException) 
            {
                Console.WriteLine("Overflow exception, number was too long or too shoret for an int32");
            }
            catch(ArgumentNullException) 
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }finally
            {
                Console.WriteLine("This is called anyways!!!!");
            }
       

            

            
            Console.ReadKey();
        }
    }
}
*/


/*
namespace CatchArror
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 0;

            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Attempted to divide by zero");
            }
        }
       
    }
}
*/



// Operators
/*namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args) 
        {
            int num1 = 12;
            int num2 = 4;
            int num3;


            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);


            bool isSunny = true;
            Console.WriteLine("is it synny? {0}", !isSunny);



            // incriment operator
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            // +
            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            // -
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);

            // "/"
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);


            // "*"
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);

            // "%"
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEquel;
            isEquel = num1 == num2;
            

            // not equality operator
            isEquel = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEquel);

            // conditional operator "AND"
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            // "OR" operator
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);
            Console.ReadKey();



        }
    }
}*/

/*namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Input day temperature : ");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if (userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("value entered, was no number. 0 set as temperature");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Freezing weather.\n");
            } else if (numTemp == 20)
            {
                Console.WriteLine("Normal weather.\n");
            } else if(numTemp > 30)
            {
                Console.WriteLine("Hot temp.\n");
            }
            else
            {
                Console.WriteLine("Shorts are enough today!!");
            }
           
        
    
            Console.Read();
        }
    }
}
*/

// TryParse() Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the operation succeeded.
/*namespace TryParse
{
    class Programm
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);
            Console.WriteLine(success);


            if (success)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);

            }
            else
            {
                Console.WriteLine("parsing faild!");
            }

        }
    }
}*/

// If Statements & Nested If Statements
// User Login form
/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRegistered = true;
            bool isAdmin = false;
            string userName = "";
            Console.WriteLine("Pleas enter your username");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registerd user");
              
                Console.WriteLine("Hi there, " + userName);
                   
                Console.WriteLine("Hi there, Admin");
                 
            
            }
            if (isRegistered || isAdmin)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
              

        }
       
    }

}*/

// Switch & 