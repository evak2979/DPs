using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Command
{
    //Encapsulate a request as an object, thereby letting you parameterise clients with different requests, queye or log requests and support
    //undoable operations
    public class Radio
    {
        public const int MinVolume = 0;
        public const int MaxVolume = 10;
        public const int DefaultVolume = 5;
        private bool switchedOn;
        private int volume;

        public Radio()
        {
            switchedOn = false;
            volume = DefaultVolume;
        }

        public virtual bool On => switchedOn;

        public virtual int Volume => volume;

        public virtual void SwitchOn()
        {
            switchedOn = true;
            Console.WriteLine("Radio now on, volume level" + Volume);
        }

        public virtual void SwitchOff()
        {
            switchedOn = false;
            Console.WriteLine("Radio now off");
        }

        public virtual void VolumeUp()
        {
            if (On)
            {
                if (volume < MaxVolume)
                {
                    volume++;
                }
            }
        }

        public virtual void VolumeDown()
        {
            if (On)
            {
                if (volume > MinVolume)
                {
                    volume--;
                }
            }
        }
    }

    public class ElectricWindow
    {
        public bool Open { get; set; }

        public void OpenWindow()
        {
            Open = true;
        }

        public void CloseWindow()
        {
            Open = false;
        }
    }

    public interface IVoiceCommand
    {
        void Execute();
    }

    public class VolumeUpCommand : IVoiceCommand
    {
        private readonly Radio _radio;

        public VolumeUpCommand(Radio radio)
        {
            _radio = radio;
        }
        public void Execute()
        {
            _radio.VolumeUp();
        }
    }

    public class WindowOpenCommand : IVoiceCommand
    {
        private readonly ElectricWindow _window;

        public WindowOpenCommand(ElectricWindow window)
        {
            _window = window;
        }
        public void Execute()
        {
            _window.OpenWindow();
        }
    }
}
