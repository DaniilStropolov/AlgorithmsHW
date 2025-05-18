namespace AlgorithmsHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("У вас есть премиум? (true/false): ");
            bool isPremiun = Convert.ToBoolean(Console.ReadLine());

            User user = new User(login, name, isPremiun);
            user.Greet();
            if (!user.IsPremium)
            {
                AdService.ShowAds();
            }
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

        public void Greet()
        {
            Console.WriteLine("\nПриветствую тебя, " + Name + "\n");
        }
    }

    class AdService
    {
        static public void ShowAds()
        {
            Console.WriteLine("\tПосетите наш новый сайт с бесплатными играми free.games.for.a.fool.com\n");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("\tКупите подписку на МыКомбо и слушайте музыку везде и всегда.\n");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("\tОформите премиум-подписку на наш сервис, чтобы не видеть рекламу\n");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}