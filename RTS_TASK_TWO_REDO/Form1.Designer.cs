namespace RTS_TASK_TWO_REDO
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
            this.mapLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.unitInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.resourceTextBox = new System.Windows.Forms.RichTextBox();
            this.startPauseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(12, 47);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(70, 17);
            this.mapLabel.TabIndex = 0;
            this.mapLabel.Text = "mapLabel";
            this.mapLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(12, 9);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(68, 20);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Round:";
            // 
            // unitInfoTextBox
            // 
            this.unitInfoTextBox.Location = new System.Drawing.Point(777, 12);
            this.unitInfoTextBox.Name = "unitInfoTextBox";
            this.unitInfoTextBox.Size = new System.Drawing.Size(241, 421);
            this.unitInfoTextBox.TabIndex = 1;
            this.unitInfoTextBox.Text = "";
            // 
            // resourceTextBox
            // 
            this.resourceTextBox.Location = new System.Drawing.Point(533, 12);
            this.resourceTextBox.Name = "resourceTextBox";
            this.resourceTextBox.Size = new System.Drawing.Size(238, 421);
            this.resourceTextBox.TabIndex = 1;
            this.resourceTextBox.Text = "";
            // 
            // startPauseButton
            // 
            this.startPauseButton.Location = new System.Drawing.Point(532, 453);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(107, 37);
            this.startPauseButton.TabIndex = 2;
            this.startPauseButton.Text = "Start / Pause";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.StartPauseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(802, 464);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 37);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(915, 464);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 37);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(645, 453);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(59, 20);
            this.unitLabel.TabIndex = 3;
            this.unitLabel.Text = "Units:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingLabel.Location = new System.Drawing.Point(645, 481);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(93, 20);
            this.buildingLabel.TabIndex = 3;
            this.buildingLabel.Text = "Buildings:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 510);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startPauseButton);
            this.Controls.Add(this.resourceTextBox);
            this.Controls.Add(this.unitInfoTextBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.mapLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.RichTextBox unitInfoTextBox;
        private System.Windows.Forms.RichTextBox resourceTextBox;
        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label buildingLabel;
    }
}

