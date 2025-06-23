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
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace LocalizadorDeCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cep = TxtCep.Text.Replace("-", "").Replace(" ", "");
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            //Verificar se o 
            if (cep.Length < 8)
            {
                MessageBox.Show("Cep inválido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Limitar a utilização  do webclient dentro do escopol
                using (WebClient navegador = new WebClient())
                {
                    string conteudo = navegador.DownloadString(url);
                    //converter para UFT-8 (Corrigit a acentuação)
                    conteudo = Encoding.UTF8.GetString(Encoding.Default.GetBytes(conteudo));

                    //Instanciar um objeto do tipo endereco
                    Endereco endereco = new Endereco();
                    endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);

                    if (!string.IsNullOrEmpty(endereco.Cep))
                    {
                        //Regular os campos
                        LblCEP.Text = $"Cep: {endereco.Cep}";
                        Lbllogradouro.Text = $"Logradouro: {endereco.Logradouro}";
                        LblComplemento.Text = $"Complemento: {endereco.Complemento}";
                        LblUnidade.Text = $"Unidade: {endereco.Unidade}";
                        LblBairro.Text = $"Bairro: {endereco.Bairro}";
                        LblLocalidade.Text = $"Localidade: {endereco.Localidade}";
                        LblUF.Text = $"UF: {endereco.Uf}";
                        LblEstado.Text = $"Estado: {endereco.Estado}";
                        LblRegiao.Text = $"Região: {endereco.Regiao}";
                        LblDdd.Text = $"DDD: {endereco.Ddd}";
                    }
                    else
                    {
                        MessageBox.Show("Cep não encontrado");
                    }
                }

            }
        }
        

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
