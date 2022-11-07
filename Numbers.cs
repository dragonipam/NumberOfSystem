using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem2
{
    public enum SystemOfNumber { two, eight, ten, sixteen };
    public class Numbers
    {
        private int value;
        private SystemOfNumber system;
        public Numbers(int value, SystemOfNumber system)
        {
            this.value = value;
            this.system = system;
        }
        public string Verbose()
        {
            string systemVerbose = "";
            switch (this.system)
            {
                case SystemOfNumber.two:
                    systemVerbose = "2";
                    break;
                case SystemOfNumber.eight:
                    systemVerbose = "8";
                    break;
                case SystemOfNumber.ten:
                    systemVerbose = "10";
                    break;
                case SystemOfNumber.sixteen:
                    systemVerbose = "16";
                    break;
            }
            return String.Format("{0} {1}", this.value, systemVerbose);
        }
        //Перевод из любой в 10 систему
        public static int ConvertToTen(int number)
        {
            return Convert.ToInt32(Convert.ToString(number, 10));
        }
        //Перевод из 10 системы в любую
        public static int ConvertToOut(int number, int system)
        {
            return Convert.ToInt32(Convert.ToString(number, system));
        }
        // сложение
        public static Numbers operator +(Numbers instance, int number)
        {
            int val1 = number;
            if (Convert.ToInt32(instance.system) != 10)
            {
                int syst = Convert.ToInt32(instance.system);
                val1 = ConvertToTen(number);
            }
            return new Numbers(instance.value + val1, instance.system);
        }

        public static Numbers operator +(int number, Numbers instance)
        {
            int val1 = number;
            if (Convert.ToInt32(instance.system) != 10)
            {
                int syst = Convert.ToInt32(instance.system);
                val1 = ConvertToTen(number);
            }
            return instance + val1;
        }

        // умножение
        public static Numbers operator *(Numbers instance, int number)
        {
            int val1 = number;
            if (Convert.ToInt32(instance.system) != 10)
            {
                int syst = Convert.ToInt32(instance.system);
                val1 = ConvertToTen(number);
            }
            return new Numbers(instance.value * val1, instance.system);
        }

        public static Numbers operator *(int number, Numbers instance)
        {
            int val1 = number;
            if (Convert.ToInt32(instance.system) != 10)
            {
                int syst = Convert.ToInt32(instance.system);
                val1 = ConvertToTen(number);
            }
            return instance * val1;
        }

        // вычитание
        public static Numbers operator -(Numbers instance, int number)
        {
            int val1 = number;
            if (Convert.ToInt32(instance.system) != 10)
            {
                int syst = Convert.ToInt32(instance.system);
                val1 = ConvertToTen(number);
            }
            return new Numbers(instance.value - val1, instance.system);
        }

        public static Numbers operator -(int number, Numbers instance)
        {
            int val1 = number;
            if (Convert.ToInt32(instance.system) != 10)
            {
                int syst = Convert.ToInt32(instance.system);
                val1 = ConvertToTen(number);
            }
            return instance - val1;
        }
        public string ConvertToSixteen(int number)
        {
            return Convert.ToString(number, 16);
        }
        public Numbers To(SystemOfNumber newType)
        {
            var newValue = this.value;
            if (this.system == SystemOfNumber.ten)
            {
                switch (newType)
                {
                    case SystemOfNumber.ten:
                        newValue = this.value;
                        break;
                    case SystemOfNumber.two:
                        newValue = ConvertToTen(this.value);
                        newValue = ConvertToOut(newValue, 2);
                        break;
                    case SystemOfNumber.eight:
                        newValue = ConvertToTen(this.value);
                        newValue = ConvertToOut(newValue, 8);
                        break;
                    case SystemOfNumber.sixteen:
                        newValue = ConvertToTen(this.value);
                        newValue = ConvertToOut(newValue, 16);
                        break;
                }
            }
            else if (newType == SystemOfNumber.ten)
            {
                switch (this.system)
                {
                    case SystemOfNumber.ten:
                        newValue = this.value;
                        break;
                    case SystemOfNumber.two:
                        newValue = ConvertToTen(this.value);
                        newValue = ConvertToOut(newValue, 2);
                        break;
                    case SystemOfNumber.eight:
                        newValue = ConvertToTen(this.value);
                        newValue = ConvertToOut(newValue, 8);
                        break;
                    case SystemOfNumber.sixteen:
                        newValue = ConvertToTen(this.value);
                        newValue = ConvertToOut(newValue, 16);
                        break;
                }
            }
            else
            {
                newValue = this.To(SystemOfNumber.ten).To(newType).value;
            }
            return new Numbers(newValue, newType);
        }
        // сложение двух длин
        public static Numbers operator +(Numbers instance1, Numbers instance2)
        {
            return instance1 + instance2.To(instance1.system).value;
        }

        // вычитание двух длин
        public static Numbers operator -(Numbers instance1, Numbers instance2)
        {
            return instance1 - instance2.To(instance1.system).value;
        }

        // умножение двух длин
        public static Numbers operator *(Numbers instance1, Numbers instance2)
        {
            return instance1 * instance2.To(instance1.system).value;
        }
    }
}
