﻿namespace BrickBreaker
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modeSelector = new System.Windows.Forms.ComboBox();
            this.levelDesignerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Yellow;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Black;
            this.playButton.Location = new System.Drawing.Point(751, 539);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(242, 96);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.playButton_MouseHover);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Yellow;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(24, 541);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(242, 96);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(350, 21);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(528, 69);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "BRICK BREAKER\r\n";
            // 
            // modeSelector
            // 
            this.modeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeSelector.ForeColor = System.Drawing.Color.White;
            this.modeSelector.FormattingEnabled = true;
            this.modeSelector.Location = new System.Drawing.Point(750, 465);
            this.modeSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeSelector.Name = "modeSelector";
            this.modeSelector.Size = new System.Drawing.Size(242, 47);
            this.modeSelector.TabIndex = 3;
            this.modeSelector.Text = "Mode";
            // 
            // levelDesignerButton
            // 
            this.levelDesignerButton.BackColor = System.Drawing.Color.White;
            this.levelDesignerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.levelDesignerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.levelDesignerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.levelDesignerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelDesignerButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelDesignerButton.Location = new System.Drawing.Point(631, 348);
            this.levelDesignerButton.Margin = new System.Windows.Forms.Padding(5);
            this.levelDesignerButton.Name = "levelDesignerButton";
            this.levelDesignerButton.Size = new System.Drawing.Size(409, 115);
            this.levelDesignerButton.TabIndex = 2;
            this.levelDesignerButton.Text = "Level Designer";
            this.levelDesignerButton.UseVisualStyleBackColor = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.modeSelector);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1065, 675);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox modeSelector;
        private System.Windows.Forms.Button levelDesignerButton;
    }
}
