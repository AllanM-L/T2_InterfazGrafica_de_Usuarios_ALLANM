namespace T2_InterfazGrafica_de_Usuarios_ALLANM
{
    partial class frm_MenuPrincipal
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
            panel1 = new Panel();
            btn_Respaldos = new Button();
            btn_RespaldoBD = new Button();
            btn_Usuarios = new Button();
            btn_Asistencia = new Button();
            lbl_Mensaje = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 139, 80);
            panel1.Controls.Add(btn_Respaldos);
            panel1.Controls.Add(btn_RespaldoBD);
            panel1.Controls.Add(btn_Usuarios);
            panel1.Controls.Add(btn_Asistencia);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 484);
            panel1.TabIndex = 0;
            // 
            // btn_Respaldos
            // 
            btn_Respaldos.Dock = DockStyle.Top;
            btn_Respaldos.Location = new Point(0, 297);
            btn_Respaldos.Name = "btn_Respaldos";
            btn_Respaldos.Size = new Size(285, 99);
            btn_Respaldos.TabIndex = 1;
            btn_Respaldos.Text = "Resplados";
            btn_Respaldos.UseVisualStyleBackColor = true;
            // 
            // btn_RespaldoBD
            // 
            btn_RespaldoBD.Dock = DockStyle.Top;
            btn_RespaldoBD.Location = new Point(0, 198);
            btn_RespaldoBD.Name = "btn_RespaldoBD";
            btn_RespaldoBD.Size = new Size(285, 99);
            btn_RespaldoBD.TabIndex = 2;
            btn_RespaldoBD.Text = "Respaldos BD";
            btn_RespaldoBD.UseVisualStyleBackColor = true;
            // 
            // btn_Usuarios
            // 
            btn_Usuarios.Dock = DockStyle.Top;
            btn_Usuarios.Location = new Point(0, 99);
            btn_Usuarios.Name = "btn_Usuarios";
            btn_Usuarios.Size = new Size(285, 99);
            btn_Usuarios.TabIndex = 3;
            btn_Usuarios.Text = "Usuarios";
            btn_Usuarios.UseVisualStyleBackColor = true;
            btn_Usuarios.Click += btn_Usuarios_Click;
            // 
            // btn_Asistencia
            // 
            btn_Asistencia.Dock = DockStyle.Top;
            btn_Asistencia.Location = new Point(0, 0);
            btn_Asistencia.Name = "btn_Asistencia";
            btn_Asistencia.Size = new Size(285, 99);
            btn_Asistencia.TabIndex = 4;
            btn_Asistencia.Text = "Asistencia";
            btn_Asistencia.UseVisualStyleBackColor = true;
            btn_Asistencia.Click += button4_Click;
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mensaje.Location = new Point(307, 189);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(481, 38);
            lbl_Mensaje.TabIndex = 1;
            lbl_Mensaje.Text = "Bienvenido al menu principal";
            lbl_Mensaje.Click += label1_Click;
            // 
            // frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 484);
            Controls.Add(lbl_Mensaje);
            Controls.Add(panel1);
            Name = "frm_MenuPrincipal";
            Text = "Menu Principal";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Respaldos;
        private Button btn_RespaldoBD;
        private Button btn_Usuarios;
        private Button btn_Asistencia;
        private Label lbl_Mensaje;
    }
}
