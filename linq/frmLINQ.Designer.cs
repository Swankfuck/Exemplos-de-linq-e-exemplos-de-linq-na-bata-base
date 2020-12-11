namespace linq
{
    partial class frmLINQ
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
            this.lista = new System.Windows.Forms.ListBox();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_executar = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(13, 52);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(673, 238);
            this.lista.TabIndex = 0;
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(692, 258);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(115, 33);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(692, 13);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(115, 72);
            this.cmd_executar.TabIndex = 3;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_resultado.Location = new System.Drawing.Point(13, 13);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(673, 23);
            this.label_resultado.TabIndex = 4;
            this.label_resultado.Text = "[ resultados ]";
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 303);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.cmd_executar);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLINQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ em C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label_resultado;
    }
}

