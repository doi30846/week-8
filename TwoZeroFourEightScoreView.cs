using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form,View
    {
      
     /*   private string pass;

        public string Passvalue
        {
            get { return pass; }
            set { pass = value; }
        }
        */
            
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        public void Notify(Model m)
        {
           
            input(((TwoZeroFourEightModel)m).GetScore());
        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {
           // lblScore.Text = "Your score = " +pass;
        }


        public void input(int a)
        {
            lblScore.Text = Convert.ToString(a);
        }
        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
