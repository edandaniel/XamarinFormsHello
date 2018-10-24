using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsHello
{
    class MyConfiguration
    {
        public MyConfiguration()
        {
            this.Cookies = this.Email = true;
        }
        public bool Track { get; set; }
        public bool Cookies { get; set; }
        public bool Board { get; set; }
        public bool Email { get; set; }
        public bool Sms { get; set; }

    }
}
