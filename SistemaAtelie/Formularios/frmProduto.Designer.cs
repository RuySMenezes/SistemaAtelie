
namespace SistemaAtelie.Formularios
{
    partial class frmProduto
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
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProduto
            // 
            this.dgProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(324, 417);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.RowHeadersWidth = 51;
            this.dgProduto.RowTemplate.Height = 24;
            this.dgProduto.Size = new System.Drawing.Size(1391, 472);
            this.dgProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(290, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(908, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(1250, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(395, 79);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(373, 22);
            this.tbNome.TabIndex = 4;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(997, 79);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(95, 22);
            this.tbValor.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.btExcluir);
            this.panel1.Controls.Add(this.btEditar);
            this.panel1.Controls.Add(this.btCadastrar);
            this.panel1.Controls.Add(this.tbDescricao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbQuantidade);
            this.panel1.Controls.Add(this.tbValor);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(104, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1791, 255);
            this.panel1.TabIndex = 6;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.White;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisar.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.Location = new System.Drawing.Point(1225, 180);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(125, 51);
            this.btPesquisar.TabIndex = 11;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.White;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Location = new System.Drawing.Point(1629, 180);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(125, 51);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.White;
            this.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.Black;
            this.btEditar.Location = new System.Drawing.Point(1498, 180);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(125, 51);
            this.btEditar.TabIndex = 11;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btEditar_MouseClick);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.White;
            this.btCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btCadastrar.Location = new System.Drawing.Point(1356, 180);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(136, 51);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCadastrar_MouseClick);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(191, 180);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(978, 22);
            this.tbDescricao.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(69, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(1410, 81);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(71, 22);
            this.tbQuantidade.TabIndex = 6;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.White;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Black;
            this.btVoltar.Location = new System.Drawing.Point(31, 824);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(131, 65);
            this.btVoltar.TabIndex = 7;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btVoltar_MouseClick);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SistemaAtelie.Properties.Resources.Textura_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dgProduto);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btPesquisar;
    }
}