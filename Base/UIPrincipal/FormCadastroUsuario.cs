using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            
        }
 
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("Cadastro realizado com suceso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);    
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuarioBLL.Inserir(usuario);

        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            nomeUsuarioTextBox.Focus();
        }

        private void buttonSalvarCadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("Cadastro realizado com suceso!");
            usuarioBindingSource.AddNew();
            nomeUsuarioTextBox.Focus();


        }
    }
 }
