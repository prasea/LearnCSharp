namespace IntroToC_.Interfaces
{
    class TvRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
