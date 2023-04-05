using System;
using System.Collections.Generic;

namespace Vehicle_Security
{
    public class CommandDRCM : CommandBase
    {
        private Camera _camera;
        private Terminal _terminal;
        //private VideoSave _videoSave;

        public CommandDRCM(Camera camera, Terminal terminal)
        {
            _camera = camera;
            _terminal = terminal;

        }

        public override void Execute()
        {
            Sensor sensor = new Sensor();
            _terminal.Write("Sensor tripped - Door has sensed motion, recording in progress");
            sensor.EventTimeing(true);

        }

        public override string GetName()
        {
            return _camera.Set_Name();
        }

        public override int GetDevicePort()
        {
            return _camera.Set_Port();
        }

        public override bool GetDeviceStatus()
        {
            _camera._status = true;
            return _camera._status;
        }

        public override string GetHelp()
        {
            return $"{_camera.Set_Name}\tInternal Camera on Vehicle\n";
        }

    }


}