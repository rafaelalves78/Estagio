using System;

namespace HerancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "Combo device scan result";
        }
    }
}
