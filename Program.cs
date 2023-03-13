using System;
    class Program
    {
        class WhileLoop
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day of week: ");
            int day = Convert.ToInt32(Console.ReadLine());
           
            if (day == 1){
                Console.WriteLine("Monday");
            }
            else if (day == 2){
                Console.WriteLine("Tuesday");
            }
            else if (day == 3){
                Console.WriteLine("Wednesday");
            }
            else if (day == 4){
                Console.WriteLine("Thursday");
            }
            else if (day == 5){
                Console.WriteLine("Friday");
            }
            else if (day == 6){
                Console.WriteLine("Saturday");
            }
            else if (day == 7){
                Console.WriteLine("Sunday");
            }

            Console.WriteLine("Enter time of day: ");
            int time = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Enter menu (breakfastset, weekendset or coffee): ");
            string menu = Console.ReadLine();

            if (menu == "breakfastset")
            {
                if (time > 11.00 ){
                    Console.Write("sorry your order is out of stock");
                }
                
            }
            else if (menu == "weekendset")
            {
                if (day < 6){
                    Console.Write("Sorry your order is not available");
                }
                 Console.WriteLine("Enter menu again: ");
                 Console.ReadLine();
            }

            else if ( menu != "weekendset, breakfastset, coffee")
            {
            Console.Write("Please enter a valid menu");
            }

        

        }
        }
    }