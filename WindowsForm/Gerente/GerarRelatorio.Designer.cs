namespace ControleDeProjetos
{
    partial class GerarRelatorio
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
            this.dgProjeto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxConsultor = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProjeto
            // 
            this.dgProjeto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjeto.Location = new System.Drawing.Point(31, 93);
            this.dgProjeto.Name = "dgProjeto";
            this.dgProjeto.Size = new System.Drawing.Size(863, 440);
            this.dgProjeto.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(619, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 101;
            this.label4.Text = "Usuário";
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new System.Drawing.Point(682, 21);
            this.txtGerente.Margin = new System.Windows.Forms.Padding(4);
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.ReadOnly = true;
            this.txtGerente.Size = new System.Drawing.Size(212, 25);
            this.txtGerente.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 99;
            this.label3.Text = "Gerar Relatório";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(678, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 103;
            this.label10.Text = "Status:";
            // 
            // cboxStatus
            // 
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Items.AddRange(new object[] {
            "Todos os Projetos",
            "Em Planejamento",
            "Em Execução",
            "Paralisado",
            "Encerrado"});
            this.cboxStatus.Location = new System.Drawing.Point(732, 62);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(162, 25);
            this.cboxStatus.TabIndex = 102;
            this.cboxStatus.SelectedIndexChanged += new System.EventHandler(this.cboxStatus_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(417, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Consultor:";
            // 
            // cboxConsultor
            // 
            this.cboxConsultor.FormattingEnabled = true;
            this.cboxConsultor.Items.AddRange(new object[] {
            "Todos os Projetos",
            "Em Planejamento",
            "Em Execução",
            "Paralisado",
            "Encerrado"});
            this.cboxConsultor.Location = new System.Drawing.Point(496, 65);
            this.cboxConsultor.Name = "cboxConsultor";
            this.cboxConsultor.Size = new System.Drawing.Size(162, 25);
            this.cboxConsultor.TabIndex = 104;
            this.cboxConsultor.SelectedIndexChanged += new System.EventHandler(this.cboxConsultor_SelectedIndexChanged_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Location = new System.Drawing.Point(682, 540);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(212, 48);
            this.btnBack.TabIndex = 106;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(461, 540);
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(213, 48);
            this.btnGerarRelatorio.TabIndex = 107;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // GerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 610);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxConsultor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGerente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgProjeto);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerarRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dgProjeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgProjeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGerente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxConsultor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}