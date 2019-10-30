namespace ZooSimulator
{
    partial class ZooSimulation
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
            this.feedButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.elephantTextBox = new System.Windows.Forms.TextBox();
            this.giraffeTextBox = new System.Windows.Forms.TextBox();
            this.monkeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feedButton
            // 
            this.feedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feedButton.Location = new System.Drawing.Point(624, 418);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(141, 49);
            this.feedButton.TabIndex = 0;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resetButton.Location = new System.Drawing.Point(415, 418);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(141, 49);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label16.Location = new System.Drawing.Point(30, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 31);
            this.label16.TabIndex = 17;
            this.label16.Text = "Elephants";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label17.Location = new System.Drawing.Point(432, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 31);
            this.label17.TabIndex = 18;
            this.label17.Text = "Giraffes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label18.Location = new System.Drawing.Point(797, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 31);
            this.label18.TabIndex = 19;
            this.label18.Text = "Monkeys";
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.timeElapsedLabel.Location = new System.Drawing.Point(30, 424);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(156, 31);
            this.timeElapsedLabel.TabIndex = 50;
            this.timeElapsedLabel.Text = "Time spent:";
            // 
            // elephantTextBox
            // 
            this.elephantTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elephantTextBox.Location = new System.Drawing.Point(36, 156);
            this.elephantTextBox.Multiline = true;
            this.elephantTextBox.Name = "elephantTextBox";
            this.elephantTextBox.Size = new System.Drawing.Size(385, 200);
            this.elephantTextBox.TabIndex = 52;
            // 
            // giraffeTextBox
            // 
            this.giraffeTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.giraffeTextBox.Location = new System.Drawing.Point(438, 156);
            this.giraffeTextBox.Multiline = true;
            this.giraffeTextBox.Name = "giraffeTextBox";
            this.giraffeTextBox.Size = new System.Drawing.Size(350, 200);
            this.giraffeTextBox.TabIndex = 53;
            // 
            // monkeyTextBox
            // 
            this.monkeyTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monkeyTextBox.Location = new System.Drawing.Point(803, 156);
            this.monkeyTextBox.Multiline = true;
            this.monkeyTextBox.Name = "monkeyTextBox";
            this.monkeyTextBox.Size = new System.Drawing.Size(350, 200);
            this.monkeyTextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(362, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 62);
            this.label1.TabIndex = 55;
            this.label1.Text = "Zoo Simulator";
            // 
            // ZooSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monkeyTextBox);
            this.Controls.Add(this.giraffeTextBox);
            this.Controls.Add(this.elephantTextBox);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.feedButton);
            this.Name = "ZooSimulation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.TextBox elephantTextBox;
        private System.Windows.Forms.TextBox giraffeTextBox;
        private System.Windows.Forms.TextBox monkeyTextBox;
        private System.Windows.Forms.Label label1;
    }
}

