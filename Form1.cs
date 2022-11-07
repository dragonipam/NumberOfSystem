namespace NumberSystem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var measureItems = new string[]{
            "2 си",
            "8 си",
            "10 си",
            "16 си",};

            inputBox1.DataSource = new List<string>(measureItems);
            inputBox2.DataSource = new List<string>(measureItems);
            outBox1.DataSource = new List<string>(measureItems);
        }
        private SystemOfNumber GetMeasureType(ComboBox comboBox)
        {
            SystemOfNumber measureType;
            switch (comboBox.Text)
            {
                case "10 си":
                    measureType = SystemOfNumber.ten;
                    break;
                case "2 си":
                    measureType = SystemOfNumber.two;
                    break;
                case "8 си":
                    measureType = SystemOfNumber.eight;
                    break;
                case "16 си":
                    measureType = SystemOfNumber.sixteen;
                    break;
                default:
                    measureType = SystemOfNumber.ten;
                    break;
            }
            return measureType;
        }

        public string ConvertToHex(int number)
        {
            char [] table = new char[] {'0','1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string hex = "";
            while (number != 0)
            {
                if (number % 16 > 9)
                {
                    hex = Convert.ToString(table[number % 16]);
                }
                hex += number % 16;
                number /= 16;
            }
            return hex;
        }

        private void Calculate()
        {
            try
            {
                var firstValue = int.Parse(txt1.Text);
                var secondValue = int.Parse(txt2.Text);

                SystemOfNumber firstType = GetMeasureType(inputBox1);
                SystemOfNumber secondType = GetMeasureType(inputBox2);
                SystemOfNumber resultType = GetMeasureType(outBox1);

                var firstNumbers = new Numbers(firstValue, firstType);
                var secondNumbers = new Numbers(secondValue, secondType);
                bool boolSum = false;
                Numbers sumNumbers;

                switch (comboBox1.Text)
                {
                    case "+":
                        sumNumbers = firstNumbers + secondNumbers;
                        break;
                    case "-":
                        sumNumbers = firstNumbers - secondNumbers;
                        break;
                    case "*":
                        sumNumbers = firstNumbers * secondNumbers;
                        break;
                    case "=":
                        if (firstNumbers == secondNumbers)
                        {
                            boolSum = true;
                        }
                        sumNumbers = firstNumbers;
                        break;
                    default:
                        sumNumbers = firstNumbers;
                        break;
                }
                if (boolSum)
                {
                    txt3.Text = "Значения равны";
                }
                else
                {
                    txt3.Text = sumNumbers.To(resultType).Verbose();
                }
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}