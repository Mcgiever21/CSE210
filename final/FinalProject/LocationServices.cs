namespace Vehicle_Security
{
 using System;
 using System.IO;
 using System.Collections.Generic;

class LocationServices
 {
    private string _Location = "";
    protected string Get_GPS(string pin_reciever)
    {
        _Location = pin_reciever;
        return pin_reciever;

    }
 }   
}