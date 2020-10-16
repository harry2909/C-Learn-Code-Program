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
            this.programmeArea = new System.Windows.Forms.RichTextBox();
            this.commandLine = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.commandLineLabel = new System.Windows.Forms.Label();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // programmeArea
            // 
            this.programmeArea.Location = new System.Drawing.Point(27, 68);
            this.programmeArea.Name = "programmeArea";
            this.programmeArea.Size = new System.Drawing.Size(436, 350);
            this.programmeArea.TabIndex = 2;
            this.programmeArea.Text = "";
            // 
            // commandLine
            // 
            this.commandLine.BackColor = System.Drawing.SystemColors.WindowText;
            this.commandLine.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.commandLine.Location = new System.Drawing.Point(27, 476);
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
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(483, 69);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(434, 348);
            this.drawPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(947, 652);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.commandLineLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.commandLine);
            this.Controls.Add(this.programmeArea);
            this.Name = "Form1";
            this.Text = "Programming Learning Environment";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel drawPanel;

        private System.Windows.Forms.RichTextBox commandLine;
        private System.Windows.Forms.Label commandLineLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RichTextBox programmeArea;

        #endregion
    }
}