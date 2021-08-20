
namespace aula_wf03
{
    partial class EXEC02
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
            this.btnsair = new System.Windows.Forms.Button();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.checkAdd = new System.Windows.Forms.CheckBox();
            this.checkRemover = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lime;
            this.btnsair.Location = new System.Drawing.Point(598, 485);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(162, 42);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.AllowUserToOrderColumns = true;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.NomeCol,
            this.PrecoCol});
            this.dgProduto.Location = new System.Drawing.Point(22, 19);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.Size = new System.Drawing.Size(738, 295);
            this.dgProduto.TabIndex = 1;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "Id";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Width = 60;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 200;
            // 
            // PrecoCol
            // 
            this.PrecoCol.HeaderText = "Preco";
            this.PrecoCol.Name = "PrecoCol";
            this.PrecoCol.ReadOnly = true;
            // 
            // btnExecuta
            // 
            this.btnExecuta.BackColor = System.Drawing.Color.Fuchsia;
            this.btnExecuta.ForeColor = System.Drawing.Color.Black;
            this.btnExecuta.Location = new System.Drawing.Point(409, 485);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(162, 42);
            this.btnExecuta.TabIndex = 2;
            this.btnExecuta.Text = "executa";
            this.btnExecuta.UseVisualStyleBackColor = false;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // checkAdd
            // 
            this.checkAdd.AutoSize = true;
            this.checkAdd.Location = new System.Drawing.Point(22, 493);
            this.checkAdd.Name = "checkAdd";
            this.checkAdd.Size = new System.Drawing.Size(109, 28);
            this.checkAdd.TabIndex = 3;
            this.checkAdd.Text = "Adicionar";
            this.checkAdd.UseVisualStyleBackColor = true;
            this.checkAdd.CheckedChanged += new System.EventHandler(this.checkAdd_CheckedChanged);
            // 
            // checkRemover
            // 
            this.checkRemover.AutoSize = true;
            this.checkRemover.Location = new System.Drawing.Point(151, 493);
            this.checkRemover.Name = "checkRemover";
            this.checkRemover.Size = new System.Drawing.Size(106, 28);
            this.checkRemover.TabIndex = 4;
            this.checkRemover.Text = "Remover";
            this.checkRemover.UseVisualStyleBackColor = true;
            this.checkRemover.CheckedChanged += new System.EventHandler(this.checkRemover_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 325);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 362);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(60, 24);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preco";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(12, 395);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(110, 24);
            this.lblFornecedor.TabIndex = 7;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 320);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 29);
            this.txtNome.TabIndex = 8;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(128, 357);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(241, 29);
            this.txtPreco.TabIndex = 9;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(128, 392);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(241, 29);
            this.txtFornecedor.TabIndex = 10;
            // 
            // EXEC02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.checkRemover);
            this.Controls.Add(this.checkAdd);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.dgProduto);
            this.Controls.Add(this.btnsair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EXEC02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXEC02";
            this.Load += new System.EventHandler(this.EXEC02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCol;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.CheckBox checkAdd;
        private System.Windows.Forms.CheckBox checkRemover;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtFornecedor;
    }
}