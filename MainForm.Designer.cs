namespace RandomizeCodeEvergyMonster
{
    partial class MainForm
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
            this.Numbers = new System.Windows.Forms.TextBox();
            this.NumbersLabel = new System.Windows.Forms.Label();
            this.NumbersPanel = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.GenerateUniq = new System.Windows.Forms.CheckBox();
            this.SaveToFile = new System.Windows.Forms.CheckBox();
            this.Rus = new System.Windows.Forms.CheckBox();
            this.FilenamePanel = new System.Windows.Forms.Panel();
            this.Filename = new System.Windows.Forms.TextBox();
            this.RusCaps = new System.Windows.Forms.CheckBox();
            this.EngCaps = new System.Windows.Forms.CheckBox();
            this.Eng = new System.Windows.Forms.CheckBox();
            this.SymbolsPanel = new System.Windows.Forms.Panel();
            this.Symbols = new System.Windows.Forms.TextBox();
            this.SymbolsLabel = new System.Windows.Forms.Label();
            this.LengthCodesLabel = new System.Windows.Forms.Label();
            this.LengthCodesPanel = new System.Windows.Forms.Panel();
            this.LengthCodes = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.MaxNumsPanel = new System.Windows.Forms.Panel();
            this.MaxNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Count = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.показатьФайлСКодамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumbersPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            this.FilenamePanel.SuspendLayout();
            this.SymbolsPanel.SuspendLayout();
            this.LengthCodesPanel.SuspendLayout();
            this.MaxNumsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numbers
            // 
            this.Numbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numbers.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Numbers.Location = new System.Drawing.Point(3, 7);
            this.Numbers.MaxLength = 200;
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(280, 15);
            this.Numbers.TabIndex = 1;
            this.Numbers.Text = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
            // 
            // NumbersLabel
            // 
            this.NumbersLabel.AutoSize = true;
            this.NumbersLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumbersLabel.ForeColor = System.Drawing.Color.White;
            this.NumbersLabel.Location = new System.Drawing.Point(10, 42);
            this.NumbersLabel.Name = "NumbersLabel";
            this.NumbersLabel.Size = new System.Drawing.Size(249, 17);
            this.NumbersLabel.TabIndex = 0;
            this.NumbersLabel.Text = "Допустимые цифры(через запятую):";
            // 
            // NumbersPanel
            // 
            this.NumbersPanel.BackColor = System.Drawing.Color.White;
            this.NumbersPanel.Controls.Add(this.Numbers);
            this.NumbersPanel.Location = new System.Drawing.Point(12, 62);
            this.NumbersPanel.Name = "NumbersPanel";
            this.NumbersPanel.Size = new System.Drawing.Size(286, 28);
            this.NumbersPanel.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.GenerateUniq);
            this.Settings.Controls.Add(this.SaveToFile);
            this.Settings.Controls.Add(this.Rus);
            this.Settings.Controls.Add(this.FilenamePanel);
            this.Settings.Controls.Add(this.RusCaps);
            this.Settings.Controls.Add(this.EngCaps);
            this.Settings.Controls.Add(this.Eng);
            this.Settings.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(303, 45);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(288, 218);
            this.Settings.TabIndex = 99;
            this.Settings.TabStop = false;
            this.Settings.Text = "Настройки";
            // 
            // GenerateUniq
            // 
            this.GenerateUniq.AutoSize = true;
            this.GenerateUniq.Checked = true;
            this.GenerateUniq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GenerateUniq.Location = new System.Drawing.Point(6, 172);
            this.GenerateUniq.Name = "GenerateUniq";
            this.GenerateUniq.Size = new System.Drawing.Size(278, 38);
            this.GenerateUniq.TabIndex = 11;
            this.GenerateUniq.Text = "Генерировать уникальные коды на\r\nоснове файла с сохраннёными кодами\r\n";
            this.GenerateUniq.UseVisualStyleBackColor = true;
            // 
            // SaveToFile
            // 
            this.SaveToFile.AutoSize = true;
            this.SaveToFile.Checked = true;
            this.SaveToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveToFile.Location = new System.Drawing.Point(6, 76);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(182, 21);
            this.SaveToFile.TabIndex = 9;
            this.SaveToFile.Text = "Сохранять коды в файл";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.CheckedChanged += new System.EventHandler(this.SaveToFile_CheckedChanged);
            // 
            // Rus
            // 
            this.Rus.AutoSize = true;
            this.Rus.Location = new System.Drawing.Point(6, 49);
            this.Rus.Name = "Rus";
            this.Rus.Size = new System.Drawing.Size(139, 21);
            this.Rus.TabIndex = 7;
            this.Rus.Text = "Русский алфавит";
            this.Rus.UseVisualStyleBackColor = true;
            // 
            // FilenamePanel
            // 
            this.FilenamePanel.BackColor = System.Drawing.Color.White;
            this.FilenamePanel.Controls.Add(this.Filename);
            this.FilenamePanel.Location = new System.Drawing.Point(6, 138);
            this.FilenamePanel.Name = "FilenamePanel";
            this.FilenamePanel.Size = new System.Drawing.Size(279, 28);
            this.FilenamePanel.TabIndex = 0;
            // 
            // Filename
            // 
            this.Filename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filename.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filename.Location = new System.Drawing.Point(3, 7);
            this.Filename.MaxLength = 200;
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(273, 15);
            this.Filename.TabIndex = 9;
            this.Filename.Text = "codes.txt";
            // 
            // RusCaps
            // 
            this.RusCaps.AutoSize = true;
            this.RusCaps.Location = new System.Drawing.Point(174, 49);
            this.RusCaps.Name = "RusCaps";
            this.RusCaps.Size = new System.Drawing.Size(111, 21);
            this.RusCaps.TabIndex = 8;
            this.RusCaps.Text = "Только КАПС";
            this.RusCaps.UseVisualStyleBackColor = true;
            // 
            // EngCaps
            // 
            this.EngCaps.AutoSize = true;
            this.EngCaps.Checked = true;
            this.EngCaps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EngCaps.Location = new System.Drawing.Point(174, 24);
            this.EngCaps.Name = "EngCaps";
            this.EngCaps.Size = new System.Drawing.Size(111, 21);
            this.EngCaps.TabIndex = 6;
            this.EngCaps.Text = "Только КАПС";
            this.EngCaps.UseVisualStyleBackColor = true;
            // 
            // Eng
            // 
            this.Eng.AutoSize = true;
            this.Eng.Checked = true;
            this.Eng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Eng.Location = new System.Drawing.Point(6, 22);
            this.Eng.Name = "Eng";
            this.Eng.Size = new System.Drawing.Size(162, 21);
            this.Eng.TabIndex = 5;
            this.Eng.Text = "Английский алфавит";
            this.Eng.UseVisualStyleBackColor = true;
            // 
            // SymbolsPanel
            // 
            this.SymbolsPanel.BackColor = System.Drawing.Color.White;
            this.SymbolsPanel.Controls.Add(this.Symbols);
            this.SymbolsPanel.Location = new System.Drawing.Point(12, 114);
            this.SymbolsPanel.Name = "SymbolsPanel";
            this.SymbolsPanel.Size = new System.Drawing.Size(285, 28);
            this.SymbolsPanel.TabIndex = 0;
            // 
            // Symbols
            // 
            this.Symbols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Symbols.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Symbols.Location = new System.Drawing.Point(3, 7);
            this.Symbols.MaxLength = 200;
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(280, 15);
            this.Symbols.TabIndex = 2;
            // 
            // SymbolsLabel
            // 
            this.SymbolsLabel.AutoSize = true;
            this.SymbolsLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymbolsLabel.ForeColor = System.Drawing.Color.White;
            this.SymbolsLabel.Location = new System.Drawing.Point(12, 95);
            this.SymbolsLabel.Name = "SymbolsLabel";
            this.SymbolsLabel.Size = new System.Drawing.Size(283, 17);
            this.SymbolsLabel.TabIndex = 0;
            this.SymbolsLabel.Text = "Возможные спецсимволы(через запятую):";
            // 
            // LengthCodesLabel
            // 
            this.LengthCodesLabel.AutoSize = true;
            this.LengthCodesLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthCodesLabel.ForeColor = System.Drawing.Color.White;
            this.LengthCodesLabel.Location = new System.Drawing.Point(12, 155);
            this.LengthCodesLabel.Name = "LengthCodesLabel";
            this.LengthCodesLabel.Size = new System.Drawing.Size(88, 17);
            this.LengthCodesLabel.TabIndex = 0;
            this.LengthCodesLabel.Text = "Длина кода:";
            // 
            // LengthCodesPanel
            // 
            this.LengthCodesPanel.BackColor = System.Drawing.Color.White;
            this.LengthCodesPanel.Controls.Add(this.LengthCodes);
            this.LengthCodesPanel.Location = new System.Drawing.Point(12, 175);
            this.LengthCodesPanel.Name = "LengthCodesPanel";
            this.LengthCodesPanel.Size = new System.Drawing.Size(135, 28);
            this.LengthCodesPanel.TabIndex = 0;
            // 
            // LengthCodes
            // 
            this.LengthCodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LengthCodes.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthCodes.Location = new System.Drawing.Point(3, 7);
            this.LengthCodes.MaxLength = 200;
            this.LengthCodes.Name = "LengthCodes";
            this.LengthCodes.Size = new System.Drawing.Size(129, 15);
            this.LengthCodes.TabIndex = 4;
            this.LengthCodes.Text = "10";
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Generate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Generate.ForeColor = System.Drawing.Color.White;
            this.Generate.Location = new System.Drawing.Point(0, 281);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(603, 35);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Сгенирировать";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // MaxNumsPanel
            // 
            this.MaxNumsPanel.BackColor = System.Drawing.Color.White;
            this.MaxNumsPanel.Controls.Add(this.MaxNums);
            this.MaxNumsPanel.Location = new System.Drawing.Point(162, 175);
            this.MaxNumsPanel.Name = "MaxNumsPanel";
            this.MaxNumsPanel.Size = new System.Drawing.Size(135, 28);
            this.MaxNumsPanel.TabIndex = 0;
            // 
            // MaxNums
            // 
            this.MaxNums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxNums.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxNums.Location = new System.Drawing.Point(3, 7);
            this.MaxNums.MaxLength = 200;
            this.MaxNums.Name = "MaxNums";
            this.MaxNums.Size = new System.Drawing.Size(129, 15);
            this.MaxNums.TabIndex = 6;
            this.MaxNums.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс кол-во цифр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Count);
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 28);
            this.panel1.TabIndex = 0;
            // 
            // Count
            // 
            this.Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(3, 7);
            this.Count.MaxLength = 200;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(279, 15);
            this.Count.TabIndex = 4;
            this.Count.Text = "10";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьФайлСКодамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "Menu";
            // 
            // показатьФайлСКодамиToolStripMenuItem
            // 
            this.показатьФайлСКодамиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.показатьФайлСКодамиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.показатьФайлСКодамиToolStripMenuItem.Name = "показатьФайлСКодамиToolStripMenuItem";
            this.показатьФайлСКодамиToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.показатьФайлСКодамиToolStripMenuItem.Text = "Показать файл с кодами";
            this.показатьФайлСКодамиToolStripMenuItem.Click += new System.EventHandler(this.показатьФайлСКодамиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(603, 316);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.NumbersPanel);
            this.Controls.Add(this.SymbolsPanel);
            this.Controls.Add(this.MaxNumsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LengthCodesPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthCodesLabel);
            this.Controls.Add(this.SymbolsLabel);
            this.Controls.Add(this.NumbersLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Генератор кодов Energy Monster";
            this.NumbersPanel.ResumeLayout(false);
            this.NumbersPanel.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.FilenamePanel.ResumeLayout(false);
            this.FilenamePanel.PerformLayout();
            this.SymbolsPanel.ResumeLayout(false);
            this.SymbolsPanel.PerformLayout();
            this.LengthCodesPanel.ResumeLayout(false);
            this.LengthCodesPanel.PerformLayout();
            this.MaxNumsPanel.ResumeLayout(false);
            this.MaxNumsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Numbers;
        private Label NumbersLabel;
        private Panel NumbersPanel;
        private GroupBox Settings;
        private CheckBox Rus;
        private Panel SymbolsPanel;
        private TextBox Symbols;
        private Label SymbolsLabel;
        private CheckBox RusCaps;
        private CheckBox EngCaps;
        private CheckBox Eng;
        private CheckBox SaveToFile;
        private Panel LengthCodesPanel;
        private TextBox LengthCodes;
        private Label LengthCodesLabel;
        private Panel FilenamePanel;
        private TextBox Filename;
        private CheckBox GenerateUniq;
        private Button Generate;
        private Panel MaxNumsPanel;
        private TextBox MaxNums;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox Count;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem показатьФайлСКодамиToolStripMenuItem;
    }
}