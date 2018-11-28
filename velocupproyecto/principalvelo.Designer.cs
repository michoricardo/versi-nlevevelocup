namespace velocupproyecto
{
    partial class principalvelo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principalvelo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botoningresar = new System.Windows.Forms.PictureBox();
            this.botonminimizar = new System.Windows.Forms.PictureBox();
            this.botoncerrar = new System.Windows.Forms.PictureBox();
            this.labelhora = new System.Windows.Forms.Label();
            this.labelfecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textousuario = new System.Windows.Forms.TextBox();
            this.textopassword = new System.Windows.Forms.TextBox();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botoningresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botoncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Usuariolabel);
            this.panel1.Controls.Add(this.textopassword);
            this.panel1.Controls.Add(this.textousuario);
            this.panel1.Controls.Add(this.botoningresar);
            this.panel1.Controls.Add(this.botonminimizar);
            this.panel1.Controls.Add(this.botoncerrar);
            this.panel1.Controls.Add(this.labelhora);
            this.panel1.Controls.Add(this.labelfecha);
            this.panel1.Location = new System.Drawing.Point(142, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 280);
            this.panel1.TabIndex = 8;
            // 
            // botoningresar
            // 
            this.botoningresar.BackColor = System.Drawing.Color.Transparent;
            this.botoningresar.BackgroundImage = global::velocupproyecto.Properties.Resources.btn_ingresar;
            this.botoningresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoningresar.Location = new System.Drawing.Point(47, 101);
            this.botoningresar.Name = "botoningresar";
            this.botoningresar.Size = new System.Drawing.Size(60, 52);
            this.botoningresar.TabIndex = 5;
            this.botoningresar.TabStop = false;
            this.botoningresar.Click += new System.EventHandler(this.botoningresar_Click);
            this.botoningresar.MouseLeave += new System.EventHandler(this.botoningresar_MouseLeave);
            this.botoningresar.MouseHover += new System.EventHandler(this.botoningresar_MouseHover);
            // 
            // botonminimizar
            // 
            this.botonminimizar.Image = global::velocupproyecto.Properties.Resources.btn_min;
            this.botonminimizar.Location = new System.Drawing.Point(44, 3);
            this.botonminimizar.Name = "botonminimizar";
            this.botonminimizar.Size = new System.Drawing.Size(35, 28);
            this.botonminimizar.TabIndex = 4;
            this.botonminimizar.TabStop = false;
            this.botonminimizar.Click += new System.EventHandler(this.botonminimizar_Click);
            // 
            // botoncerrar
            // 
            this.botoncerrar.Image = global::velocupproyecto.Properties.Resources.btn_cerrar;
            this.botoncerrar.Location = new System.Drawing.Point(3, 3);
            this.botoncerrar.Name = "botoncerrar";
            this.botoncerrar.Size = new System.Drawing.Size(35, 28);
            this.botoncerrar.TabIndex = 3;
            this.botoncerrar.TabStop = false;
            this.botoncerrar.Click += new System.EventHandler(this.botoncerrar_Click);
            // 
            // labelhora
            // 
            this.labelhora.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhora.Location = new System.Drawing.Point(269, 40);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(192, 26);
            this.labelhora.TabIndex = 2;
            this.labelhora.Text = "Hora:";
            this.labelhora.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelfecha
            // 
            this.labelfecha.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.Location = new System.Drawing.Point(265, 13);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(256, 27);
            this.labelfecha.TabIndex = 1;
            this.labelfecha.Text = "Fecha:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textousuario
            // 
            this.textousuario.BackColor = System.Drawing.Color.SkyBlue;
            this.textousuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textousuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textousuario.Location = new System.Drawing.Point(124, 175);
            this.textousuario.Name = "textousuario";
            this.textousuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textousuario.Size = new System.Drawing.Size(271, 19);
            this.textousuario.TabIndex = 6;
            // 
            // textopassword
            // 
            this.textopassword.BackColor = System.Drawing.Color.SkyBlue;
            this.textopassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textopassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textopassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textopassword.Location = new System.Drawing.Point(124, 219);
            this.textopassword.Name = "textopassword";
            this.textopassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textopassword.Size = new System.Drawing.Size(271, 19);
            this.textopassword.TabIndex = 7;
            this.textopassword.UseSystemPasswordChar = true;
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.BackColor = System.Drawing.Color.DarkGray;
            this.Usuariolabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolabel.Location = new System.Drawing.Point(37, 176);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(70, 18);
            this.Usuariolabel.TabIndex = 8;
            this.Usuariolabel.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // principalvelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::velocupproyecto.Properties.Resources.ciclismofondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principalvelo";
            this.Text = "principalvelo";
            this.Load += new System.EventHandler(this.principalvelo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.principalvelo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.principalvelo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.principalvelo_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botoningresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botoncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox botoncerrar;
        private System.Windows.Forms.PictureBox botonminimizar;
        private System.Windows.Forms.PictureBox botoningresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.TextBox textopassword;
        private System.Windows.Forms.TextBox textousuario;
    }
}