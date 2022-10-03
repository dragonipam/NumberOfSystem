using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSV_Color__LAB3
{
    public class Color
    {
        private int HUE;
        private byte saturation;
        private byte value;
        public Color(int HUE, byte saturation, byte value)
        {
            this.HUE=HUE;
            this.saturation = saturation;
            this.value=value;
        }
        //x is >= 0 and <= 100
        public string Print()
        {
            return String.Format("{0} {1} {2}", this.HUE, this.saturation, this.value);
        }
        public static Color operator +(Color instance, int number)
        {
            var newValue = instance.HUE + number;
            var color = new Color(newValue, instance.saturation, instance.value);
            return color;
        }
        public static Color operator +(int number, Color instance)
        {
            return instance + number;
        }
    }
}
