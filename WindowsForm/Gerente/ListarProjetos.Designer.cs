namespace ControleDeProjetos
{
    partial class ListarProjetos
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
            this.label10 = new System.Windows.Forms.Label();
            this.cboxFiltro = new System.Windows.Forms.ComboBox();
            this.dgProjeto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserLogado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(679, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 108;
            this.label10.Text = "Filtro:";
            // 
            // cboxFiltro
            // 
            this.cboxFiltro.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos os Projetos",
            "Em Planejamento",
            "Em Execução",
            "Paralisado",
            "Encerrado"});
            this.cboxFiltro.FormattingEnabled = true;
            this.cboxFiltro.Items.AddRange(new object[] {
            "Todos os Projetos",
            "Em Planejamento",
            "Em Execução",
            "Paralisado",
            "Encerrado"});
            this.cboxFiltro.Location = new System.Drawing.Point(733, 50);
            this.cboxFiltro.Name = "cboxFiltro";
            this.cboxFiltro.Size = new System.Drawing.Size(162, 25);
            this.cboxFiltro.TabIndex = 107;
            this.cboxFiltro.SelectedIndexChanged += new System.EventHandler(this.cboxFiltro_SelectedIndexChanged_1);
            // 
            // dgProjeto
            // 
            this.dgProjeto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjeto.Location = new System.Drawing.Point(40, 81);
            this.dgProjeto.Name = "dgProjeto";
            this.dgProjeto.Size = new System.Drawing.Size(854, 465);
            this.dgProjeto.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(619, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Usuário";
            // 
            // txtUserLogado
            // 
            this.txtUserLogado.Location = new System.Drawing.Point(682, 13);
            this.txtUserLogado.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserLogado.Name = "txtUserLogado";
            this.txtUserLogado.ReadOnly = true;
            this.txtUserLogado.Size = new System.Drawing.Size(212, 25);
            this.txtUserLogado.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(35, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 103;
            this.label3.Text = "Listar Projetos";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Location = new System.Drawing.Point(682, 572);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(212, 48);
            this.btnBack.TabIndex = 102;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListarProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 633);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboxFiltro);
            this.Controls.Add(this.dgProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserLogado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarProjetos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProjeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxFiltro;
        private System.Windows.Forms.DataGridView dgProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserLogado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}