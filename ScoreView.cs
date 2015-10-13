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
    public partial class ScoreView : Form
    {
        public ScoreView()
        {
            InitializeComponent();
        }
        public void updatescore(int score)
        {
            score_txt_scoreview.Text = "" + score;
        }

        private void score_txt_scoreview_Click(object sender, EventArgs e)
        {

        }

        private void ScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
