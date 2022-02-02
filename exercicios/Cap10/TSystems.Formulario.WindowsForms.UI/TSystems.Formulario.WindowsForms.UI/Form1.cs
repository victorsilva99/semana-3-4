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

namespace TSystems.Formulario.WindowsForms.UI
{
    public partial class frmPrincipal : Form
    {
        string site;
        public frmPrincipal()
        {
            InitializeComponent();
            this.BtnLer.Click += async (o, e) => { await BtnLer_Click(o, e); };
            site = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task BtnLer_Click(object sender, EventArgs e)
        {
            lstStatus.Items.Add("Lendo site...");
            lstStatus.Refresh();
            var web = new HttpClient();
            site = await web.GetStringAsync(new Uri(txtSite.Text));

            if (site != "" && txtPalavra.Text != "")
            {
                lstStatus.Items.Add("Site lide");
                BtnContar_Click(sender, e);
            }
        }
        private async void BtnContar_Click(object sender, EventArgs e)
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
        private async Task<int> ContarPalavras(string palavra)
        {
            return await Task.Run(() => Regex.Matches(site, palavra).Count());
        }
    }
}
