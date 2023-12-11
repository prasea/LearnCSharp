namespace IntroToC_.Interfaces
{
    class VolumeButton : ICommand
    {
        IElectronicDevice _device;
        public VolumeButton(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeUp();
        }

        public void Undo()
        {
            _device.VolumeDown();
        }
    }
}
