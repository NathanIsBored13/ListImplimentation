using System;

namespace ListImplimentation
{
    class Program
    {
        static void Main()
        {
            string input;
            bool exit = false;
            NList nList = new NList();
            do
            {
                Console.Write("> ");
                input = Console.ReadLine().ToLower();
                switch (input.Split(" ")[0])
                {
                    case "get":
                        Console.WriteLine(nList.Get(Convert.ToInt32(input.Split(" ")[1])));
                        break;
                    case "getlength":
                        Console.WriteLine(nList.GetLength());
                        break;
                    case "print":
                        Console.WriteLine($"[{string.Join(", ", nList.ToArray())}]");
                        break;
                    case "set":
                        nList.Set(Convert.ToInt32(input.Split(" ")[1]), Convert.ToInt32(input.Split(" ")[2]));
                        break;
                    case "add":
                        nList.Add(Convert.ToInt32(input.Split(" ")[1]));
                        break;
                    case "insert":
                        nList.Insert(Convert.ToInt32(input.Split(" ")[1]), Convert.ToInt32(input.Split(" ")[2]));
                        break;
                    case "remove":
                        nList.Remove();
                        break;
                    case "clear":
                        nList.Clear();
                        break;
                    case "removeat":
                        nList.RemoveAt(Convert.ToInt32(input.Split(" ")[1]));
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid command");
                        break;
                }
                Console.WriteLine();
            } while (!exit);
        }
    }
}