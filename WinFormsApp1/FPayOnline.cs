using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FPayOnline : Form
    {
        public FPayOnline()
        {
            InitializeComponent();
        }

        private List<Order> orders = new List<Order>();

        public List<Order> Orders { get => orders; set => orders = value; }

        private void FPayOnline_Load(object sender, EventArgs e)
        {

        }

        private void button_done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
