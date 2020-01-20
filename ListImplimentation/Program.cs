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
                    case "isempty":
                        Console.WriteLine(nList.IsEmpty());
                        break;
                    case "get":
                        Console.WriteLine(nList.Get(Convert.ToInt32(input.Split(" ")[1])));
                        break;
                    case "search":
                        Console.WriteLine(nList.Search(Convert.ToInt32(input.Split(" ")[1])));
                        break;
                    case "index":
                        Console.WriteLine(nList.Index(Convert.ToInt32(input.Split(" ")[1])));
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
                    case "pop":
                        nList.Pop();
                        break;
                    case "popat":
                        nList.Pop(Convert.ToInt32(input.Split(" ")[1]));
                        break;
                    case "remove":
                        nList.Remove(Convert.ToInt32(input.Split(" ")[1]));
                        break;
                    case "clear":
                        nList.Clear();
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