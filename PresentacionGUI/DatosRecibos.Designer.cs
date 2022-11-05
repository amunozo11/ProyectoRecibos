namespace PresentacionGUI
{
    partial class DatosRecibos
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
            this.panelRecibo = new System.Windows.Forms.Panel();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbConcepto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.CbBanco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateLimete = new System.Windows.Forms.DateTimePicker();
            this.DateExtra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.panelRecibo.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRecibo
            // 
            this.panelRecibo.Controls.Add(this.txtObservacion);
            this.panelRecibo.Controls.Add(this.label7);
            this.panelRecibo.Controls.Add(this.DateExtra);
            this.panelRecibo.Controls.Add(this.DateLimete);
            this.panelRecibo.Controls.Add(this.label6);
            this.panelRecibo.Controls.Add(this.label5);
            this.panelRecibo.Controls.Add(this.CbBanco);
            this.panelRecibo.Controls.Add(this.label4);
            this.panelRecibo.Controls.Add(this.txtValor);
            this.panelRecibo.Controls.Add(this.label3);
            this.panelRecibo.Controls.Add(this.CbConcepto);
            this.panelRecibo.Controls.Add(this.label2);
            this.panelRecibo.Controls.Add(this.txtReferencia);
            this.panelRecibo.Controls.Add(this.label1);
            this.panelRecibo.Controls.Add(this.panelBtn);
            this.panelRecibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecibo.Location = new System.Drawing.Point(0, 0);
            this.panelRecibo.Name = "panelRecibo";
            this.panelRecibo.Size = new System.Drawing.Size(668, 400);
            this.panelRecibo.TabIndex = 0;
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))));
            this.panelBtn.Controls.Add(this.BtnLimpiar);
            this.panelBtn.Controls.Add(this.btnCancelar);
            this.panelBtn.Controls.Add(this.btnAgregar);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtn.Location = new System.Drawing.Point(0, 354);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(668, 46);
            this.panelBtn.TabIndex = 36;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(263, 12);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 37;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(355, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(171, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferencia.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtReferencia.Location = new System.Drawing.Point(171, 55);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(201, 13);
            this.txtReferencia.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Referencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Concepto";
            // 
            // CbConcepto
            // 
            this.CbConcepto.BackColor = System.Drawing.Color.White;
            this.CbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbConcepto.ForeColor = System.Drawing.Color.Black;
            this.CbConcepto.FormattingEnabled = true;
            this.CbConcepto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CbConcepto.Location = new System.Drawing.Point(171, 90);
            this.CbConcepto.Name = "CbConcepto";
            this.CbConcepto.Size = new System.Drawing.Size(88, 21);
            this.CbConcepto.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtValor.Location = new System.Drawing.Point(171, 138);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(201, 13);
            this.txtValor.TabIndex = 42;
            // 
            // CbBanco
            // 
            this.CbBanco.BackColor = System.Drawing.Color.White;
            this.CbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBanco.ForeColor = System.Drawing.Color.Black;
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CbBanco.Location = new System.Drawing.Point(171, 168);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.Size = new System.Drawing.Size(88, 21);
            this.CbBanco.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(47, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fecha Limete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(47, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha Extraordinaria";
            // 
            // DateLimete
            // 
            this.DateLimete.Location = new System.Drawing.Point(171, 206);
            this.DateLimete.Name = "DateLimete";
            this.DateLimete.Size = new System.Drawing.Size(200, 20);
            this.DateLimete.TabIndex = 47;
            // 
            // DateExtra
            // 
            this.DateExtra.Location = new System.Drawing.Point(171, 236);
            this.DateExtra.Name = "DateExtra";
            this.DateExtra.Size = new System.Drawing.Size(200, 20);
            this.DateExtra.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(47, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(171, 275);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(201, 56);
            this.txtObservacion.TabIndex = 50;
            this.txtObservacion.Text = "";
            // 
            // DatosRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.panelRecibo);
            this.Name = "DatosRecibos";
            this.Text = "DatosRecibos";
            this.panelRecibo.ResumeLayout(false);
            this.panelRecibo.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecibo;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbConcepto;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateExtra;
        private System.Windows.Forms.DateTimePicker DateLimete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
    }
}