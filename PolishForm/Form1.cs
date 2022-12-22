using PolishNotation.Services;

namespace PolishForm
{
    public partial class Form1 : Form
    {
        private readonly StackService<string> _stackService;
        public Form1()
        {
            InitializeComponent();
            _stackService = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            string[] expression = textBox1.Text.Split(' ');

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                if (PolishService.IsOperator(expression[i]))
                {
                    string? value1 = _stackService.Pop();
                    string? value2 = _stackService.Pop();

                    _stackService.Push(PolishService.Calculate(expression[i], int.Parse(value1), int.Parse(value2)).ToString());
                }
                else
                    _stackService.Push(expression[i]);
            }

            string result = string.Empty;

            while (_stackService.Any)
                result += _stackService.Pop();
            textBox2.Text = result;
        }
    }
}