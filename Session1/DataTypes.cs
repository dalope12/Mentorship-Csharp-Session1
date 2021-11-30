using System;

namespace Session1
{
    class DataTypes
    {
        public static void dataTypesMethod()
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Integer numbers 10, 20, 30
            Int32 intNumber = 1;
            int intNumber2 = 2;

            Console.WriteLine("Hi, this is number1 variable: and this is not going to be a number" + intNumber);
            Console.WriteLine($"Hi, this is number2 variable: {intNumber2} and this is going to be another number 3");

            Console.ReadKey();


            // Double number with decimal 10.11, 20.25

            double doubleNumber = 10.22;
            Console.WriteLine($"Hi, this is doubleNumber: {doubleNumber}");
            Console.ReadKey();

            // Boolean: true, false, null

            Boolean booleanVariable = true;

            Console.WriteLine($"Hi, this is booleanVariable: {booleanVariable}");
            Console.ReadKey();

            // String 

            String stringVariable = "This is a training.";

            Console.WriteLine(stringVariable);
            Console.ReadKey();

        }
    }
}
