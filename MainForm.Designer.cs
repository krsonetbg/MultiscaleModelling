namespace MultiscaleModelling
{
    partial class MainWindowForm
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
            this.space_display = new System.Windows.Forms.PictureBox();
            this.button_space_generation = new System.Windows.Forms.Button();
            this.button_single_iteration = new System.Windows.Forms.Button();
            this.button_growth = new System.Windows.Forms.Button();
            this.label_inclusions_size = new System.Windows.Forms.Label();
            this.label_inclusions_type = new System.Windows.Forms.Label();
            this.groupBox_neighborhood = new System.Windows.Forms.GroupBox();
            this.radioButton_Von_Neumann = new System.Windows.Forms.RadioButton();
            this.radioButton_Moore = new System.Windows.Forms.RadioButton();
            this.comboBox_inclusions = new System.Windows.Forms.ComboBox();
            this.groupBox_inclusions = new System.Windows.Forms.GroupBox();
            this.button_generate_inclusions = new System.Windows.Forms.Button();
            this.numericUpDown_number_of_inclusions = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_inclusion_size = new System.Windows.Forms.NumericUpDown();
            this.label_inclusions_no = new System.Windows.Forms.Label();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.groupBox_run_algorithm = new System.Windows.Forms.GroupBox();
            this.groupBox_space_init = new System.Windows.Forms.GroupBox();
            this.label_grain_number = new System.Windows.Forms.Label();
            this.numericUpDown_dimension = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_number_of_grains = new System.Windows.Forms.NumericUpDown();
            this.label_dimension = new System.Windows.Forms.Label();
            this.groupBox_structure = new System.Windows.Forms.GroupBox();
            this.numericUpDown_new_grains = new System.Windows.Forms.NumericUpDown();
            this.label_number_of_new_grains = new System.Windows.Forms.Label();
            this.button_generate_new_grains = new System.Windows.Forms.Button();
            this.numericUpDown_structure_grain_number = new System.Windows.Forms.NumericUpDown();
            this.label_structure_grain_number = new System.Windows.Forms.Label();
            this.label_structure_type = new System.Windows.Forms.Label();
            this.button_generate_structure = new System.Windows.Forms.Button();
            this.comboBox_structure_type = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_probability = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_extended_CA = new System.Windows.Forms.RadioButton();
            this.radioButton_classic_CA = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_generate_border = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).BeginInit();
            this.groupBox_neighborhood.SuspendLayout();
            this.groupBox_inclusions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_inclusions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inclusion_size)).BeginInit();
            this.groupBox_main.SuspendLayout();
            this.groupBox_run_algorithm.SuspendLayout();
            this.groupBox_space_init.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_grains)).BeginInit();
            this.groupBox_structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_new_grains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_structure_grain_number)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_probability)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // space_display
            // 
            this.space_display.Location = new System.Drawing.Point(689, 22);
            this.space_display.Margin = new System.Windows.Forms.Padding(4);
            this.space_display.Name = "space_display";
            this.space_display.Size = new System.Drawing.Size(585, 471);
            this.space_display.TabIndex = 1;
            this.space_display.TabStop = false;
            this.space_display.Click += new System.EventHandler(this.space_display_Click);
            // 
            // button_space_generation
            // 
            this.button_space_generation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_space_generation.Location = new System.Drawing.Point(3, 100);
            this.button_space_generation.Margin = new System.Windows.Forms.Padding(4);
            this.button_space_generation.Name = "button_space_generation";
            this.button_space_generation.Size = new System.Drawing.Size(297, 28);
            this.button_space_generation.TabIndex = 2;
            this.button_space_generation.Text = "Generate initial space";
            this.button_space_generation.UseVisualStyleBackColor = true;
            this.button_space_generation.Click += new System.EventHandler(this.button_generate_initial_space);
            // 
            // button_single_iteration
            // 
            this.button_single_iteration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_single_iteration.Enabled = false;
            this.button_single_iteration.Location = new System.Drawing.Point(3, 23);
            this.button_single_iteration.Margin = new System.Windows.Forms.Padding(4);
            this.button_single_iteration.Name = "button_single_iteration";
            this.button_single_iteration.Size = new System.Drawing.Size(294, 31);
            this.button_single_iteration.TabIndex = 3;
            this.button_single_iteration.Text = "Proceed single iteration";
            this.button_single_iteration.UseVisualStyleBackColor = true;
            this.button_single_iteration.Click += new System.EventHandler(this.button_proceed_single_iteration);
            // 
            // button_growth
            // 
            this.button_growth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_growth.Enabled = false;
            this.button_growth.Location = new System.Drawing.Point(3, 54);
            this.button_growth.Margin = new System.Windows.Forms.Padding(4);
            this.button_growth.Name = "button_growth";
            this.button_growth.Size = new System.Drawing.Size(294, 28);
            this.button_growth.TabIndex = 4;
            this.button_growth.Text = "Proceed growth";
            this.button_growth.UseVisualStyleBackColor = true;
            this.button_growth.Click += new System.EventHandler(this.button_growth_Click);
            // 
            // label_inclusions_size
            // 
            this.label_inclusions_size.AutoSize = true;
            this.label_inclusions_size.Location = new System.Drawing.Point(8, 64);
            this.label_inclusions_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inclusions_size.Name = "label_inclusions_size";
            this.label_inclusions_size.Size = new System.Drawing.Size(117, 17);
            this.label_inclusions_size.TabIndex = 7;
            this.label_inclusions_size.Text = "Size of inclusions";
            // 
            // label_inclusions_type
            // 
            this.label_inclusions_type.AutoSize = true;
            this.label_inclusions_type.Location = new System.Drawing.Point(8, 96);
            this.label_inclusions_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inclusions_type.Name = "label_inclusions_type";
            this.label_inclusions_type.Size = new System.Drawing.Size(122, 17);
            this.label_inclusions_type.TabIndex = 8;
            this.label_inclusions_type.Text = "Type of inclusions";
            // 
            // groupBox_neighborhood
            // 
            this.groupBox_neighborhood.Controls.Add(this.radioButton_Von_Neumann);
            this.groupBox_neighborhood.Controls.Add(this.radioButton_Moore);
            this.groupBox_neighborhood.Location = new System.Drawing.Point(8, 321);
            this.groupBox_neighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_neighborhood.Name = "groupBox_neighborhood";
            this.groupBox_neighborhood.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_neighborhood.Size = new System.Drawing.Size(302, 80);
            this.groupBox_neighborhood.TabIndex = 12;
            this.groupBox_neighborhood.TabStop = false;
            this.groupBox_neighborhood.Text = "Neighborhood type";
            // 
            // radioButton_Von_Neumann
            // 
            this.radioButton_Von_Neumann.AutoSize = true;
            this.radioButton_Von_Neumann.Checked = true;
            this.radioButton_Von_Neumann.Enabled = false;
            this.radioButton_Von_Neumann.Location = new System.Drawing.Point(89, 42);
            this.radioButton_Von_Neumann.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Von_Neumann.Name = "radioButton_Von_Neumann";
            this.radioButton_Von_Neumann.Size = new System.Drawing.Size(115, 21);
            this.radioButton_Von_Neumann.TabIndex = 1;
            this.radioButton_Von_Neumann.TabStop = true;
            this.radioButton_Von_Neumann.Text = "VonNeumann";
            this.radioButton_Von_Neumann.UseVisualStyleBackColor = true;
            // 
            // radioButton_Moore
            // 
            this.radioButton_Moore.AutoSize = true;
            this.radioButton_Moore.Enabled = false;
            this.radioButton_Moore.Location = new System.Drawing.Point(8, 42);
            this.radioButton_Moore.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Moore.Name = "radioButton_Moore";
            this.radioButton_Moore.Size = new System.Drawing.Size(69, 21);
            this.radioButton_Moore.TabIndex = 0;
            this.radioButton_Moore.TabStop = true;
            this.radioButton_Moore.Text = "Moore";
            this.radioButton_Moore.UseVisualStyleBackColor = true;
            // 
            // comboBox_inclusions
            // 
            this.comboBox_inclusions.FormattingEnabled = true;
            this.comboBox_inclusions.Items.AddRange(new object[] {
            "Circular",
            "Square"});
            this.comboBox_inclusions.Location = new System.Drawing.Point(171, 86);
            this.comboBox_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_inclusions.Name = "comboBox_inclusions";
            this.comboBox_inclusions.Size = new System.Drawing.Size(160, 24);
            this.comboBox_inclusions.TabIndex = 13;
            this.comboBox_inclusions.Text = "None";
            // 
            // groupBox_inclusions
            // 
            this.groupBox_inclusions.Controls.Add(this.button_generate_inclusions);
            this.groupBox_inclusions.Controls.Add(this.numericUpDown_number_of_inclusions);
            this.groupBox_inclusions.Controls.Add(this.numericUpDown_inclusion_size);
            this.groupBox_inclusions.Controls.Add(this.label_inclusions_no);
            this.groupBox_inclusions.Controls.Add(this.comboBox_inclusions);
            this.groupBox_inclusions.Controls.Add(this.label_inclusions_size);
            this.groupBox_inclusions.Controls.Add(this.label_inclusions_type);
            this.groupBox_inclusions.Location = new System.Drawing.Point(326, 22);
            this.groupBox_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_inclusions.Name = "groupBox_inclusions";
            this.groupBox_inclusions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_inclusions.Size = new System.Drawing.Size(342, 152);
            this.groupBox_inclusions.TabIndex = 14;
            this.groupBox_inclusions.TabStop = false;
            this.groupBox_inclusions.Text = "Inclusions";
            // 
            // button_generate_inclusions
            // 
            this.button_generate_inclusions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_generate_inclusions.Location = new System.Drawing.Point(4, 120);
            this.button_generate_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.button_generate_inclusions.Name = "button_generate_inclusions";
            this.button_generate_inclusions.Size = new System.Drawing.Size(334, 28);
            this.button_generate_inclusions.TabIndex = 19;
            this.button_generate_inclusions.Text = "Generate inclusions";
            this.button_generate_inclusions.UseVisualStyleBackColor = true;
            this.button_generate_inclusions.Click += new System.EventHandler(this.button_generate_inclusions_Click);
            // 
            // numericUpDown_number_of_inclusions
            // 
            this.numericUpDown_number_of_inclusions.Location = new System.Drawing.Point(171, 29);
            this.numericUpDown_number_of_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_number_of_inclusions.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_number_of_inclusions.Name = "numericUpDown_number_of_inclusions";
            this.numericUpDown_number_of_inclusions.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_number_of_inclusions.TabIndex = 20;
            // 
            // numericUpDown_inclusion_size
            // 
            this.numericUpDown_inclusion_size.Location = new System.Drawing.Point(171, 59);
            this.numericUpDown_inclusion_size.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_inclusion_size.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_inclusion_size.Name = "numericUpDown_inclusion_size";
            this.numericUpDown_inclusion_size.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_inclusion_size.TabIndex = 19;
            // 
            // label_inclusions_no
            // 
            this.label_inclusions_no.AutoSize = true;
            this.label_inclusions_no.Location = new System.Drawing.Point(8, 34);
            this.label_inclusions_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inclusions_no.Name = "label_inclusions_no";
            this.label_inclusions_no.Size = new System.Drawing.Size(140, 17);
            this.label_inclusions_no.TabIndex = 6;
            this.label_inclusions_no.Text = "Number of inclusions";
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.button_generate_border);
            this.groupBox_main.Controls.Add(this.groupBox_run_algorithm);
            this.groupBox_main.Controls.Add(this.groupBox_space_init);
            this.groupBox_main.Controls.Add(this.space_display);
            this.groupBox_main.Controls.Add(this.groupBox_structure);
            this.groupBox_main.Controls.Add(this.groupBox1);
            this.groupBox_main.Controls.Add(this.groupBox_inclusions);
            this.groupBox_main.Controls.Add(this.groupBox_neighborhood);
            this.groupBox_main.Location = new System.Drawing.Point(13, 32);
            this.groupBox_main.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_main.Size = new System.Drawing.Size(1411, 607);
            this.groupBox_main.TabIndex = 0;
            this.groupBox_main.TabStop = false;
            // 
            // groupBox_run_algorithm
            // 
            this.groupBox_run_algorithm.Controls.Add(this.button_single_iteration);
            this.groupBox_run_algorithm.Controls.Add(this.button_growth);
            this.groupBox_run_algorithm.Location = new System.Drawing.Point(7, 408);
            this.groupBox_run_algorithm.Name = "groupBox_run_algorithm";
            this.groupBox_run_algorithm.Size = new System.Drawing.Size(300, 85);
            this.groupBox_run_algorithm.TabIndex = 17;
            this.groupBox_run_algorithm.TabStop = false;
            this.groupBox_run_algorithm.Text = "Algorithm execution";
            // 
            // groupBox_space_init
            // 
            this.groupBox_space_init.Controls.Add(this.label_grain_number);
            this.groupBox_space_init.Controls.Add(this.button_space_generation);
            this.groupBox_space_init.Controls.Add(this.numericUpDown_dimension);
            this.groupBox_space_init.Controls.Add(this.numericUpDown_number_of_grains);
            this.groupBox_space_init.Controls.Add(this.label_dimension);
            this.groupBox_space_init.Location = new System.Drawing.Point(7, 22);
            this.groupBox_space_init.Name = "groupBox_space_init";
            this.groupBox_space_init.Size = new System.Drawing.Size(303, 131);
            this.groupBox_space_init.TabIndex = 16;
            this.groupBox_space_init.TabStop = false;
            this.groupBox_space_init.Text = "Space initialization";
            // 
            // label_grain_number
            // 
            this.label_grain_number.AutoSize = true;
            this.label_grain_number.Location = new System.Drawing.Point(7, 66);
            this.label_grain_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grain_number.Name = "label_grain_number";
            this.label_grain_number.Size = new System.Drawing.Size(117, 17);
            this.label_grain_number.TabIndex = 17;
            this.label_grain_number.Text = "Number of grains";
            // 
            // numericUpDown_dimension
            // 
            this.numericUpDown_dimension.Location = new System.Drawing.Point(131, 36);
            this.numericUpDown_dimension.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_dimension.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_dimension.Name = "numericUpDown_dimension";
            this.numericUpDown_dimension.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_dimension.TabIndex = 15;
            this.numericUpDown_dimension.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_number_of_grains
            // 
            this.numericUpDown_number_of_grains.Location = new System.Drawing.Point(132, 66);
            this.numericUpDown_number_of_grains.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_number_of_grains.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_number_of_grains.Name = "numericUpDown_number_of_grains";
            this.numericUpDown_number_of_grains.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_number_of_grains.TabIndex = 18;
            this.numericUpDown_number_of_grains.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_dimension
            // 
            this.label_dimension.AutoSize = true;
            this.label_dimension.Location = new System.Drawing.Point(7, 36);
            this.label_dimension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dimension.Name = "label_dimension";
            this.label_dimension.Size = new System.Drawing.Size(116, 17);
            this.label_dimension.TabIndex = 16;
            this.label_dimension.Text = "Space dimension";
            // 
            // groupBox_structure
            // 
            this.groupBox_structure.Controls.Add(this.numericUpDown_new_grains);
            this.groupBox_structure.Controls.Add(this.label_number_of_new_grains);
            this.groupBox_structure.Controls.Add(this.button_generate_new_grains);
            this.groupBox_structure.Controls.Add(this.numericUpDown_structure_grain_number);
            this.groupBox_structure.Controls.Add(this.label_structure_grain_number);
            this.groupBox_structure.Controls.Add(this.label_structure_type);
            this.groupBox_structure.Controls.Add(this.button_generate_structure);
            this.groupBox_structure.Controls.Add(this.comboBox_structure_type);
            this.groupBox_structure.Location = new System.Drawing.Point(326, 181);
            this.groupBox_structure.Name = "groupBox_structure";
            this.groupBox_structure.Size = new System.Drawing.Size(342, 232);
            this.groupBox_structure.TabIndex = 15;
            this.groupBox_structure.TabStop = false;
            this.groupBox_structure.Text = "Structure";
            // 
            // numericUpDown_new_grains
            // 
            this.numericUpDown_new_grains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_new_grains.Location = new System.Drawing.Point(171, 120);
            this.numericUpDown_new_grains.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_new_grains.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_new_grains.Name = "numericUpDown_new_grains";
            this.numericUpDown_new_grains.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_new_grains.TabIndex = 27;
            this.numericUpDown_new_grains.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_number_of_new_grains
            // 
            this.label_number_of_new_grains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_number_of_new_grains.AutoSize = true;
            this.label_number_of_new_grains.Location = new System.Drawing.Point(8, 125);
            this.label_number_of_new_grains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_number_of_new_grains.Name = "label_number_of_new_grains";
            this.label_number_of_new_grains.Size = new System.Drawing.Size(146, 17);
            this.label_number_of_new_grains.TabIndex = 26;
            this.label_number_of_new_grains.Text = "Number of new grains";
            // 
            // button_generate_new_grains
            // 
            this.button_generate_new_grains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_generate_new_grains.Location = new System.Drawing.Point(3, 199);
            this.button_generate_new_grains.Name = "button_generate_new_grains";
            this.button_generate_new_grains.Size = new System.Drawing.Size(336, 30);
            this.button_generate_new_grains.TabIndex = 25;
            this.button_generate_new_grains.Text = "Generate new grains";
            this.button_generate_new_grains.UseVisualStyleBackColor = true;
            this.button_generate_new_grains.Click += new System.EventHandler(this.button_generate_new_grains_Click);
            // 
            // numericUpDown_structure_grain_number
            // 
            this.numericUpDown_structure_grain_number.Location = new System.Drawing.Point(171, 53);
            this.numericUpDown_structure_grain_number.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_structure_grain_number.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_structure_grain_number.Name = "numericUpDown_structure_grain_number";
            this.numericUpDown_structure_grain_number.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_structure_grain_number.TabIndex = 24;
            // 
            // label_structure_grain_number
            // 
            this.label_structure_grain_number.AutoSize = true;
            this.label_structure_grain_number.Location = new System.Drawing.Point(8, 58);
            this.label_structure_grain_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_structure_grain_number.Name = "label_structure_grain_number";
            this.label_structure_grain_number.Size = new System.Drawing.Size(117, 17);
            this.label_structure_grain_number.TabIndex = 23;
            this.label_structure_grain_number.Text = "Number of grains";
            // 
            // label_structure_type
            // 
            this.label_structure_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_structure_type.AutoSize = true;
            this.label_structure_type.Location = new System.Drawing.Point(8, 24);
            this.label_structure_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_structure_type.Name = "label_structure_type";
            this.label_structure_type.Size = new System.Drawing.Size(40, 17);
            this.label_structure_type.TabIndex = 22;
            this.label_structure_type.Text = "Type";
            // 
            // button_generate_structure
            // 
            this.button_generate_structure.Enabled = false;
            this.button_generate_structure.Location = new System.Drawing.Point(7, 87);
            this.button_generate_structure.Margin = new System.Windows.Forms.Padding(4);
            this.button_generate_structure.Name = "button_generate_structure";
            this.button_generate_structure.Size = new System.Drawing.Size(332, 28);
            this.button_generate_structure.TabIndex = 21;
            this.button_generate_structure.Text = "Generate structure";
            this.button_generate_structure.UseVisualStyleBackColor = true;
            this.button_generate_structure.Click += new System.EventHandler(this.button_generate_structure_Click);
            // 
            // comboBox_structure_type
            // 
            this.comboBox_structure_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_structure_type.FormattingEnabled = true;
            this.comboBox_structure_type.Items.AddRange(new object[] {
            "Substructure",
            "Dual phase"});
            this.comboBox_structure_type.Location = new System.Drawing.Point(171, 17);
            this.comboBox_structure_type.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_structure_type.Name = "comboBox_structure_type";
            this.comboBox_structure_type.Size = new System.Drawing.Size(160, 24);
            this.comboBox_structure_type.TabIndex = 14;
            this.comboBox_structure_type.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_probability);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_extended_CA);
            this.groupBox1.Controls.Add(this.radioButton_classic_CA);
            this.groupBox1.Location = new System.Drawing.Point(0, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(310, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm version";
            // 
            // numericUpDown_probability
            // 
            this.numericUpDown_probability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_probability.Location = new System.Drawing.Point(182, 92);
            this.numericUpDown_probability.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_probability.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_probability.Name = "numericUpDown_probability";
            this.numericUpDown_probability.Size = new System.Drawing.Size(99, 22);
            this.numericUpDown_probability.TabIndex = 26;
            this.numericUpDown_probability.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Change probability [%]";
            // 
            // radioButton_extended_CA
            // 
            this.radioButton_extended_CA.AutoSize = true;
            this.radioButton_extended_CA.Checked = true;
            this.radioButton_extended_CA.Location = new System.Drawing.Point(182, 42);
            this.radioButton_extended_CA.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_extended_CA.Name = "radioButton_extended_CA";
            this.radioButton_extended_CA.Size = new System.Drawing.Size(110, 21);
            this.radioButton_extended_CA.TabIndex = 1;
            this.radioButton_extended_CA.TabStop = true;
            this.radioButton_extended_CA.Text = "Extended CA";
            this.radioButton_extended_CA.UseVisualStyleBackColor = true;
            this.radioButton_extended_CA.CheckedChanged += new System.EventHandler(this.radioButton_extended_CA_CheckedChanged);
            // 
            // radioButton_classic_CA
            // 
            this.radioButton_classic_CA.AutoSize = true;
            this.radioButton_classic_CA.Location = new System.Drawing.Point(32, 42);
            this.radioButton_classic_CA.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_classic_CA.Name = "radioButton_classic_CA";
            this.radioButton_classic_CA.Size = new System.Drawing.Size(47, 21);
            this.radioButton_classic_CA.TabIndex = 0;
            this.radioButton_classic_CA.TabStop = true;
            this.radioButton_classic_CA.Text = "CA";
            this.radioButton_classic_CA.UseVisualStyleBackColor = true;
            this.radioButton_classic_CA.CheckedChanged += new System.EventHandler(this.radioButton_classic_CA_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1311, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.exportDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.importDataToolStripMenuItem.Text = "Import data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exportDataToolStripMenuItem.Text = "Export data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // button_generate_border
            // 
            this.button_generate_border.Location = new System.Drawing.Point(329, 431);
            this.button_generate_border.Name = "button_generate_border";
            this.button_generate_border.Size = new System.Drawing.Size(328, 54);
            this.button_generate_border.TabIndex = 18;
            this.button_generate_border.Text = "Show grain boundaries";
            this.button_generate_border.UseVisualStyleBackColor = true;
            this.button_generate_border.Click += new System.EventHandler(this.button_generate_border_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 568);
            this.Controls.Add(this.groupBox_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindowForm";
            this.Text = "Multiscale Modelling";
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).EndInit();
            this.groupBox_neighborhood.ResumeLayout(false);
            this.groupBox_neighborhood.PerformLayout();
            this.groupBox_inclusions.ResumeLayout(false);
            this.groupBox_inclusions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_inclusions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inclusion_size)).EndInit();
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_run_algorithm.ResumeLayout(false);
            this.groupBox_space_init.ResumeLayout(false);
            this.groupBox_space_init.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_grains)).EndInit();
            this.groupBox_structure.ResumeLayout(false);
            this.groupBox_structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_new_grains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_structure_grain_number)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_probability)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox space_display;
        private System.Windows.Forms.Button button_space_generation;
        private System.Windows.Forms.Button button_single_iteration;
        private System.Windows.Forms.Button button_growth;
        private System.Windows.Forms.Label label_inclusions_size;
        private System.Windows.Forms.Label label_inclusions_type;
        private System.Windows.Forms.GroupBox groupBox_neighborhood;
        private System.Windows.Forms.RadioButton radioButton_Von_Neumann;
        private System.Windows.Forms.RadioButton radioButton_Moore;
        private System.Windows.Forms.ComboBox comboBox_inclusions;
        private System.Windows.Forms.GroupBox groupBox_inclusions;
        private System.Windows.Forms.Label label_inclusions_no;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Label label_dimension;
        private System.Windows.Forms.NumericUpDown numericUpDown_dimension;
        private System.Windows.Forms.NumericUpDown numericUpDown_number_of_grains;
        private System.Windows.Forms.Label label_grain_number;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_number_of_inclusions;
        private System.Windows.Forms.NumericUpDown numericUpDown_inclusion_size;
        private System.Windows.Forms.Button button_generate_inclusions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_extended_CA;
        private System.Windows.Forms.RadioButton radioButton_classic_CA;
        private System.Windows.Forms.ComboBox comboBox_structure_type;
        private System.Windows.Forms.GroupBox groupBox_structure;
        private System.Windows.Forms.Button button_generate_structure;
        private System.Windows.Forms.NumericUpDown numericUpDown_structure_grain_number;
        private System.Windows.Forms.Label label_structure_grain_number;
        private System.Windows.Forms.Label label_structure_type;
        private System.Windows.Forms.GroupBox groupBox_space_init;
        private System.Windows.Forms.GroupBox groupBox_run_algorithm;
        private System.Windows.Forms.NumericUpDown numericUpDown_probability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_generate_new_grains;
        private System.Windows.Forms.NumericUpDown numericUpDown_new_grains;
        private System.Windows.Forms.Label label_number_of_new_grains;
        private System.Windows.Forms.Button button_generate_border;
    }
}

