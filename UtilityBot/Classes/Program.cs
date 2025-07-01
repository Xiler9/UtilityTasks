using System;
using UtilityBot.Classes;

namespace VoiceTexterBot
{
    public class Program
    {
        public static void Main()
        {
            //Создание массива и заполнение его данными
            List<User> users = new List<User>();
            User user1 = new User();
            user1.IsPremium = false;
            user1.Login = "user";
            users.Add(user1);
            User user2 = new User();
            user2.IsPremium = true;
            user2.Login = "gun";
            users.Add(user2);
            //заполнение имени каждого пользователя и выставление рекламы
            foreach (User user in users) 
            {
                Console.WriteLine($"{user.Login}, введите ваше имя:");
                user.Name = Console.ReadLine();
                if (!user.IsPremium)
                {
                    User.ShowAds();
                }
            }
        }
    }
}