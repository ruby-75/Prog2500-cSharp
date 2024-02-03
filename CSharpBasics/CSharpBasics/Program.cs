using System.Security.Cryptography.X509Certificates;



namespace CSharpBasics
{
    internal class Program
    {
        //very first method called whenever your application is executed
        static void Main(string[] args)
        {
            int myInt = 10;
            int yourInt;
            long myLong = 2003372036854775800;
            float myFloat = 5.2F;
            double myDouble = 89.9856D;
            bool myBool = false;
            char myChar = 'a';
            string myString = "Hello ";

            //Built in library methods (Console line is the class, WriteLine is the method, period is a member accessors,
            //parenthesis say invoke it now and you can pass arguments in them.)

            //WriteLine- Output data with a new line character. Outputs data as a string
            //Write- string with no new line character.
            Console.Write("C# data types include ");
            Console.WriteLine("int, long, float, double, bool, char, and string.");
            Console.WriteLine();
            Console.WriteLine("A description of each can be found at " +
                "https://www.w3schools.com/cs/cs_data_types.php ");
            Console.WriteLine();
            Console.WriteLine("Invoke a method by calling the class (Console) using the member access (.) and the method name (WriteLine) followed by parenthesis ().");
            Console.WriteLine();

            //if the window opens and closes before you can read it use this line to keep it open
            //Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter a your first name.");
            //user input - string
            string fName = Console.ReadLine();
            Console.WriteLine("Enter a your Last name.");
            //user input - string
            string lName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(myString + fName + ". Welcome to C# programming language.");
            Console.WriteLine();
            Console.WriteLine("I have described some basic details about the language here, ");
            Console.WriteLine("and you can investigate more details by reviewing my code.\"");
            Console.WriteLine();

            /*
            bool displayMenu = true;
            while (displayMenu)
            {

                Console.Clear();
                Console.WriteLine("Choose one of the following options.");
                Console.WriteLine();
                Console.WriteLine("1. Operators");
                Console.WriteLine("2. Keywords");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("0. Exit the Program");
                string userMainMenuInput = Console.ReadLine();

                switch (userMainMenuInput)
                {
                    case "1":
                        // Operators method
                        break;
                    case "2":
                        // Keywords function
                        break;
                    case "3":
                        //
                        break;
                    case "4":
                        //
                        break;
                        break;
                    case "5":
                        //
                        break;

                    case "0":
                        Console.WriteLine("bye!");
                        displayMenu = false;
                        break;
                }
                displayMenu = true;

            }
            */


            Console.WriteLine("Choose one of the following options.");
            Console.WriteLine();
            Console.WriteLine("1. Arithmetic Operators");
            Console.WriteLine("2. Assignment Operators");
            Console.WriteLine("3. Comparison Operators");
            Console.WriteLine("4. Logical Operators");
            Console.WriteLine("5. Return to the Main Menu");
            Console.WriteLine("0. Exit the Program");

            string userValue = Console.ReadLine();
            Console.WriteLine();

            OperatorChoice(userValue, myInt);


            Console.WriteLine("Choose one of the following options.");
            Console.WriteLine();
            Console.WriteLine("1. Keywords");
            Console.WriteLine("2. Contextual keywords");
            string userChoice = Console.ReadLine();

            //if else statement. Can only be written this way when there are only two options. True is everything after the ? and before the  colon and
            //false is everything after the colon. Called a Ternary Operator
            string message = (userChoice == "1") ? "abstract\tas\t\tbase\t\tbool\t\tbreak\t\tbyte\ncase\t\tcatch\t\tchar\t\tchecked\t\tclass\t\tconst\n" +
                "continue\tdecimal\t\tdefault\t\tdelegate\tdo\t\tdouble\nelse\t\tenum\t\tevent\t\texplicit\textern\t\tfalse\nfinally\t\tfixed\t\t" +
                "float\t\tfor\t\tforeach\t\tgoto\nif\t\timplicit\tin\t\tint\t\tinterface\tinternal\nis\t\tlock\t\tlong\t\tnamespace\tnew\t\t" +
                "null\nobject\t\toperator\tout\t\toverride\tparams\t\tprivate\nprotected\tpublic\t\treadonly\tref\t\treturn\t\tsbyte\n" +
                "sealed\t\tshort\t\tsizeof\t\tstackalloc\tstatic\t\tstring\nstruct\t\tswitch\t\tthis\t\tthrow\t\ttrue\t\ttry\ntypeof\t\tuint\t\t" +
                "ulong\t\tunchecked\tunsafe\t\tushort\nusing\t\tvirtual\t\tvoid\t\tvolatile\twhile\n\nFor details on keywords go to " +
                "https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/\n" : "add\t\tand\t\talias\t\tascending\targs\t\tasync\n" +
                "await\t\tby\t\tdescending\tdynamic\t\tequals\t\tfile\nfrom\t\tget\t\tglobal\t\tgroup\t\tinit\t\tinto\njoin\t\tlet\t\t" +
                "managed\t\tnameof\t\tnint\t\tnot\nnotnull\t\tnuint\t\ton\t\tor\t\torderby\t\tpartial\n" +
                "record\t\tremove\t\trequired\tscoped\t\tselect\t\tset\nunmanaged\t" +
                "value\t\tvar\t\twhen\t\twhere\t\twith\t\tyield\n\n" +
                "For details on Contextual keywords go to https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/";
            Console.WriteLine(message);
            Console.WriteLine();


            Console.WriteLine("Choose the corresponding number to get a description of the data type.");
            Console.WriteLine("1. int");
            Console.WriteLine("2. long");
            Console.WriteLine("3. float");
            Console.WriteLine("4. double");
            Console.WriteLine("5. char");
            Console.WriteLine("6. bool");
            Console.WriteLine("7. string");
            Console.WriteLine("8. Return to the Main Menu");
            Console.WriteLine("0. To exit the program");
            Console.WriteLine();
            string userMenuInput = Console.ReadLine();

            switch (userMenuInput)

            {

                case "1":
                    Console.WriteLine("An int stores whole numbers from -2,147,483,648 to 2,147,483,647.");
                    Console.WriteLine("An example of an int is " + myInt);
                    break;
                case "2":
                    Console.WriteLine("A long stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.");
                    Console.WriteLine("An example of a long is " + myLong);
                    break;
                case "3":
                    Console.WriteLine("A float stores fractional numbers. Sufficient for storing 6 to 7 decimal digits");
                    Console.WriteLine("An example of a float is " + myFloat);
                    break;
                case "4":
                    Console.WriteLine("A double stores fractional numbers. Sufficient for storing 15 decimal digits.");
                    Console.WriteLine("An example of a double is " + myDouble);
                    break;
                    break;
                case "5":
                    Console.WriteLine("A char stores a single character/letter, surrounded by single quotes.");
                    Console.WriteLine("An example of a char is " + myChar);
                    break;
                case "6":
                    Console.WriteLine("A bool stores true or false values.");
                    Console.WriteLine("An example of a bool is " + myBool);
                    break;
                case "7":
                    Console.WriteLine("A string stores a sequence of characters, surrounded by double quotes ");
                    Console.WriteLine("An example of a string is " + fName);
                    break;
                case "8":
                    //method to return to the main menu
                    break;
                case "0":
                    Console.WriteLine("bye!");
                    break;

            }

            Console.WriteLine();

            Console.WriteLine("Example of an array. ");
            Console.WriteLine("You can add the values when you declare it or later.");
            Console.WriteLine();
            Console.WriteLine("int[] numbers = new int[5] {5, 10, 15, 20, 25};");
            Console.WriteLine("Console.WriteLine(number[3]);  // find the value in index 3. Remember the index starts at 0.");
            Console.WriteLine();
            Console.WriteLine("Result:");

            int[] numbers = new int[5] { 5, 10, 15, 20, 25 };
            Console.WriteLine(numbers[3]);


            Console.WriteLine();

            Console.WriteLine("Example of a for loop");
            Console.WriteLine("for (int i = 10; i > 0; i--)");
            Console.WriteLine("{");
            Console.WriteLine("Console.WriteLine(i);");
            Console.WriteLine("}");
            Console.WriteLine();
            Console.WriteLine("Result:");


            //use a loop to create a countdown
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //array of strings printed with for each loop
            Console.WriteLine("Array of stings printed using a foreach loop.");
            Console.WriteLine("string[] names = new string[] { \"Mary\", \"Jary\", \"Carey\", \"Harry\", \"Terry\" };");
            Console.WriteLine();
            Console.WriteLine("foreach (string name in names) {  Console.WriteLine(name); }");
            Console.WriteLine("Results:");

            string[] names = new string[] { "Mary", "Jary", "Carey", "Harry", "Terry" };

            foreach (string name in names) { Console.WriteLine(name); }

            Console.WriteLine();


            PrintStrings(ReverseString(fName), ReverseString(lName));
            PrintStrings(ReverseString(fName));
        }



        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);

        }

        //method
        private static void PrintStrings(string message1, string message2)
        {
            Console.Write(String.Format(" {0} {1}", message1, message2));
            Console.WriteLine();
        }

        //overloading method
        private static void PrintStrings(string message)
        {
            Console.Write(message);
            Console.WriteLine();
        }

        public static void OperatorChoice(string userValue, int myInt)
        {
            if (userValue == "1")
            {
                Console.WriteLine(" Arithmetic Operators");
                Console.WriteLine("Enter an integer value between 1 an 100.");
                string userInput = Console.ReadLine();
                //Convert string to int
                int userNum = Convert.ToInt32(userInput);

                //using the arithmetic operators and assigning the results to variables
                int adding = myInt + userNum;
                int subtracting = myInt - userNum;
                int multiplying = myInt * userNum;
                int dividing = userNum / myInt;
                int modulus = userNum % myInt;
                int incrementing = ++userNum;
                int decrementing = --userNum;
                Console.WriteLine();

                //printing the results to the screen
                Console.WriteLine("My number is " + myInt + " your number is " + userNum);
                Console.WriteLine();
                Console.WriteLine("+\tAddition");
                Console.WriteLine(myInt + " + " + userNum + " = " + adding);
                Console.WriteLine();
                Console.WriteLine("-\tSubtraction");
                Console.WriteLine(myInt + " - " + userNum + " = " + subtracting);
                Console.WriteLine();
                Console.WriteLine("*\tMultiplication");
                Console.WriteLine(myInt + " * " + userNum + " = " + multiplying);
                Console.WriteLine();
                Console.WriteLine("/\tDivision");
                Console.WriteLine(userNum + " / " + myInt + " = " + dividing);
                Console.WriteLine();
                Console.WriteLine("%\tModulus");
                Console.WriteLine(userNum + " % " + myInt + " = " + modulus);
                Console.WriteLine();
                Console.WriteLine("++\tIncrement");
                Console.WriteLine(" ++ " + userNum + " = " + incrementing + " Now your number is " + incrementing);
                Console.WriteLine();
                Console.WriteLine("--\tDecrement");
                Console.WriteLine(" -- " + incrementing + " = " + decrementing + " Now your number is " + decrementing);
                Console.WriteLine();
                //method to return to menu
            }
            else if (userValue == "2")
            {
                Console.WriteLine(" Assignment Operators");
                Console.WriteLine("Operator\tExample\t\tSame As\r\n");
                Console.WriteLine("   =\t\tx = 5\t\tx = 5\t\r\n");
                Console.WriteLine("   +=\t\tx += 3\t\tx = x + 3\t\r\n");
                Console.WriteLine("   -=\t\tx -= 3\t\tx = x - 3\t\r\n");
                Console.WriteLine("   *=\t\tx *= 3\t\tx = x * 3\t\r\n");
                Console.WriteLine("   /=\t\tx /= 3\t\tx = x / 3\t\r\n");
                Console.WriteLine("   %=\t\tx %= 3\t\tx = x % 3\t\r\n");
                Console.WriteLine("   &=\t\tx &= 3\t\tx = x & 3\t\r\n");
                Console.WriteLine("   |=\t\tx |= 3\t\tx = x | 3\t\r\n");
                Console.WriteLine("   ^=\t\tx ^= 3\t\tx = x ^ 3\t\r\n");
                Console.WriteLine("   >>=\t\tx >>= 3\t\tx = x >> 3\t\r\n");
                Console.WriteLine("   <<=\t\tx <<= 3\t\tx = x << 3");
                //method to return to menu
            }
            else if (userValue == "3")
            {
                Console.WriteLine(" Comparison Operators");
                Console.WriteLine("   ==\tEqual to");
                Console.WriteLine("   !=\tNot equal");
                Console.WriteLine("   >\tGreater than");
                Console.WriteLine("   <\tLess than");
                Console.WriteLine("   >=\tGreater than or equal to");
                Console.WriteLine("   <=\tLess than or equal to");
                //method to return to menu
            }
            else if (userValue == "4")
            {
                Console.WriteLine(" Logical Operators");
                Console.WriteLine("   && \tLogical AND");
                Console.WriteLine(" if ((x > y) && (a < b) both must be true for the statement to be true.");
                Console.WriteLine();
                Console.WriteLine("   || \tLogical OR");
                Console.WriteLine("if ((x > y) || (a < b) one must be true for the statement to be true.");
                Console.WriteLine();
                Console.WriteLine("   !\tLogical NOT");
                Console.WriteLine("if (!(x > y) || (a < b) the not operator make statement the opposite (x > y) become (x <= y). ");
                //method to return to menu
            }
            else if (userValue == "5")
            {
                //don't need braces if there is only one line of code
                //method to return to main menu
            }
            else if (userValue == "0")
            {
                //exit program
                Console.WriteLine("bye!");
            }
            else
            {
                //error checking
                Console.WriteLine("Your choice must be 0 to 5. Please try again.");
                //method to return to menu
            }
            Console.WriteLine();

        }
    }
   
}
