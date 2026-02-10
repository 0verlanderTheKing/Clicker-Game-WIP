namespace The_Clicker_Game
{
    partial class Simple_Clicker_Game
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
            this.click_Display = new System.Windows.Forms.TextBox();
            this.Click_Reset_Button = new System.Windows.Forms.Button();
            this.clicker_Button = new System.Windows.Forms.Button();
            this.upgrades_Panel = new System.Windows.Forms.Panel();
            this.upgrade_Two_Button = new System.Windows.Forms.Button();
            this.upgrade_One_Button = new System.Windows.Forms.Button();
            this.high_Score = new System.Windows.Forms.TextBox();
            this.High_Score_Label = new System.Windows.Forms.Label();
            this.upgrades_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // click_Display
            // 
            this.click_Display.Location = new System.Drawing.Point(252, 35);
            this.click_Display.Name = "click_Display";
            this.click_Display.ReadOnly = true;
            this.click_Display.Size = new System.Drawing.Size(147, 22);
            this.click_Display.TabIndex = 1;
            this.click_Display.TextChanged += new System.EventHandler(this.click_Display_TextChanged);
            // 
            // Click_Reset_Button
            // 
            this.Click_Reset_Button.Location = new System.Drawing.Point(267, 128);
            this.Click_Reset_Button.Name = "Click_Reset_Button";
            this.Click_Reset_Button.Size = new System.Drawing.Size(101, 29);
            this.Click_Reset_Button.TabIndex = 2;
            this.Click_Reset_Button.Text = "Reset";
            this.Click_Reset_Button.UseVisualStyleBackColor = true;
            this.Click_Reset_Button.Click += new System.EventHandler(this.Click_Reset_Button_Click);
            // 
            // clicker_Button
            // 
            this.clicker_Button.Location = new System.Drawing.Point(267, 81);
            this.clicker_Button.Name = "clicker_Button";
            this.clicker_Button.Size = new System.Drawing.Size(101, 29);
            this.clicker_Button.TabIndex = 3;
            this.clicker_Button.Text = "Click";
            this.clicker_Button.UseVisualStyleBackColor = true;
            this.clicker_Button.Click += new System.EventHandler(this.clicker_Button_Click);
            // 
            // upgrades_Panel
            // 
            this.upgrades_Panel.AutoScroll = true;
            this.upgrades_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upgrades_Panel.Controls.Add(this.upgrade_Two_Button);
            this.upgrades_Panel.Controls.Add(this.upgrade_One_Button);
            this.upgrades_Panel.Location = new System.Drawing.Point(451, 61);
            this.upgrades_Panel.Name = "upgrades_Panel";
            this.upgrades_Panel.Size = new System.Drawing.Size(219, 150);
            this.upgrades_Panel.TabIndex = 4;
            this.upgrades_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.upgrades_Panel_Paint);
            // 
            // upgrade_Two_Button
            // 
            this.upgrade_Two_Button.Location = new System.Drawing.Point(4, 39);
            this.upgrade_Two_Button.Name = "upgrade_Two_Button";
            this.upgrade_Two_Button.Size = new System.Drawing.Size(210, 23);
            this.upgrade_Two_Button.TabIndex = 1;
            this.upgrade_Two_Button.Text = "Add 500 click(s)";
            this.upgrade_Two_Button.UseVisualStyleBackColor = true;
            this.upgrade_Two_Button.Click += new System.EventHandler(this.upgrade_Two_Button_Click);
            // 
            // upgrade_One_Button
            // 
            this.upgrade_One_Button.Location = new System.Drawing.Point(4, 4);
            this.upgrade_One_Button.Name = "upgrade_One_Button";
            this.upgrade_One_Button.Size = new System.Drawing.Size(210, 28);
            this.upgrade_One_Button.TabIndex = 0;
            this.upgrade_One_Button.Text = "Click Multiplier";
            this.upgrade_One_Button.UseVisualStyleBackColor = true;
            this.upgrade_One_Button.Click += new System.EventHandler(this.upgrade_One_Button_Click);
            // 
            // high_Score
            // 
            this.high_Score.Location = new System.Drawing.Point(72, 61);
            this.high_Score.Name = "high_Score";
            this.high_Score.ReadOnly = true;
            this.high_Score.Size = new System.Drawing.Size(100, 22);
            this.high_Score.TabIndex = 5;
            this.high_Score.TextChanged += new System.EventHandler(this.high_Score_TextChanged);
            // 
            // High_Score_Label
            // 
            this.High_Score_Label.AutoSize = true;
            this.High_Score_Label.Location = new System.Drawing.Point(69, 22);
            this.High_Score_Label.Name = "High_Score_Label";
            this.High_Score_Label.Size = new System.Drawing.Size(74, 16);
            this.High_Score_Label.TabIndex = 6;
            this.High_Score_Label.Text = "High Score";
            // 
            // Simple_Clicker_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 253);
            this.Controls.Add(this.High_Score_Label);
            this.Controls.Add(this.high_Score);
            this.Controls.Add(this.upgrades_Panel);
            this.Controls.Add(this.clicker_Button);
            this.Controls.Add(this.Click_Reset_Button);
            this.Controls.Add(this.click_Display);
            this.Name = "Simple_Clicker_Game";
            this.Text = "Simple Clicker Game";
            this.Load += new System.EventHandler(this.Simple_Clicker_Game_Load);
            this.upgrades_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox click_Display;
        private System.Windows.Forms.Button Click_Reset_Button;
        private System.Windows.Forms.Button clicker_Button;
        private System.Windows.Forms.Panel upgrades_Panel;
        private System.Windows.Forms.Button upgrade_One_Button;
        private System.Windows.Forms.TextBox high_Score;
        private System.Windows.Forms.Label High_Score_Label;
        private System.Windows.Forms.Button upgrade_Two_Button;
    }
}

