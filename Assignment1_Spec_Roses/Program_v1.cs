using System;

namespace Assignment1_Spec_Roses
{
    class Program
    {
        static double total_amount_1;
        static int Number_plant_1;
        const int N = 4;
        string[] name = new string[4];
        //list<string> name_list = new list<string>();
        static void Main(string[] args)
        {   
            Console.WriteLine("WELCOME TO VICTORY ROSES ONLINE!");
            for (int i = 0; i < N; i++) { 
            Console.WriteLine("");
            Console.Write("Enter customer name placing the order:");
            String Cutomer_name_1 = Console.ReadLine();
                //name.append(Cutomer_name_1);
            Console.WriteLine("");
            Console.Write("Enter type of the rose to order Standard (S) or Bush (B)?)");
            String Plant_type_1 = Console.ReadLine();
            Console.WriteLine("");
            do{
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
            } else { 
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
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            }
        }
    }
}
