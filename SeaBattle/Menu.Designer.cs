
namespace SeaBattle
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Exit = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::SeaBattle.Properties.Resources.exit_menu;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(303, 278);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(184, 45);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Play
            // 
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Location = new System.Drawing.Point(314, 152);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(162, 44);
            this.Play.TabIndex = 1;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // help
            // 
            this.help.BackgroundImage = global::SeaBattle.Pictures.help1;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Location = new System.Drawing.Point(314, 214);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(162, 43);
            this.help.TabIndex = 2;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeaBattle.Pictures.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.help);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button help;
    }
}