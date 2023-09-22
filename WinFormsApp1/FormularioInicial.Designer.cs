namespace WinFormsApp1
{
    partial class FormularioInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrar=new Button();
            lblNombre=new Label();
            txtNombre=new TextBox();
            txtSalario=new TextBox();
            lblSalario=new Label();
            rdoFem=new RadioButton();
            rdoMas=new RadioButton();
            cmbTareas=new ComboBox();
            lblTareas=new Label();
            grpGenero=new GroupBox();
            lstEmpleados=new ListBox();
            btnAgregarTarea=new Button();
            dataGridView1=new DataGridView();
            Tareas=new DataGridViewTextBoxColumn();
            grpGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor=Color.Khaki;
            btnMostrar.Location=new Point(56, 288);
            btnMostrar.Name="btnMostrar";
            btnMostrar.Size=new Size(75, 23);
            btnMostrar.TabIndex=0;
            btnMostrar.Text="Cargar";
            btnMostrar.UseVisualStyleBackColor=false;
            btnMostrar.Click+=btnMostrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize=true;
            lblNombre.Location=new Point(44, 15);
            lblNombre.Name="lblNombre";
            lblNombre.Size=new Size(51, 15);
            lblNombre.TabIndex=1;
            lblNombre.Text="Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor=Color.LemonChiffon;
            txtNombre.Location=new Point(101, 12);
            txtNombre.Name="txtNombre";
            txtNombre.Size=new Size(104, 23);
            txtNombre.TabIndex=2;
            // 
            // txtSalario
            // 
            txtSalario.BackColor=Color.LemonChiffon;
            txtSalario.Location=new Point(101, 55);
            txtSalario.Name="txtSalario";
            txtSalario.Size=new Size(104, 23);
            txtSalario.TabIndex=4;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize=true;
            lblSalario.Location=new Point(44, 58);
            lblSalario.Name="lblSalario";
            lblSalario.Size=new Size(42, 15);
            lblSalario.TabIndex=3;
            lblSalario.Text="Salario";
            // 
            // rdoFem
            // 
            rdoFem.AutoSize=true;
            rdoFem.Location=new Point(6, 19);
            rdoFem.Name="rdoFem";
            rdoFem.Size=new Size(78, 19);
            rdoFem.TabIndex=5;
            rdoFem.TabStop=true;
            rdoFem.Text="Femenino";
            rdoFem.UseVisualStyleBackColor=true;
            // 
            // rdoMas
            // 
            rdoMas.AutoSize=true;
            rdoMas.Location=new Point(6, 44);
            rdoMas.Name="rdoMas";
            rdoMas.Size=new Size(80, 19);
            rdoMas.TabIndex=6;
            rdoMas.TabStop=true;
            rdoMas.Text="Masculino";
            rdoMas.UseVisualStyleBackColor=true;
            // 
            // cmbTareas
            // 
            cmbTareas.FormattingEnabled=true;
            cmbTareas.Items.AddRange(new object[] { "Cerrar caja", "Limpiar cocina", "Limpiar baño", "Atender clientes" });
            cmbTareas.Location=new Point(44, 211);
            cmbTareas.Name="cmbTareas";
            cmbTareas.Size=new Size(121, 23);
            cmbTareas.TabIndex=8;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize=true;
            lblTareas.Location=new Point(44, 190);
            lblTareas.Name="lblTareas";
            lblTareas.Size=new Size(115, 15);
            lblTareas.TabIndex=9;
            lblTareas.Text="Tareas del trabajador";
            // 
            // grpGenero
            // 
            grpGenero.BackColor=Color.MediumPurple;
            grpGenero.Controls.Add(rdoFem);
            grpGenero.Controls.Add(rdoMas);
            grpGenero.Location=new Point(44, 104);
            grpGenero.Name="grpGenero";
            grpGenero.Size=new Size(98, 66);
            grpGenero.TabIndex=10;
            grpGenero.TabStop=false;
            grpGenero.Text="Genero";
            // 
            // lstEmpleados
            // 
            lstEmpleados.BackColor=Color.Khaki;
            lstEmpleados.FormattingEnabled=true;
            lstEmpleados.ItemHeight=15;
            lstEmpleados.Location=new Point(363, 12);
            lstEmpleados.Name="lstEmpleados";
            lstEmpleados.Size=new Size(159, 64);
            lstEmpleados.TabIndex=11;
            lstEmpleados.SelectedIndexChanged+=lstEmpleados_SelectedIndexChanged;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor=Color.MediumPurple;
            btnAgregarTarea.Location=new Point(56, 240);
            btnAgregarTarea.Name="btnAgregarTarea";
            btnAgregarTarea.Size=new Size(86, 23);
            btnAgregarTarea.TabIndex=12;
            btnAgregarTarea.Text="Agregar tarea";
            btnAgregarTarea.UseVisualStyleBackColor=false;
            btnAgregarTarea.Click+=btnAgregarTarea_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tareas });
            dataGridView1.Location=new Point(363, 104);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size(159, 150);
            dataGridView1.TabIndex=13;
            // 
            // Tareas
            // 
            Tareas.HeaderText="Tareas";
            Tareas.Name="Tareas";
            // 
            // FormularioInicial
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(577, 323);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarTarea);
            Controls.Add(lstEmpleados);
            Controls.Add(grpGenero);
            Controls.Add(lblTareas);
            Controls.Add(cmbTareas);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnMostrar);
            Name="FormularioInicial";
            Text="Form1";
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtSalario;
        private Label lblSalario;
        private RadioButton rdoFem;
        private RadioButton rdoMas;
        private ComboBox cmbTareas;
        private Label lblTareas;
        private GroupBox grpGenero;
        private ListBox lstEmpleados;
        private Button btnAgregarTarea;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tareas;
    }
}