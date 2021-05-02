
namespace Random_String_Generator
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
            this.components = new System.ComponentModel.Container();
            this.Output_ = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearOutput = new System.Windows.Forms.CheckBox();
            this.UseRegex2 = new System.Windows.Forms.CheckBox();
            this.UseRegex1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.StringWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SurroundingCharString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sepetator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfString = new System.Windows.Forms.NumericUpDown();
            this.LengthOfString = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.UseCharacter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UseCharacterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SeperatorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SCFES = new System.Windows.Forms.ToolTip(this.components);
            this.SESTBWTWO = new System.Windows.Forms.ToolTip(this.components);
            this.UseRegex = new System.Windows.Forms.ToolTip(this.components);
            this.Output.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StringWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfString)).BeginInit();
            this.SuspendLayout();
            // 
            // Output_
            // 
            this.Output_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_.Location = new System.Drawing.Point(6, 19);
            this.Output_.MaxLength = 2147483647;
            this.Output_.Multiline = true;
            this.Output_.Name = "Output_";
            this.Output_.ReadOnly = true;
            this.Output_.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_.Size = new System.Drawing.Size(587, 229);
            this.Output_.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Controls.Add(this.Output_);
            this.Output.Location = new System.Drawing.Point(13, 13);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(599, 254);
            this.Output.TabIndex = 1;
            this.Output.TabStop = false;
            this.Output.Text = "Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ClearOutput);
            this.groupBox2.Controls.Add(this.UseRegex2);
            this.groupBox2.Controls.Add(this.UseRegex1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.SaveToFileButton);
            this.groupBox2.Controls.Add(this.GenerateButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.StringWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SurroundingCharString);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Sepetator);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumberOfString);
            this.groupBox2.Controls.Add(this.LengthOfString);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UseCharacter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Box";
            // 
            // ClearOutput
            // 
            this.ClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearOutput.AutoSize = true;
            this.ClearOutput.Checked = true;
            this.ClearOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClearOutput.Location = new System.Drawing.Point(402, 41);
            this.ClearOutput.Name = "ClearOutput";
            this.ClearOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClearOutput.Size = new System.Drawing.Size(179, 17);
            this.ClearOutput.TabIndex = 23;
            this.ClearOutput.Text = "Clear output after each generate";
            this.ClearOutput.UseVisualStyleBackColor = true;
            // 
            // UseRegex2
            // 
            this.UseRegex2.AutoSize = true;
            this.UseRegex2.Location = new System.Drawing.Point(286, 99);
            this.UseRegex2.Name = "UseRegex2";
            this.UseRegex2.Size = new System.Drawing.Size(79, 17);
            this.UseRegex2.TabIndex = 22;
            this.UseRegex2.Text = "Use Regex";
            this.UseRegex.SetToolTip(this.UseRegex2, "Enable this allow you to use regex like: \\r\\n for new line, \\t for a tab characte" +
        "r,... This is especially useful if you want to split the random string to block." +
        "");
            this.UseRegex2.UseVisualStyleBackColor = true;
            // 
            // UseRegex1
            // 
            this.UseRegex1.AutoSize = true;
            this.UseRegex1.Location = new System.Drawing.Point(151, 72);
            this.UseRegex1.Name = "UseRegex1";
            this.UseRegex1.Size = new System.Drawing.Size(79, 17);
            this.UseRegex1.TabIndex = 21;
            this.UseRegex1.Text = "Use Regex";
            this.UseRegex.SetToolTip(this.UseRegex1, "Enable this allow you to use regex like: \\r\\n for new line, \\t for a tab characte" +
        "r,... This is especially useful if you want to split the random string to block." +
        "");
            this.UseRegex1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(500, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Word Wrap";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToFileButton.Location = new System.Drawing.Point(467, 127);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(114, 23);
            this.SaveToFileButton.TabIndex = 19;
            this.SaveToFileButton.Text = "Save output to file";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(386, 127);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 18;
            this.GenerateButton.Text = "Generate!";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "character";
            this.SESTBWTWO.SetToolTip(this.label7, "When generating the random string, break the string to another line when the stri" +
        "ng reached the width provided in the box.");
            // 
            // StringWidth
            // 
            this.StringWidth.Location = new System.Drawing.Point(219, 125);
            this.StringWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.StringWidth.Name = "StringWidth";
            this.StringWidth.Size = new System.Drawing.Size(56, 20);
            this.StringWidth.TabIndex = 16;
            this.SESTBWTWO.SetToolTip(this.StringWidth, "When generating the random string, break the string to another line when the stri" +
        "ng reached the width provided in the box.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Split each string to block with the width of:";
            this.SESTBWTWO.SetToolTip(this.label4, "When generating the random string, break the string to another line when the stri" +
        "ng reached the width provided in the box.");
            // 
            // SurroundingCharString
            // 
            this.SurroundingCharString.Location = new System.Drawing.Point(207, 97);
            this.SurroundingCharString.Name = "SurroundingCharString";
            this.SurroundingCharString.Size = new System.Drawing.Size(73, 20);
            this.SurroundingCharString.TabIndex = 14;
            this.SurroundingCharString.Text = "\"";
            this.SCFES.SetToolTip(this.SurroundingCharString, "When generating a random string, surround that string with the provided string in" +
        " the box");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Surrounding char/string for each string: ";
            this.SCFES.SetToolTip(this.label6, "When generating a random string, surround that string with the provided string in" +
        " the box");
            // 
            // Sepetator
            // 
            this.Sepetator.Location = new System.Drawing.Point(72, 70);
            this.Sepetator.Name = "Sepetator";
            this.Sepetator.Size = new System.Drawing.Size(73, 20);
            this.Sepetator.TabIndex = 12;
            this.Sepetator.Text = ", ";
            this.SeperatorToolTip.SetToolTip(this.Sepetator, "For each new random string, seperate them with the previous random string with th" +
        "e provided string in the box");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seperator: ";
            this.SeperatorToolTip.SetToolTip(this.label5, "For each new random string, seperate them with the previous random string with th" +
        "e provided string in the box");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of string: ";
            // 
            // NumberOfString
            // 
            this.NumberOfString.Location = new System.Drawing.Point(275, 44);
            this.NumberOfString.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumberOfString.Name = "NumberOfString";
            this.NumberOfString.Size = new System.Drawing.Size(56, 20);
            this.NumberOfString.TabIndex = 5;
            this.NumberOfString.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // LengthOfString
            // 
            this.LengthOfString.Location = new System.Drawing.Point(99, 44);
            this.LengthOfString.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.LengthOfString.Name = "LengthOfString";
            this.LengthOfString.Size = new System.Drawing.Size(56, 20);
            this.LengthOfString.TabIndex = 4;
            this.LengthOfString.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Length of string: ";
            // 
            // UseCharacter
            // 
            this.UseCharacter.Location = new System.Drawing.Point(92, 16);
            this.UseCharacter.Name = "UseCharacter";
            this.UseCharacter.Size = new System.Drawing.Size(239, 20);
            this.UseCharacter.TabIndex = 1;
            this.UseCharacter.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            this.UseCharacterToolTip.SetToolTip(this.UseCharacter, "When generating the random string, use the character provided in the box");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use character: ";
            this.UseCharacterToolTip.SetToolTip(this.label1, "When generating the random string, use the character provided in the box");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Output);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Random String Generator";
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StringWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfString)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Output_;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberOfString;
        private System.Windows.Forms.NumericUpDown LengthOfString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UseCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sepetator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown StringWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SurroundingCharString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip UseCharacterToolTip;
        private System.Windows.Forms.ToolTip SeperatorToolTip;
        private System.Windows.Forms.ToolTip SESTBWTWO;
        private System.Windows.Forms.ToolTip SCFES;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox UseRegex2;
        private System.Windows.Forms.CheckBox UseRegex1;
        private System.Windows.Forms.ToolTip UseRegex;
        private System.Windows.Forms.CheckBox ClearOutput;
    }
}

