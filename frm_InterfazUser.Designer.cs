namespace T2_InterfazGrafica_de_Usuarios_ALLANM
{
    partial class frm_InterfazUser
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox text_Nombre;
        private TextBox text_Apellido;
        private TextBox text_Cedula;
        private TextBox text_Celular;
        private Button btn_Guardar;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Cedula;
        private Label lbl_Celular;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            text_Nombre = new TextBox();
            text_Apellido = new TextBox();
            text_Cedula = new TextBox();
            text_Celular = new TextBox();
            btn_Guardar = new Button();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_Cedula = new Label();
            lbl_Celular = new Label();
            SuspendLayout();
            // 
            // text_Nombre
            // 
            text_Nombre.Location = new Point(100, 30);
            text_Nombre.Name = "text_Nombre";
            text_Nombre.Size = new Size(200, 23);
            text_Nombre.TabIndex = 0;
            // 
            // text_Apellido
            // 
            text_Apellido.Location = new Point(100, 60);
            text_Apellido.Name = "text_Apellido";
            text_Apellido.Size = new Size(200, 23);
            text_Apellido.TabIndex = 1;
            // 
            // text_Cedula
            // 
            text_Cedula.Location = new Point(100, 90);
            text_Cedula.Name = "text_Cedula";
            text_Cedula.Size = new Size(200, 23);
            text_Cedula.TabIndex = 2;
            // 
            // text_Celular
            // 
            text_Celular.Location = new Point(100, 120);
            text_Celular.Name = "text_Celular";
            text_Celular.Size = new Size(200, 23);
            text_Celular.TabIndex = 3;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(100, 160);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 4;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btnGuardar_Click;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(30, 33);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 5;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(30, 63);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 6;
            lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Cedula
            // 
            lbl_Cedula.AutoSize = true;
            lbl_Cedula.Location = new Point(30, 93);
            lbl_Cedula.Name = "lbl_Cedula";
            lbl_Cedula.Size = new Size(44, 15);
            lbl_Cedula.TabIndex = 7;
            lbl_Cedula.Text = "Cédula";
            // 
            // lbl_Celular
            // 
            lbl_Celular.AutoSize = true;
            lbl_Celular.Location = new Point(30, 123);
            lbl_Celular.Name = "lbl_Celular";
            lbl_Celular.Size = new Size(44, 15);
            lbl_Celular.TabIndex = 8;
            lbl_Celular.Text = "Celular";
            // 
            // frm_InterfazUser
            // 
            ClientSize = new Size(334, 211);
            Controls.Add(lbl_Celular);
            Controls.Add(lbl_Cedula);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(btn_Guardar);
            Controls.Add(text_Celular);
            Controls.Add(text_Cedula);
            Controls.Add(text_Apellido);
            Controls.Add(text_Nombre);
            Name = "frm_InterfazUser";
            Text = "Ingreso de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
