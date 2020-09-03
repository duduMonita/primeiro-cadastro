using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoTCC
{
    public partial class Form1Cadastro : Form
    {
        public Form1Cadastro()
        {
            InitializeComponent();
        }
        private string arquivo;
        private string mensagem;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string salvar()//Função para salvar o cadastro em .txt, que sera chamada no WriteAllFiles
        {
            string sexo;//Uma variável string, usada para receber o resultado da checagem dos radio buttons
            if (rBttnMasc.Checked)//Checagem dos radio buttons
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Feminino";
            }
            return txtbNome.Text +//Retornando o texto de todas as textBox e comboBox
                "." + txtbSobre.Text +
                "." + txtbCPF.Text +
                "." + txtbRG.Text +
                "." + cBoxEstado.Text +
                "." + cBoxCidade.Text +
                "." + txtbIdade.Text +
                "." + sexo +
                "." + cBoxTamSup.Text +
                "." + cBoxTamInf.Text;
        }
        private void CadastroOk(object sender, CancelEventArgs e)//Botão salvar dentro do Dialog(saveFileDialog1)
        {
            File.WriteAllText(saveFileDialog1.FileName, salvar());//Utilizando a biblioteca Sistem.IO com a classe File.WriteAllText, podemos salvar todas as strings contidas nos objetos
        }
        private void bttnLimpar_Click(object sender, EventArgs e)//Botão para limpar todos os campos, que contém string ou estão selecionados
        {
            txtbCPF.Clear();
            txtbNome.Clear();
            txtbRG.Clear();
            txtbSobre.Clear();
            cBoxCidade.SelectedIndex = -1;
            cBoxEstado.SelectedIndex = -1;
            rBttnFem.Checked = false;
            rBttnMasc.Checked = false;

        }
        private void bttnCadastrar_Click_1(object sender, EventArgs e)//Botão cadastrar
        {
            //Verificação dos Campos de dados, se estão vazios, aparecerá uma MessageBox "Campos não inseridos", e será sinalizado no form os campos que faltam
            if ((txtbCPF.Text == "") || (txtbRG.Text == "") || (txtbSobre.Text == "") || (txtbNome.Text == "") || (cBoxCidade.Text == "") || (cBoxEstado.Text == "") || (cBoxTamInf.Text == "") || (cBoxTamSup.Text == "") || ((rBttnFem.Checked == false) && (rBttnMasc.Checked == false)))
            {
                MessageBox.Show("Campos de cadastro vazios!", "Alerta !", MessageBoxButtons.OK);
                if (txtbCPF.Text == "")
                {
                    txtErroCPF.Visible = true;
                }
                else
                {
                    txtErroCPF.Visible = false;
                }
                if (txtbNome.Text == "")
                {
                    txtErroNome.Visible = true;
                }
                else
                {
                    txtErroNome.Visible = false;
                }
                if (txtbRG.Text == "")
                {
                    txtErroRG.Visible = true;
                }
                else
                {
                    txtErroRG.Visible = false;
                }
                if (txtbSobre.Text == "")
                {
                    txtErroSobre.Visible = true;
                }
                else
                {
                    txtErroSobre.Visible = false;
                }
                if (cBoxEstado.Text == "")
                {
                    txtErroEstado.Visible = true;
                }
                else
                {
                    txtErroEstado.Visible = false;
                }
                if (cBoxEstado.Text == "")
                {
                    txtErroCidade.Visible = true;
                }
                else
                {
                    txtErroCidade.Visible = false;
                }
                if (txtbIdade.Text == "")
                {
                    txtErroIdade.Visible = true;
                }
                else
                {
                    txtErroIdade.Visible = false;
                }
                if (cBoxTamSup.Text == "")
                {
                    txtErroTamSup.Visible = true;
                }
                else
                {
                    txtErroTamSup.Visible = false;
                }
                if (cBoxTamInf.Text == "")
                {
                    txtErroTamInf.Visible = true;
                }
                else
                {
                    txtErroTamInf.Visible = false;
                }
                if ((rBttnMasc.Checked == false) && (rBttnFem.Checked == false))
                {
                    txtErroSexo.Visible = true;
                }
                else
                {
                    txtErroSexo.Visible = false;
                }
            }
            else//Se todos os campos estão completos, será retirada as mensagens "Campos não inseridos", e abre o saveFileDialog para salvar o arquivo em .txt
            {
                txtErroCidade.Visible = false;
                txtErroCPF.Visible = false;
                txtErroEstado.Visible = false;
                txtErroNome.Visible = false;
                txtErroRG.Visible = false;
                txtErroSexo.Visible = false;
                txtErroSobre.Visible = false;
                txtErroIdade.Visible = false;
                txtErroTamInf.Visible = false;
                txtErroTamSup.Visible = false;
                saveFileDialog1.Filter = "Arquivo texto | *.txt";
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.ShowDialog();
            }
        }
        private void bttnSair_Click_1(object sender, EventArgs e)//Fechar o programa 
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quer fechar o programa ?", "Alerta !", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void bttnOrdCadastro_Click(object sender, EventArgs e)//      JAO COMENTA
        {
            List<string> mensagemLinha = new List<string>();//      JAO COMENTA
            using (OpenFileDialog openFileDialog = new OpenFileDialog())//      JAO COMENTA
            {
                openFileDialog.Title = "Ordenar Dados";
                openFileDialog.Filter = "Arquivo texto | *.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    arquivo = openFileDialog.FileName;
            }
            if (String.IsNullOrEmpty(arquivo))
            {
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
            }
            else//Utilizando uma classe do System.IO StreamReader, para ler o arquivo 
            {
                using (StreamReader texto = new StreamReader(arquivo))
                {
                    while ((mensagem = texto.ReadToEnd()) != null)
                    {
                        string[] google = mensagem.Split('.');//Recorta a string como um todo, quando ver um caracter especifico e coloca no vetor
                        List<string> cad = new List<string>();//Criando uma lista de strings, para ordenar os dados cadastrais
                        for (int i = 0; i < google.Length; i++)//Criando um Array, para adicionar na lista, o resultado do Split
                        {
                            cad.Add(google[i]);
                        }
                        cad.Sort();//Para fazer a ordenação crescente dos dados
                        //MessageBox.Show exibir cadastro já ordenado
                        MessageBox.Show((cad[0] + "\n" + cad[1] + cad[2] + "\n" + cad[3] + "\n" + cad[4] + "\n" + cad[5] + "\n" + cad[6] + "\n" + cad[7] + "\n" + cad[8] + "\n" + cad[9] + "\n"));
                    }
                }
                int registro = mensagemLinha.Count; //total de linhas do arquivo.
                for (int i = 0; i < mensagemLinha.Count; i++)//      JAO COMENTA
                {
                    TextBox textbox1 = new TextBox();
                    textbox1.Text += mensagemLinha[i];
                    File.WriteAllText(arquivo, mensagemLinha[i] + "1");
                }
            }
        }

        private void bttnEdCadastro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Utiliza a classe OpenFileDialog para abrir o Dialogo
            ofd.Filter = "Arquivo texto | *.txt";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName))//Utiliza a Classe StreamReader, para ler o que esta dentro do .txt
                    {
                        while (!reader.EndOfStream)//O leitor Reader verifica se o arquivo não esta vazio
                        {
                            string linhaDados = reader.ReadLine();//linhaDados recebe toda a string do .txt
                            string[] dados = linhaDados.Split('.');//O Split divide os dados por um ponto, e armazena em um vetor "dados", que é utilizado para inserir esses dados de volta nos objetos
                            txtbNome.Text = dados[0];
                            txtbSobre.Text = dados[1];
                            txtbCPF.Text = dados[2];
                            txtbRG.Text = dados[3];
                            cBoxEstado.Text = dados[4];
                            cBoxCidade.Text = dados[5];
                            txtbIdade.Text = dados[6];
                            cBoxTamSup.Text = dados[8];
                            cBoxTamInf.Text = dados[9];//Inserção dos dados nos objetos
                            if (dados[7] == "Masculino")
                            {
                                rBttnMasc.Checked = true;
                            }
                            else
                            {
                                rBttnFem.Checked = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro." + ex.Message, "Alerta.", MessageBoxButtons.OK);//Mensagem de erro se a Ordenação não funcionar
                }
            }
        }
    }
}
