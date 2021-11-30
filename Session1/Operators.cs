using System;

namespace Session1
{
    class Operators
    {
        public static void operatorsMethod()
        {
            int number1 = 10, number2 = 20, total =0;
            double number3 = 10.0;

            total = number1 + number2;
            Console.WriteLine("The total is " + total);

            String text1 = "Hi there", text2 = ", how are you ?", total2= "";

            total2 = text1 + text2;

            Console.WriteLine(total2);

            Console.WriteLine(number1 != number2);
            Console.WriteLine("break 1 ");
            Console.WriteLine(number1 == number3);
            Console.WriteLine("break 2");

            if (number1 == number3 && number2 != number1)
            {
                Console.WriteLine("You're right. 1");
            }

            Console.WriteLine(number1=number2);

            if(number1 == number3 || number2 == number1)
            {
                Console.WriteLine("You're right. 2");
            }

        }
    }
}
