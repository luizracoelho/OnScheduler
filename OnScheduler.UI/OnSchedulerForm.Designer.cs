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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDiario = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.AdicionarDiarioButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlDiarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdDiarioTextBox = new System.Windows.Forms.TextBox();
            this.AgendamentoDiarioDataGridView = new System.Windows.Forms.DataGridView();
            this.IdDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendamentoDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabSazonal = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.UrlSazonalTextBox = new System.Windows.Forms.TextBox();
            this.DescricaoSazonalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdicionarSazonalButton = new System.Windows.Forms.Button();
            this.IdSazonalTextBox = new System.Windows.Forms.TextBox();
            this.TipoSazonalidadeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SazonalidadeTextBox = new System.Windows.Forms.TextBox();
            this.AgendamentoSazonalDataGridView = new System.Windows.Forms.DataGridView();
            this.IdSazonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSazonalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoAvisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendamentoSazonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabDiario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoDiarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDiarioBindingSource)).BeginInit();
            this.tabSazonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoSazonalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoSazonalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDiario);
            this.tabControl.Controls.Add(this.tabSazonal);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(712, 439);
            this.tabControl.TabIndex = 1;
            // 
            // tabDiario
            // 
            this.tabDiario.Controls.Add(this.splitContainer1);
            this.tabDiario.Location = new System.Drawing.Point(4, 22);
            this.tabDiario.Name = "tabDiario";
            this.tabDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiario.Size = new System.Drawing.Size(704, 413);
            this.tabDiario.TabIndex = 2;
            this.tabDiario.Text = "Diário";
            this.tabDiario.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AgendamentoDiarioDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(698, 407);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.96875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.03125F));
            this.tableLayoutPanel1.Controls.Add(this.DescricaoDiarioTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DomingoCheckBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TercaCheckBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.QuartaCheckBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.QuintaCheckBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.SextaCheckBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.SabadoCheckBox, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.DomingoDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SegundaDateTimePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TercaDateTimePicker, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.QuartaDateTimePicker, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.QuintaDateTimePicker, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.SextaDateTimePicker, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.SabadoDateTimePicker, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.SegundaCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdicionarDiarioButton, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UrlDiarioTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdDiarioTextBox, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 230);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // DescricaoDiarioTextBox
            // 
            this.DescricaoDiarioTextBox.Location = new System.Drawing.Point(162, 3);
            this.DescricaoDiarioTextBox.Name = "DescricaoDiarioTextBox";
            this.DescricaoDiarioTextBox.Size = new System.Drawing.Size(388, 20);
            this.DescricaoDiarioTextBox.TabIndex = 0;
            // 
            // DomingoCheckBox
            // 
            this.DomingoCheckBox.AutoSize = true;
            this.DomingoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomingoCheckBox.Location = new System.Drawing.Point(3, 48);
            this.DomingoCheckBox.Name = "DomingoCheckBox";
            this.DomingoCheckBox.Size = new System.Drawing.Size(68, 16);
            this.DomingoCheckBox.TabIndex = 2;
            this.DomingoCheckBox.Text = "Domingo";
            this.DomingoCheckBox.UseVisualStyleBackColor = true;
            this.DomingoCheckBox.CheckedChanged += new System.EventHandler(this.DomingoCheckBox_CheckedChanged);
            // 
            // TercaCheckBox
            // 
            this.TercaCheckBox.AutoSize = true;
            this.TercaCheckBox.Location = new System.Drawing.Point(3, 92);
            this.TercaCheckBox.Name = "TercaCheckBox";
            this.TercaCheckBox.Size = new System.Drawing.Size(80, 16);
            this.TercaCheckBox.TabIndex = 6;
            this.TercaCheckBox.Text = "Terça-Feira";
            this.TercaCheckBox.UseVisualStyleBackColor = true;
            this.TercaCheckBox.CheckedChanged += new System.EventHandler(this.TercaCheckBox_CheckedChanged);
            // 
            // QuartaCheckBox
            // 
            this.QuartaCheckBox.AutoSize = true;
            this.QuartaCheckBox.Location = new System.Drawing.Point(3, 114);
            this.QuartaCheckBox.Name = "QuartaCheckBox";
            this.QuartaCheckBox.Size = new System.Drawing.Size(84, 16);
            this.QuartaCheckBox.TabIndex = 8;
            this.QuartaCheckBox.Text = "Quarta-Feira";
            this.QuartaCheckBox.UseVisualStyleBackColor = true;
            this.QuartaCheckBox.CheckedChanged += new System.EventHandler(this.QuartaCheckBox_CheckedChanged);
            // 
            // QuintaCheckBox
            // 
            this.QuintaCheckBox.AutoSize = true;
            this.QuintaCheckBox.Location = new System.Drawing.Point(3, 136);
            this.QuintaCheckBox.Name = "QuintaCheckBox";
            this.QuintaCheckBox.Size = new System.Drawing.Size(83, 16);
            this.QuintaCheckBox.TabIndex = 10;
            this.QuintaCheckBox.Text = "Quinta-Feira";
            this.QuintaCheckBox.UseVisualStyleBackColor = true;
            this.QuintaCheckBox.CheckedChanged += new System.EventHandler(this.QuintaCheckBox_CheckedChanged);
            // 
            // SextaCheckBox
            // 
            this.SextaCheckBox.AutoSize = true;
            this.SextaCheckBox.Location = new System.Drawing.Point(3, 158);
            this.SextaCheckBox.Name = "SextaCheckBox";
            this.SextaCheckBox.Size = new System.Drawing.Size(79, 16);
            this.SextaCheckBox.TabIndex = 12;
            this.SextaCheckBox.Text = "Sexta-Feira";
            this.SextaCheckBox.UseVisualStyleBackColor = true;
            this.SextaCheckBox.CheckedChanged += new System.EventHandler(this.SextaCheckBox_CheckedChanged);
            // 
            // SabadoCheckBox
            // 
            this.SabadoCheckBox.AutoSize = true;
            this.SabadoCheckBox.Location = new System.Drawing.Point(3, 180);
            this.SabadoCheckBox.Name = "SabadoCheckBox";
            this.SabadoCheckBox.Size = new System.Drawing.Size(63, 16);
            this.SabadoCheckBox.TabIndex = 14;
            this.SabadoCheckBox.Text = "Sábado";
            this.SabadoCheckBox.UseVisualStyleBackColor = true;
            this.SabadoCheckBox.CheckedChanged += new System.EventHandler(this.SabadoCheckBox_CheckedChanged);
            // 
            // DomingoDateTimePicker
            // 
            this.DomingoDateTimePicker.Enabled = false;
            this.DomingoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DomingoDateTimePicker.Location = new System.Drawing.Point(162, 48);
            this.DomingoDateTimePicker.Name = "DomingoDateTimePicker";
            this.DomingoDateTimePicker.ShowUpDown = true;
            this.DomingoDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.DomingoDateTimePicker.TabIndex = 3;
            // 
            // SegundaDateTimePicker
            // 
            this.SegundaDateTimePicker.Enabled = false;
            this.SegundaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SegundaDateTimePicker.Location = new System.Drawing.Point(162, 70);
            this.SegundaDateTimePicker.Name = "SegundaDateTimePicker";
            this.SegundaDateTimePicker.ShowUpDown = true;
            this.SegundaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.SegundaDateTimePicker.TabIndex = 5;
            // 
            // TercaDateTimePicker
            // 
            this.TercaDateTimePicker.Enabled = false;
            this.TercaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TercaDateTimePicker.Location = new System.Drawing.Point(162, 92);
            this.TercaDateTimePicker.Name = "TercaDateTimePicker";
            this.TercaDateTimePicker.ShowUpDown = true;
            this.TercaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.TercaDateTimePicker.TabIndex = 7;
            // 
            // QuartaDateTimePicker
            // 
            this.QuartaDateTimePicker.Enabled = false;
            this.QuartaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.QuartaDateTimePicker.Location = new System.Drawing.Point(162, 114);
            this.QuartaDateTimePicker.Name = "QuartaDateTimePicker";
            this.QuartaDateTimePicker.ShowUpDown = true;
            this.QuartaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.QuartaDateTimePicker.TabIndex = 9;
            // 
            // QuintaDateTimePicker
            // 
            this.QuintaDateTimePicker.Enabled = false;
            this.QuintaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.QuintaDateTimePicker.Location = new System.Drawing.Point(162, 136);
            this.QuintaDateTimePicker.Name = "QuintaDateTimePicker";
            this.QuintaDateTimePicker.ShowUpDown = true;
            this.QuintaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.QuintaDateTimePicker.TabIndex = 11;
            // 
            // SextaDateTimePicker
            // 
            this.SextaDateTimePicker.Enabled = false;
            this.SextaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SextaDateTimePicker.Location = new System.Drawing.Point(162, 158);
            this.SextaDateTimePicker.Name = "SextaDateTimePicker";
            this.SextaDateTimePicker.ShowUpDown = true;
            this.SextaDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.SextaDateTimePicker.TabIndex = 13;
            // 
            // SabadoDateTimePicker
            // 
            this.SabadoDateTimePicker.Enabled = false;
            this.SabadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SabadoDateTimePicker.Location = new System.Drawing.Point(162, 180);
            this.SabadoDateTimePicker.Name = "SabadoDateTimePicker";
            this.SabadoDateTimePicker.ShowUpDown = true;
            this.SabadoDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.SabadoDateTimePicker.TabIndex = 15;
            // 
            // SegundaCheckBox
            // 
            this.SegundaCheckBox.AutoSize = true;
            this.SegundaCheckBox.Location = new System.Drawing.Point(3, 70);
            this.SegundaCheckBox.Name = "SegundaCheckBox";
            this.SegundaCheckBox.Size = new System.Drawing.Size(95, 16);
            this.SegundaCheckBox.TabIndex = 4;
            this.SegundaCheckBox.Text = "Segunda-Feira";
            this.SegundaCheckBox.UseVisualStyleBackColor = true;
            this.SegundaCheckBox.CheckedChanged += new System.EventHandler(this.SegundaCheckBox_CheckedChanged);
            // 
            // AdicionarDiarioButton
            // 
            this.AdicionarDiarioButton.Location = new System.Drawing.Point(162, 202);
            this.AdicionarDiarioButton.Name = "AdicionarDiarioButton";
            this.AdicionarDiarioButton.Size = new System.Drawing.Size(75, 23);
            this.AdicionarDiarioButton.TabIndex = 16;
            this.AdicionarDiarioButton.Text = "Adicionar";
            this.AdicionarDiarioButton.UseVisualStyleBackColor = true;
            this.AdicionarDiarioButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UrlDiarioTextBox
            // 
            this.UrlDiarioTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UrlDiarioTextBox.Location = new System.Drawing.Point(162, 26);
            this.UrlDiarioTextBox.Name = "UrlDiarioTextBox";
            this.UrlDiarioTextBox.Size = new System.Drawing.Size(388, 20);
            this.UrlDiarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descrição:";
            // 
            // IdDiarioTextBox
            // 
            this.IdDiarioTextBox.Location = new System.Drawing.Point(3, 202);
            this.IdDiarioTextBox.Name = "IdDiarioTextBox";
            this.IdDiarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdDiarioTextBox.TabIndex = 28;
            this.IdDiarioTextBox.Visible = false;
            // 
            // AgendamentoDiarioDataGridView
            // 
            this.AgendamentoDiarioDataGridView.AllowUserToAddRows = false;
            this.AgendamentoDiarioDataGridView.AllowUserToDeleteRows = false;
            this.AgendamentoDiarioDataGridView.AutoGenerateColumns = false;
            this.AgendamentoDiarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgendamentoDiarioDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.AgendamentoDiarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendamentoDiarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDiario,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.AgendamentoDiarioDataGridView.DataSource = this.agendamentoDiarioBindingSource;
            this.AgendamentoDiarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgendamentoDiarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AgendamentoDiarioDataGridView.Name = "AgendamentoDiarioDataGridView";
            this.AgendamentoDiarioDataGridView.ReadOnly = true;
            this.AgendamentoDiarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgendamentoDiarioDataGridView.Size = new System.Drawing.Size(698, 156);
            this.AgendamentoDiarioDataGridView.TabIndex = 0;
            this.AgendamentoDiarioDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendamentoDiarioDataGridView_CellDoubleClick);
            this.AgendamentoDiarioDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgendamentoDiarioDataGridView_KeyDown);
            // 
            // IdDiario
            // 
            this.IdDiario.DataPropertyName = "Id";
            this.IdDiario.HeaderText = "Id";
            this.IdDiario.Name = "IdDiario";
            this.IdDiario.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn3.HeaderText = "Url";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // agendamentoDiarioBindingSource
            // 
            this.agendamentoDiarioBindingSource.DataSource = typeof(OnScheduler.AgendamentoDiario);
            // 
            // tabSazonal
            // 
            this.tabSazonal.Controls.Add(this.splitContainer2);
            this.tabSazonal.Location = new System.Drawing.Point(4, 22);
            this.tabSazonal.Name = "tabSazonal";
            this.tabSazonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabSazonal.Size = new System.Drawing.Size(704, 413);
            this.tabSazonal.TabIndex = 3;
            this.tabSazonal.Text = "Sazonal";
            this.tabSazonal.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.UrlSazonalTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.DescricaoSazonalTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.AdicionarSazonalButton);
            this.splitContainer2.Panel1.Controls.Add(this.IdSazonalTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.TipoSazonalidadeComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.SazonalidadeTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AgendamentoSazonalDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(698, 407);
            this.splitContainer2.SplitterDistance = 184;
            this.splitContainer2.TabIndex = 13;
            // 
            // UrlSazonalTextBox
            // 
            this.UrlSazonalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UrlSazonalTextBox.Location = new System.Drawing.Point(120, 43);
            this.UrlSazonalTextBox.Name = "UrlSazonalTextBox";
            this.UrlSazonalTextBox.Size = new System.Drawing.Size(369, 20);
            this.UrlSazonalTextBox.TabIndex = 12;
            // 
            // DescricaoSazonalTextBox
            // 
            this.DescricaoSazonalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DescricaoSazonalTextBox.Location = new System.Drawing.Point(120, 12);
            this.DescricaoSazonalTextBox.Name = "DescricaoSazonalTextBox";
            this.DescricaoSazonalTextBox.Size = new System.Drawing.Size(369, 20);
            this.DescricaoSazonalTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "URL:";
            // 
            // AdicionarSazonalButton
            // 
            this.AdicionarSazonalButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdicionarSazonalButton.Location = new System.Drawing.Point(120, 103);
            this.AdicionarSazonalButton.Name = "AdicionarSazonalButton";
            this.AdicionarSazonalButton.Size = new System.Drawing.Size(75, 23);
            this.AdicionarSazonalButton.TabIndex = 17;
            this.AdicionarSazonalButton.Text = "Adicionar";
            this.AdicionarSazonalButton.UseVisualStyleBackColor = true;
            // 
            // IdSazonalTextBox
            // 
            this.IdSazonalTextBox.Location = new System.Drawing.Point(580, 148);
            this.IdSazonalTextBox.Name = "IdSazonalTextBox";
            this.IdSazonalTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdSazonalTextBox.TabIndex = 18;
            this.IdSazonalTextBox.Visible = false;
            // 
            // TipoSazonalidadeComboBox
            // 
            this.TipoSazonalidadeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TipoSazonalidadeComboBox.FormattingEnabled = true;
            this.TipoSazonalidadeComboBox.Location = new System.Drawing.Point(243, 68);
            this.TipoSazonalidadeComboBox.Name = "TipoSazonalidadeComboBox";
            this.TipoSazonalidadeComboBox.Size = new System.Drawing.Size(142, 21);
            this.TipoSazonalidadeComboBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sazonalidade:";
            // 
            // SazonalidadeTextBox
            // 
            this.SazonalidadeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SazonalidadeTextBox.Location = new System.Drawing.Point(120, 68);
            this.SazonalidadeTextBox.Name = "SazonalidadeTextBox";
            this.SazonalidadeTextBox.Size = new System.Drawing.Size(117, 20);
            this.SazonalidadeTextBox.TabIndex = 16;
            // 
            // AgendamentoSazonalDataGridView
            // 
            this.AgendamentoSazonalDataGridView.AllowUserToAddRows = false;
            this.AgendamentoSazonalDataGridView.AllowUserToDeleteRows = false;
            this.AgendamentoSazonalDataGridView.AutoGenerateColumns = false;
            this.AgendamentoSazonalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgendamentoSazonalDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.AgendamentoSazonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendamentoSazonalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSazonal,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.TipoSazonalidade,
            this.tempoAvisoDataGridViewTextBoxColumn});
            this.AgendamentoSazonalDataGridView.DataSource = this.agendamentoSazonalBindingSource;
            this.AgendamentoSazonalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgendamentoSazonalDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AgendamentoSazonalDataGridView.Name = "AgendamentoSazonalDataGridView";
            this.AgendamentoSazonalDataGridView.ReadOnly = true;
            this.AgendamentoSazonalDataGridView.Size = new System.Drawing.Size(698, 219);
            this.AgendamentoSazonalDataGridView.TabIndex = 10;
            this.AgendamentoSazonalDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendamentoSazonalDataGridView_CellDoubleClick);
            this.AgendamentoSazonalDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgendamentoSazonalDataGridView_KeyDown);
            // 
            // IdSazonal
            // 
            this.IdSazonal.DataPropertyName = "Id";
            this.IdSazonal.HeaderText = "Id";
            this.IdSazonal.Name = "IdSazonal";
            this.IdSazonal.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn5.HeaderText = "Url";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // TipoSazonalidade
            // 
            this.TipoSazonalidade.DataPropertyName = "TipoSazonalidade";
            this.TipoSazonalidade.HeaderText = "Tipo Sazonalidade";
            this.TipoSazonalidade.Name = "TipoSazonalidade";
            this.TipoSazonalidade.ReadOnly = true;
            // 
            // tempoAvisoDataGridViewTextBoxColumn
            // 
            this.tempoAvisoDataGridViewTextBoxColumn.DataPropertyName = "TempoAviso";
            this.tempoAvisoDataGridViewTextBoxColumn.HeaderText = "Tempo Aviso";
            this.tempoAvisoDataGridViewTextBoxColumn.Name = "tempoAvisoDataGridViewTextBoxColumn";
            this.tempoAvisoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agendamentoSazonalBindingSource
            // 
            this.agendamentoSazonalBindingSource.DataSource = typeof(OnScheduler.AgendamentoSazonal);
            // 
            // OnSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 439);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(728, 478);
            this.Name = "OnSchedulerForm";
            this.Text = "OnScheduler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnScheduler_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDiario.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoDiarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDiarioBindingSource)).EndInit();
            this.tabSazonal.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoSazonalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoSazonalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDiario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox DomingoCheckBox;
        private System.Windows.Forms.CheckBox SegundaCheckBox;
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
        private System.Windows.Forms.DataGridView AgendamentoDiarioDataGridView;
        private System.Windows.Forms.TabPage tabSazonal;
        private System.Windows.Forms.TextBox UrlDiarioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdicionarDiarioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource agendamentoDiarioBindingSource;
        private System.Windows.Forms.TextBox DescricaoDiarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdDiarioTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView AgendamentoSazonalDataGridView;
        private System.Windows.Forms.BindingSource agendamentoSazonalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSazonalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSazonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSazonalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoAvisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox UrlSazonalTextBox;
        private System.Windows.Forms.TextBox DescricaoSazonalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AdicionarSazonalButton;
        private System.Windows.Forms.TextBox IdSazonalTextBox;
        private System.Windows.Forms.ComboBox TipoSazonalidadeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SazonalidadeTextBox;
    }
}