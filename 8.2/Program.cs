using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2
{
    class DialTelephone
    {
        public bool disk { get; set; }
    }

    class PushButtonTelephone : DialTelephone
    {
        public bool button { get; set; }
        public bool display { get; set; }
    }

    class MobilePhone : PushButtonTelephone
    {
        public bool color { get; set; }
        public bool vibration { get; set; }
        public bool bluetooth { get; set; }
        public int Sim { get; set; }
    }

    class ColorMobilePhone : MobilePhone
    {
        public bool speakerphone { get; set; }
        public int CameraMP { get; set; }
    }

    class iPhone : ColorMobilePhone
    {
        public int touchscreen { get; set; }
        public bool WiFi { get; set; }
        public string GPRS { get; set; }
        public int cameras { get; set; }
    }

    class GoogleGlass : iPhone
    {
        public int SecondCameraMP { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DialTelephone tel1 = new DialTelephone();
            tel1.disk = true;
            PushButtonTelephone tel2 = new PushButtonTelephone();
            tel2.disk = false;
            tel2.button = true;
            tel2.display = false;
            MobilePhone tel3 = new MobilePhone();
            tel3.disk = false;
            tel3.button = true;
            tel3.display = true;
            tel3.Sim = 1;
            tel3.bluetooth = true;
            tel3.color = false;
            tel3.vibration = true;
            ColorMobilePhone tel4 = new ColorMobilePhone();
            tel4.disk = false;
            tel4.button = true;
            tel4.display = true;
            tel4.Sim = 2;
            tel4.bluetooth = true;
            tel4.color = true;
            tel4.vibration = true;
            tel4.speakerphone = true;
            tel4.CameraMP = 1;
            iPhone tel5 = new iPhone();
            tel5.disk = false;
            tel5.button = true;
            tel5.display = true;
            tel5.Sim = 1;
            tel5.bluetooth = true;
            tel5.color = true;
            tel5.vibration = true;
            tel5.speakerphone = true;
            tel5.cameras = 1;
            tel5.CameraMP = 2;
            tel5.touchscreen = 5;
            tel5.WiFi = true;
            tel5.GPRS = "2G";
            GoogleGlass tel6 = new GoogleGlass();
            tel6.disk = false;
            tel6.button = false;
            tel6.display = true;
            tel6.Sim = 2;
            tel6.bluetooth = true;
            tel6.color = true;
            tel6.vibration = true;
            tel6.speakerphone = true;
            tel6.cameras = 2;
            tel6.CameraMP = 13;
            tel6.SecondCameraMP = 8;
            tel6.touchscreen = 10;
            tel6.WiFi = true;
            tel6.GPRS = "4G";


        }
    }
}
