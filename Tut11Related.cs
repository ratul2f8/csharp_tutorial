using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
   interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
    interface ICommand
    {
        void Execute();
        void Undo();
    }
    class PowerButton : ICommand
    {
        IElectronicDevice device;
        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
    class Television : IElectronicDevice
    {
        public int Volume { get; set; } = 0;
        public void Off()
        {
            Console.WriteLine("The TV is OFF");
        }

        public void On()
        {
            Console.WriteLine("The TV is ON");
        }

        public void VolumeDown()
        {
            if(Volume > 0)
            {
                Volume--;
                Console.WriteLine($"Volume of the TV is now : {Volume}");
            }
        }

        public void VolumeUp()
        {
            if (Volume < 100)
            {
                Volume++;
                Console.WriteLine($"Volume of the TV is now : {Volume}");
            }
        }
    }
    class TVRemote
    {
       public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
