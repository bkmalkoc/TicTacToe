using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void Main(string[] args)
        {
            int playerIndexChoice = 0;
            char playerIcon;

            UpdateMatrix(arr);

            int starter = ChooseStarter();

            if (starter == 1){
                playerIndexChoice = ReadFromPlayer1();
                playerIcon = 'X';
            }
            else {
                playerIndexChoice = ReadFromPlayer2();
                playerIcon = 'Y';
            }

            ChangeVariableOnMatrix(playerIndexChoice, playerIcon);
            UpdateMatrix(arr);

            int winner = 0;
            int loopIndex = starter;

            do
            {
                if(loopIndex == 2)
                {
                    playerIndexChoice = ReadFromPlayer1();
                    playerIcon = 'X';
                    loopIndex = 1;
                }
                else
                {
                    playerIndexChoice = ReadFromPlayer2();
                    playerIcon = 'Y';
                    loopIndex = 2;
                }

                ChangeVariableOnMatrix(playerIndexChoice, playerIcon);
                UpdateMatrix(arr);

                winner = ChooseWinner();
                if(winner == 1)
                {
                    Console.WriteLine("Congrats Player" );
                    break;
                }
            } while (winner != 1);
            Console.ReadLine();
        }

        public static int ReadFromPlayer1()
        {
            string readLine = null;
            Console.WriteLine("Enter a coordinate for Player 1: ");
            readLine = Console.ReadLine();
            while (!IfTheNumberBetween1and10(readLine))
            {
                Console.WriteLine("Enter a proper coordinate ");
                readLine = Console.ReadLine();
            }
            return int.Parse(readLine);
        }

        public static int ReadFromPlayer2()
        {
            string readLine = null;
            Console.WriteLine("Enter a coordinate for Player 2: ");
            readLine = Console.ReadLine();

            while (!IfTheNumberBetween1and10(readLine))
            {
                Console.WriteLine("Enter a proper coordinate ");
                readLine = Console.ReadLine();
            }
            return int.Parse(readLine);
        }

        public static bool IfTheNumberBetween1and10(string input)
        {
            int num = 0;
            bool ifNum = Int32.TryParse(input, out num);
            if (ifNum)
            {
                int numm = int.Parse(input);
                if (numm > 0 && numm < 10)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static void UpdateMatrix(char[] arr)
        {
            Console.WriteLine("{0} {1} {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("{0} {1} {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("{0} {1} {2}", arr[7], arr[8], arr[9]);
        }

        public static void ChangeVariableOnMatrix(int input, char playerIcon)
        {
            if(arr[input] == 'X' || arr[input] == 'Y')
            {
                Console.WriteLine("Already chosen. Missed your chance");
            }
            else
            {
                arr[input] = playerIcon;
            }
        }

        public static int ChooseStarter()
        {
            Random random = new Random();
            int randomPlayer = random.Next(1, 3);
            return randomPlayer;
        }

        public static int ChooseWinner()
        {
            if(arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }

            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }

            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
