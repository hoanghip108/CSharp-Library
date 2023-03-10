using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minhanh
{
    public abstract class MenuProgram
    {
        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if(choice == 0) break;
            }
        }
        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);
        protected int GetChoice()
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}