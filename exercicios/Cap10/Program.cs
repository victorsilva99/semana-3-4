using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class frmPrincipal : Form
    {
        string site;
        public frmPrincipal()
        {
            InitializeComponent();
            this.btnLer.Click += async (o, e) => { await btnLer_Click(o, e); };
            site = "";
        }

        private async Task btnLer_Click(object sender, EventArgs e)
        {
            lstStatus.Items.Add("Lendo site...");
            lstStatus.Refresh();
            var web = new HttpClient();
            site = await web.GetStringAsync(new Uri(txtSite.Text));

            if (site != "" && txtPalavra.Text != "")
            {
                lstStatus.Items.Add("Site lide");
                btnContar_Click(sender, e);
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "")
            {
                var total = Regex.Matches(site, txtPalavra.Text).Count();
                lstStatus.Items.Add($"Total de ocorrências da palavra {txtPalavra.Text} = { total}");
            }
            else
            {
                lstStatus.Items.Add("Palavra não informada");
            }
        }
    }
}
