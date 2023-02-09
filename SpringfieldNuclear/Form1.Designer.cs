namespace SpringfieldNuclear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorLabel1 = new System.Windows.Forms.Label();
            this.reactorLabel2 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 28F);
            this.titleLabel.Location = new System.Drawing.Point(176, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(579, 68);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            // 
            // reactorLabel1
            // 
            this.reactorLabel1.AutoSize = true;
            this.reactorLabel1.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel1.Location = new System.Drawing.Point(132, 183);
            this.reactorLabel1.Name = "reactorLabel1";
            this.reactorLabel1.Size = new System.Drawing.Size(189, 54);
            this.reactorLabel1.TabIndex = 1;
            this.reactorLabel1.Text = "Reactor 1";
            this.reactorLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactorLabel2
            // 
            this.reactorLabel2.AutoSize = true;
            this.reactorLabel2.Font = new System.Drawing.Font("Impact", 22F);
            this.reactorLabel2.Location = new System.Drawing.Point(623, 183);
            this.reactorLabel2.Name = "reactorLabel2";
            this.reactorLabel2.Size = new System.Drawing.Size(194, 54);
            this.reactorLabel2.TabIndex = 2;
            this.reactorLabel2.Text = "Reactor 2";
            this.reactorLabel2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(137, 247);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(184, 179);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(628, 247);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(185, 179);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputLabel.Location = new System.Drawing.Point(181, 578);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(574, 54);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(350, 460);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(244, 75);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(958, 684);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactorLabel2);
            this.Controls.Add(this.reactorLabel1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Springfield Nuclear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactorLabel1;
        private System.Windows.Forms.Label reactorLabel2;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

