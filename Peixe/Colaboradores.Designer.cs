namespace Peixe
{
    partial class Colaboradores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colaboradores));
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProgramador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mtbSalario = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnSalario,
            this.ColumnCpf,
            this.ColumnSexo,
            this.ColumnCargo,
            this.ColumnProgramador});
            this.dgvColaboradores.Location = new System.Drawing.Point(16, 264);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.Size = new System.Drawing.Size(493, 150);
            this.dgvColaboradores.TabIndex = 37;
            this.dgvColaboradores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradores_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.HeaderText = "Salario";
            this.ColumnSalario.Name = "ColumnSalario";
            this.ColumnSalario.ReadOnly = true;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "Cpf";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ColumnProgramador
            // 
            this.ColumnProgramador.HeaderText = "Programador";
            this.ColumnProgramador.Name = "ColumnProgramador";
            this.ColumnProgramador.ReadOnly = true;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(322, 111);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 29);
            this.txtCargo.TabIndex = 35;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(318, 84);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(61, 24);
            this.lblCargo.TabIndex = 34;
            this.lblCargo.Text = "Cargo";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(168, 159);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 24);
            this.lblSexo.TabIndex = 33;
            this.lblSexo.Text = "Sexo";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 159);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 24);
            this.lblSalario.TabIndex = 30;
            this.lblSalario.Text = "Salario";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(172, 111);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 29);
            this.txtCpf.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cpf";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(16, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 29);
            this.txtNome.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(105, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 24);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "0";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 24);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Código =";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 36);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(172, 222);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 36);
            this.btnDeletar.TabIndex = 39;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Outro..."});
            this.cbSexo.Location = new System.Drawing.Point(172, 184);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(100, 32);
            this.cbSexo.TabIndex = 41;
            // 
            // mtbSalario
            // 
            this.mtbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSalario.Location = new System.Drawing.Point(16, 186);
            this.mtbSalario.Mask = "99999,99 ";
            this.mtbSalario.Name = "mtbSalario";
            this.mtbSalario.Size = new System.Drawing.Size(100, 29);
            this.mtbSalario.TabIndex = 42;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(322, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 28);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Programador";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mtbSalario);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvColaboradores);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.Colaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.MaskedTextBox mtbSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgramador;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}