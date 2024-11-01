using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test12._1._5
{
    class Controller
    {
        public List<User> UserList;
        public Controller()
        {
            UserList = new List<User>();
            int CountUsers = 0;
            do
            {
                Console.WriteLine("Ведите количество пользователей: \n");
                string LiteralCountUsers = Console.ReadLine();
                int.TryParse(LiteralCountUsers, out CountUsers);

            }
            while (!(CountUsers > 0));
            
            FillListUsers(CountUsers);
            foreach (var user in UserList)
                HelloUser(user);
            
            Console.ReadKey();
        }
        public void FillListUsers(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Ведите логин {i+1}-го пользователя: ");
                string LoginUser = Console.ReadLine();
                Console.WriteLine($"Ведите имя {i + 1}-го пользователя: ");
                string NameUser = Console.ReadLine();
                Console.WriteLine($"Статус {i + 1}-го пользователя (премиум-подписка, yes/no): ");
                string Prem = Console.ReadLine();
                bool IsPremium = Prem == "yes";
                UserList.Add(new User(LoginUser, NameUser, IsPremium));
            }
        }

        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        public void HelloUser(User user)
        {
            if (user != null)
            {
                string premium = "Нет";
                if (user.IsPremium)
                    premium = "Да";
                
                Console.WriteLine($"Привет {user.Name} Логин: {user.Login} Статус подписки: {premium} ");
                if (!user.IsPremium)
                    ShowAds();
            }
        }
    }
}