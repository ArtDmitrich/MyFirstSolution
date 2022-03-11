namespace Lesson8Library
{
    public class Room
    {
        private string Name { get; }
        private Printer? Printer { get; set; }
        
        public Room (string name, Printer printer)
        {
            Name = name;
            Printer = printer;
        }
        public Room(string name)
        {
            Name = name;
        }
        public void SetPrinterInThisRoom (Printer printer)
        {
            this.Printer = printer;
        }
        public void MakeThisLazyPrinterWork(string value)
        {
            if (Printer == null)
            {
                this.PrinterNullError();
                return;
            }

            this.Printer.Print(value);
        }
        public override string ToString()
        {
            if (Printer == null)
            {
                return $"{this.Name} без принтера";
            }

            return $"{this.Name} с {Printer}";
        }

    }
}