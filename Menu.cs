using System;

namespace Bag
{
    class Menu
    {
        private Bags bg = new Bags();

        private static int MenuInput()
        {
            Console.WriteLine("\n********************************");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. OnlyOne");
            Console.WriteLine("4. Print");
            Console.WriteLine("****************************************");

            int n = Convert.ToInt32(Console.ReadLine());

            return n;
        }

        public void Run()
        {
            int num;
            do
            {
                num = MenuInput();
                switch(num)
                {
                    case 0:
                        Console.WriteLine("This system will be down");
                        break;
                    case 1:
                        PutIn();
                        break;
                    case 2:
                        RemoveList();
                        break;
                    case 3:
                        Only();
                        break;
                    case 4:
                        Print();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (num != 0);
        }

        private void PutIn()
        {
            Console.WriteLine("What element shall I add?");
            int element = Convert.ToInt32(Console.ReadLine());
            bg.Insert(element);
        }

        private void RemoveList()
        {
            Console.WriteLine("What element shall I remove?");
            int element = Convert.ToInt32(Console.ReadLine());
            bg.RemoveList(element);
        }

        private void Only()
        {
            int n = bg.OnlyOne();
            Console.WriteLine(n);
        }

        private void Print()
        {
            bg.Print();
        }
    }
}