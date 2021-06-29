using System;
using System.Collections.Generic;
using System.Text;

namespace ImageShareApp
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Whatsapp _messenger = new Whatsapp();
            Image _gallery1 = new Image(_messenger);
            _gallery1.Share();

            Gmail _mailaccount = new Gmail();
            Image _gallery2 = new Image(_mailaccount);
            _gallery2.Share();

            Bluetooth _device = new Bluetooth();
            Image _gallery3 = new Image(_device);
            _gallery3.Share();


        }

    }
}
