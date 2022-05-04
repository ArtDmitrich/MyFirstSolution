using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OneLine
    {
        public int PositionFromTop { get; set; }
        public int PositionFromLeft { get; set; }
        public int MaxColumnLength { get; set; }
        private string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private int textLength;
        private object block = new object();
        Mutex mutex = new Mutex();
        private static Random random = new Random();
        public OneLine(int positionFromLeft, int maxColumnLength, int textLength, object block)
        {
            PositionFromLeft = positionFromLeft;
            MaxColumnLength = maxColumnLength;
            this.textLength = textLength;
            this.block = block;
        }
        private char GetRandomChar()
        {
            return text[random.Next(text.Length)];
        }
        private async Task PrintLine(int lineLength)
        {
            var curentTopPosition = PositionFromTop;

            if (curentTopPosition > 0)
            {
                lock (block)
                {
                    //mutex.WaitOne();
                    Console.SetCursorPosition(PositionFromLeft, curentTopPosition - 1);
                    Console.Write(' ');
                    //mutex.ReleaseMutex();
                }
            }
            for (int i = 0; i < lineLength; i++)
            {
                lock (block)
                {
                    //mutex.WaitOne();
                    Console.SetCursorPosition(PositionFromLeft, curentTopPosition);
                    Console.Write(GetRandomChar());
                    //mutex.ReleaseMutex();
                }
                curentTopPosition++;
                await Task.Delay(10);
            }
        }
        public Task StartMoveLine()
        {
            var temp = Task.Run(async () =>
            {
                var counter = 0;                
                do
                {
                    var length = textLength;

                    if (PositionFromTop == MaxColumnLength)
                    {
                        PositionFromTop = 0;
                        counter = 0;                        
                    }
                    else if (PositionFromTop + textLength >= MaxColumnLength)
                    {
                        counter++;
                        length -= counter;
                    }
                    await PrintLine(length);
                    await Task.Delay(50);

                    PositionFromTop++;
                } while (true);
            });
            return temp;
        }
    }
}
