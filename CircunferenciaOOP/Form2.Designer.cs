
namespace CircunferenciaOOP
{
    partial class Form2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblPi = new System.Windows.Forms.Label();
            this.textBoxRaio = new System.Windows.Forms.TextBox();
            this.textBoxPi = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(76, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule Area Circunferência";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRaio.Location = new System.Drawing.Point(33, 147);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(103, 21);
            this.lblRaio.TabIndex = 1;
            this.lblRaio.Text = "Valor do raio:";
            // 
            // lblPi
            // 
            this.lblPi.AutoSize = true;
            this.lblPi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPi.Location = new System.Drawing.Point(33, 219);
            this.lblPi.Name = "lblPi";
            this.lblPi.Size = new System.Drawing.Size(89, 21);
            this.lblPi.TabIndex = 2;
            this.lblPi.Text = "Valor do pi:";
            // 
            // textBoxRaio
            // 
            this.textBoxRaio.Location = new System.Drawing.Point(33, 174);
            this.textBoxRaio.Name = "textBoxRaio";
            this.textBoxRaio.Size = new System.Drawing.Size(136, 23);
            this.textBoxRaio.TabIndex = 3;
            // 
            // textBoxPi
            // 
            this.textBoxPi.Location = new System.Drawing.Point(33, 247);
            this.textBoxPi.Name = "textBoxPi";
            this.textBoxPi.Size = new System.Drawing.Size(136, 23);
            this.textBoxPi.TabIndex = 4;
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClique.Location = new System.Drawing.Point(21, 374);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(100, 35);
            this.btnClique.TabIndex = 5;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(149, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(278, 374);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CircunferenciaOOP.Properties.Resources.area_circulo1;
            this.pictureBox1.Location = new System.Drawing.Point(185, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.textBoxPi);
            this.Controls.Add(this.textBoxRaio);
            this.Controls.Add(this.lblPi);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Circunferência";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblPi;
        private System.Windows.Forms.TextBox textBoxRaio;
        private System.Windows.Forms.TextBox textBoxPi;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}