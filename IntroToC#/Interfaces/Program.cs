namespace IntroToC_.Interfaces
{
    class Program
    {
        static void Main(string args)
        {
            IElectronicDevice TV = TvRemote.GetDevice();
            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();
        }
    }
}
