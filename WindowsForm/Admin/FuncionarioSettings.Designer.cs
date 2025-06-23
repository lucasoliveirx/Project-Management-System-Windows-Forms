namespace ControleDeProjetos
{
    partial class FuncionarioSettings
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
            this.dgFuncionarios = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxFiltro = new System.Windows.Forms.ComboBox();
            this.btnRegistrarConsultor = new System.Windows.Forms.Button();
            this.btnRegistrarGerente = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFuncionarios
            // 
            this.dgFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Location = new System.Drawing.Point(277, 91);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.Size = new System.Drawing.Size(616, 465);
            this.dgFuncionarios.TabIndex = 107;
            this.dgFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionarios_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(14, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 110;
            this.label10.Text = "Funcionário:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(17, 109);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(164, 25);
            this.txtFuncionario.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(677, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 113;
            this.label1.Text = "Filtro:";
            // 
            // cboxFiltro
            // 
            this.cboxFiltro.FormattingEnabled = true;
            this.cboxFiltro.Items.AddRange(new object[] {
            "Consultor",
            "Gerente"});
            this.cboxFiltro.Location = new System.Drawing.Point(731, 51);
            this.cboxFiltro.Name = "cboxFiltro";
            this.cboxFiltro.Size = new System.Drawing.Size(162, 25);
            this.cboxFiltro.TabIndex = 112;
            this.cboxFiltro.SelectedIndexChanged += new System.EventHandler(this.cboxFiltro_SelectedIndexChanged_1);
            // 
            // btnRegistrarConsultor
            // 
            this.btnRegistrarConsultor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarConsultor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarConsultor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarConsultor.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarConsultor.Location = new System.Drawing.Point(17, 320);
            this.btnRegistrarConsultor.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarConsultor.Name = "btnRegistrarConsultor";
            this.btnRegistrarConsultor.Size = new System.Drawing.Size(213, 48);
            this.btnRegistrarConsultor.TabIndex = 114;
            this.btnRegistrarConsultor.Text = "Registrar Consultor";
            this.btnRegistrarConsultor.UseVisualStyleBackColor = false;
            this.btnRegistrarConsultor.Click += new System.EventHandler(this.btnRegistrarConsultor_Click);
            // 
            // btnRegistrarGerente
            // 
            this.btnRegistrarGerente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarGerente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGerente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarGerente.Location = new System.Drawing.Point(17, 376);
            this.btnRegistrarGerente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarGerente.Name = "btnRegistrarGerente";
            this.btnRegistrarGerente.Size = new System.Drawing.Size(213, 48);
            this.btnRegistrarGerente.TabIndex = 115;
            this.btnRegistrarGerente.Text = "Registrar Gerente";
            this.btnRegistrarGerente.UseVisualStyleBackColor = false;
            this.btnRegistrarGerente.Click += new System.EventHandler(this.btnRegistrarGerente_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.BackColor = System.Drawing.Color.White;
            this.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAtivar.Location = new System.Drawing.Point(17, 156);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(213, 49);
            this.btnAtivar.TabIndex = 117;
            this.btnAtivar.Text = "Ativar Funcionario";
            this.btnAtivar.UseVisualStyleBackColor = false;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click_1);
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.Color.White;
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativar.ForeColor = System.Drawing.Color.Crimson;
            this.btnInativar.Location = new System.Drawing.Point(17, 211);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(213, 49);
            this.btnInativar.TabIndex = 118;
            this.btnInativar.Text = "Inativar Funcionario";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Location = new System.Drawing.Point(17, 508);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 48);
            this.btnBack.TabIndex = 119;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 30);
            this.label3.TabIndex = 120;
            this.label3.Text = "Funcionário Settings";
            // 
            // FuncionarioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInativar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.btnRegistrarGerente);
            this.Controls.Add(this.btnRegistrarConsultor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxFiltro);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgFuncionarios);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FuncionarioSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionarioSettings";
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFuncionarios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxFiltro;
        private System.Windows.Forms.Button btnRegistrarConsultor;
        private System.Windows.Forms.Button btnRegistrarGerente;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
    }
}