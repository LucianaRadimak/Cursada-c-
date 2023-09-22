namespace WinFormsApp1
{
    public partial class FormularioInicial : Form
    {
        List<Empleado> empleados;
        List<string> tareasEmpleado;
        public FormularioInicial()
        {
            InitializeComponent();
            empleados = new List<Empleado>();
            tareasEmpleado = new List<string>();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre;
            float salario;
            string genero;

            nombre = txtNombre.Text;
            salario = float.Parse(txtSalario.Text);

            if (rdoFem.Checked)
                genero = rdoFem.Text;
            else
                genero = rdoMas.Text;

            Empleado empleado;
            empleado = new Empleado(nombre, salario, genero, tareasEmpleado);
            empleados.Add(empleado);
            MostrarLista(empleados);
            tareasEmpleado.Clear();
            //MessageBox.Show("Hola mundo"); //Funciona como un alert            
        }

        private void MostrarLista(List<Empleado> lista)
        {
            lstEmpleados.Items.Clear();
            foreach (Empleado empleado in lista)
            {
                lstEmpleados.Items.Add(empleado.ToString());
            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            tareasEmpleado.Add(cmbTareas.Text);
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = lstEmpleados.SelectedIndex;
            Empleado empleadoSeleccionado = empleados[index];
            dataGridView1.Rows.Clear();
            foreach (string tarea in empleadoSeleccionado.Tareas)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = tarea;
                row.Cells.Add(cell);
                dataGridView1.Rows.Add(row);
            }
        }
    }
}