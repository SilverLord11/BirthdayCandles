using System;

namespace BirthdayCakeCandles
{
    class Program
    {

        static void Main(string[] args)
        {
            int numberOfCandles = 4;
            int[] heightOfCandles = new int[4] { 4, 4, 1, 3 };
            int candlesBlownOut = 0;

            if(heightOfCandles[0] == 4)
            {
                candlesBlownOut++;
            } 
            if (heightOfCandles[1] == 4)
            {
                candlesBlownOut++;
            }
            if (heightOfCandles[2] == 4)
            {
                candlesBlownOut++;
            }
            if (heightOfCandles[3] == 4)
            {
                candlesBlownOut++;
            }
            Console.Write("Number of candles: " + numberOfCandles + "\n");
            Console.Write("Number of candles blown out: " + candlesBlownOut);
        }
    }
}
