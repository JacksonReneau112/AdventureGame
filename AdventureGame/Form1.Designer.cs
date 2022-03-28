namespace AdventureGame
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
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.storyOutputLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.option3button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(97, 319);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(346, 48);
            this.option1Label.TabIndex = 2;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(97, 373);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(346, 48);
            this.option2Label.TabIndex = 3;
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(544, 319);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(244, 102);
            this.option3Label.TabIndex = 5;
            this.option3Label.Visible = false;
            // 
            // storyOutputLabel
            // 
            this.storyOutputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyOutputLabel.ForeColor = System.Drawing.Color.White;
            this.storyOutputLabel.Location = new System.Drawing.Point(468, 12);
            this.storyOutputLabel.Name = "storyOutputLabel";
            this.storyOutputLabel.Size = new System.Drawing.Size(320, 301);
            this.storyOutputLabel.TabIndex = 7;
            this.storyOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(450, 301);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // option3button
            // 
            this.option3button.BackgroundImage = global::AdventureGame.Properties.Resources.arrowRight;
            this.option3button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3button.Location = new System.Drawing.Point(459, 319);
            this.option3button.Name = "option3button";
            this.option3button.Size = new System.Drawing.Size(79, 48);
            this.option3button.TabIndex = 4;
            this.option3button.UseVisualStyleBackColor = true;
            this.option3button.Visible = false;
            this.option3button.Click += new System.EventHandler(this.option3button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImage = global::AdventureGame.Properties.Resources.arrowRight;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.ForeColor = System.Drawing.Color.Black;
            this.option2Button.Location = new System.Drawing.Point(12, 373);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(79, 48);
            this.option2Button.TabIndex = 1;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImage = global::AdventureGame.Properties.Resources.arrowRight;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(12, 319);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(79, 48);
            this.option1Button.TabIndex = 0;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.choice1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.storyOutputLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Name = "Form1";
            this.Text = "Your Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option3button;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label storyOutputLabel;
    }
}

