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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_inclusions_size = new System.Windows.Forms.Label();
            this.label_inclusions_type = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox_neighborhood = new System.Windows.Forms.GroupBox();
            this.radioButton_Von_Neumann = new System.Windows.Forms.RadioButton();
            this.radioButton_Moore = new System.Windows.Forms.RadioButton();
            this.comboBox_inclusions = new System.Windows.Forms.ComboBox();
            this.groupBox_inclusions = new System.Windows.Forms.GroupBox();
            this.label_inclusions_no = new System.Windows.Forms.Label();
            this.groupBox_config = new System.Windows.Forms.GroupBox();
            this.numericUpDown_number_of_grains = new System.Windows.Forms.NumericUpDown();
            this.label_grain_number = new System.Windows.Forms.Label();
            this.label_dimension = new System.Windows.Forms.Label();
            this.numericUpDown_dimension = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).BeginInit();
            this.groupBox_neighborhood.SuspendLayout();
            this.groupBox_inclusions.SuspendLayout();
            this.groupBox_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_grains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // space_display
            // 
            this.space_display.Location = new System.Drawing.Point(706, 12);
            this.space_display.Name = "space_display";
            this.space_display.Size = new System.Drawing.Size(439, 383);
            this.space_display.TabIndex = 1;
            this.space_display.TabStop = false;
            // 
            // button_space_generation
            // 
            this.button_space_generation.Location = new System.Drawing.Point(6, 338);
            this.button_space_generation.Name = "button_space_generation";
            this.button_space_generation.Size = new System.Drawing.Size(133, 23);
            this.button_space_generation.TabIndex = 2;
            this.button_space_generation.Text = "Generate initial space";
            this.button_space_generation.UseVisualStyleBackColor = true;
            this.button_space_generation.Click += new System.EventHandler(this.button_generate_initial_space);
            // 
            // button_single_iteration
            // 
            this.button_single_iteration.Location = new System.Drawing.Point(6, 367);
            this.button_single_iteration.Name = "button_single_iteration";
            this.button_single_iteration.Size = new System.Drawing.Size(133, 25);
            this.button_single_iteration.TabIndex = 3;
            this.button_single_iteration.Text = "Proceed single iteration";
            this.button_single_iteration.UseVisualStyleBackColor = true;
            this.button_single_iteration.Click += new System.EventHandler(this.button_proceed_single_iteration);
            // 
            // button_growth
            // 
            this.button_growth.Location = new System.Drawing.Point(6, 398);
            this.button_growth.Name = "button_growth";
            this.button_growth.Size = new System.Drawing.Size(133, 23);
            this.button_growth.TabIndex = 4;
            this.button_growth.Text = "Proceed growth";
            this.button_growth.UseVisualStyleBackColor = true;
            this.button_growth.Click += new System.EventHandler(this.button_growth_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(191, 446);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_inclusions_size
            // 
            this.label_inclusions_size.AutoSize = true;
            this.label_inclusions_size.Location = new System.Drawing.Point(22, 67);
            this.label_inclusions_size.Name = "label_inclusions_size";
            this.label_inclusions_size.Size = new System.Drawing.Size(88, 13);
            this.label_inclusions_size.TabIndex = 7;
            this.label_inclusions_size.Text = "Size of inclusions";
            // 
            // label_inclusions_type
            // 
            this.label_inclusions_type.AutoSize = true;
            this.label_inclusions_type.Location = new System.Drawing.Point(22, 93);
            this.label_inclusions_type.Name = "label_inclusions_type";
            this.label_inclusions_type.Size = new System.Drawing.Size(92, 13);
            this.label_inclusions_type.TabIndex = 8;
            this.label_inclusions_type.Text = "Type of inclusions";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // groupBox_neighborhood
            // 
            this.groupBox_neighborhood.Controls.Add(this.radioButton_Von_Neumann);
            this.groupBox_neighborhood.Controls.Add(this.radioButton_Moore);
            this.groupBox_neighborhood.Location = new System.Drawing.Point(6, 19);
            this.groupBox_neighborhood.Name = "groupBox_neighborhood";
            this.groupBox_neighborhood.Size = new System.Drawing.Size(158, 65);
            this.groupBox_neighborhood.TabIndex = 12;
            this.groupBox_neighborhood.TabStop = false;
            this.groupBox_neighborhood.Text = "Neighborhood type";
            // 
            // radioButton_Von_Neumann
            // 
            this.radioButton_Von_Neumann.AutoSize = true;
            this.radioButton_Von_Neumann.Checked = true;
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
            "Rectangular"});
            this.comboBox_inclusions.Location = new System.Drawing.Point(144, 93);
            this.comboBox_inclusions.Name = "comboBox_inclusions";
            this.comboBox_inclusions.Size = new System.Drawing.Size(121, 21);
            this.comboBox_inclusions.TabIndex = 13;
            this.comboBox_inclusions.Text = "None";
            // 
            // groupBox_inclusions
            // 
            this.groupBox_inclusions.Controls.Add(this.label_inclusions_no);
            this.groupBox_inclusions.Controls.Add(this.comboBox_inclusions);
            this.groupBox_inclusions.Controls.Add(this.label_inclusions_size);
            this.groupBox_inclusions.Controls.Add(this.label_inclusions_type);
            this.groupBox_inclusions.Controls.Add(this.textBox2);
            this.groupBox_inclusions.Controls.Add(this.textBox1);
            this.groupBox_inclusions.Location = new System.Drawing.Point(6, 90);
            this.groupBox_inclusions.Name = "groupBox_inclusions";
            this.groupBox_inclusions.Size = new System.Drawing.Size(280, 131);
            this.groupBox_inclusions.TabIndex = 14;
            this.groupBox_inclusions.TabStop = false;
            this.groupBox_inclusions.Text = "Inclusions";
            // 
            // label_inclusions_no
            // 
            this.label_inclusions_no.AutoSize = true;
            this.label_inclusions_no.Location = new System.Drawing.Point(22, 42);
            this.label_inclusions_no.Name = "label_inclusions_no";
            this.label_inclusions_no.Size = new System.Drawing.Size(105, 13);
            this.label_inclusions_no.TabIndex = 6;
            this.label_inclusions_no.Text = "Number of inclusions";
            // 
            // groupBox_config
            // 
            this.groupBox_config.Controls.Add(this.numericUpDown_number_of_grains);
            this.groupBox_config.Controls.Add(this.label_grain_number);
            this.groupBox_config.Controls.Add(this.label_dimension);
            this.groupBox_config.Controls.Add(this.numericUpDown_dimension);
            this.groupBox_config.Controls.Add(this.groupBox_inclusions);
            this.groupBox_config.Controls.Add(this.groupBox_neighborhood);
            this.groupBox_config.Controls.Add(this.checkBox1);
            this.groupBox_config.Controls.Add(this.button_growth);
            this.groupBox_config.Controls.Add(this.button_single_iteration);
            this.groupBox_config.Controls.Add(this.button_space_generation);
            this.groupBox_config.Location = new System.Drawing.Point(12, 56);
            this.groupBox_config.Name = "groupBox_config";
            this.groupBox_config.Size = new System.Drawing.Size(611, 481);
            this.groupBox_config.TabIndex = 0;
            this.groupBox_config.TabStop = false;
            this.groupBox_config.Text = "Configuration";
            // 
            // numericUpDown_number_of_grains
            // 
            this.numericUpDown_number_of_grains.Location = new System.Drawing.Point(103, 291);
            this.numericUpDown_number_of_grains.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_number_of_grains.Name = "numericUpDown_number_of_grains";
            this.numericUpDown_number_of_grains.Size = new System.Drawing.Size(120, 20);
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
            this.label_grain_number.Location = new System.Drawing.Point(9, 293);
            this.label_grain_number.Name = "label_grain_number";
            this.label_grain_number.Size = new System.Drawing.Size(87, 13);
            this.label_grain_number.TabIndex = 17;
            this.label_grain_number.Text = "Number of grains";
            // 
            // label_dimension
            // 
            this.label_dimension.AutoSize = true;
            this.label_dimension.Location = new System.Drawing.Point(9, 261);
            this.label_dimension.Name = "label_dimension";
            this.label_dimension.Size = new System.Drawing.Size(88, 13);
            this.label_dimension.TabIndex = 16;
            this.label_dimension.Text = "Space dimension";
            // 
            // numericUpDown_dimension
            // 
            this.numericUpDown_dimension.Location = new System.Drawing.Point(103, 259);
            this.numericUpDown_dimension.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_dimension.Name = "numericUpDown_dimension";
            this.numericUpDown_dimension.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_dimension.TabIndex = 15;
            this.numericUpDown_dimension.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
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
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importDataToolStripMenuItem.Text = "Import data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportDataToolStripMenuItem.Text = "Export data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 588);
            this.Controls.Add(this.space_display);
            this.Controls.Add(this.groupBox_config);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowForm";
            this.Text = "Multiscale Modelling";
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).EndInit();
            this.groupBox_neighborhood.ResumeLayout(false);
            this.groupBox_neighborhood.PerformLayout();
            this.groupBox_inclusions.ResumeLayout(false);
            this.groupBox_inclusions.PerformLayout();
            this.groupBox_config.ResumeLayout(false);
            this.groupBox_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_grains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_inclusions_size;
        private System.Windows.Forms.Label label_inclusions_type;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

