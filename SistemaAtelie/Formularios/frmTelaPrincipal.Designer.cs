
using System;

namespace SistemaAtelie.Formularios
{
    partial class frmTelaPrincipal
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
            System.Windows.Forms.LinkLabel lbRelatorio;
            System.Windows.Forms.LinkLabel lbEstoque;
            System.Windows.Forms.LinkLabel lbVenda;
            System.Windows.Forms.LinkLabel lbCliente;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            lbRelatorio = new System.Windows.Forms.LinkLabel();
            lbEstoque = new System.Windows.Forms.LinkLabel();
            lbVenda = new System.Windows.Forms.LinkLabel();
            lbCliente = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRelatorio
            // 
            lbRelatorio.AutoSize = true;
            lbRelatorio.BackColor = System.Drawing.Color.Black;
            lbRelatorio.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lbRelatorio.LinkColor = System.Drawing.Color.White;
            lbRelatorio.Location = new System.Drawing.Point(548, 9);
            lbRelatorio.Name = "lbRelatorio";
            lbRelatorio.Size = new System.Drawing.Size(150, 46);
            lbRelatorio.TabIndex = 10;
            lbRelatorio.TabStop = true;
            lbRelatorio.Text = "Pesquisa";
            lbRelatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbRelatorio_MouseClick);
            // 
            // lbEstoque
            // 
            lbEstoque.AutoSize = true;
            lbEstoque.BackColor = System.Drawing.Color.Black;
            lbEstoque.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lbEstoque.LinkColor = System.Drawing.Color.White;
            lbEstoque.Location = new System.Drawing.Point(193, 9);
            lbEstoque.Name = "lbEstoque";
            lbEstoque.Size = new System.Drawing.Size(150, 46);
            lbEstoque.TabIndex = 9;
            lbEstoque.TabStop = true;
            lbEstoque.Text = "Produtos";
            lbEstoque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbEstoque_MouseClick);
            // 
            // lbVenda
            // 
            lbVenda.AutoSize = true;
            lbVenda.BackColor = System.Drawing.Color.Black;
            lbVenda.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lbVenda.LinkColor = System.Drawing.Color.White;
            lbVenda.Location = new System.Drawing.Point(384, 9);
            lbVenda.Name = "lbVenda";
            lbVenda.Size = new System.Drawing.Size(111, 46);
            lbVenda.TabIndex = 8;
            lbVenda.TabStop = true;
            lbVenda.Text = "Venda";
            lbVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbVenda_MouseClick);
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.BackColor = System.Drawing.Color.Black;
            lbCliente.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lbCliente.LinkColor = System.Drawing.Color.White;
            lbCliente.Location = new System.Drawing.Point(12, 9);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new System.Drawing.Size(139, 46);
            lbCliente.TabIndex = 11;
            lbCliente.TabStop = true;
            lbCliente.Text = "Clientes";
            lbCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCliente_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2522, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(489, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 199);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mimos Ateliê";
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::SistemaAtelie.Properties.Resources.Textura_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(lbRelatorio);
            this.Controls.Add(lbVenda);
            this.Controls.Add(lbCliente);
            this.Controls.Add(lbEstoque);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}