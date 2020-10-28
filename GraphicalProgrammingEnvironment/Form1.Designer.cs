namespace GraphicalProgrammingEnvironment
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.programArea = new System.Windows.Forms.RichTextBox();
            this.commandLine = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.commandLineLabel = new System.Windows.Forms.Label();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.runButton = new System.Windows.Forms.Button();
            this.penBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.fillCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // programArea
            // 
            this.programArea.BackColor = System.Drawing.SystemColors.WindowText;
            this.programArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.programArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.programArea.Location = new System.Drawing.Point(27, 68);
            this.programArea.Name = "programArea";
            this.programArea.Size = new System.Drawing.Size(436, 350);
            this.programArea.TabIndex = 2;
            this.programArea.Text = "";
            // 
            // commandLine
            // 
            this.commandLine.BackColor = System.Drawing.SystemColors.WindowText;
            this.commandLine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.commandLine.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.commandLine.Location = new System.Drawing.Point(27, 476);
            this.commandLine.Multiline = false;
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(891, 138);
            this.commandLine.TabIndex = 3;
            this.commandLine.Text = "";
            this.commandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
            // 
            // inputLabel
            // 
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputLabel.Location = new System.Drawing.Point(192, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(100, 46);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(667, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 46);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commandLineLabel
            // 
            this.commandLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.commandLineLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commandLineLabel.Location = new System.Drawing.Point(345, 427);
            this.commandLineLabel.Name = "commandLineLabel";
            this.commandLineLabel.Size = new System.Drawing.Size(252, 46);
            this.commandLineLabel.TabIndex = 6;
            this.commandLineLabel.Text = "Command Line";
            this.commandLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.AliceBlue;
            this.drawBox.Location = new System.Drawing.Point(482, 68);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(436, 350);
            this.drawBox.TabIndex = 7;
            this.drawBox.TabStop = false;
            this.drawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawBox_Paint);
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.runButton.Location = new System.Drawing.Point(27, 427);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 32);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // penBox
            // 
            this.penBox.FormattingEnabled = true;
            this.penBox.Location = new System.Drawing.Point(111, 438);
            this.penBox.Name = "penBox";
            this.penBox.Size = new System.Drawing.Size(102, 21);
            this.penBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pen Colour\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(27, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.loadButton.Location = new System.Drawing.Point(111, 22);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 32);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // fillCheckBox
            // 
            this.fillCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fillCheckBox.Location = new System.Drawing.Point(241, 440);
            this.fillCheckBox.Name = "fillCheckBox";
            this.fillCheckBox.Size = new System.Drawing.Size(34, 21);
            this.fillCheckBox.TabIndex = 14;
            this.fillCheckBox.UseVisualStyleBackColor = true;
            this.fillCheckBox.Click += new System.EventHandler(this.fillCheckBox_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fill Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(947, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fillCheckBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.penBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.commandLineLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.commandLine);
            this.Controls.Add(this.programArea);
            this.Name = "Form1";
            this.Text = "Programming Learning Environment";
            ((System.ComponentModel.ISupportInitialize) (this.drawBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox fillCheckBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.RichTextBox programArea;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox penBox;

        private System.Windows.Forms.Button runButton;

        private System.Windows.Forms.PictureBox drawBox;

        private System.Windows.Forms.RichTextBox commandLine;
        private System.Windows.Forms.Label commandLineLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;

        #endregion
    }
}