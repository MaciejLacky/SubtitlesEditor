namespace SubtitlesEditor
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTimeShift = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOutputFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFileToFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPathToFolder = new System.Windows.Forms.TextBox();
            this.btnAddPathToFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPathToFile = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeShift)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStartProcess);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(303, 177);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(205, 37);
            this.btnStartProcess.TabIndex = 2;
            this.btnStartProcess.Text = "Uruchom proces";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTimeShift);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbOutputFileName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddFileToFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPathToFolder);
            this.groupBox1.Controls.Add(this.btnAddPathToFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPathToFile);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytaj plik .srt";
            // 
            // nudTimeShift
            // 
            this.nudTimeShift.DecimalPlaces = 3;
            this.nudTimeShift.Location = new System.Drawing.Point(571, 83);
            this.nudTimeShift.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTimeShift.Name = "nudTimeShift";
            this.nudTimeShift.Size = new System.Drawing.Size(115, 23);
            this.nudTimeShift.TabIndex = 9;
            this.nudTimeShift.Value = new decimal(new int[] {
            5880,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Przesunięcie czasu napisów [s]";
            // 
            // tbOutputFileName
            // 
            this.tbOutputFileName.Location = new System.Drawing.Point(194, 82);
            this.tbOutputFileName.Name = "tbOutputFileName";
            this.tbOutputFileName.Size = new System.Drawing.Size(165, 23);
            this.tbOutputFileName.TabIndex = 7;
            this.tbOutputFileName.Text = "napisyOutput.srt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwa pliku wynikowego";
            // 
            // btnAddFileToFolder
            // 
            this.btnAddFileToFolder.Location = new System.Drawing.Point(692, 55);
            this.btnAddFileToFolder.Name = "btnAddFileToFolder";
            this.btnAddFileToFolder.Size = new System.Drawing.Size(75, 23);
            this.btnAddFileToFolder.TabIndex = 5;
            this.btnAddFileToFolder.Text = "Dodaj";
            this.btnAddFileToFolder.UseVisualStyleBackColor = true;
            this.btnAddFileToFolder.Click += new System.EventHandler(this.btnAddFileToFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folder do pliku wynikowego";
            // 
            // tbPathToFolder
            // 
            this.tbPathToFolder.Location = new System.Drawing.Point(194, 55);
            this.tbPathToFolder.Name = "tbPathToFolder";
            this.tbPathToFolder.Size = new System.Drawing.Size(492, 23);
            this.tbPathToFolder.TabIndex = 3;
            // 
            // btnAddPathToFile
            // 
            this.btnAddPathToFile.Location = new System.Drawing.Point(692, 26);
            this.btnAddPathToFile.Name = "btnAddPathToFile";
            this.btnAddPathToFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddPathToFile.TabIndex = 2;
            this.btnAddPathToFile.Text = "Dodaj";
            this.btnAddPathToFile.UseVisualStyleBackColor = true;
            this.btnAddPathToFile.Click += new System.EventHandler(this.btnAddPathToFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ścieżka do pliku";
            // 
            // tbPathToFile
            // 
            this.tbPathToFile.Location = new System.Drawing.Point(194, 26);
            this.tbPathToFile.Name = "tbPathToFile";
            this.tbPathToFile.Size = new System.Drawing.Size(492, 23);
            this.tbPathToFile.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.Text = "SubtitlesEditor";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnAddPathToFile;
        private Label label1;
        private TextBox tbPathToFile;
        private Button btnStartProcess;
        private Button btnAddFileToFolder;
        private Label label2;
        private TextBox tbPathToFolder;
        private TextBox tbOutputFileName;
        private Label label3;
        private Label label4;
        private NumericUpDown nudTimeShift;
    }
}