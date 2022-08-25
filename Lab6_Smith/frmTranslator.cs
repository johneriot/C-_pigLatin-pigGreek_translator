using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Smith
{
    public partial class frmTranslator : Form
    {
        PigLatinTranslator plt = new PigLatinTranslator();
        PigGreekTranslator pgt = new PigGreekTranslator();
        public frmTranslator()
        {
            InitializeComponent();
            PigLatinTranslator plt = new PigLatinTranslator();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglish.Text = "";
            txtTranslation.Text = "";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                //throw exception if textbox is empty
                if(txtEnglish.Text == "")
                {
                    throw new Exception();
                }
                //check which radio button is selected and translate text accordingly
                else if (rbtnLatin.Checked == true)
                {
                    txtTranslation.Text = plt.Translate(txtEnglish.Text);

                }
                else if (rbtnGreek.Checked == true)
                {
                    txtTranslation.Text = pgt.Translate(txtEnglish.Text);

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter text to be translated.");
            }
        }

        private void rbtnLatin_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslation.Text = "Pig Latin Translation";
        }

        private void rbtnGreek_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslation.Text = "Pig Greek Translation";
        }
    }
}
