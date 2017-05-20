using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1 
    {
        //Checkboxes
        private void Assign_CheckedChanged(object sender, EventArgs e)
        {
            if (Assign.Checked)
            {
                Grade1.Enabled = true;
                W1.Enabled = true;
                button1.Enabled = true;
                button13.Enabled = true;
            }
            else
            {
                Grade1.Enabled = false;
                W1.Enabled = false;
                button1.Enabled = false;
                button13.Enabled = false;
            }
        }

        private void Quizz_CheckedChanged(object sender, EventArgs e)
        {
            if (Quizz.Checked)
            {
                Grade2.Enabled = true;
                W2.Enabled = true;
                button2.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                Grade2.Enabled = false;
                W2.Enabled = false;
                button2.Enabled = false;
                button12.Enabled = false;
            }
        }

        private void Labs_CheckedChanged(object sender, EventArgs e)
        {
            if (Labs.Checked)
            {
                Grade3.Enabled = true;
                W3.Enabled = true;
                button4.Enabled = true;
                button11.Enabled = true;
            }
            else
            {
                Grade3.Enabled = false;
                W3.Enabled = false;
                button4.Enabled = false;
                button11.Enabled = false;
            }
        }

        private void Midterm_CheckedChanged(object sender, EventArgs e)
        {
            if (Midterm.Checked)
            {
                Grade4.Enabled = true;
                W4.Enabled = true;
                button3.Enabled = true;
                button10.Enabled = true;
            }
            else
            {
                Grade4.Enabled = false;
                W4.Enabled = false;
                button3.Enabled = false;
                button10.Enabled = false;
            }
        }

        private void checkBonus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBonus.Checked)
                Avg5.Enabled = true;
            else
                Avg5.Enabled = false;
        }
    }
}
