namespace AmbarPPC
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    public class TextBoxNumeric : TextBox
    {
        private bool allowNegative = false;
        private bool allowSpace = false;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
            string numberDecimalSeparator = numberFormat.NumberDecimalSeparator;
            string negativeSign = numberFormat.NegativeSign;
            string str3 = e.KeyChar.ToString();
            if (((!char.IsDigit(e.KeyChar) && !str3.Equals(numberDecimalSeparator)) && ((!this.allowNegative || !str3.Equals(negativeSign)) && ((e.KeyChar != '\b') && (e.KeyChar != Convert.ToChar(Keys.Delete))))) && (!this.allowSpace || (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }

        public bool AllowSpace
        {
            get
            {
                return this.allowSpace;
            }
            set
            {
                this.allowSpace = value;
            }
        }

        public decimal DecimalValue
        {
            get
            {
                if (this.Text.Length == 0)
                {
                    return 0M;
                }
                try
                {
                    return decimal.Parse(this.Text);
                }
                catch (Exception)
                {
                    return 0M;
                }
            }
        }

        public int IntValue
        {
            get
            {
                if (this.Text.Length == 0)
                {
                    return 0;
                }
                try
                {
                    return int.Parse(this.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
    }
}

