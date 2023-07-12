using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CatFacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://meowfacts.herokuapp.com/");
                JObject catFact = JObject.Parse(json);
                string factData = (string)catFact["data"][0];
                lblCatFactText.Text = factData.ToString();
            }
            lblCatFactText.Left = (this.ClientSize.Width - lblCatFactText.Width) / 2;
        }
    }
}
