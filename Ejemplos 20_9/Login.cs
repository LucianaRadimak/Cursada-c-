namespace Ejemplos_20_9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string contrase�a = this.txtContrase�a.Text;
            if (usuario == "pepito" && contrase�a == "123")
            {
                //MessageBox.Show("Usuario logeado con exito", "Log in",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alerta alerta = new Alerta();
                alerta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrecta", "Log in",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}