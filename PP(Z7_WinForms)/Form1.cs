using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z7_WinForms_
{
    public partial class Praktika_7 : Form
    {
        public Praktika_7()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(enter_str.Text);
            StringBuilder substr = new StringBuilder(enter_substr.Text);
            str.Replace(substr.ToString(), "");
            add_str.Text = str.ToString();
        }
        static int numberOfUpWords(StringBuilder input)
        {
            int ret = 0, ind = 0;
            while (ind < input.Length)
            {
                int nUCase = 0, nLCase = 0;
                while (ind < input.Length && char.IsLetter(input[ind]))
                {
                    if (char.IsUpper(input[ind])) nUCase++;
                    if (char.IsLower(input[ind])) nLCase++;
                    ind++;
                }
                if (nUCase > 0 && nLCase == 0) ret++;
                while (ind < input.Length && !char.IsLetter(input[ind]))
                    ind++;
            }
            return ret;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(enter_str2.Text);
            Num.Text = numberOfUpWords(str).ToString();
        }
    }
}
