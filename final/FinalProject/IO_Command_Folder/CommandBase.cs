using System;
using System.Collections.Generic;

namespace Vehicle_Security
{
    public class CommandBase
    {
        //private Camera _camera;
        //private Terminal _terminal;
        //Yes I copy Pasted this from goal setter. 
        //Most of Command structure is mirrored from Goal setter
        public virtual void Execute()
        {
            throw new Exception("Execute not implemented in base class.");
        }

        public virtual string GetName()
        {
            throw new Exception("GetName not implemented in base class.");
        }

        public virtual int GetDevicePort()
        {
            throw new Exception("GetDevicePort not implemented in base class.");
        }

        public virtual bool GetDeviceStatus()
        {
            throw new Exception("GetDeviceStatus not implemented in base class.");
        }

        public virtual string GetHelp()
        {
            throw new Exception("GetDeviceStatus not implemented in base class.");
        }
    }


}