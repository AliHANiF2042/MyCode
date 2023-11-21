namespace calculator
{
    public partial class Form1 : Form
    {
        int number1 = 0;
        int number2 = 0;
        string optr = " ";
        bool isFirstNumber = true;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //تغییر استایل دکمه ها
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }

            }
        }

        void setToNumber(string text)
        {
            if (isFirstNumber)  //برای فهمیدن عدد اول یا دوم موقع واردکردن
            {
                number1 = Convert.ToInt32(display.Text);
            }
            else
            {
                number2 = Convert.ToInt32(display.Text);
            }
        }

        private void HandleNumberClick(object sender, EventArgs e)
        {
            Button Number = (Button)sender;
            display.Text += Number.Text;
            setToNumber(display.Text);
            this.ActiveControl = display;
        }
        private void backspaceClick(object sender, EventArgs e)
        {
            string currnetText = display.Text;
            if(currnetText.Length > 0)
            {
                display.Text = currnetText.Remove(currnetText.Length - 1);
                //display.Text = currnetText;
            }
            
        }




        private void FullClear(object sender, EventArgs e)
        {
            display.Text = "0";  //اعداد را صفر کند
            isFirstNumber = true;
        }

        private void HandleOptr(object sender, EventArgs e)
        {
            isFirstNumber = false;
            Button optrButton = (Button)sender;
            optr = optrButton.Text;
            this.ActiveControl = display;

            display.Text = " "; //خالی گذاشتن بعد فشردن اپراتور
        }

        private void mosavi_Click(object sender, EventArgs e)
        {
            int result = 0;
            switch (optr)
            {

                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }

            display.Text = result.ToString();
            isFirstNumber = true;
        }



        private void keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //MessageBox.Show(e.KeyCode + "");
            if (e.KeyCode == Keys.NumPad1)
            {
                display.Text += "1";
                setToNumber(display.Text);

            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                display.Text += "2";
                setToNumber(display.Text);

            }
            else if (e.KeyCode == Keys.Enter)
            {
                mosavi.PerformClick();

            }
            else if (e.KeyCode == Keys.Add)
            {
                optr = "+";
                isFirstNumber = false;
                display.Text = "";
            }
        }

        private void ChangeSign(object sender, EventArgs e)
        {
            display.Text = (Convert.ToInt32(display.Text) * -1) + ""; //کد قرینه کردن علامت اعداد
        }


    }
}