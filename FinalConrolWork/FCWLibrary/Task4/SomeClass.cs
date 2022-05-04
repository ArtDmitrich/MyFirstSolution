using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCWLibrary.Task4
{
    public class SomeClass
    {
        private delegate void SomeDelegate();
        private event SomeDelegate Alarm;

        private static int counter = 0;
        public SomeClass()
        {
            Alarm += () => Console.WriteLine("Alarm"); // добавил после завершения контрольной
            //Alarm += AlarmMethod; убрал после завершения контролькой
        }
        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod");
            counter++;
            if (counter == 10) // написано в задаче после 10, а не каждые 10
            {
                Alarm.Invoke();
            }
        }
        //private void AlarmMethod()
        //{
        //    Console.WriteLine("AlarmMethod"); убрал после завершения контролькой
        //}
    }
}
