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
    public partial class TwoZeroFourEightScoreView : Form
    {
       
        private string pass;

        public string Passvalue
        {
            get { return pass; }
            set { pass = value; }
        }

            
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Your score = " +pass;
        }
    }
}
