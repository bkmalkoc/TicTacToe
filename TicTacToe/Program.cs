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
            Console.WriteLine("Enter a coordinate for Player1: ");
            int readLine = int.Parse(Console.ReadLine());
            return readLine;
        }

        public static int ReadFromPlayer2()
        {
            Console.WriteLine("Enter a coordinate for Player 2: ");
            int readLine = int.Parse(Console.ReadLine());
            return readLine;
        }

        //public static void CreateXYMatrix()
        //{
        //    const int MATRIX_ROWS = 3;
        //    const int MATRIX_COLUMNS = 3;

        //    int inputX = 0;
        //    int inputY = 0;

        //    double[,] matrix = new double[MATRIX_ROWS, MATRIX_COLUMNS];
            
            


        //    for (int i = 0; i < MATRIX_ROWS; i++)
        //    {
        //        for (int j = 0; j < MATRIX_COLUMNS; j++)
        //        {
        //            Console.Write("Enter value for ({0},{1}): ", i, j);
        //            string input = Console.ReadLine();
        //            int intInput = 0;

        //            if(input == "" || input == null)
        //            {
        //                input = "0";
        //                intInput = int.Parse(input);
        //                matrix[i, j] = intInput;
        //            }
        //            intInput = int.Parse(input);
        //            matrix[i, j] = intInput;
        //        }
        //    }

        //    for(int i = 0; i < MATRIX_ROWS; i++)
        //    {
        //        for (int y = 0; y < MATRIX_COLUMNS; y++)
        //        {
        //            Console.Write(matrix[i,y] + " ");
        //        }
        //        Console.WriteLine(" ");
        //    }
        //}
        
        public static void UpdateMatrix(char[] arr)
        {
            Console.WriteLine("{0} {1} {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("{0} {1} {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("{0} {1} {2}", arr[7], arr[8], arr[9]);
        }

        public static void ChangeVariableOnMatrix(int input, char playerIcon)
        {
            char choosenIndex = arr[input];
            arr[input] = playerIcon;
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
