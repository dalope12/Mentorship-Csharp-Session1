using System;

namespace Session1
{
    class Conditionals_and_flow
    {
        public static void conditionalsMethod()
        {
            int number1 = 10, number2 = 20, total = 0;
            double number3 = 10.0;

            total = number1 + number2;

            if (number1 == number3 && number2 == number1)
            {
                Console.WriteLine("You're right.");
            }
            else if (number2 == number1)
            {
                Console.WriteLine("You're not right.2");
            }
            else
            {
                Console.WriteLine("You're not right.3");
            }


            switch (total)
            {
                case 15:
                    Console.WriteLine("You're right.1");
                    break;
                case 20:
                    Console.WriteLine("You're right.2");
                    break;
                case 25:
                    Console.WriteLine("You're right.3");
                    break;
                case 30:
                    Console.WriteLine("You're right.4");
                    break;
                case 10:
                    Console.WriteLine("You're right.5");
                    break;
                default:
                    Console.WriteLine("You're not right.6");
                    break;
            }
        }

        public static void conditionalLoops()
        {
            String text1 = "hi";
            int count = 0;
            
            // while
            while (text1=="hi" && count <= 2)
            {
                Console.WriteLine("You're right. " + count);
                count++;
                //count = count + 1;
            }

            Console.WriteLine("-----");

            // for
            for (int i=3; i > 0; i--)
            {
                Console.WriteLine("You're right. " + i);
            }

            // do while
            do
            {
                Console.WriteLine("You're right. ");
                text1 = "hi2";
            } while (text1 == "hi");

            count = 0;
            text1 = "hi";

            do
            {
                Console.WriteLine("You're right. "+count);
                count++;
            } while (text1 == "hi" && count <= 2);
        }
    }
}
