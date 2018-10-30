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
            this.groupBox_config = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_extended_CA = new System.Windows.Forms.RadioButton();
            this.radioButton_classic_CA = new System.Windows.Forms.RadioButton();
            this.numericUpDown_number_of_grains = new System.Windows.Forms.NumericUpDown();
            this.label_grain_number = new System.Windows.Forms.Label();
            this.label_dimension = new System.Windows.Forms.Label();
            this.numericUpDown_dimension = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_structure_type = new System.Windows.Forms.ComboBox();
            this.groupBox_structure = new System.Windows.Forms.GroupBox();
            this.button_generate_structure = new System.Windows.Forms.Button();
            this.label_structure_type = new System.Windows.Forms.Label();
            this.label_structure_grain_number = new System.Windows.Forms.Label();
            this.numericUpDown_structure_grain_number = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).BeginInit();
            this.groupBox_neighborhood.SuspendLayout();
            this.groupBox_inclusions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_inclusions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inclusion_size)).BeginInit();
            this.groupBox_config.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_grains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_structure_grain_number)).BeginInit();
            this.SuspendLayout();
            // 
            // space_display
            // 
            this.space_display.Location = new System.Drawing.Point(789, 34);
            this.space_display.Margin = new System.Windows.Forms.Padding(4);
            this.space_display.Name = "space_display";
            this.space_display.Size = new System.Drawing.Size(585, 471);
            this.space_display.TabIndex = 1;
            this.space_display.TabStop = false;
            this.space_display.Click += new System.EventHandler(this.space_display_Click);
            // 
            // button_space_generation
            // 
            this.button_space_generation.Location = new System.Drawing.Point(8, 405);
            this.button_space_generation.Margin = new System.Windows.Forms.Padding(4);
            this.button_space_generation.Name = "button_space_generation";
            this.button_space_generation.Size = new System.Drawing.Size(177, 28);
            this.button_space_generation.TabIndex = 2;
            this.button_space_generation.Text = "Generate initial space";
            this.button_space_generation.UseVisualStyleBackColor = true;
            this.button_space_generation.Click += new System.EventHandler(this.button_generate_initial_space);
            // 
            // button_single_iteration
            // 
            this.button_single_iteration.Location = new System.Drawing.Point(8, 441);
            this.button_single_iteration.Margin = new System.Windows.Forms.Padding(4);
            this.button_single_iteration.Name = "button_single_iteration";
            this.button_single_iteration.Size = new System.Drawing.Size(177, 31);
            this.button_single_iteration.TabIndex = 3;
            this.button_single_iteration.Text = "Proceed single iteration";
            this.button_single_iteration.UseVisualStyleBackColor = true;
            this.button_single_iteration.Click += new System.EventHandler(this.button_proceed_single_iteration);
            // 
            // button_growth
            // 
            this.button_growth.Location = new System.Drawing.Point(8, 479);
            this.button_growth.Margin = new System.Windows.Forms.Padding(4);
            this.button_growth.Name = "button_growth";
            this.button_growth.Size = new System.Drawing.Size(177, 28);
            this.button_growth.TabIndex = 4;
            this.button_growth.Text = "Proceed growth";
            this.button_growth.UseVisualStyleBackColor = true;
            this.button_growth.Click += new System.EventHandler(this.button_growth_Click);
            // 
            // label_inclusions_size
            // 
            this.label_inclusions_size.AutoSize = true;
            this.label_inclusions_size.Location = new System.Drawing.Point(29, 82);
            this.label_inclusions_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inclusions_size.Name = "label_inclusions_size";
            this.label_inclusions_size.Size = new System.Drawing.Size(117, 17);
            this.label_inclusions_size.TabIndex = 7;
            this.label_inclusions_size.Text = "Size of inclusions";
            // 
            // label_inclusions_type
            // 
            this.label_inclusions_type.AutoSize = true;
            this.label_inclusions_type.Location = new System.Drawing.Point(29, 114);
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
            this.groupBox_neighborhood.Location = new System.Drawing.Point(8, 23);
            this.groupBox_neighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_neighborhood.Name = "groupBox_neighborhood";
            this.groupBox_neighborhood.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_neighborhood.Size = new System.Drawing.Size(211, 80);
            this.groupBox_neighborhood.TabIndex = 12;
            this.groupBox_neighborhood.TabStop = false;
            this.groupBox_neighborhood.Text = "Neighborhood type";
            // 
            // radioButton_Von_Neumann
            // 
            this.radioButton_Von_Neumann.AutoSize = true;
            this.radioButton_Von_Neumann.Checked = true;
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
            this.comboBox_inclusions.Location = new System.Drawing.Point(192, 114);
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
            this.groupBox_inclusions.Location = new System.Drawing.Point(8, 111);
            this.groupBox_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_inclusions.Name = "groupBox_inclusions";
            this.groupBox_inclusions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_inclusions.Size = new System.Drawing.Size(373, 210);
            this.groupBox_inclusions.TabIndex = 14;
            this.groupBox_inclusions.TabStop = false;
            this.groupBox_inclusions.Text = "Inclusions";
            // 
            // button_generate_inclusions
            // 
            this.button_generate_inclusions.Location = new System.Drawing.Point(32, 161);
            this.button_generate_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.button_generate_inclusions.Name = "button_generate_inclusions";
            this.button_generate_inclusions.Size = new System.Drawing.Size(320, 28);
            this.button_generate_inclusions.TabIndex = 19;
            this.button_generate_inclusions.Text = "Generate inclusions";
            this.button_generate_inclusions.UseVisualStyleBackColor = true;
            this.button_generate_inclusions.Click += new System.EventHandler(this.button_generate_inclusions_Click);
            // 
            // numericUpDown_number_of_inclusions
            // 
            this.numericUpDown_number_of_inclusions.Location = new System.Drawing.Point(192, 49);
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
            this.numericUpDown_inclusion_size.Location = new System.Drawing.Point(192, 80);
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
            this.label_inclusions_no.Location = new System.Drawing.Point(29, 52);
            this.label_inclusions_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inclusions_no.Name = "label_inclusions_no";
            this.label_inclusions_no.Size = new System.Drawing.Size(140, 17);
            this.label_inclusions_no.TabIndex = 6;
            this.label_inclusions_no.Text = "Number of inclusions";
            // 
            // groupBox_config
            // 
            this.groupBox_config.Controls.Add(this.groupBox1);
            this.groupBox_config.Controls.Add(this.numericUpDown_number_of_grains);
            this.groupBox_config.Controls.Add(this.label_grain_number);
            this.groupBox_config.Controls.Add(this.label_dimension);
            this.groupBox_config.Controls.Add(this.numericUpDown_dimension);
            this.groupBox_config.Controls.Add(this.groupBox_inclusions);
            this.groupBox_config.Controls.Add(this.groupBox_neighborhood);
            this.groupBox_config.Controls.Add(this.button_growth);
            this.groupBox_config.Controls.Add(this.button_single_iteration);
            this.groupBox_config.Controls.Add(this.button_space_generation);
            this.groupBox_config.Location = new System.Drawing.Point(16, 33);
            this.groupBox_config.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_config.Name = "groupBox_config";
            this.groupBox_config.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_config.Size = new System.Drawing.Size(449, 507);
            this.groupBox_config.TabIndex = 0;
            this.groupBox_config.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_extended_CA);
            this.groupBox1.Controls.Add(this.radioButton_classic_CA);
            this.groupBox1.Location = new System.Drawing.Point(256, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(211, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm version";
            // 
            // radioButton_extended_CA
            // 
            this.radioButton_extended_CA.AutoSize = true;
            this.radioButton_extended_CA.Checked = true;
            this.radioButton_extended_CA.Location = new System.Drawing.Point(89, 42);
            this.radioButton_extended_CA.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_extended_CA.Name = "radioButton_extended_CA";
            this.radioButton_extended_CA.Size = new System.Drawing.Size(110, 21);
            this.radioButton_extended_CA.TabIndex = 1;
            this.radioButton_extended_CA.TabStop = true;
            this.radioButton_extended_CA.Text = "Extended CA";
            this.radioButton_extended_CA.UseVisualStyleBackColor = true;
            // 
            // radioButton_classic_CA
            // 
            this.radioButton_classic_CA.AutoSize = true;
            this.radioButton_classic_CA.Location = new System.Drawing.Point(8, 42);
            this.radioButton_classic_CA.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_classic_CA.Name = "radioButton_classic_CA";
            this.radioButton_classic_CA.Size = new System.Drawing.Size(47, 21);
            this.radioButton_classic_CA.TabIndex = 0;
            this.radioButton_classic_CA.TabStop = true;
            this.radioButton_classic_CA.Text = "CA";
            this.radioButton_classic_CA.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_number_of_grains
            // 
            this.numericUpDown_number_of_grains.Location = new System.Drawing.Point(130, 369);
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
            // label_grain_number
            // 
            this.label_grain_number.AutoSize = true;
            this.label_grain_number.Location = new System.Drawing.Point(5, 371);
            this.label_grain_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grain_number.Name = "label_grain_number";
            this.label_grain_number.Size = new System.Drawing.Size(117, 17);
            this.label_grain_number.TabIndex = 17;
            this.label_grain_number.Text = "Number of grains";
            // 
            // label_dimension
            // 
            this.label_dimension.AutoSize = true;
            this.label_dimension.Location = new System.Drawing.Point(5, 332);
            this.label_dimension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dimension.Name = "label_dimension";
            this.label_dimension.Size = new System.Drawing.Size(116, 17);
            this.label_dimension.TabIndex = 16;
            this.label_dimension.Text = "Space dimension";
            // 
            // numericUpDown_dimension
            // 
            this.numericUpDown_dimension.Location = new System.Drawing.Point(130, 329);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1387, 28);
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
            // comboBox_structure_type
            // 
            this.comboBox_structure_type.FormattingEnabled = true;
            this.comboBox_structure_type.Items.AddRange(new object[] {
            "Substructure",
            "Dual phase"});
            this.comboBox_structure_type.Location = new System.Drawing.Point(173, 49);
            this.comboBox_structure_type.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_structure_type.Name = "comboBox_structure_type";
            this.comboBox_structure_type.Size = new System.Drawing.Size(160, 24);
            this.comboBox_structure_type.TabIndex = 14;
            this.comboBox_structure_type.Text = "None";
            // 
            // groupBox_structure
            // 
            this.groupBox_structure.Controls.Add(this.numericUpDown_structure_grain_number);
            this.groupBox_structure.Controls.Add(this.label_structure_grain_number);
            this.groupBox_structure.Controls.Add(this.label_structure_type);
            this.groupBox_structure.Controls.Add(this.button_generate_structure);
            this.groupBox_structure.Controls.Add(this.comboBox_structure_type);
            this.groupBox_structure.Location = new System.Drawing.Point(404, 144);
            this.groupBox_structure.Name = "groupBox_structure";
            this.groupBox_structure.Size = new System.Drawing.Size(378, 210);
            this.groupBox_structure.TabIndex = 15;
            this.groupBox_structure.TabStop = false;
            this.groupBox_structure.Text = "Structure";
            // 
            // button_generate_structure
            // 
            this.button_generate_structure.Enabled = false;
            this.button_generate_structure.Location = new System.Drawing.Point(7, 161);
            this.button_generate_structure.Margin = new System.Windows.Forms.Padding(4);
            this.button_generate_structure.Name = "button_generate_structure";
            this.button_generate_structure.Size = new System.Drawing.Size(335, 28);
            this.button_generate_structure.TabIndex = 21;
            this.button_generate_structure.Text = "Generate structure";
            this.button_generate_structure.UseVisualStyleBackColor = true;
            this.button_generate_structure.Click += new System.EventHandler(this.button_generate_structure_Click);
            // 
            // label_structure_type
            // 
            this.label_structure_type.AutoSize = true;
            this.label_structure_type.Location = new System.Drawing.Point(39, 54);
            this.label_structure_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_structure_type.Name = "label_structure_type";
            this.label_structure_type.Size = new System.Drawing.Size(40, 17);
            this.label_structure_type.TabIndex = 22;
            this.label_structure_type.Text = "Type";
            // 
            // label_structure_grain_number
            // 
            this.label_structure_grain_number.AutoSize = true;
            this.label_structure_grain_number.Location = new System.Drawing.Point(34, 114);
            this.label_structure_grain_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_structure_grain_number.Name = "label_structure_grain_number";
            this.label_structure_grain_number.Size = new System.Drawing.Size(117, 17);
            this.label_structure_grain_number.TabIndex = 23;
            this.label_structure_grain_number.Text = "Number of grains";
            // 
            // numericUpDown_structure_grain_number
            // 
            this.numericUpDown_structure_grain_number.Location = new System.Drawing.Point(173, 112);
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
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 565);
            this.Controls.Add(this.groupBox_structure);
            this.Controls.Add(this.space_display);
            this.Controls.Add(this.groupBox_config);
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
            this.groupBox_config.ResumeLayout(false);
            this.groupBox_config.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_grains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_structure.ResumeLayout(false);
            this.groupBox_structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_structure_grain_number)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_config;
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
    }
}

