using System;

namespace Final_Work{
    class Program{
        static void Main(string[] args){


            String? yesNo = "";
            while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no"){
            Console.Write("Желаете вводить строки вручную? (yes/no): ");
            yesNo = Console.ReadLine();
            }





        }
    }
}
