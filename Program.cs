/*
Vazifa menejeri:
Vazifalarni boshqarish uchun dastur yozing. 
Foydalanuvchi vazifalarni qo'shishi, o'chirishi va bajarilganligini belgilashi kerak.
Dastur vazifalar ro'yxatini va ularning holatini saqlashi kerak.
 For loop, While loop yoki Forech-dan foydalaning, va Array yoki List-dan foydalaning.

*/
//Tartiblashda Githubdan https://github.com/alexeykrymov/ToDo-List-in-C-/blob/main/Program.cs foydalanildi. 
//2-3 marotaba o'z kodimga o'ralib qoldim. :)
using System;
namespace Takrorlash
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            string[] taskName = new string[10];
            int i = 1;
            bool[] isCompleted = new bool[10];
            for(int x = 0; x < 10; x++)
            {
                isCompleted[x] = false;
            }

            while(isWorking)
            {
                System.Console.WriteLine("1) Vazifa qo'shish");
                System.Console.WriteLine("2) Vazifani bajarilgan deb belgilash");
                System.Console.WriteLine("3) Vazifalar ro'yxati");
                System.Console.WriteLine("4) Vazifani tahrirlash");
                System.Console.WriteLine("5) Chiqish");

                int option = Convert.ToInt32(Console.ReadLine());

                switch(option) 
                {
                    case 1:
                    {
                        System.Console.WriteLine("Vazifa nomini kiriting: ");
                        taskName[i] = Console.ReadLine();
                        i++;
                        System.Console.WriteLine("Vazifa jadvalga qo'shildi.");
                        Console.Clear();   
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Vazifalar ro'yxati:");
                        for(int j = 1; j < i; j++)
                        {
                            Console.WriteLine( j + ") "+ taskName[j] + " - " + (isCompleted[j] ? "bajarilgan" : "bajarilmagan"));
                        }
                         System.Console.WriteLine("Bajarilgan belgisini qo'yish uchun vazifa raqamini kiriting:");
                         int taskNumber = Convert.ToInt32(Console.ReadLine());
                         if(taskNumber <= i)
                         {
                            isCompleted[taskNumber] = true;
                         }
                         else{
                            System.Console.WriteLine("Xato qiymat kiritildi.");
                         }
                         break;
                    }  
                                 
                    case 3:
                    {
                        for(int j = 1; j < i; j++)
                        {
                             Console.WriteLine( j + ") "+ taskName[j] + " - " + (isCompleted[j] ? "bajarilgan" : "bajarilmagan"));
                        }
                        break;
                    }     
                    case 4:
                    {
                        System.Console.WriteLine("Nomini o'zgartirmoqchi bo'lgan vazifani tanlang: ");
                        for(int j = 1; j < i; j++)
                        {
                             Console.WriteLine( j + ") "+ taskName[j]);
                        }
                        int tempOption = Convert.ToInt32(Console.ReadLine());
                        if(tempOption < i)
                        {
                            System.Console.Write($"{tempOption} - ");
                            taskName[tempOption] = Console.ReadLine(); 
                        }
                        break;
                    }     
                    case 5:
                    {
                        isWorking = false;
                        break; 
                    }
                }
             
            }
        }
    }
}