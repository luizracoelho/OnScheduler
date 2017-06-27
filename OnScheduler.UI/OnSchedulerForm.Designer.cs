namespace OnScheduler.UI
{
    partial class OnSchedulerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components/* = null*/;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnSchedulerForm));
            this.agendamentoDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoSazonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OnSchedulerTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalvarDiarioButton = new System.Windows.Forms.Button();
            this.AgendamentoDiarioDataGridView = new System.Windows.Forms.DataGridView();
            this.IdDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoDiarioTextBox = new System.Windows.Forms.TextBox();
            this.DomingoCheckBox = new System.Windows.Forms.CheckBox();
            this.TercaCheckBox = new System.Windows.Forms.CheckBox();
            this.QuartaCheckBox = new System.Windows.Forms.CheckBox();
            this.QuintaCheckBox = new System.Windows.Forms.CheckBox();
            this.SextaCheckBox = new System.Windows.Forms.CheckBox();
            this.SabadoCheckBox = new System.Windows.Forms.CheckBox();
            this.DomingoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SegundaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TercaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.QuartaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.QuintaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SextaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SabadoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SegundaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlDiarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdDiarioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SalvarSazonalButton = new System.Windows.Forms.Button();
            this.AgendamentoSazonalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSazonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoAvisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlSazonalTextBox = new System.Windows.Forms.TextBox();
            this.DescricaoSazonalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdSazonalTextBox = new System.Windows.Forms.TextBox();
            this.TipoSazonalidadeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SazonalidadeTextBox = new System.Windows.Forms.TextBox();
            this.SalvarDiarioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalvarSazonalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalvarDiarioToolStripMenu = new System.Windows.Forms.ToolStripButton();
            this.SalvarSazonalToolStripMenu = new System.Windows.Forms.ToolStripButton();
            this.SalvarDiariotoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoSazonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoDiarioDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoSazonalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // agendamentoDiarioBindingSource
            // 
            this.agendamentoDiarioBindingSource.DataSource = typeof(OnScheduler.AgendamentoDiario);
            // 
            // agendamentoSazonalBindingSource
            // 
            this.agendamentoSazonalBindingSource.DataSource = typeof(OnScheduler.AgendamentoSazonal);
            // 
            // OnSchedulerTimer
            // 
            this.OnSchedulerTimer.Interval = 9000;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 629);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SalvarDiarioButton);
            this.groupBox1.Controls.Add(this.AgendamentoDiarioDataGridView);
            this.groupBox1.Controls.Add(this.DescricaoDiarioTextBox);
            this.groupBox1.Controls.Add(this.DomingoCheckBox);
            this.groupBox1.Controls.Add(this.TercaCheckBox);
            this.groupBox1.Controls.Add(this.QuartaCheckBox);
            this.groupBox1.Controls.Add(this.QuintaCheckBox);
            this.groupBox1.Controls.Add(this.SextaCheckBox);
            this.groupBox1.Controls.Add(this.SabadoCheckBox);
            this.groupBox1.Controls.Add(this.DomingoDateTimePicker);
            this.groupBox1.Controls.Add(this.SegundaDateTimePicker);
            this.groupBox1.Controls.Add(this.TercaDateTimePicker);
            this.groupBox1.Controls.Add(this.QuartaDateTimePicker);
            this.groupBox1.Controls.Add(this.QuintaDateTimePicker);
            this.groupBox1.Controls.Add(this.SextaDateTimePicker);
            this.groupBox1.Controls.Add(this.SabadoDateTimePicker);
            this.groupBox1.Controls.Add(this.SegundaCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UrlDiarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdDiarioTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diário";
            // 
            // SalvarDiarioButton
            // 
            this.SalvarDiarioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SalvarDiarioButton.Location = new System.Drawing.Point(6, 252);
            this.SalvarDiarioButton.Name = "SalvarDiarioButton";
            this.SalvarDiarioButton.Size = new System.Drawing.Size(75, 23);
            this.SalvarDiarioButton.TabIndex = 16;
            this.SalvarDiarioButton.Text = "Salvar";
            this.SalvarDiarioButton.UseVisualStyleBackColor = true;
            this.SalvarDiarioButton.Click += new System.EventHandler(this.SalvarDiarioButton_Click);
            // 
            // AgendamentoDiarioDataGridView
            // 
            this.AgendamentoDiarioDataGridView.AllowUserToAddRows = false;
            this.AgendamentoDiarioDataGridView.AllowUserToDeleteRows = false;
            this.AgendamentoDiarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgendamentoDiarioDataGridView.AutoGenerateColumns = false;
            this.AgendamentoDiarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AgendamentoDiarioDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.AgendamentoDiarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgendamentoDiarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendamentoDiarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDiario,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.AgendamentoDiarioDataGridView.DataSource = this.agendamentoDiarioBindingSource;
            this.AgendamentoDiarioDataGridView.Location = new System.Drawing.Point(557, 25);
            this.AgendamentoDiarioDataGridView.Name = "AgendamentoDiarioDataGridView";
            this.AgendamentoDiarioDataGridView.ReadOnly = true;
            this.AgendamentoDiarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgendamentoDiarioDataGridView.Size = new System.Drawing.Size(415, 204);
            this.AgendamentoDiarioDataGridView.TabIndex = 95;
            this.AgendamentoDiarioDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendamentoDiarioDataGridView_CellDoubleClick);
            this.AgendamentoDiarioDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgendamentoDiarioDataGridView_KeyDown);
            // 
            // IdDiario
            // 
            this.IdDiario.DataPropertyName = "Id";
            this.IdDiario.HeaderText = "Id";
            this.IdDiario.Name = "IdDiario";
            this.IdDiario.ReadOnly = true;
            this.IdDiario.Visible = false;
            this.IdDiario.Width = 218;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn3.HeaderText = "Url";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 48;
            // 
            // DescricaoDiarioTextBox
            // 
            this.DescricaoDiarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescricaoDiarioTextBox.Location = new System.Drawing.Point(163, 25);
            this.DescricaoDiarioTextBox.Name = "DescricaoDiarioTextBox";
            this.DescricaoDiarioTextBox.Size = new System.Drawing.Size(388, 20);
            this.DescricaoDiarioTextBox.TabIndex = 0;
            // 
            // DomingoCheckBox
            // 
            this.DomingoCheckBox.AutoSize = true;
            this.DomingoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomingoCheckBox.Location = new System.Drawing.Point(9, 73);
            this.DomingoCheckBox.Name = "DomingoCheckBox";
            this.DomingoCheckBox.Size = new System.Drawing.Size(68, 17);
            this.DomingoCheckBox.TabIndex = 2;
            this.DomingoCheckBox.Text = "Domingo";
            this.DomingoCheckBox.UseVisualStyleBackColor = true;
            this.DomingoCheckBox.CheckedChanged += new System.EventHandler(this.DomingoCheckBox_CheckedChanged);
            // 
            // TercaCheckBox
            // 
            this.TercaCheckBox.AutoSize = true;
            this.TercaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TercaCheckBox.Location = new System.Drawing.Point(9, 121);
            this.TercaCheckBox.Name = "TercaCheckBox";
            this.TercaCheckBox.Size = new System.Drawing.Size(80, 17);
            this.TercaCheckBox.TabIndex = 6;
            this.TercaCheckBox.Text = "Terça-Feira";
            this.TercaCheckBox.UseVisualStyleBackColor = true;
            this.TercaCheckBox.CheckedChanged += new System.EventHandler(this.TercaCheckBox_CheckedChanged);
            // 
            // QuartaCheckBox
            // 
            this.QuartaCheckBox.AutoSize = true;
            this.QuartaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuartaCheckBox.Location = new System.Drawing.Point(9, 145);
            this.QuartaCheckBox.Name = "QuartaCheckBox";
            this.QuartaCheckBox.Size = new System.Drawing.Size(84, 17);
            this.QuartaCheckBox.TabIndex = 8;
            this.QuartaCheckBox.Text = "Quarta-Feira";
            this.QuartaCheckBox.UseVisualStyleBackColor = true;
            this.QuartaCheckBox.CheckedChanged += new System.EventHandler(this.QuartaCheckBox_CheckedChanged);
            // 
            // QuintaCheckBox
            // 
            this.QuintaCheckBox.AutoSize = true;
            this.QuintaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuintaCheckBox.Location = new System.Drawing.Point(9, 169);
            this.QuintaCheckBox.Name = "QuintaCheckBox";
            this.QuintaCheckBox.Size = new System.Drawing.Size(83, 17);
            this.QuintaCheckBox.TabIndex = 10;
            this.QuintaCheckBox.Text = "Quinta-Feira";
            this.QuintaCheckBox.UseVisualStyleBackColor = true;
            this.QuintaCheckBox.CheckedChanged += new System.EventHandler(this.QuintaCheckBox_CheckedChanged);
            // 
            // SextaCheckBox
            // 
            this.SextaCheckBox.AutoSize = true;
            this.SextaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SextaCheckBox.Location = new System.Drawing.Point(9, 193);
            this.SextaCheckBox.Name = "SextaCheckBox";
            this.SextaCheckBox.Size = new System.Drawing.Size(79, 17);
            this.SextaCheckBox.TabIndex = 12;
            this.SextaCheckBox.Text = "Sexta-Feira";
            this.SextaCheckBox.UseVisualStyleBackColor = true;
            this.SextaCheckBox.CheckedChanged += new System.EventHandler(this.SextaCheckBox_CheckedChanged);
            // 
            // SabadoCheckBox
            // 
            this.SabadoCheckBox.AutoSize = true;
            this.SabadoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SabadoCheckBox.Location = new System.Drawing.Point(9, 217);
            this.SabadoCheckBox.Name = "SabadoCheckBox";
            this.SabadoCheckBox.Size = new System.Drawing.Size(63, 17);
            this.SabadoCheckBox.TabIndex = 14;
            this.SabadoCheckBox.Text = "Sábado";
            this.SabadoCheckBox.UseVisualStyleBackColor = true;
            this.SabadoCheckBox.CheckedChanged += new System.EventHandler(this.SabadoCheckBox_CheckedChanged);
            // 
            // DomingoDateTimePicker
            // 
            this.DomingoDateTimePicker.CustomFormat = "HH:mm";
            this.DomingoDateTimePicker.Enabled = false;
            this.DomingoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomingoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DomingoDateTimePicker.Location = new System.Drawing.Point(163, 73);
            this.DomingoDateTimePicker.Name = "DomingoDateTimePicker";
            this.DomingoDateTimePicker.ShowUpDown = true;
            this.DomingoDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.DomingoDateTimePicker.TabIndex = 3;
            // 
            // SegundaDateTimePicker
            // 
            this.SegundaDateTimePicker.CustomFormat = "HH:mm";
            this.SegundaDateTimePicker.Enabled = false;
            this.SegundaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegundaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SegundaDateTimePicker.Location = new System.Drawing.Point(163, 97);
            this.SegundaDateTimePicker.Name = "SegundaDateTimePicker";
            this.SegundaDateTimePicker.ShowUpDown = true;
            this.SegundaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.SegundaDateTimePicker.TabIndex = 5;
            // 
            // TercaDateTimePicker
            // 
            this.TercaDateTimePicker.CustomFormat = "HH:mm";
            this.TercaDateTimePicker.Enabled = false;
            this.TercaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TercaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TercaDateTimePicker.Location = new System.Drawing.Point(163, 121);
            this.TercaDateTimePicker.Name = "TercaDateTimePicker";
            this.TercaDateTimePicker.ShowUpDown = true;
            this.TercaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.TercaDateTimePicker.TabIndex = 7;
            // 
            // QuartaDateTimePicker
            // 
            this.QuartaDateTimePicker.CustomFormat = "HH:mm";
            this.QuartaDateTimePicker.Enabled = false;
            this.QuartaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuartaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.QuartaDateTimePicker.Location = new System.Drawing.Point(163, 145);
            this.QuartaDateTimePicker.Name = "QuartaDateTimePicker";
            this.QuartaDateTimePicker.ShowUpDown = true;
            this.QuartaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.QuartaDateTimePicker.TabIndex = 9;
            // 
            // QuintaDateTimePicker
            // 
            this.QuintaDateTimePicker.CustomFormat = "HH:mm";
            this.QuintaDateTimePicker.Enabled = false;
            this.QuintaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuintaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.QuintaDateTimePicker.Location = new System.Drawing.Point(163, 169);
            this.QuintaDateTimePicker.Name = "QuintaDateTimePicker";
            this.QuintaDateTimePicker.ShowUpDown = true;
            this.QuintaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.QuintaDateTimePicker.TabIndex = 11;
            // 
            // SextaDateTimePicker
            // 
            this.SextaDateTimePicker.CustomFormat = "HH:mm";
            this.SextaDateTimePicker.Enabled = false;
            this.SextaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SextaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SextaDateTimePicker.Location = new System.Drawing.Point(163, 193);
            this.SextaDateTimePicker.Name = "SextaDateTimePicker";
            this.SextaDateTimePicker.ShowUpDown = true;
            this.SextaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.SextaDateTimePicker.TabIndex = 13;
            // 
            // SabadoDateTimePicker
            // 
            this.SabadoDateTimePicker.CustomFormat = "HH:mm";
            this.SabadoDateTimePicker.Enabled = false;
            this.SabadoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SabadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SabadoDateTimePicker.Location = new System.Drawing.Point(163, 217);
            this.SabadoDateTimePicker.Name = "SabadoDateTimePicker";
            this.SabadoDateTimePicker.ShowUpDown = true;
            this.SabadoDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.SabadoDateTimePicker.TabIndex = 15;
            // 
            // SegundaCheckBox
            // 
            this.SegundaCheckBox.AutoSize = true;
            this.SegundaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegundaCheckBox.Location = new System.Drawing.Point(9, 97);
            this.SegundaCheckBox.Name = "SegundaCheckBox";
            this.SegundaCheckBox.Size = new System.Drawing.Size(95, 17);
            this.SegundaCheckBox.TabIndex = 4;
            this.SegundaCheckBox.Text = "Segunda-Feira";
            this.SegundaCheckBox.UseVisualStyleBackColor = true;
            this.SegundaCheckBox.CheckedChanged += new System.EventHandler(this.SegundaCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 88;
            this.label1.Text = "URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UrlDiarioTextBox
            // 
            this.UrlDiarioTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UrlDiarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlDiarioTextBox.Location = new System.Drawing.Point(163, 49);
            this.UrlDiarioTextBox.Name = "UrlDiarioTextBox";
            this.UrlDiarioTextBox.Size = new System.Drawing.Size(388, 20);
            this.UrlDiarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Descrição:";
            // 
            // IdDiarioTextBox
            // 
            this.IdDiarioTextBox.Location = new System.Drawing.Point(4, 242);
            this.IdDiarioTextBox.Name = "IdDiarioTextBox";
            this.IdDiarioTextBox.Size = new System.Drawing.Size(100, 21);
            this.IdDiarioTextBox.TabIndex = 90;
            this.IdDiarioTextBox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SalvarSazonalButton);
            this.groupBox2.Controls.Add(this.AgendamentoSazonalDataGridView);
            this.groupBox2.Controls.Add(this.UrlSazonalTextBox);
            this.groupBox2.Controls.Add(this.DescricaoSazonalTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.IdSazonalTextBox);
            this.groupBox2.Controls.Add(this.TipoSazonalidadeComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SazonalidadeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 309);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sazonal";
            // 
            // SalvarSazonalButton
            // 
            this.SalvarSazonalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SalvarSazonalButton.Location = new System.Drawing.Point(6, 280);
            this.SalvarSazonalButton.Name = "SalvarSazonalButton";
            this.SalvarSazonalButton.Size = new System.Drawing.Size(75, 23);
            this.SalvarSazonalButton.TabIndex = 21;
            this.SalvarSazonalButton.Text = "Salvar";
            this.SalvarSazonalButton.UseVisualStyleBackColor = true;
            this.SalvarSazonalButton.Click += new System.EventHandler(this.SalvarSazonalButton_Click);
            // 
            // AgendamentoSazonalDataGridView
            // 
            this.AgendamentoSazonalDataGridView.AllowUserToAddRows = false;
            this.AgendamentoSazonalDataGridView.AllowUserToDeleteRows = false;
            this.AgendamentoSazonalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgendamentoSazonalDataGridView.AutoGenerateColumns = false;
            this.AgendamentoSazonalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AgendamentoSazonalDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.AgendamentoSazonalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgendamentoSazonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendamentoSazonalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.IdSazonal,
            this.dataGridViewTextBoxColumn5,
            this.tempoAvisoDataGridViewTextBoxColumn});
            this.AgendamentoSazonalDataGridView.DataSource = this.agendamentoSazonalBindingSource;
            this.AgendamentoSazonalDataGridView.Location = new System.Drawing.Point(557, 27);
            this.AgendamentoSazonalDataGridView.Name = "AgendamentoSazonalDataGridView";
            this.AgendamentoSazonalDataGridView.ReadOnly = true;
            this.AgendamentoSazonalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgendamentoSazonalDataGridView.Size = new System.Drawing.Size(415, 233);
            this.AgendamentoSazonalDataGridView.TabIndex = 38;
            this.AgendamentoSazonalDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendamentoSazonalDataGridView_CellDoubleClick);
            this.AgendamentoSazonalDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgendamentoSazonalDataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // IdSazonal
            // 
            this.IdSazonal.DataPropertyName = "Id";
            this.IdSazonal.HeaderText = "Id";
            this.IdSazonal.Name = "IdSazonal";
            this.IdSazonal.ReadOnly = true;
            this.IdSazonal.Visible = false;
            this.IdSazonal.Width = 41;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn5.HeaderText = "Url";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 45;
            // 
            // tempoAvisoDataGridViewTextBoxColumn
            // 
            this.tempoAvisoDataGridViewTextBoxColumn.DataPropertyName = "Sazonalidade";
            this.tempoAvisoDataGridViewTextBoxColumn.HeaderText = "Sazonalidade";
            this.tempoAvisoDataGridViewTextBoxColumn.Name = "tempoAvisoDataGridViewTextBoxColumn";
            this.tempoAvisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempoAvisoDataGridViewTextBoxColumn.Width = 96;
            // 
            // UrlSazonalTextBox
            // 
            this.UrlSazonalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UrlSazonalTextBox.Location = new System.Drawing.Point(163, 55);
            this.UrlSazonalTextBox.Name = "UrlSazonalTextBox";
            this.UrlSazonalTextBox.Size = new System.Drawing.Size(388, 20);
            this.UrlSazonalTextBox.TabIndex = 18;
            // 
            // DescricaoSazonalTextBox
            // 
            this.DescricaoSazonalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DescricaoSazonalTextBox.Location = new System.Drawing.Point(163, 27);
            this.DescricaoSazonalTextBox.Name = "DescricaoSazonalTextBox";
            this.DescricaoSazonalTextBox.Size = new System.Drawing.Size(388, 20);
            this.DescricaoSazonalTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "URL:";
            // 
            // IdSazonalTextBox
            // 
            this.IdSazonalTextBox.Location = new System.Drawing.Point(432, 83);
            this.IdSazonalTextBox.Name = "IdSazonalTextBox";
            this.IdSazonalTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdSazonalTextBox.TabIndex = 37;
            this.IdSazonalTextBox.Visible = false;
            // 
            // TipoSazonalidadeComboBox
            // 
            this.TipoSazonalidadeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TipoSazonalidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoSazonalidadeComboBox.FormattingEnabled = true;
            this.TipoSazonalidadeComboBox.Location = new System.Drawing.Point(286, 82);
            this.TipoSazonalidadeComboBox.Name = "TipoSazonalidadeComboBox";
            this.TipoSazonalidadeComboBox.Size = new System.Drawing.Size(142, 21);
            this.TipoSazonalidadeComboBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Sazonalidade:";
            // 
            // SazonalidadeTextBox
            // 
            this.SazonalidadeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SazonalidadeTextBox.Location = new System.Drawing.Point(163, 82);
            this.SazonalidadeTextBox.Name = "SazonalidadeTextBox";
            this.SazonalidadeTextBox.Size = new System.Drawing.Size(117, 20);
            this.SazonalidadeTextBox.TabIndex = 19;
            this.SazonalidadeTextBox.Text = "0";
            // 
            // SalvarDiarioToolStripButton
            // 
            this.SalvarDiarioToolStripButton.Name = "SalvarDiarioToolStripButton";
            this.SalvarDiarioToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // SalvarSazonalToolStripButton
            // 
            this.SalvarSazonalToolStripButton.Name = "SalvarSazonalToolStripButton";
            this.SalvarSazonalToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // SalvarDiarioToolStripMenu
            // 
            this.SalvarDiarioToolStripMenu.Name = "SalvarDiarioToolStripMenu";
            this.SalvarDiarioToolStripMenu.Size = new System.Drawing.Size(23, 23);
            // 
            // SalvarSazonalToolStripMenu
            // 
            this.SalvarSazonalToolStripMenu.Name = "SalvarSazonalToolStripMenu";
            this.SalvarSazonalToolStripMenu.Size = new System.Drawing.Size(23, 23);
            // 
            // SalvarDiariotoolStripButton1
            // 
            this.SalvarDiariotoolStripButton1.Name = "SalvarDiariotoolStripButton1";
            this.SalvarDiariotoolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // OnSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(728, 478);
            this.Name = "OnSchedulerForm";
            this.Text = "OnScheduler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnScheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoSazonalBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoDiarioDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoSazonalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource agendamentoDiarioBindingSource;
        private System.Windows.Forms.BindingSource agendamentoSazonalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSazonalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer OnSchedulerTimer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView AgendamentoSazonalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSazonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoAvisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox UrlSazonalTextBox;
        private System.Windows.Forms.TextBox DescricaoSazonalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdSazonalTextBox;
        private System.Windows.Forms.ComboBox TipoSazonalidadeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SazonalidadeTextBox;
        private System.Windows.Forms.TextBox DescricaoDiarioTextBox;
        private System.Windows.Forms.CheckBox DomingoCheckBox;
        private System.Windows.Forms.CheckBox TercaCheckBox;
        private System.Windows.Forms.CheckBox QuartaCheckBox;
        private System.Windows.Forms.CheckBox QuintaCheckBox;
        private System.Windows.Forms.CheckBox SextaCheckBox;
        private System.Windows.Forms.CheckBox SabadoCheckBox;
        private System.Windows.Forms.DateTimePicker DomingoDateTimePicker;
        private System.Windows.Forms.DateTimePicker SegundaDateTimePicker;
        private System.Windows.Forms.DateTimePicker TercaDateTimePicker;
        private System.Windows.Forms.DateTimePicker QuartaDateTimePicker;
        private System.Windows.Forms.DateTimePicker QuintaDateTimePicker;
        private System.Windows.Forms.DateTimePicker SextaDateTimePicker;
        private System.Windows.Forms.DateTimePicker SabadoDateTimePicker;
        private System.Windows.Forms.CheckBox SegundaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlDiarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdDiarioTextBox;
        private System.Windows.Forms.ToolStripButton SalvarDiarioToolStripButton;
        private System.Windows.Forms.ToolStripButton SalvarSazonalToolStripButton;
        private System.Windows.Forms.DataGridView AgendamentoDiarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton SalvarDiarioToolStripMenu;
        private System.Windows.Forms.ToolStripButton SalvarSazonalToolStripMenu;
        private System.Windows.Forms.ToolStripButton SalvarDiariotoolStripButton1;
        private System.Windows.Forms.Button SalvarDiarioButton;
        private System.Windows.Forms.Button SalvarSazonalButton;
    }
}