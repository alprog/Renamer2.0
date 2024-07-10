namespace Renamer2
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
            InputPathCombo = new ComboBox();
            SelectInputButton = new Button();
            ListView = new ListView();
            indexColumn = new ColumnHeader();
            beforeCol = new ColumnHeader();
            afterCol = new ColumnHeader();
            InputPatternTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            UseModTextBox = new TextBox();
            label3 = new Label();
            UseStartTextBox = new TextBox();
            PreviewPictureBox = new PictureBox();
            RenameCheckBox = new CheckBox();
            RenamePatternTextBox = new TextBox();
            label4 = new Label();
            RenameStartTextBox = new TextBox();
            label5 = new Label();
            PerformButton = new Button();
            label6 = new Label();
            TargetFolderTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).BeginInit();
            SuspendLayout();
            // 
            // InputPathCombo
            // 
            InputPathCombo.FormattingEnabled = true;
            InputPathCombo.Location = new Point(62, 40);
            InputPathCombo.Name = "InputPathCombo";
            InputPathCombo.Size = new Size(340, 23);
            InputPathCombo.TabIndex = 1;
            InputPathCombo.TextChanged += InputPathCombo_TextChanged;
            // 
            // SelectInputButton
            // 
            SelectInputButton.Location = new Point(408, 39);
            SelectInputButton.Name = "SelectInputButton";
            SelectInputButton.Size = new Size(34, 23);
            SelectInputButton.TabIndex = 2;
            SelectInputButton.Text = "...";
            SelectInputButton.UseVisualStyleBackColor = true;
            SelectInputButton.Click += SelectInputButton_Click;
            // 
            // ListView
            // 
            ListView.Columns.AddRange(new ColumnHeader[] { indexColumn, beforeCol, afterCol });
            ListView.FullRowSelect = true;
            ListView.ImeMode = ImeMode.On;
            ListView.Location = new Point(459, 40);
            ListView.MultiSelect = false;
            ListView.Name = "ListView";
            ListView.Size = new Size(436, 674);
            ListView.TabIndex = 3;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // indexColumn
            // 
            indexColumn.Text = "#";
            indexColumn.Width = 30;
            // 
            // beforeCol
            // 
            beforeCol.Text = "Сейчас";
            beforeCol.Width = 200;
            // 
            // afterCol
            // 
            afterCol.Text = "Станет";
            afterCol.Width = 200;
            // 
            // InputPatternTextBox
            // 
            InputPatternTextBox.Location = new Point(146, 72);
            InputPatternTextBox.Name = "InputPatternTextBox";
            InputPatternTextBox.Size = new Size(95, 23);
            InputPatternTextBox.TabIndex = 4;
            InputPatternTextBox.Text = "*.png";
            InputPatternTextBox.TextChanged += InputPatternText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 5;
            label1.Text = "Использовать файлы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "Папка:";
            // 
            // UseModTextBox
            // 
            UseModTextBox.Location = new Point(144, 137);
            UseModTextBox.Name = "UseModTextBox";
            UseModTextBox.Size = new Size(29, 23);
            UseModTextBox.TabIndex = 8;
            UseModTextBox.Text = "1";
            UseModTextBox.TextAlign = HorizontalAlignment.Center;
            UseModTextBox.TextChanged += LeftModText_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 140);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "начиная с";
            // 
            // UseStartTextBox
            // 
            UseStartTextBox.Location = new Point(243, 137);
            UseStartTextBox.Name = "UseStartTextBox";
            UseStartTextBox.Size = new Size(29, 23);
            UseStartTextBox.TabIndex = 10;
            UseStartTextBox.Text = "0";
            UseStartTextBox.TextAlign = HorizontalAlignment.Center;
            UseStartTextBox.TextChanged += UseStartText_TextChanged;
            // 
            // PreviewPictureBox
            // 
            PreviewPictureBox.BorderStyle = BorderStyle.Fixed3D;
            PreviewPictureBox.Location = new Point(95, 483);
            PreviewPictureBox.Name = "PreviewPictureBox";
            PreviewPictureBox.Size = new Size(264, 231);
            PreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PreviewPictureBox.TabIndex = 11;
            PreviewPictureBox.TabStop = false;
            // 
            // RenameCheckBox
            // 
            RenameCheckBox.AutoSize = true;
            RenameCheckBox.Checked = true;
            RenameCheckBox.CheckState = CheckState.Checked;
            RenameCheckBox.Location = new Point(13, 189);
            RenameCheckBox.Name = "RenameCheckBox";
            RenameCheckBox.Size = new Size(116, 19);
            RenameCheckBox.TabIndex = 12;
            RenameCheckBox.Text = "Переименовать:";
            RenameCheckBox.UseVisualStyleBackColor = true;
            RenameCheckBox.CheckedChanged += RenameCheckBox_CheckedChanged;
            // 
            // RenamePatternTextBox
            // 
            RenamePatternTextBox.Location = new Point(132, 187);
            RenamePatternTextBox.Name = "RenamePatternTextBox";
            RenamePatternTextBox.Size = new Size(211, 23);
            RenamePatternTextBox.TabIndex = 13;
            RenamePatternTextBox.Text = "name_##";
            RenamePatternTextBox.TextChanged += RenamePatternTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 140);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 14;
            label4.Text = "Использовать каждый";
            // 
            // RenameStartTextBox
            // 
            RenameStartTextBox.Location = new Point(413, 185);
            RenameStartTextBox.Name = "RenameStartTextBox";
            RenameStartTextBox.Size = new Size(29, 23);
            RenameStartTextBox.TabIndex = 16;
            RenameStartTextBox.Text = "0";
            RenameStartTextBox.TextAlign = HorizontalAlignment.Center;
            RenameStartTextBox.TextChanged += RenameStartTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 188);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 15;
            label5.Text = "начиная с";
            // 
            // PerformButton
            // 
            PerformButton.Enabled = false;
            PerformButton.Location = new Point(13, 318);
            PerformButton.Name = "PerformButton";
            PerformButton.Size = new Size(429, 36);
            PerformButton.TabIndex = 17;
            PerformButton.Text = "Делай!";
            PerformButton.UseVisualStyleBackColor = true;
            PerformButton.Click += PerformButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 292);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 18;
            label6.Text = "Экспортировать в:";
            // 
            // TargetFolderTextBox
            // 
            TargetFolderTextBox.Location = new Point(127, 289);
            TargetFolderTextBox.Name = "TargetFolderTextBox";
            TargetFolderTextBox.Size = new Size(315, 23);
            TargetFolderTextBox.TabIndex = 19;
            TargetFolderTextBox.TextChanged += TargetFolderTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 738);
            Controls.Add(TargetFolderTextBox);
            Controls.Add(label6);
            Controls.Add(PerformButton);
            Controls.Add(RenameStartTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RenamePatternTextBox);
            Controls.Add(RenameCheckBox);
            Controls.Add(PreviewPictureBox);
            Controls.Add(UseStartTextBox);
            Controls.Add(label3);
            Controls.Add(UseModTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputPatternTextBox);
            Controls.Add(ListView);
            Controls.Add(SelectInputButton);
            Controls.Add(InputPathCombo);
            Name = "MainForm";
            Text = "Renamer 2.0";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox InputPathCombo;
        private Button SelectInputButton;
        private ListView ListView;
        private ColumnHeader beforeCol;
        private ColumnHeader afterCol;
        private TextBox InputPatternTextBox;
        private Label label1;
        private Label label2;
        private TextBox UseModTextBox;
        private Label label3;
        private TextBox UseStartTextBox;
        private PictureBox PreviewPictureBox;
        private CheckBox RenameCheckBox;
        private TextBox RenamePatternTextBox;
        private ColumnHeader indexColumn;
        private Label label4;
        private TextBox RenameStartTextBox;
        private Label label5;
        private Button PerformButton;
        private Label label6;
        private TextBox TargetFolderTextBox;
    }
}
