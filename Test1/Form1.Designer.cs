namespace Test1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.totalPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxScooters = new System.Windows.Forms.ListBox();
            this.listBoxSuburbs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonFindScooters = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.totalPayToolStripMenuItem,
            this.findToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(276, 6);
            // 
            // totalPayToolStripMenuItem
            // 
            this.totalPayToolStripMenuItem.Name = "totalPayToolStripMenuItem";
            this.totalPayToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.totalPayToolStripMenuItem.Text = "Total Pay";
            this.totalPayToolStripMenuItem.Click += new System.EventHandler(this.totalPayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.findToolStripMenuItem.Text = "Find the pay-most suburb";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Scooters";
            // 
            // listBoxScooters
            // 
            this.listBoxScooters.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxScooters.FormattingEnabled = true;
            this.listBoxScooters.ItemHeight = 14;
            this.listBoxScooters.Location = new System.Drawing.Point(20, 46);
            this.listBoxScooters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxScooters.Name = "listBoxScooters";
            this.listBoxScooters.Size = new System.Drawing.Size(795, 214);
            this.listBoxScooters.TabIndex = 2;
            // 
            // listBoxSuburbs
            // 
            this.listBoxSuburbs.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSuburbs.FormattingEnabled = true;
            this.listBoxSuburbs.ItemHeight = 14;
            this.listBoxSuburbs.Location = new System.Drawing.Point(20, 294);
            this.listBoxSuburbs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxSuburbs.Name = "listBoxSuburbs";
            this.listBoxSuburbs.Size = new System.Drawing.Size(795, 144);
            this.listBoxSuburbs.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Scooters";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enderley",
            "Rototuna",
            "Central",
            "Silverdale",
            "Queenswood",
            "Claudelands",
            "Flagstaff",
            "Deanwell",
            "Beerescourt",
            "Frankton",
            "Glenview",
            "Dinsdale",
            "Whitiora",
            "Ruakura",
            "Fairfield",
            "Harrowfield",
            "Aberdeen",
            "Chartwell",
            "Fitzroy",
            "Hillcrest",
            "Fairview",
            "Hamilton East",
            "Melville"});
            this.comboBox1.Location = new System.Drawing.Point(67, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonFindScooters
            // 
            this.buttonFindScooters.Location = new System.Drawing.Point(194, 3);
            this.buttonFindScooters.Name = "buttonFindScooters";
            this.buttonFindScooters.Size = new System.Drawing.Size(122, 24);
            this.buttonFindScooters.TabIndex = 6;
            this.buttonFindScooters.Text = "Find Scooters";
            this.buttonFindScooters.UseVisualStyleBackColor = true;
            this.buttonFindScooters.Click += new System.EventHandler(this.buttonFindScooters_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(323, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate Cost";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 509);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonFindScooters);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxSuburbs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxScooters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "COMPx102 Practical Test 1 5pm 2020";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxScooters;
        private System.Windows.Forms.ListBox listBoxSuburbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem totalPayToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFindScooters;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    }
}

