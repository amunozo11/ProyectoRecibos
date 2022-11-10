namespace PresentacionGUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSession = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(412, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(412, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(449, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicie Session Aqui";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(404, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(404, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(62)))), ((int)(((byte)(216)))));
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSession.Location = new System.Drawing.Point(403, 241);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(210, 40);
            this.btnSession.TabIndex = 11;
            this.btnSession.Text = "Iniciar Session";
            this.btnSession.UseVisualStyleBackColor = false;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(415, 137);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 13);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Location = new System.Drawing.Point(415, 195);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(191, 13);
            this.txtContraseña.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(612, 337);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(539, 343);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 15;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(666, 377);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistro);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegistro;
    }
}