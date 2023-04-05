namespace Vehicle_Security
{
    using System;
    using System.Timers;
    using System.Threading.Tasks;

    public class Device
    {
        protected int _port;
        public bool _status = false;
        protected string _deviceName = "";
        protected string _deviceType = "";

        public void Devices(){Device device = new Device();}
    }

    public class Camera : Device
    {
        //private string _FileType = "mp4?";
        private int _NameCount = 0;

        public string Set_Name()
        {
            _NameCount += 1;
            _deviceName = $"D{_NameCount}";
            return _deviceName;
        }

        public int Set_Port()
        {
            _port += 1;
            return _port;
        }

        public string Type()
        {
            _NameCount += 1;
            _deviceType = "camera";
            return _deviceType;
        }
    }

    public class Microphone : Device
    {
        //private string _FileType = "mp3?";
        private int _NameCount = 0;
        public string Set_Name()
        {
            _NameCount += 1;
            _deviceName = $"M{_NameCount}";
            return _deviceName;
        }
    }

    public class Sensor : Device
    {
        
        public bool EventTimeing(bool event_happened)
        {
            Terminal _terminal = new Terminal();
            Timer timer = new Timer(120000);
            _status = event_happened;

            /*do{*/
                if(_status == true)
                {
                    // reset timer whenever activated
                    timer.Start();
                }
                _terminal.Write("Recording finished \nsensor reset ");

            /*}while(event_happened == True    need to learn threading for this to work );*/

            _status = false;
            return _status;
        }

        public void EventReturn (ElapsedEventArgs e)
        {
            Console.WriteLine("The event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
        }
    }

    public class Door : Sensor
    {
        public string CarDoorsns()
        {
            _deviceName = "ds";
            return _deviceName;
        }
    }

        public class Hood : Sensor
    {
        public string CarHoodsns()
        {
            _deviceName = "hs";
            return _deviceName;
        }
    }

        public class Trunk : Sensor
    {
        public string CarTrunksns()
        {
            _deviceName = "ts";
            return _deviceName;
        }

    }

}