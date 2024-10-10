/*
Vazifa menejeri:
Vazifalarni boshqarish uchun dastur yozing. 
Foydalanuvchi vazifalarni qo'shishi, o'chirishi va bajarilganligini belgilashi kerak.
Dastur vazifalar ro'yxatini va ularning holatini saqlashi kerak.
 For loop, While loop yoki Forech-dan foydalaning, va Array yoki List-dan foydalaning.

*/
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
namespace Takrorlas
{
    class Program{
        static void Main(string[] args)
        {
            string[] task = new string[100];
            bool[] isCompleted = new bool[100];
            bool isWorking = true;
            int i = 1;
        
            System.Console.WriteLine("Vazifa qo'shish(+, Qo'shish, Yangi)\nVazifa o'chirish(-, o'chirish, olib tashlash, del, delete)");
            string userInput = Console.ReadLine().ToLower();
            if(userInput == "+" || userInput == "qoshish" || userInput == "qushish" || userInput == "qo'shish" || userInput == "qo`shish"){
                while(isWorking && i <= 100)
                {
                    System.Console.Write($"{i}-vazifa nomini kiriting: ");
                    task[i] = Console.ReadLine();
                    System.Console.Write("Yana vazifa kiritasizmi?(Ha/Yo'q) -> ");
                    string temp = Console.ReadLine().ToLower();
                    if(temp == "ha" || temp == "ga")
                    {
                        i++;
                        isWorking = true;
                        //temp = ""; // Qayta kelgan sikl shu shartni ichiga kirmasligi uchun
                    }
                    else if(temp == "yo'q" || temp == "yuq" || temp == "yoq")
                    {       
                            isWorking = false;
                            //temp = "";
                                             
                            System.Console.WriteLine("Sizning vazifalaringiz: ");
                            System.Console.WriteLine("Vazifa nomi\tVazifa holati");
                            for(int j = 1; j <= i; j++)
                            {
                                System.Console.Write($"{j}) " + task[j] + " => ");
                                if(isCompleted[j] == false)
                                {
                                    System.Console.WriteLine("bajarilmagan");
                                }
                                else{
                                    System.Console.WriteLine("bajarilgan");
                                }
                            }
                            //Vazifalarni ko'rsatish uchun
                            
                    }
                    else{
                        System.Console.WriteLine("Xatolik!. Dastur tugatildi.");
                        break;
                    }
                }
               
                //Vazifalarni boshqarish qismi:
               isWorking = true;
               while(isWorking)
               {
                    System.Console.WriteLine("Tahrirlash uchun vazifani tanlang(tartib raqami bo'yicha): ");
                    i = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine(task[i] +" - tanlandi. Qaysi parametrni o'zgartiramiz: \n 1) Nomi 2) \nBajarilganlik statusi ");
                    
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1: {
                            System.Console.WriteLine("Yangi nom kiritishingiz mumkin:");
                                break;
                        }
                        case 2: {
                            System.Console.WriteLine("Statusi bajarilgan(+) bo'lsa bajarilmagan(-) ishorasini kiriting: ");
                            switch(Convert.ToChar(Console.ReadLine())) {
                                case '+': {
                                    isCompleted[i] = true;
                                    System.Console.WriteLine("O'zgartirish muvaffaqiyatli amalga oshirildi.");
                                    break;
                                }
                                case '-':
                                {
                                    isCompleted[i] = false;
                                    System.Console.WriteLine("O'zgartirish muvaffaqiyatli amalga oshirildi.");
                                    // SHU SIKLNI WHILE BILAN ISHLA
                                    break;
                                }
                                default:
                                {
                                    System.Console.WriteLine("Xatolik. Hozirgi holat:");
                                    
                                    break;
                                }
                            }
                            break;
                        }
                        default: {
                            System.Console.WriteLine("Xatolik Dastur tugatildi:");
                            break;
                        }
                } 
                
            }   
        }
    }   
}
}