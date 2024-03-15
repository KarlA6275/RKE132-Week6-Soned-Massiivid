string[] snacks = {"mysushi", "pizzakiosk", "rääguburger", "doner kebab", "chopsticks nr. 17"};

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Täna me sööme {snacks[randomIndex]}");
