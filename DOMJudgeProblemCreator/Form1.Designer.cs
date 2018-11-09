﻿namespace DOMJudgeProblemCreator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoWorkingDirectory = new System.Windows.Forms.Label();
            this.workingDirectory = new System.Windows.Forms.Label();
            this.infoTestCases = new System.Windows.Forms.Label();
            this.testCases = new System.Windows.Forms.Label();
            this.newProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.infoName = new System.Windows.Forms.Label();
            this.infoMemLimit = new System.Windows.Forms.Label();
            this.infoTimeLimit = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.memLimit = new System.Windows.Forms.TextBox();
            this.timeLimit = new System.Windows.Forms.TextBox();
            this.infoNickName = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.MaskedTextBox();
            this.infoHexColour = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.hexColour = new System.Windows.Forms.Label();
            this.btnChooseColour = new System.Windows.Forms.Button();
            this.infoProblemStatement = new System.Windows.Forms.Label();
            this.problemStatement = new System.Windows.Forms.Label();
            this.btnChooseProblemStatement = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnNewTestCase = new System.Windows.Forms.Button();
            this.btnUpdateTestCase = new System.Windows.Forms.Button();
            this.checkSample = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testCases);
            this.groupBox1.Controls.Add(this.infoTestCases);
            this.groupBox1.Controls.Add(this.workingDirectory);
            this.groupBox1.Controls.Add(this.infoWorkingDirectory);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProblemToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // infoWorkingDirectory
            // 
            this.infoWorkingDirectory.AutoSize = true;
            this.infoWorkingDirectory.Location = new System.Drawing.Point(22, 30);
            this.infoWorkingDirectory.Name = "infoWorkingDirectory";
            this.infoWorkingDirectory.Size = new System.Drawing.Size(95, 13);
            this.infoWorkingDirectory.TabIndex = 0;
            this.infoWorkingDirectory.Text = "Working Directory:";
            // 
            // workingDirectory
            // 
            this.workingDirectory.AutoSize = true;
            this.workingDirectory.Location = new System.Drawing.Point(123, 30);
            this.workingDirectory.Name = "workingDirectory";
            this.workingDirectory.Size = new System.Drawing.Size(0, 13);
            this.workingDirectory.TabIndex = 1;
            // 
            // infoTestCases
            // 
            this.infoTestCases.AutoSize = true;
            this.infoTestCases.Location = new System.Drawing.Point(22, 57);
            this.infoTestCases.Name = "infoTestCases";
            this.infoTestCases.Size = new System.Drawing.Size(63, 13);
            this.infoTestCases.TabIndex = 2;
            this.infoTestCases.Text = "Test Cases:";
            // 
            // testCases
            // 
            this.testCases.AutoSize = true;
            this.testCases.Location = new System.Drawing.Point(123, 57);
            this.testCases.Name = "testCases";
            this.testCases.Size = new System.Drawing.Size(0, 13);
            this.testCases.TabIndex = 3;
            // 
            // newProblemToolStripMenuItem
            // 
            this.newProblemToolStripMenuItem.Name = "newProblemToolStripMenuItem";
            this.newProblemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newProblemToolStripMenuItem.Text = "New Problem";
            this.newProblemToolStripMenuItem.Click += new System.EventHandler(this.newProblemToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseProblemStatement);
            this.groupBox2.Controls.Add(this.problemStatement);
            this.groupBox2.Controls.Add(this.infoProblemStatement);
            this.groupBox2.Controls.Add(this.btnChooseColour);
            this.groupBox2.Controls.Add(this.hexColour);
            this.groupBox2.Controls.Add(this.infoHexColour);
            this.groupBox2.Controls.Add(this.nickName);
            this.groupBox2.Controls.Add(this.infoNickName);
            this.groupBox2.Controls.Add(this.timeLimit);
            this.groupBox2.Controls.Add(this.memLimit);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.infoTimeLimit);
            this.groupBox2.Controls.Add(this.infoMemLimit);
            this.groupBox2.Controls.Add(this.infoName);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Problem";
            // 
            // infoName
            // 
            this.infoName.AutoSize = true;
            this.infoName.Location = new System.Drawing.Point(18, 32);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(38, 13);
            this.infoName.TabIndex = 4;
            this.infoName.Text = "Name:";
            // 
            // infoMemLimit
            // 
            this.infoMemLimit.AutoSize = true;
            this.infoMemLimit.Location = new System.Drawing.Point(18, 84);
            this.infoMemLimit.Name = "infoMemLimit";
            this.infoMemLimit.Size = new System.Drawing.Size(96, 13);
            this.infoMemLimit.TabIndex = 5;
            this.infoMemLimit.Text = "Memory Limit (MB):";
            // 
            // infoTimeLimit
            // 
            this.infoTimeLimit.AutoSize = true;
            this.infoTimeLimit.Location = new System.Drawing.Point(18, 111);
            this.infoTimeLimit.Name = "infoTimeLimit";
            this.infoTimeLimit.Size = new System.Drawing.Size(57, 13);
            this.infoTimeLimit.TabIndex = 6;
            this.infoTimeLimit.Text = "Time Limit:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(62, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(270, 20);
            this.name.TabIndex = 7;
            // 
            // memLimit
            // 
            this.memLimit.Location = new System.Drawing.Point(120, 81);
            this.memLimit.Name = "memLimit";
            this.memLimit.Size = new System.Drawing.Size(212, 20);
            this.memLimit.TabIndex = 8;
            // 
            // timeLimit
            // 
            this.timeLimit.Location = new System.Drawing.Point(81, 107);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(251, 20);
            this.timeLimit.TabIndex = 9;
            // 
            // infoNickName
            // 
            this.infoNickName.AutoSize = true;
            this.infoNickName.Location = new System.Drawing.Point(18, 58);
            this.infoNickName.Name = "infoNickName";
            this.infoNickName.Size = new System.Drawing.Size(66, 13);
            this.infoNickName.TabIndex = 10;
            this.infoNickName.Text = "Short Name:";
            // 
            // nickName
            // 
            this.nickName.AllowPromptAsInput = false;
            this.nickName.HidePromptOnLeave = true;
            this.nickName.Location = new System.Drawing.Point(94, 55);
            this.nickName.Mask = "Aaaaaaaaaa";
            this.nickName.Name = "nickName";
            this.nickName.PromptChar = ' ';
            this.nickName.Size = new System.Drawing.Size(238, 20);
            this.nickName.TabIndex = 11;
            // 
            // infoHexColour
            // 
            this.infoHexColour.AutoSize = true;
            this.infoHexColour.Location = new System.Drawing.Point(18, 137);
            this.infoHexColour.Name = "infoHexColour";
            this.infoHexColour.Size = new System.Drawing.Size(62, 13);
            this.infoHexColour.TabIndex = 12;
            this.infoHexColour.Text = "Hex Colour:";
            // 
            // hexColour
            // 
            this.hexColour.AutoSize = true;
            this.hexColour.BackColor = System.Drawing.Color.White;
            this.hexColour.Location = new System.Drawing.Point(86, 137);
            this.hexColour.Name = "hexColour";
            this.hexColour.Size = new System.Drawing.Size(50, 13);
            this.hexColour.TabIndex = 13;
            this.hexColour.Text = "#FFFFFF";
            // 
            // btnChooseColour
            // 
            this.btnChooseColour.Location = new System.Drawing.Point(142, 132);
            this.btnChooseColour.Name = "btnChooseColour";
            this.btnChooseColour.Size = new System.Drawing.Size(75, 23);
            this.btnChooseColour.TabIndex = 14;
            this.btnChooseColour.Text = "Choose";
            this.btnChooseColour.UseVisualStyleBackColor = true;
            this.btnChooseColour.Click += new System.EventHandler(this.btnChooseColour_Click);
            // 
            // infoProblemStatement
            // 
            this.infoProblemStatement.AutoSize = true;
            this.infoProblemStatement.Location = new System.Drawing.Point(18, 162);
            this.infoProblemStatement.Name = "infoProblemStatement";
            this.infoProblemStatement.Size = new System.Drawing.Size(99, 13);
            this.infoProblemStatement.TabIndex = 15;
            this.infoProblemStatement.Text = "Problem Statement:";
            // 
            // problemStatement
            // 
            this.problemStatement.AutoSize = true;
            this.problemStatement.Location = new System.Drawing.Point(119, 162);
            this.problemStatement.Name = "problemStatement";
            this.problemStatement.Size = new System.Drawing.Size(65, 13);
            this.problemStatement.TabIndex = 16;
            this.problemStatement.Text = "Invalid path!";
            // 
            // btnChooseProblemStatement
            // 
            this.btnChooseProblemStatement.Location = new System.Drawing.Point(280, 157);
            this.btnChooseProblemStatement.Name = "btnChooseProblemStatement";
            this.btnChooseProblemStatement.Size = new System.Drawing.Size(75, 23);
            this.btnChooseProblemStatement.TabIndex = 17;
            this.btnChooseProblemStatement.Text = "Choose";
            this.btnChooseProblemStatement.UseVisualStyleBackColor = true;
            this.btnChooseProblemStatement.Click += new System.EventHandler(this.btnChooseProblemStatement_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF Files|*.pdf|TXT Files|*.txt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkSample);
            this.groupBox3.Controls.Add(this.btnUpdateTestCase);
            this.groupBox3.Controls.Add(this.btnNewTestCase);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(386, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 309);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Cases";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(139, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 111);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Sample Input";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(139, 146);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(250, 117);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Sample Output";
            this.richTextBox2.WordWrap = false;
            // 
            // btnNewTestCase
            // 
            this.btnNewTestCase.Location = new System.Drawing.Point(233, 274);
            this.btnNewTestCase.Name = "btnNewTestCase";
            this.btnNewTestCase.Size = new System.Drawing.Size(75, 23);
            this.btnNewTestCase.TabIndex = 18;
            this.btnNewTestCase.Text = "New";
            this.btnNewTestCase.UseVisualStyleBackColor = true;
            this.btnNewTestCase.Click += new System.EventHandler(this.btnNewTestCase_Click);
            // 
            // btnUpdateTestCase
            // 
            this.btnUpdateTestCase.Enabled = false;
            this.btnUpdateTestCase.Location = new System.Drawing.Point(314, 274);
            this.btnUpdateTestCase.Name = "btnUpdateTestCase";
            this.btnUpdateTestCase.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTestCase.TabIndex = 19;
            this.btnUpdateTestCase.Text = "Update";
            this.btnUpdateTestCase.UseVisualStyleBackColor = true;
            this.btnUpdateTestCase.Click += new System.EventHandler(this.btnUpdateTestCase_Click);
            // 
            // checkSample
            // 
            this.checkSample.AutoSize = true;
            this.checkSample.Location = new System.Drawing.Point(153, 278);
            this.checkSample.Name = "checkSample";
            this.checkSample.Size = new System.Drawing.Size(61, 17);
            this.checkSample.TabIndex = 20;
            this.checkSample.Text = "Sample";
            this.checkSample.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(713, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save As Zip";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(12, 354);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(95, 354);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 23;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DOMJudge Problem Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label infoWorkingDirectory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label infoTestCases;
        private System.Windows.Forms.Label workingDirectory;
        private System.Windows.Forms.Label testCases;
        private System.Windows.Forms.ToolStripMenuItem newProblemToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox nickName;
        private System.Windows.Forms.Label infoNickName;
        private System.Windows.Forms.TextBox timeLimit;
        private System.Windows.Forms.TextBox memLimit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label infoTimeLimit;
        private System.Windows.Forms.Label infoMemLimit;
        private System.Windows.Forms.Label infoName;
        private System.Windows.Forms.Label infoHexColour;
        private System.Windows.Forms.Button btnChooseColour;
        private System.Windows.Forms.Label hexColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChooseProblemStatement;
        private System.Windows.Forms.Label problemStatement;
        private System.Windows.Forms.Label infoProblemStatement;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkSample;
        private System.Windows.Forms.Button btnUpdateTestCase;
        private System.Windows.Forms.Button btnNewTestCase;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}
