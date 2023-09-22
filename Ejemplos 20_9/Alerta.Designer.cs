namespace Ejemplos_20_9
{
    partial class Alerta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo=new Label();
            btnOk=new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize=true;
            lblTitulo.BackColor=Color.Transparent;
            lblTitulo.Location=new Point(126, 26);
            lblTitulo.Name="lblTitulo";
            lblTitulo.Size=new Size(45, 15);
            lblTitulo.TabIndex=0;
            lblTitulo.Text="TITULO";
            lblTitulo.Click+=label1_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor=Color.YellowGreen;
            btnOk.Location=new Point(115, 175);
            btnOk.Name="btnOk";
            btnOk.Size=new Size(75, 23);
            btnOk.TabIndex=1;
            btnOk.Text="OK";
            btnOk.UseVisualStyleBackColor=false;
            btnOk.Click+=btnOk_Click;
            // 
            // Alerta
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackgroundImage=Properties.Resources._77d2897a90bcf27ac3b08f1d4563b74a;
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(308, 251);
            Controls.Add(btnOk);
            Controls.Add(lblTitulo);
            Name="Alerta";
            Text="Alerta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnOk;
    }
}