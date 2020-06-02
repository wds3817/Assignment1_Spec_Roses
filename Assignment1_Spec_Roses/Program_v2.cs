using System;

namespace Assignment1_Spec_Roses
{
    class Program
    {
        static double total_amount_1;
        static int Number_plant_1;
        const int N = 4;

        static void Main(string[] args)
        {

            //array to store the information
            String[] Customer_Names = new String[N];
            String[] Plant_types = new String[N];
            int[] Plant_numbers = new int[N];
            double[] Order_prices = new double[N];

            //record the lowest and higest information
            String highest_customer_name = "";
            double highest_order_cost = 0.0;
            String lowest_customer_name = "";
            double lowest_order_cost = 0.0;

            Console.WriteLine("WELCOME TO VICTORY ROSES ONLINE!");

            Console.WriteLine("");

            Console.WriteLine("<<<NOTICE: You need to input " + N + "(=N) datasets>>>");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("This is the #" + (i + 1) + " customer");
                Console.Write("Enter customer name placing the order:");
                String Cutomer_name_1 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter type of the rose to order Standard (S) or Bush (B)?)");
                String Plant_type_1 = Console.ReadLine();
                Console.WriteLine("");
                do
                {
                    Console.Write("Enter number of plants:");
                    Number_plant_1 = Convert.ToInt32(Console.ReadLine());
                    if (Number_plant_1 < 20 || Number_plant_1 > 200)
                    {
                        Console.Error.WriteLine("The number of plants should be at least 20 and at most 200");
                    }
                    continue;
                } while (Number_plant_1 < 20 || Number_plant_1 > 200);
                if (Plant_type_1 == "S" || Plant_type_1 == "s")
                {
                    if (Number_plant_1 >= 20 && Number_plant_1 < 50)
                    {
                        total_amount_1 = Number_plant_1 * 15.0 * 1.2;
                    }
                    else if (Number_plant_1 >= 50 && Number_plant_1 < 100)
                    {
                        total_amount_1 = Number_plant_1 * 12.50 * 1.2;
                    }
                    else if (Number_plant_1 > 100)
                    {
                        total_amount_1 = Number_plant_1 * 10.00 * 1.2;
                    }
                }
                else
                {
                    if (Number_plant_1 >= 20 && Number_plant_1 < 50)
                    {
                        total_amount_1 = Number_plant_1 * 15.0;
                    }
                    else if (Number_plant_1 >= 50 && Number_plant_1 < 100)
                    {
                        total_amount_1 = Number_plant_1 * 12.50;
                    }
                    else if (Number_plant_1 > 100)
                    {
                        total_amount_1 = Number_plant_1 * 10.00;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Order total for Garden Galore is " + "$" + total_amount_1);

                // set the results to the arrays
                Customer_Names[i] = Cutomer_name_1;
                Plant_types[i] = Plant_type_1;
                Plant_numbers[i] = Number_plant_1;
                Order_prices[i] = total_amount_1;

                //check high/low data
                if (i == 0) {
                    highest_order_cost = total_amount_1;
                    highest_customer_name = Cutomer_name_1;
                    lowest_order_cost = total_amount_1;
                    lowest_customer_name = Cutomer_name_1;
                }
                if (total_amount_1> highest_order_cost) {
                    highest_order_cost = total_amount_1;
                    highest_customer_name = Cutomer_name_1;
                }
                if (total_amount_1 < lowest_order_cost) {
                    lowest_order_cost = total_amount_1;
                    lowest_customer_name = Cutomer_name_1;
                }

                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            }


            // print out summary
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("Name\t\t" + "Numbers of Plants\t\t" + "Bush or Standard\t\t" + "Order Total\t\t");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(Customer_Names[i] + "\t"+ Plant_numbers[i]+"\t"+ Plant_types[i]+"\t"+ Order_prices[i]);
                
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Rose order with highest order cost by customer "+ highest_customer_name + " for " + highest_order_cost);
            Console.WriteLine("Rose order with lowest order cost by customer " + lowest_customer_name + " for " + lowest_order_cost);
            Console.ReadLine();
        }
    }
}
