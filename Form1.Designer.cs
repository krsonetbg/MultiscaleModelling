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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxNeighborhood = new System.Windows.Forms.GroupBox();
            this.radioButton_Von_Neumann = new System.Windows.Forms.RadioButton();
            this.radioButton_Moore = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_inclusions_type = new System.Windows.Forms.Label();
            this.label_inclusions_size = new System.Windows.Forms.Label();
            this.label_inclusions_no = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_space_generation = new System.Windows.Forms.Button();
            this.space_display = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxNeighborhood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBoxNeighborhood);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label_inclusions_type);
            this.groupBox1.Controls.Add(this.label_inclusions_size);
            this.groupBox1.Controls.Add(this.label_inclusions_no);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_space_generation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBoxNeighborhood
            // 
            this.groupBoxNeighborhood.Controls.Add(this.radioButton_Von_Neumann);
            this.groupBoxNeighborhood.Controls.Add(this.radioButton_Moore);
            this.groupBoxNeighborhood.Location = new System.Drawing.Point(6, 19);
            this.groupBoxNeighborhood.Name = "groupBoxNeighborhood";
            this.groupBoxNeighborhood.Size = new System.Drawing.Size(158, 65);
            this.groupBoxNeighborhood.TabIndex = 12;
            this.groupBoxNeighborhood.TabStop = false;
            this.groupBoxNeighborhood.Text = "Neighborhood type";
            // 
            // radioButton_Von_Neumann
            // 
            this.radioButton_Von_Neumann.AutoSize = true;
            this.radioButton_Von_Neumann.Location = new System.Drawing.Point(67, 34);
            this.radioButton_Von_Neumann.Name = "radioButton_Von_Neumann";
            this.radioButton_Von_Neumann.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Von_Neumann.TabIndex = 1;
            this.radioButton_Von_Neumann.TabStop = true;
            this.radioButton_Von_Neumann.Text = "VonNeumann";
            this.radioButton_Von_Neumann.UseVisualStyleBackColor = true;
            this.radioButton_Von_Neumann.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.radioButton_Moore.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label_inclusions_type
            // 
            this.label_inclusions_type.AutoSize = true;
            this.label_inclusions_type.Location = new System.Drawing.Point(0, 219);
            this.label_inclusions_type.Name = "label_inclusions_type";
            this.label_inclusions_type.Size = new System.Drawing.Size(92, 13);
            this.label_inclusions_type.TabIndex = 8;
            this.label_inclusions_type.Text = "Type of inclusions";
            // 
            // label_inclusions_size
            // 
            this.label_inclusions_size.AutoSize = true;
            this.label_inclusions_size.Location = new System.Drawing.Point(0, 193);
            this.label_inclusions_size.Name = "label_inclusions_size";
            this.label_inclusions_size.Size = new System.Drawing.Size(88, 13);
            this.label_inclusions_size.TabIndex = 7;
            this.label_inclusions_size.Text = "Size of inclusions";
            // 
            // label_inclusions_no
            // 
            this.label_inclusions_no.AutoSize = true;
            this.label_inclusions_no.Location = new System.Drawing.Point(0, 168);
            this.label_inclusions_no.Name = "label_inclusions_no";
            this.label_inclusions_no.Size = new System.Drawing.Size(105, 13);
            this.label_inclusions_no.TabIndex = 6;
            this.label_inclusions_no.Text = "Number of inclusions";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_space_generation
            // 
            this.button_space_generation.Location = new System.Drawing.Point(3, 101);
            this.button_space_generation.Name = "button_space_generation";
            this.button_space_generation.Size = new System.Drawing.Size(127, 23);
            this.button_space_generation.TabIndex = 2;
            this.button_space_generation.Text = "Generate initial space";
            this.button_space_generation.UseVisualStyleBackColor = true;
            this.button_space_generation.Click += new System.EventHandler(this.button1_Click);
            // 
            // space_display
            // 
            this.space_display.Location = new System.Drawing.Point(440, 12);
            this.space_display.Name = "space_display";
            this.space_display.Size = new System.Drawing.Size(439, 383);
            this.space_display.TabIndex = 1;
            this.space_display.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 588);
            this.Controls.Add(this.space_display);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindowForm";
            this.Text = "Multiscale Modelling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxNeighborhood.ResumeLayout(false);
            this.groupBoxNeighborhood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.space_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Von_Neumann;
        private System.Windows.Forms.RadioButton radioButton_Moore;
        private System.Windows.Forms.Label label_inclusions_type;
        private System.Windows.Forms.Label label_inclusions_size;
        private System.Windows.Forms.Label label_inclusions_no;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_space_generation;
        private System.Windows.Forms.PictureBox space_display;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxNeighborhood;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

