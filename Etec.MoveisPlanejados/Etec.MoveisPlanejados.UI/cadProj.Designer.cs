namespace Etec.MoveisPlanejados.UI
{
    partial class cadProj
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
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDtEntrega = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.txtIdMovel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dgvProjetos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(133, 102);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(100, 20);
            this.txtIdCli.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "ID (Cliente)*:";
            // 
            // txtDtEntrega
            // 
            this.txtDtEntrega.Location = new System.Drawing.Point(133, 199);
            this.txtDtEntrega.Name = "txtDtEntrega";
            this.txtDtEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtDtEntrega.TabIndex = 42;
            // 
            // txtUF
            // 
            this.txtUF.AutoSize = true;
            this.txtUF.Location = new System.Drawing.Point(130, 182);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(92, 13);
            this.txtUF.TabIndex = 41;
            this.txtUF.Text = "Data de Entrega*:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 196);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 38;
            // 
            // txtCel
            // 
            this.txtCel.AutoSize = true;
            this.txtCel.Location = new System.Drawing.Point(9, 179);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(38, 13);
            this.txtCel.TabIndex = 37;
            this.txtCel.Text = "Preço:";
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Location = new System.Drawing.Point(9, 134);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(58, 13);
            this.txtSexo.TabIndex = 36;
            this.txtSexo.Text = "Descrição:";
            // 
            // txtIdMovel
            // 
            this.txtIdMovel.Location = new System.Drawing.Point(12, 102);
            this.txtIdMovel.Name = "txtIdMovel";
            this.txtIdMovel.Size = new System.Drawing.Size(100, 20);
            this.txtIdMovel.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID (Tipo do Móvel)*:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cadastro de Projeto";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 226);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(221, 23);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(12, 151);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(221, 20);
            this.txtDesc.TabIndex = 47;
            // 
            // dgvProjetos
            // 
            this.dgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjetos.Location = new System.Drawing.Point(255, 12);
            this.dgvProjetos.Name = "dgvProjetos";
            this.dgvProjetos.Size = new System.Drawing.Size(213, 237);
            this.dgvProjetos.TabIndex = 48;
            // 
            // cadProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.dgvProjetos);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDtEntrega);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtIdMovel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadProj";
            this.Text = "cadProj";
            this.Load += new System.EventHandler(this.cadProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDtEntrega;
        private System.Windows.Forms.Label txtUF;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label txtCel;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.TextBox txtIdMovel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DataGridView dgvProjetos;
    }
}