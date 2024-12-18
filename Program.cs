class Program
{
    static void Main()
    {
        List<string> works = new List<string>();
        while (true)
        {
            Console.WriteLine("To-Do");
            Console.WriteLine("[1] View Tasks");
            Console.WriteLine("[2] Add Tasks");
            Console.WriteLine("[3] Remove Tasks");
            Console.WriteLine("[4] Exit");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice > 0 && userChoice < 5 && (userChoice is int))
            {
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Tasks");
                        foreach(var trampo in works)
                        {
                            if (trampo.Length == 0)
                            {
                                Console.WriteLine("Today, you don't have any tasks.");
                            }
                            Console.WriteLine(trampo.Length);
                            Console.WriteLine(trampo);
                        }
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter the name of the task you want to add: ");
                        var work = Console.ReadLine();
                        if (work != null && (!(works.Contains(work)))) {
                            works.Add(work);
                        }
                        else
                        {
                            continue;
                        }
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter the name of the task you want to remove: ");
                        work = Console.ReadLine();
                        if (work != null && works.Contains(work))
                        {
                            works.Remove(work);
                            Console.WriteLine("Task removed");
                        }
                        else
                        {
                            Console.WriteLine("This task does not exist.");
                            continue;
                        }
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Good bye");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Opção invalida, escolha uma das opções de 1 a 4");
            }
        }

    }
}