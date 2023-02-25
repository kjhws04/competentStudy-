using System;

namespace Csharp
{
    class Program
    {
        enum srp
        {
            sci = 1,
            roc = 2,
            pap = 3
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int aichoice = rand.Next(0, 3);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)srp.sci:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case (int)srp.roc:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)srp.pap:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aichoice)
            {
                case (int)srp.sci:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case (int)srp.roc:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case (int)srp.pap:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            if (choice == aichoice)
                Console.WriteLine("비겼습니다.");
            else if (choice == (int)srp.sci && aichoice == (int)srp.pap)
                Console.WriteLine("이겼습니다.");
            else if (choice == (int)srp.roc && aichoice == (int)srp.sci)
                Console.WriteLine("이겼습니다.");
            else if (choice == (int)srp.pap && aichoice == (int)srp.roc)
                Console.WriteLine("이겼습니다.");
            else
                Console.WriteLine("패배했습니다.");
        }
    }
}
