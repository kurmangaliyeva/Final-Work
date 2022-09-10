using System;

namespace Final_Work{
    class Program{
        static void Main(string[] args){


            String? yesNo = "";
            while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no"){
            Console.Write("Желаете вводить строки массива вручную? (yes/no): ");
            yesNo = Console.ReadLine();
            }

            string[] arrayOfStrings = new string[]  {};

            if (yesNo.ToLower() == "yes") {
            int n = InputNumbers("Введите количество элементов массива: ");
            arrayOfStrings = new string[n];
            for (int i = 0; i < arrayOfStrings.Length; i++){
                Console.Write($" Введите {i+1} строку: ");
                arrayOfStrings[i] = Console.ReadLine();
                }
            }
            
            else {
            arrayOfStrings = new string[]  {"hello", "2", "world", ":-)"};
            }





        }
    }
}
