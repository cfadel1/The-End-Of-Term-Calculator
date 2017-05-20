
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[] count = new int[4];
        double[] total = new double[4];
        double[] number = new double[4];
        double[] avg = new double[4];
        double[] avgWorth = new double[4];

        double bonus = 0;
        double grdNeeded = 0;
        double finalWorth = 0;
        double ovrlAvg = 0;
        double ovrl = 0;

        public Form1()
        {
            InitializeComponent();
            Assign.Checked = true;
            Quizz.Checked = true;
            Labs.Checked = true;
            Midterm.Checked = true;
            checkBonus.Checked = true;
            //ClearListBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Add for assignments
        private void button13_Click(object sender, EventArgs e)
        {
            count[0] += 1;
            number[0] = double.Parse(Grade1.Text);
            total[0] += number[0];
            Grade1.Clear();
        }

        //Calculate for assignemnts
        private void button1_Click(object sender, EventArgs e)
        {
            avg[0] = total[0] / count[0];
            Avg1.Text = avg[0].ToString();
        }

        //Add for Quizzes
        private void button12_Click(object sender, EventArgs e)
        {
            count[1] += 1;
            number[1] = double.Parse(Grade2.Text);
            total[1] += number[1];
            Grade2.Clear();
        }

        //Calculate for Quizzes
        private void button2_Click(object sender, EventArgs e)
        {
            avg[1] = total[1] / count[1];
            Avg2.Text = avg[1].ToString();
        }

        //Add for Labs
        private void button10_Click(object sender, EventArgs e)
        {
            count[2] += 1;
            number[2] = double.Parse(Grade4.Text);
            total[2] += number[2];
            Grade4.Clear();
        }

        //Calculate for Labs
        private void button3_Click(object sender, EventArgs e)
        {
            avg[2] = total[2] / count[2];
            Avg4.Text = avg[2].ToString();
        }

        //Add for Midterms
        private void button11_Click(object sender, EventArgs e)
        {
            count[3] += 1;
            number[3] = double.Parse(Grade3.Text);
            total[3] += number[3];
            Grade3.Clear();
        }

        //Calculate for Midterms
        private void button4_Click(object sender, EventArgs e)
        {
            avg[3] = total[3] / count[3];
            Avg3.Text = avg[3].ToString();
        }

        //Bonus
        private void button5_Click(object sender, EventArgs e)
        {
            Avg5.Text = (Avg5.Text.ToString());
        }

        //Main Average
        private void button8_Click(object sender, EventArgs e)
        {
            double[] temp = new double[5];

            temp[0] = double.TryParse(W1.Text, out avgWorth[0]) ? ((avgWorth[0] * avg[0]) / 100) : 0;
            temp[1] = double.TryParse(W2.Text, out avgWorth[1]) ? ((avgWorth[1] * avg[1]) / 100) : 0;
            temp[2] = double.TryParse(W3.Text, out avgWorth[2]) ? ((avgWorth[2] * avg[2]) / 100) : 0;
            temp[3] = double.TryParse(W4.Text, out avgWorth[3]) ? ((avgWorth[3] * avg[3]) / 100) : 0;

            if (double.TryParse(Avg5.Text, out bonus))
            {
                temp[4] = bonus;
            }
            else
            {
                bonus = 0;
            }

            ovrlAvg = temp[0] + temp[1] + temp[2] + temp[3] + temp[4];
            Avg6.Text = ovrlAvg.ToString();
        }

        //like average
        private void button15_Click(object sender, EventArgs e)
        {
            double[] temp = new double[5];
            double finalgrd;

            avgWorth[0] = double.TryParse(W1.Text, out avgWorth[0]) ? avgWorth[0] : 0;
            avgWorth[1] = double.TryParse(W2.Text, out avgWorth[1]) ? avgWorth[1] : 0;
            avgWorth[2] = double.TryParse(W3.Text, out avgWorth[2]) ? avgWorth[2] : 0;
            avgWorth[3] = double.TryParse(W4.Text, out avgWorth[3]) ? avgWorth[3] : 0;
            bonus = double.TryParse(Avg5.Text, out bonus) ? bonus : 0;

            finalWorth = ((100 - (avgWorth[0] + avgWorth[1] + avgWorth[2] + avgWorth[3])) / 100);
            grdNeeded = double.TryParse(like.Text, out ovrl) ? grdNeeded = ((ovrl - ovrlAvg - bonus) / finalWorth) : 0;
            GrdNeeded.Text = grdNeeded.ToString();
        }

        //will get Average
        private void button14_Click(object sender, EventArgs e)
        {
            double[] temp = new double[5];
            double finalgrd;

            avgWorth[0] = double.TryParse(W1.Text, out avgWorth[0]) ? avgWorth[0] : 0;
            avgWorth[1] = double.TryParse(W2.Text, out avgWorth[1]) ? avgWorth[1] : 0;
            avgWorth[2] = double.TryParse(W3.Text, out avgWorth[2]) ? avgWorth[2] : 0;
            avgWorth[3] = double.TryParse(W4.Text, out avgWorth[3]) ? avgWorth[3] : 0;
            bonus = double.TryParse(Avg5.Text, out bonus) ? bonus : 0;

            finalWorth = ((100 - (avgWorth[0] + avgWorth[1] + avgWorth[2] + avgWorth[3])) / 100);
            ovrl = double.TryParse(think.Text, out finalgrd) ? (finalgrd * finalWorth) + ovrlAvg + bonus : 0;
            Ovrl.Text = ovrl.ToString();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Clear button
        private void button7_Click(object sender, EventArgs e)
        {
            ClearListBoxes();
        }

        //Clear function
        private void ClearListBoxes()
        {
            Avg1.Clear();
            Avg2.Clear();
            Avg3.Clear();
            Avg4.Clear();
            Avg5.Clear();
            Avg6.Clear();
            GrdNeeded.Clear();
            Ovrl.Clear();
            like.Clear();
            think.Clear();
            Grade1.Clear();
            Grade2.Clear();
            Grade3.Clear();
            Grade4.Clear();
            Assign.Checked = false;
            Quizz.Checked = false;
            Labs.Checked = false;
            Midterm.Checked = false;
            checkBonus.Checked = false;
            W1.Clear();
            W2.Clear();
            W3.Clear();
            W4.Clear();
        }
    }
}