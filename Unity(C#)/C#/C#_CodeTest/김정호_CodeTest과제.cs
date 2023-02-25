using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static char[,] arr = new char[4, 4]
        {
            { '1', '1', '1', '2' },
            { '1', '9', '1', '2' },
            { '1', '8', '9', '2' },
            { '1', '2', '3', '4' }
        };

        static void Main(string[] args)
        {
            // 1번 문제
            //solution1();

            // 2번 문제
            //solution2();

            // 3번 문제
            //solution3();
        }

        #region no.1
        /// <summary>
        /// 1번 괄호 쌍 문제
        /// </summary>
        static IList<string> solution1()
        {
            Console.WriteLine("괄호 쌍의 개수 n을 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            string text = "";
            MakeParen(n, n, text);
            List<string> answer = new List<string>();
            foreach (var t in data)
            {
                answer.Add(t);
            }
            answer.Reverse();

            foreach (var i in answer)
            {
                Console.WriteLine(i);
            }
            return answer;
        }

        static Stack<string> data = new Stack<string>();

        static void MakeParen(int left, int right, string paren)
        {
            if (left == 0 && right == 0)
            {
                data.Push(paren);
            }
            if (left > 0)
            {
                MakeParen(left - 1, right, paren + '(');
            }
            if (right > 0 && left < right)
            {
                MakeParen(left, right - 1, paren + ')');
            }
        }
        #endregion

        #region no.2
        /// <summary>
        /// 2번 문자열 수식 계산 문제
        /// </summary>
        static string solution2()
        {
            Console.WriteLine("수식을 입력하세요 : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            double[] arrNum = new double[str.Length];
            char[] arrOp = new char[str.Length];
            int numCnt = 0;
            int opCnt = 0;

            double resultCalc = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if ((arr[i] >= '0') && (arr[i] <= '9')) 
                {
                    arrNum[numCnt] = double.Parse(arr[i].ToString());  
                }
                else 
                {
                    numCnt++; 
                    arrOp[opCnt++] = arr[i]; 
                }
            } 

            for (int i = 0; i < opCnt; i++)
            {
                switch (arrOp[i])
                {
                    case '*':
                        arrNum[i + 1] = arrNum[i] * arrNum[i + 1];
                        arrNum[i] = 0;
                        arrOp[i] = '+';
                        break;
                    case '/':
                        if (arrNum[i + 1] == 0)
                        {
                            Console.WriteLine("Impossible");
                            return "Impossible";
                        }
                        arrNum[i + 1] = arrNum[i] / arrNum[i + 1];
                        arrNum[i + 1] = Math.Truncate(arrNum[i + 1]);
                        arrNum[i] = 0;
                        arrOp[i] = '+';
                        break;
                }
            }

            for (int i = 0; i < opCnt; i++)
            {
                switch (arrOp[i])
                {
                    case '+':
                        arrNum[i + 1] = arrNum[i] + arrNum[i + 1];
                        break;

                    case '-':
                        arrNum[i + 1] = arrNum[i] - arrNum[i + 1];
                        break;
                }
                resultCalc = arrNum[i + 1];
            }
            Console.WriteLine(resultCalc);
            return $"{resultCalc}";
        }
        #endregion

        #region no.3
        /// <summary>
        /// 3번 cavity
        /// </summary>
        static char[,] solution3(char[,] data)
        {
            Console.WriteLine("N을 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    if (data[i, j] > data[i, j - 1] && data[i, j] > data[i, j + 1] &&
                        data[i, j] > data[i - 1, j] && data[i, j] > data[i + 1, j])
                    {
                        data[i, j] = char.Parse("X");
                    }
                }
            }
            return data;
        }
        #endregion
    }
}
