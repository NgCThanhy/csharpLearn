namespace Basic  {
    
    public class TryVar{
        // dataType variableName = initialValue;
        // 3 type of variable : Data Types, Type Inference, Constants     

        public static void DataType (){
            // C# has several built-in data types, including:

            // Numeric Types: Represents integers, floating-point numbers (whole numbers and decimal numbers).
            byte bData = 255; // 8-bit unsigned integer
            sbyte sbData = 127; // 8-bit signed integer
            short shData = 32767; // 16-bit signed integer
            ushort usData = 65535; // 16-bit unsigned integer
            int iData = 2147483647; // 32-bit signed integer
            uint uiData = 4294967295; // 32-bit unsigned integer
            long lData = 9223372036854775807; // 64-bit signed integer
            ulong ulData = 18446744073709551615; // 64-bit unsigned integer
            float fData = 3.40282347E+38F; // 32-bit single-precision floating-point number
            double dData = 1.7976931348623157E+308D; // 64-bit double-precision floating-point number


            // String Type: Represents sequences of characters (text).
            string sData = "Hello";

            // Boolean Type: Represents boolean values (true or false).
            bool blDataT = true;
            bool blDataF = false;

            // Character Types: Represents a single character.    
            char cData = 'A';   

            // Nullable Value Types: can be made nullable using the ?
            int? nullAble= null; // : alow Null :)

            // Object Type: Represents a reference to an object, a create instances of classes (base type for all types).

            // well Of course we can change types of them (from small to large is recommended):
            // Implicit (ngầm định) Type Conversion:
            short newShData = bData; // from byte to short

            //Explicit (rõ ràng) Type Conversion:
            int newIData = (int)shData; // from short to int

            // if want to convert from large to small => should use:Checked and Unchecked Conversions:
            byte newBData1 = (byte)iData; // overflow
            byte newBData2 = checked((byte)iData); // Checked conversion (exception)
            
        }

        // some var of DataType need to be the same level as the class:        
        // Enum Type: Represents an enumerated (liệt kê) type.
        enum Color { Red, Green, Blue }; // if don't attach to value => it will be default from 0 -> ...
        enum HttpStatus{ // attached and can be take by (int)
            OK = 200,
            BadRequest = 400,
            NotFound = 404,
            InternalServerError = 500
        }

        public static void InferenceType (){
            // well it just like java var
            var vData = 1000;
        }

        public static void ConstantType (){
            // Constants: Constants should use uppercase letters and underscores for word separation.
            // For example, MAX_VALUE, PI.
            const double CONST_DOUBLE_PI = 3.14159;

        }

        public static void PrintOut(){
            string name = "Alice";
            int score = 85;

            Color c = Color.Red;
            HttpStatus error = HttpStatus.BadRequest; 
            int errorCode = (int)error;

            Console.Write("print out without a line break ");
            Console.WriteLine("print out with"+" a line break ");   
            Console.WriteLine("Hello, {0}! Your score is {1}.", name, score); // like printf in c right?
            Console.WriteLine($"Hello, {name}! Your score is {score}."); // like `${name}` in javaScript right?
            Console.WriteLine($"{c}! Your error code is {errorCode}, status: {error} ."); // check enum
        }
        
        public static void InPut(){
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine(); // read all a line => until you enter
            Console.WriteLine("Hello, {0}!", name);

            Console.WriteLine("enter a character");
            int inputChar = Console.Read(); // Read a character as an integer
            char character = (char)inputChar; // Convert to char
            Console.WriteLine($"you enter, {character}! with int = {inputChar}."); 

            Console.WriteLine("pressed a key");    
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // Reads a single key press from the console, including special keys like function keys
            Console.WriteLine($"You pressed the key: {keyInfo.Key}"); // It returns a ConsoleKeyInfo object
        }

    }

    public class ArrayString{
        public static void Array(){
            int[] arr1 = new int[5]; // Create an array with 5 null elements
            int[] arr2 = { 85, 92, 78, 95, 88 };

            int arrayLength = arr2.Length; // Returns the length of the array
            for (int i = 0; i < arrayLength; i++){
                Console.WriteLine(arr2[i]);
            }

            int[,] matrix = new int[3, 3]; // 2D array (3x3)
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            // ... and so on

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        }
    
        public static void StringType() {
            string message = "Hello!"; // Using ""
            string emptyString = ""; // Empty string
            string nullString = null; // Null reference
            string Name = "yami";
            string fullName = message + " " + Name;
            int strLength = fullName.Length;

            //Strings can be accessed using zero-based indexing:
            char firstChar = fullName[0]; // Access the first character (H)
            char lastChar = fullName[strLength - 1]; // Access the last character (i)

            // Convert to uppercase and lowercase
            string upper = fullName.ToUpper();
            string lower = fullName.ToLower();

            // Substring
            string sub = fullName.Substring(4, 5); // Gets "yami"

            // Replace
            string replaced = fullName.Replace("yami", "kyun");

            // Remove whitespace
            string trimmed = fullName.Trim();

            // Split
            string[] words = fullName.Split(' ');


            // You can compare strings using various methods:
            string str1 = "hello";
            string str2 = "Hello";
            bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // (true)  ignore upper and lower case

            // StringComparison.CurrentCulture: Uses the current culture's rules for string comparison.
            // StringComparison.CurrentCultureIgnoreCase: Uses the current culture's rules for case-insensitive string comparison.
            // StringComparison.InvariantCulture: Uses the invariant culture's rules for string comparison.
            // StringComparison.InvariantCultureIgnoreCase: Uses the invariant culture's rules for case-insensitive string comparison.
            // StringComparison.Ordinal: Performs a simple binary comparison without regard to culture or case.
            // StringComparison.OrdinalIgnoreCase: Performs a case-insensitive binary comparison without regard to culture.
        }
    }

}

