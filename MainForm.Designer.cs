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
            this.button3 = new System.Windows.Forms.Button();
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
            this.label_dimension = new System.Windows.Forms.Label();
            this.numericUpDown_dimension = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).BeginInit();
            this.groupBox_neighborhood.SuspendLayout();
            this.groupBox_inclusions.SuspendLayout();
            this.groupBox_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).BeginInit();
            this.SuspendLayout();
            // 
            // space_display
            // 
            this.space_display.Location = new System.Drawing.Point(587, 15);
            this.space_display.Margin = new System.Windows.Forms.Padding(4);
            this.space_display.Name = "space_display";
            this.space_display.Size = new System.Drawing.Size(585, 471);
            this.space_display.TabIndex = 1;
            this.space_display.TabStop = false;
            // 
            // button_space_generation
            // 
            this.button_space_generation.Location = new System.Drawing.Point(4, 375);
            this.button_space_generation.Margin = new System.Windows.Forms.Padding(4);
            this.button_space_generation.Name = "button_space_generation";
            this.button_space_generation.Size = new System.Drawing.Size(169, 28);
            this.button_space_generation.TabIndex = 2;
            this.button_space_generation.Text = "Generate initial space";
            this.button_space_generation.UseVisualStyleBackColor = true;
            this.button_space_generation.Click += new System.EventHandler(this.button_generate_initial_space);
            // 
            // button_single_iteration
            // 
            this.button_single_iteration.Location = new System.Drawing.Point(181, 375);
            this.button_single_iteration.Margin = new System.Windows.Forms.Padding(4);
            this.button_single_iteration.Name = "button_single_iteration";
            this.button_single_iteration.Size = new System.Drawing.Size(100, 64);
            this.button_single_iteration.TabIndex = 3;
            this.button_single_iteration.Text = "Proceed single iteration";
            this.button_single_iteration.UseVisualStyleBackColor = true;
            this.button_single_iteration.Click += new System.EventHandler(this.button_proceed_single_iteration);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 411);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 475);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 10;
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
            "Rectangular"});
            this.comboBox_inclusions.Location = new System.Drawing.Point(192, 114);
            this.comboBox_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_inclusions.Name = "comboBox_inclusions";
            this.comboBox_inclusions.Size = new System.Drawing.Size(160, 24);
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
            this.groupBox_inclusions.Location = new System.Drawing.Point(8, 111);
            this.groupBox_inclusions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_inclusions.Name = "groupBox_inclusions";
            this.groupBox_inclusions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_inclusions.Size = new System.Drawing.Size(373, 161);
            this.groupBox_inclusions.TabIndex = 14;
            this.groupBox_inclusions.TabStop = false;
            this.groupBox_inclusions.Text = "Inclusions";
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
            this.groupBox_config.Controls.Add(this.label_dimension);
            this.groupBox_config.Controls.Add(this.numericUpDown_dimension);
            this.groupBox_config.Controls.Add(this.groupBox_inclusions);
            this.groupBox_config.Controls.Add(this.groupBox_neighborhood);
            this.groupBox_config.Controls.Add(this.checkBox1);
            this.groupBox_config.Controls.Add(this.button3);
            this.groupBox_config.Controls.Add(this.button_single_iteration);
            this.groupBox_config.Controls.Add(this.button_space_generation);
            this.groupBox_config.Location = new System.Drawing.Point(16, 15);
            this.groupBox_config.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_config.Name = "groupBox_config";
            this.groupBox_config.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_config.Size = new System.Drawing.Size(417, 546);
            this.groupBox_config.TabIndex = 0;
            this.groupBox_config.TabStop = false;
            this.groupBox_config.Text = "Configuration";
            // 
            // label_dimension
            // 
            this.label_dimension.AutoSize = true;
            this.label_dimension.Location = new System.Drawing.Point(12, 321);
            this.label_dimension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dimension.Name = "label_dimension";
            this.label_dimension.Size = new System.Drawing.Size(116, 17);
            this.label_dimension.TabIndex = 16;
            this.label_dimension.Text = "Space dimension";
            // 
            // numericUpDown_dimension
            // 
            this.numericUpDown_dimension.Location = new System.Drawing.Point(137, 319);
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
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 724);
            this.Controls.Add(this.space_display);
            this.Controls.Add(this.groupBox_config);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindowForm";
            this.Text = "Multiscale Modelling";
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).EndInit();
            this.groupBox_neighborhood.ResumeLayout(false);
            this.groupBox_neighborhood.PerformLayout();
            this.groupBox_inclusions.ResumeLayout(false);
            this.groupBox_inclusions.PerformLayout();
            this.groupBox_config.ResumeLayout(false);
            this.groupBox_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dimension)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox space_display;
        private System.Windows.Forms.Button button_space_generation;
        private System.Windows.Forms.Button button_single_iteration;
        private System.Windows.Forms.Button button3;
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
    }
}

