namespace Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> agenda;
            agenda = new List<String>();
            agenda.Add("11 12345678");
            agenda.Add("11 23456789");
            agenda.Add("11 34567890");
            Celular celular1;
            celular1 = new Celular(EMarca.Samsumg, "J7", 8, 64, agenda);
            Console.WriteLine(celular1.AlternarEncendido());            
        }
    }
}