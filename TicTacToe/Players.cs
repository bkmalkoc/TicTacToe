using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Players : IPlayer
    {

        public int ReadFromPlayer(Player player)
        {
            string readLine = null;
            readLine = Console.ReadLine();
            while (!IfTheNumberBetween1and10(readLine))
            {
                Console.WriteLine("Enter a proper coordinate ");
                readLine = Console.ReadLine();
            }
            return int.Parse(readLine);
        }

        public bool IfTheNumberBetween1and10(string input)
        {
            int num = 0;
            bool ifNumIsInt = Int32.TryParse(input, out num);
            if (ifNumIsInt)
            {
                int numm = int.Parse(input);
                if (numm > 0 && numm < 10)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
