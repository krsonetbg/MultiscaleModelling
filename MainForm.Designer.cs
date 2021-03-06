﻿namespace MultiscaleModelling
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_generate_nucleons = new System.Windows.Forms.Button();
            this.button_grow_recrystalized = new System.Windows.Forms.Button();
            this.checkBox_heterogeneous = new System.Windows.Forms.CheckBox();
            this.label_nucleons = new System.Windows.Forms.Label();
            this.button_energy_distribution_create = new System.Windows.Forms.Button();
            this.numericUpDown_nucleons_number = new System.Windows.Forms.NumericUpDown();
            this.button_energy_distribution_display = new System.Windows.Forms.Button();
            this.numericUpDown_grain_boundaries_energy = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_internal_energy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MC_iterations = new System.Windows.Forms.NumericUpDown();
            this.button_init_space_mc = new System.Windows.Forms.Button();
            this.label_number_of_MC_iterations = new System.Windows.Forms.Label();
            this.button_mc_method = new System.Windows.Forms.Button();
            this.button_generate_border = new System.Windows.Forms.Button();
            this.groupBox_run_algorithm = new System.Windows.Forms.GroupBox();
            this.groupBox_space_init = new System.Windows.Forms.GroupBox();
            this.label_grain_number = new System.Windows.Forms.Label();
            this.numericUpDown_dimension = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_number_of_grains = new System.Windows.Forms.NumericUpDown();
            this.label_dimension = new System.Windows.Forms.Label();
            this.groupBox_structure = new System.Windows.Forms.GroupBox();
            this.button_generate_new_grains_for_MC = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).BeginInit();
            this.groupBox_neighborhood.SuspendLayout();
            this.groupBox_inclusions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_inclusions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inclusion_size)).BeginInit();
            this.groupBox_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nucleons_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_grain_boundaries_energy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_internal_energy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MC_iterations)).BeginInit();
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
            this.space_display.Location = new System.Drawing.Point(517, 18);
            this.space_display.Name = "space_display";
            this.space_display.Size = new System.Drawing.Size(439, 383);
            this.space_display.TabIndex = 1;
            this.space_display.TabStop = false;
            this.space_display.Click += new System.EventHandler(this.space_display_Click);
            // 
            // button_space_generation
            // 
            this.button_space_generation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_space_generation.Location = new System.Drawing.Point(2, 81);
            this.button_space_generation.Name = "button_space_generation";
            this.button_space_generation.Size = new System.Drawing.Size(223, 23);
            this.button_space_generation.TabIndex = 2;
            this.button_space_generation.Text = "Generate initial space";
            this.button_space_generation.UseVisualStyleBackColor = true;
            this.button_space_generation.Click += new System.EventHandler(this.button_generate_initial_space);
            // 
            // button_single_iteration
            // 
            this.button_single_iteration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_single_iteration.Enabled = false;
            this.button_single_iteration.Location = new System.Drawing.Point(2, 19);
            this.button_single_iteration.Name = "button_single_iteration";
            this.button_single_iteration.Size = new System.Drawing.Size(221, 25);
            this.button_single_iteration.TabIndex = 3;
            this.button_single_iteration.Text = "Proceed single iteration";
            this.button_single_iteration.UseVisualStyleBackColor = true;
            this.button_single_iteration.Click += new System.EventHandler(this.button_proceed_single_iteration);
            // 
            // button_growth
            // 
            this.button_growth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_growth.Enabled = false;
            this.button_growth.Location = new System.Drawing.Point(2, 44);
            this.button_growth.Name = "button_growth";
            this.button_growth.Size = new System.Drawing.Size(221, 23);
            this.button_growth.TabIndex = 4;
            this.button_growth.Text = "Proceed growth";
            this.button_growth.UseVisualStyleBackColor = true;
            this.button_growth.Click += new System.EventHandler(this.button_growth_Click);
            // 
            // label_inclusions_size
            // 
            this.label_inclusions_size.AutoSize = true;
            this.label_inclusions_size.Location = new System.Drawing.Point(6, 52);
            this.label_inclusions_size.Name = "label_inclusions_size";
            this.label_inclusions_size.Size = new System.Drawing.Size(88, 13);
            this.label_inclusions_size.TabIndex = 7;
            this.label_inclusions_size.Text = "Size of inclusions";
            // 
            // label_inclusions_type
            // 
            this.label_inclusions_type.AutoSize = true;
            this.label_inclusions_type.Location = new System.Drawing.Point(6, 78);
            this.label_inclusions_type.Name = "label_inclusions_type";
            this.label_inclusions_type.Size = new System.Drawing.Size(92, 13);
            this.label_inclusions_type.TabIndex = 8;
            this.label_inclusions_type.Text = "Type of inclusions";
            // 
            // groupBox_neighborhood
            // 
            this.groupBox_neighborhood.Controls.Add(this.radioButton_Von_Neumann);
            this.groupBox_neighborhood.Controls.Add(this.radioButton_Moore);
            this.groupBox_neighborhood.Location = new System.Drawing.Point(6, 261);
            this.groupBox_neighborhood.Name = "groupBox_neighborhood";
            this.groupBox_neighborhood.Size = new System.Drawing.Size(226, 65);
            this.groupBox_neighborhood.TabIndex = 12;
            this.groupBox_neighborhood.TabStop = false;
            this.groupBox_neighborhood.Text = "Neighborhood type";
            // 
            // radioButton_Von_Neumann
            // 
            this.radioButton_Von_Neumann.AutoSize = true;
            this.radioButton_Von_Neumann.Checked = true;
            this.radioButton_Von_Neumann.Enabled = false;
            this.radioButton_Von_Neumann.Location = new System.Drawing.Point(67, 34);
            this.radioButton_Von_Neumann.Name = "radioButton_Von_Neumann";
            this.radioButton_Von_Neumann.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Von_Neumann.TabIndex = 1;
            this.radioButton_Von_Neumann.TabStop = true;
            this.radioButton_Von_Neumann.Text = "VonNeumann";
            this.radioButton_Von_Neumann.UseVisualStyleBackColor = true;
            // 
            // radioButton_Moore
            // 
            this.radioButton_Moore.AutoSize = true;
            this.radioButton_Moore.Enabled = false;
            this.radioButton_Moore.Location = new System.Drawing.Point(6, 34);
            this.radioButton_Moore.Name = "radioButton_Moore";
            this.radioButton_Moore.Size = new System.Drawing.Size(55, 17);
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
            this.comboBox_inclusions.Location = new System.Drawing.Point(128, 70);
            this.comboBox_inclusions.Name = "comboBox_inclusions";
            this.comboBox_inclusions.Size = new System.Drawing.Size(121, 21);
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
            this.groupBox_inclusions.Location = new System.Drawing.Point(244, 18);
            this.groupBox_inclusions.Name = "groupBox_inclusions";
            this.groupBox_inclusions.Size = new System.Drawing.Size(256, 124);
            this.groupBox_inclusions.TabIndex = 14;
            this.groupBox_inclusions.TabStop = false;
            this.groupBox_inclusions.Text = "Inclusions";
            // 
            // button_generate_inclusions
            // 
            this.button_generate_inclusions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_generate_inclusions.Location = new System.Drawing.Point(3, 98);
            this.button_generate_inclusions.Name = "button_generate_inclusions";
            this.button_generate_inclusions.Size = new System.Drawing.Size(250, 23);
            this.button_generate_inclusions.TabIndex = 19;
            this.button_generate_inclusions.Text = "Generate inclusions";
            this.button_generate_inclusions.UseVisualStyleBackColor = true;
            this.button_generate_inclusions.Click += new System.EventHandler(this.button_generate_inclusions_Click);
            // 
            // numericUpDown_number_of_inclusions
            // 
            this.numericUpDown_number_of_inclusions.Location = new System.Drawing.Point(128, 24);
            this.numericUpDown_number_of_inclusions.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_number_of_inclusions.Name = "numericUpDown_number_of_inclusions";
            this.numericUpDown_number_of_inclusions.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_number_of_inclusions.TabIndex = 20;
            // 
            // numericUpDown_inclusion_size
            // 
            this.numericUpDown_inclusion_size.Location = new System.Drawing.Point(128, 48);
            this.numericUpDown_inclusion_size.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_inclusion_size.Name = "numericUpDown_inclusion_size";
            this.numericUpDown_inclusion_size.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_inclusion_size.TabIndex = 19;
            // 
            // label_inclusions_no
            // 
            this.label_inclusions_no.AutoSize = true;
            this.label_inclusions_no.Location = new System.Drawing.Point(6, 28);
            this.label_inclusions_no.Name = "label_inclusions_no";
            this.label_inclusions_no.Size = new System.Drawing.Size(105, 13);
            this.label_inclusions_no.TabIndex = 6;
            this.label_inclusions_no.Text = "Number of inclusions";
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.groupBox2);
            this.groupBox_main.Controls.Add(this.numericUpDown_MC_iterations);
            this.groupBox_main.Controls.Add(this.button_init_space_mc);
            this.groupBox_main.Controls.Add(this.label_number_of_MC_iterations);
            this.groupBox_main.Controls.Add(this.button_mc_method);
            this.groupBox_main.Controls.Add(this.button_generate_border);
            this.groupBox_main.Controls.Add(this.groupBox_run_algorithm);
            this.groupBox_main.Controls.Add(this.groupBox_space_init);
            this.groupBox_main.Controls.Add(this.space_display);
            this.groupBox_main.Controls.Add(this.groupBox_structure);
            this.groupBox_main.Controls.Add(this.groupBox1);
            this.groupBox_main.Controls.Add(this.groupBox_inclusions);
            this.groupBox_main.Controls.Add(this.groupBox_neighborhood);
            this.groupBox_main.Location = new System.Drawing.Point(10, 26);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(1058, 804);
            this.groupBox_main.TabIndex = 0;
            this.groupBox_main.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_generate_nucleons);
            this.groupBox2.Controls.Add(this.button_grow_recrystalized);
            this.groupBox2.Controls.Add(this.checkBox_heterogeneous);
            this.groupBox2.Controls.Add(this.label_nucleons);
            this.groupBox2.Controls.Add(this.button_energy_distribution_create);
            this.groupBox2.Controls.Add(this.numericUpDown_nucleons_number);
            this.groupBox2.Controls.Add(this.button_energy_distribution_display);
            this.groupBox2.Controls.Add(this.numericUpDown_grain_boundaries_energy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_internal_energy);
            this.groupBox2.Location = new System.Drawing.Point(490, 462);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(442, 235);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SRXMC";
            // 
            // button_generate_nucleons
            // 
            this.button_generate_nucleons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_generate_nucleons.Location = new System.Drawing.Point(0, 42);
            this.button_generate_nucleons.Name = "button_generate_nucleons";
            this.button_generate_nucleons.Size = new System.Drawing.Size(415, 23);
            this.button_generate_nucleons.TabIndex = 41;
            this.button_generate_nucleons.Text = "Generate nucleons";
            this.button_generate_nucleons.UseVisualStyleBackColor = true;
            this.button_generate_nucleons.Click += new System.EventHandler(this.button_generate_nucleons_Click);
            // 
            // button_grow_recrystalized
            // 
            this.button_grow_recrystalized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_grow_recrystalized.Location = new System.Drawing.Point(0, 189);
            this.button_grow_recrystalized.Name = "button_grow_recrystalized";
            this.button_grow_recrystalized.Size = new System.Drawing.Size(415, 23);
            this.button_grow_recrystalized.TabIndex = 40;
            this.button_grow_recrystalized.Text = "Grow recrystalized";
            this.button_grow_recrystalized.UseVisualStyleBackColor = true;
            this.button_grow_recrystalized.Click += new System.EventHandler(this.button_grow_recrystalized_Click);
            // 
            // checkBox_heterogeneous
            // 
            this.checkBox_heterogeneous.AutoSize = true;
            this.checkBox_heterogeneous.Location = new System.Drawing.Point(4, 99);
            this.checkBox_heterogeneous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_heterogeneous.Name = "checkBox_heterogeneous";
            this.checkBox_heterogeneous.Size = new System.Drawing.Size(99, 17);
            this.checkBox_heterogeneous.TabIndex = 33;
            this.checkBox_heterogeneous.Text = "Heterogeneous";
            this.checkBox_heterogeneous.UseVisualStyleBackColor = true;
            this.checkBox_heterogeneous.CheckedChanged += new System.EventHandler(this.checkBox_heterogeneous_CheckedChanged);
            // 
            // label_nucleons
            // 
            this.label_nucleons.AutoSize = true;
            this.label_nucleons.Location = new System.Drawing.Point(188, 20);
            this.label_nucleons.Name = "label_nucleons";
            this.label_nucleons.Size = new System.Drawing.Size(102, 13);
            this.label_nucleons.TabIndex = 29;
            this.label_nucleons.Text = "Number of nucleons";
            // 
            // button_energy_distribution_create
            // 
            this.button_energy_distribution_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_energy_distribution_create.Location = new System.Drawing.Point(0, 131);
            this.button_energy_distribution_create.Name = "button_energy_distribution_create";
            this.button_energy_distribution_create.Size = new System.Drawing.Size(415, 23);
            this.button_energy_distribution_create.TabIndex = 38;
            this.button_energy_distribution_create.Text = "Generate energy distribution";
            this.button_energy_distribution_create.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_nucleons_number
            // 
            this.numericUpDown_nucleons_number.Location = new System.Drawing.Point(295, 18);
            this.numericUpDown_nucleons_number.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_nucleons_number.Name = "numericUpDown_nucleons_number";
            this.numericUpDown_nucleons_number.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_nucleons_number.TabIndex = 39;
            this.numericUpDown_nucleons_number.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_energy_distribution_display
            // 
            this.button_energy_distribution_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_energy_distribution_display.Location = new System.Drawing.Point(0, 160);
            this.button_energy_distribution_display.Name = "button_energy_distribution_display";
            this.button_energy_distribution_display.Size = new System.Drawing.Size(415, 23);
            this.button_energy_distribution_display.TabIndex = 31;
            this.button_energy_distribution_display.Text = "Show energy distribution";
            this.button_energy_distribution_display.UseVisualStyleBackColor = true;
            this.button_energy_distribution_display.Click += new System.EventHandler(this.button_energy_distribution_display_Click);
            // 
            // numericUpDown_grain_boundaries_energy
            // 
            this.numericUpDown_grain_boundaries_energy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_grain_boundaries_energy.Enabled = false;
            this.numericUpDown_grain_boundaries_energy.Location = new System.Drawing.Point(291, 108);
            this.numericUpDown_grain_boundaries_energy.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_grain_boundaries_energy.Name = "numericUpDown_grain_boundaries_energy";
            this.numericUpDown_grain_boundaries_energy.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_grain_boundaries_energy.TabIndex = 37;
            this.numericUpDown_grain_boundaries_energy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Grain boundaries energy level";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Internal energy level";
            // 
            // numericUpDown_internal_energy
            // 
            this.numericUpDown_internal_energy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_internal_energy.Location = new System.Drawing.Point(291, 84);
            this.numericUpDown_internal_energy.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_internal_energy.Name = "numericUpDown_internal_energy";
            this.numericUpDown_internal_energy.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_internal_energy.TabIndex = 35;
            this.numericUpDown_internal_energy.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_MC_iterations
            // 
            this.numericUpDown_MC_iterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_MC_iterations.Location = new System.Drawing.Point(220, 745);
            this.numericUpDown_MC_iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MC_iterations.Name = "numericUpDown_MC_iterations";
            this.numericUpDown_MC_iterations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_MC_iterations.TabIndex = 30;
            this.numericUpDown_MC_iterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_init_space_mc
            // 
            this.button_init_space_mc.Location = new System.Drawing.Point(0, 436);
            this.button_init_space_mc.Name = "button_init_space_mc";
            this.button_init_space_mc.Size = new System.Drawing.Size(415, 23);
            this.button_init_space_mc.TabIndex = 20;
            this.button_init_space_mc.Text = "Generate initial space for Monte Carlo";
            this.button_init_space_mc.UseVisualStyleBackColor = true;
            this.button_init_space_mc.Click += new System.EventHandler(this.button_init_space_mc_Click);
            // 
            // label_number_of_MC_iterations
            // 
            this.label_number_of_MC_iterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_number_of_MC_iterations.AutoSize = true;
            this.label_number_of_MC_iterations.Location = new System.Drawing.Point(90, 747);
            this.label_number_of_MC_iterations.Name = "label_number_of_MC_iterations";
            this.label_number_of_MC_iterations.Size = new System.Drawing.Size(120, 13);
            this.label_number_of_MC_iterations.TabIndex = 29;
            this.label_number_of_MC_iterations.Text = "Number of MC iterations";
            // 
            // button_mc_method
            // 
            this.button_mc_method.Location = new System.Drawing.Point(0, 494);
            this.button_mc_method.Name = "button_mc_method";
            this.button_mc_method.Size = new System.Drawing.Size(417, 23);
            this.button_mc_method.TabIndex = 19;
            this.button_mc_method.Text = "monte carlo ";
            this.button_mc_method.UseVisualStyleBackColor = true;
            this.button_mc_method.Click += new System.EventHandler(this.button_mc_method_Click);
            // 
            // button_generate_border
            // 
            this.button_generate_border.Location = new System.Drawing.Point(247, 350);
            this.button_generate_border.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_generate_border.Name = "button_generate_border";
            this.button_generate_border.Size = new System.Drawing.Size(246, 44);
            this.button_generate_border.TabIndex = 18;
            this.button_generate_border.Text = "Show grain boundaries";
            this.button_generate_border.UseVisualStyleBackColor = true;
            this.button_generate_border.Click += new System.EventHandler(this.button_generate_border_Click);
            // 
            // groupBox_run_algorithm
            // 
            this.groupBox_run_algorithm.Controls.Add(this.button_single_iteration);
            this.groupBox_run_algorithm.Controls.Add(this.button_growth);
            this.groupBox_run_algorithm.Location = new System.Drawing.Point(5, 332);
            this.groupBox_run_algorithm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_run_algorithm.Name = "groupBox_run_algorithm";
            this.groupBox_run_algorithm.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_run_algorithm.Size = new System.Drawing.Size(225, 69);
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
            this.groupBox_space_init.Location = new System.Drawing.Point(5, 18);
            this.groupBox_space_init.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_space_init.Name = "groupBox_space_init";
            this.groupBox_space_init.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_space_init.Size = new System.Drawing.Size(227, 106);
            this.groupBox_space_init.TabIndex = 16;
            this.groupBox_space_init.TabStop = false;
            this.groupBox_space_init.Text = "Space initialization";
            // 
            // label_grain_number
            // 
            this.label_grain_number.AutoSize = true;
            this.label_grain_number.Location = new System.Drawing.Point(5, 54);
            this.label_grain_number.Name = "label_grain_number";
            this.label_grain_number.Size = new System.Drawing.Size(87, 13);
            this.label_grain_number.TabIndex = 17;
            this.label_grain_number.Text = "Number of grains";
            // 
            // numericUpDown_dimension
            // 
            this.numericUpDown_dimension.Location = new System.Drawing.Point(98, 29);
            this.numericUpDown_dimension.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_dimension.Name = "numericUpDown_dimension";
            this.numericUpDown_dimension.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_dimension.TabIndex = 15;
            this.numericUpDown_dimension.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numericUpDown_number_of_grains
            // 
            this.numericUpDown_number_of_grains.Location = new System.Drawing.Point(99, 54);
            this.numericUpDown_number_of_grains.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_number_of_grains.Name = "numericUpDown_number_of_grains";
            this.numericUpDown_number_of_grains.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_number_of_grains.TabIndex = 18;
            this.numericUpDown_number_of_grains.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label_dimension
            // 
            this.label_dimension.AutoSize = true;
            this.label_dimension.Location = new System.Drawing.Point(5, 29);
            this.label_dimension.Name = "label_dimension";
            this.label_dimension.Size = new System.Drawing.Size(88, 13);
            this.label_dimension.TabIndex = 16;
            this.label_dimension.Text = "Space dimension";
            // 
            // groupBox_structure
            // 
            this.groupBox_structure.Controls.Add(this.button_generate_new_grains_for_MC);
            this.groupBox_structure.Controls.Add(this.numericUpDown_new_grains);
            this.groupBox_structure.Controls.Add(this.label_number_of_new_grains);
            this.groupBox_structure.Controls.Add(this.button_generate_new_grains);
            this.groupBox_structure.Controls.Add(this.numericUpDown_structure_grain_number);
            this.groupBox_structure.Controls.Add(this.label_structure_grain_number);
            this.groupBox_structure.Controls.Add(this.label_structure_type);
            this.groupBox_structure.Controls.Add(this.button_generate_structure);
            this.groupBox_structure.Controls.Add(this.comboBox_structure_type);
            this.groupBox_structure.Location = new System.Drawing.Point(244, 147);
            this.groupBox_structure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_structure.Name = "groupBox_structure";
            this.groupBox_structure.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_structure.Size = new System.Drawing.Size(256, 188);
            this.groupBox_structure.TabIndex = 15;
            this.groupBox_structure.TabStop = false;
            this.groupBox_structure.Text = "Structure";
            // 
            // button_generate_new_grains_for_MC
            // 
            this.button_generate_new_grains_for_MC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_generate_new_grains_for_MC.Location = new System.Drawing.Point(2, 138);
            this.button_generate_new_grains_for_MC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_generate_new_grains_for_MC.Name = "button_generate_new_grains_for_MC";
            this.button_generate_new_grains_for_MC.Size = new System.Drawing.Size(252, 24);
            this.button_generate_new_grains_for_MC.TabIndex = 28;
            this.button_generate_new_grains_for_MC.Text = "Generate new grains for MC";
            this.button_generate_new_grains_for_MC.UseVisualStyleBackColor = true;
            this.button_generate_new_grains_for_MC.Click += new System.EventHandler(this.button_generate_new_grains_for_MC_Click);
            // 
            // numericUpDown_new_grains
            // 
            this.numericUpDown_new_grains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_new_grains.Location = new System.Drawing.Point(128, 98);
            this.numericUpDown_new_grains.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_new_grains.Name = "numericUpDown_new_grains";
            this.numericUpDown_new_grains.Size = new System.Drawing.Size(120, 20);
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
            this.label_number_of_new_grains.Location = new System.Drawing.Point(6, 102);
            this.label_number_of_new_grains.Name = "label_number_of_new_grains";
            this.label_number_of_new_grains.Size = new System.Drawing.Size(110, 13);
            this.label_number_of_new_grains.TabIndex = 26;
            this.label_number_of_new_grains.Text = "Number of new grains";
            // 
            // button_generate_new_grains
            // 
            this.button_generate_new_grains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_generate_new_grains.Location = new System.Drawing.Point(2, 162);
            this.button_generate_new_grains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_generate_new_grains.Name = "button_generate_new_grains";
            this.button_generate_new_grains.Size = new System.Drawing.Size(252, 24);
            this.button_generate_new_grains.TabIndex = 25;
            this.button_generate_new_grains.Text = "Generate new grains";
            this.button_generate_new_grains.UseVisualStyleBackColor = true;
            this.button_generate_new_grains.Click += new System.EventHandler(this.button_generate_new_grains_Click);
            // 
            // numericUpDown_structure_grain_number
            // 
            this.numericUpDown_structure_grain_number.Location = new System.Drawing.Point(128, 43);
            this.numericUpDown_structure_grain_number.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_structure_grain_number.Name = "numericUpDown_structure_grain_number";
            this.numericUpDown_structure_grain_number.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_structure_grain_number.TabIndex = 24;
            // 
            // label_structure_grain_number
            // 
            this.label_structure_grain_number.AutoSize = true;
            this.label_structure_grain_number.Location = new System.Drawing.Point(6, 47);
            this.label_structure_grain_number.Name = "label_structure_grain_number";
            this.label_structure_grain_number.Size = new System.Drawing.Size(87, 13);
            this.label_structure_grain_number.TabIndex = 23;
            this.label_structure_grain_number.Text = "Number of grains";
            // 
            // label_structure_type
            // 
            this.label_structure_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_structure_type.AutoSize = true;
            this.label_structure_type.Location = new System.Drawing.Point(6, 20);
            this.label_structure_type.Name = "label_structure_type";
            this.label_structure_type.Size = new System.Drawing.Size(31, 13);
            this.label_structure_type.TabIndex = 22;
            this.label_structure_type.Text = "Type";
            // 
            // button_generate_structure
            // 
            this.button_generate_structure.Enabled = false;
            this.button_generate_structure.Location = new System.Drawing.Point(5, 71);
            this.button_generate_structure.Name = "button_generate_structure";
            this.button_generate_structure.Size = new System.Drawing.Size(249, 23);
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
            this.comboBox_structure_type.Location = new System.Drawing.Point(128, 14);
            this.comboBox_structure_type.Name = "comboBox_structure_type";
            this.comboBox_structure_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_structure_type.TabIndex = 14;
            this.comboBox_structure_type.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_probability);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_extended_CA);
            this.groupBox1.Controls.Add(this.radioButton_classic_CA);
            this.groupBox1.Location = new System.Drawing.Point(0, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm version";
            // 
            // numericUpDown_probability
            // 
            this.numericUpDown_probability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_probability.Location = new System.Drawing.Point(136, 75);
            this.numericUpDown_probability.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_probability.Name = "numericUpDown_probability";
            this.numericUpDown_probability.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_probability.TabIndex = 26;
            this.numericUpDown_probability.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Change probability [%]";
            // 
            // radioButton_extended_CA
            // 
            this.radioButton_extended_CA.AutoSize = true;
            this.radioButton_extended_CA.Checked = true;
            this.radioButton_extended_CA.Location = new System.Drawing.Point(136, 34);
            this.radioButton_extended_CA.Name = "radioButton_extended_CA";
            this.radioButton_extended_CA.Size = new System.Drawing.Size(87, 17);
            this.radioButton_extended_CA.TabIndex = 1;
            this.radioButton_extended_CA.TabStop = true;
            this.radioButton_extended_CA.Text = "Extended CA";
            this.radioButton_extended_CA.UseVisualStyleBackColor = true;
            this.radioButton_extended_CA.CheckedChanged += new System.EventHandler(this.radioButton_extended_CA_CheckedChanged);
            // 
            // radioButton_classic_CA
            // 
            this.radioButton_classic_CA.AutoSize = true;
            this.radioButton_classic_CA.Location = new System.Drawing.Point(24, 34);
            this.radioButton_classic_CA.Name = "radioButton_classic_CA";
            this.radioButton_classic_CA.Size = new System.Drawing.Size(39, 17);
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
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.exportDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.importDataToolStripMenuItem.Text = "Import data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exportDataToolStripMenuItem.Text = "Export data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 840);
            this.Controls.Add(this.groupBox_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.groupBox_main.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nucleons_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_grain_boundaries_energy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_internal_energy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MC_iterations)).EndInit();
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
        private System.Windows.Forms.Button button_mc_method;
        private System.Windows.Forms.Button button_init_space_mc;
        private System.Windows.Forms.NumericUpDown numericUpDown_MC_iterations;
        private System.Windows.Forms.Label label_number_of_MC_iterations;
        private System.Windows.Forms.Button button_generate_new_grains_for_MC;
        private System.Windows.Forms.Button button_energy_distribution_display;
        private System.Windows.Forms.CheckBox checkBox_heterogeneous;
        private System.Windows.Forms.NumericUpDown numericUpDown_grain_boundaries_energy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_internal_energy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_energy_distribution_create;
        private System.Windows.Forms.Label label_nucleons;
        private System.Windows.Forms.NumericUpDown numericUpDown_nucleons_number;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_grow_recrystalized;
        private System.Windows.Forms.Button button_generate_nucleons;
    }
}

