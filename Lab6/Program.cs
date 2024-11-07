// See https://aka.ms/new-console-template for more information

using Lab6.auth;
using Lab6.Email;
using Lab6.register;

Console.WriteLine($"Hello, World!");

while (true)
{
    if (CurrentUser.currentUsername == null)
    {
        Console.WriteLine("1. Войти");
        Console.WriteLine("2. Зарегистрироваться");
        Console.WriteLine("0. Выход");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Введите имя ");
                var name = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var password = Console.ReadLine();
                if (password != null)
                    if (name != null)
                        Console.WriteLine(Auth.login(name, password));
                break;
            case "2":
                Console.WriteLine("Введите имя ");
                var name1 = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var password1 = Console.ReadLine();
                if (password1 != null)
                    if (name1 != null)
                        Console.WriteLine(Register.register(name1, password1));
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                break;
        }
    }
    else
    {
        Console.WriteLine($"Добро пожаловать, {CurrentUser.currentUsername}!");
        Console.WriteLine("1. Отправить сообщение");
        Console.WriteLine("2. Прочитать сообщения");
        Console.WriteLine("3. Выйти");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Введите кому ");
                var to = Console.ReadLine();
                Console.WriteLine("Введите сообщение ");
                var message = Console.ReadLine();
                if (to != null)
                    if (message != null)
                        Console.WriteLine(EmailSender.sendEmail(to, message));
                break;
            case "2":
                EmailReader.readEmail()?.ForEach(Console.WriteLine);
                break;
            case "3":
                CurrentUser.currentUsername = null; // Выход из аккаунта
                break;
            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                break;
        }
    }
}