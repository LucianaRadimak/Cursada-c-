namespace Ejemplos_20_9
{
    partial class Login
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
            btnIngresar=new Button();
            btnSalir=new Button();
            txtUsuario=new TextBox();
            txtContraseña=new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor=Color.Khaki;
            btnIngresar.FlatStyle=FlatStyle.Popup;
            btnIngresar.Font=new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location=new Point(12, 126);
            btnIngresar.Name="btnIngresar";
            btnIngresar.Size=new Size(167, 40);
            btnIngresar.TabIndex=0;
            btnIngresar.Text="INGRESAR";
            btnIngresar.UseVisualStyleBackColor=false;
            btnIngresar.Click+=btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor=Color.MediumPurple;
            btnSalir.FlatStyle=FlatStyle.Flat;
            btnSalir.Location=new Point(55, 172);
            btnSalir.Name="btnSalir";
            btnSalir.Size=new Size(75, 23);
            btnSalir.TabIndex=1;
            btnSalir.Text="SALIR";
            btnSalir.UseVisualStyleBackColor=false;
            btnSalir.Click+=btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location=new Point(12, 13);
            txtUsuario.Name="txtUsuario";
            txtUsuario.PlaceholderText="Ingrese su nombre";
            txtUsuario.Size=new Size(167, 23);
            txtUsuario.TabIndex=2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location=new Point(12, 68);
            txtContraseña.Name="txtContraseña";
            txtContraseña.PasswordChar='*';
            txtContraseña.PlaceholderText="Ingrese su contraseña";
            txtContraseña.Size=new Size(167, 23);
            txtContraseña.TabIndex=3;
            txtContraseña.UseSystemPasswordChar=true;
            // 
            // Login
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LemonChiffon;
            ClientSize=new Size(192, 211);
            ControlBox=false;
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            FormBorderStyle=FormBorderStyle.None;
            Name="Login";
            Text="LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
    }
}