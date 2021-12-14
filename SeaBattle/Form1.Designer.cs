
namespace SeaBattle
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.grid_user = new System.Windows.Forms.DataGridView();
            this.grid_comp = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_comp)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_user
            // 
            this.grid_user.AllowUserToAddRows = false;
            this.grid_user.AllowUserToDeleteRows = false;
            this.grid_user.AllowUserToResizeColumns = false;
            this.grid_user.AllowUserToResizeRows = false;
            this.grid_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_user.Location = new System.Drawing.Point(44, 50);
            this.grid_user.Name = "grid_user";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_user.RowHeadersWidth = 50;
            this.grid_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_user.ShowCellErrors = false;
            this.grid_user.ShowCellToolTips = false;
            this.grid_user.ShowEditingIcon = false;
            this.grid_user.ShowRowErrors = false;
            this.grid_user.Size = new System.Drawing.Size(275, 275);
            this.grid_user.TabIndex = 0;
            this.grid_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_user_KeyDown);
            this.grid_user.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grid_user_MouseUp);
            // 
            // grid_comp
            // 
            this.grid_comp.AllowUserToAddRows = false;
            this.grid_comp.AllowUserToDeleteRows = false;
            this.grid_comp.AllowUserToResizeColumns = false;
            this.grid_comp.AllowUserToResizeRows = false;
            this.grid_comp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_comp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid_comp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_comp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_comp.Location = new System.Drawing.Point(528, 50);
            this.grid_comp.Name = "grid_comp";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_comp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_comp.RowHeadersWidth = 50;
            this.grid_comp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_comp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_comp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_comp.ShowCellErrors = false;
            this.grid_comp.ShowCellToolTips = false;
            this.grid_comp.ShowEditingIcon = false;
            this.grid_comp.ShowRowErrors = false;
            this.grid_comp.Size = new System.Drawing.Size(275, 275);
            this.grid_comp.TabIndex = 1;
            this.grid_comp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_comp_CellClick);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::SeaBattle.Pictures.clear1;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.Location = new System.Drawing.Point(221, 352);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 39);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::SeaBattle.Pictures.swim1;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart.Location = new System.Drawing.Point(345, 122);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 39);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackgroundImage = global::SeaBattle.Pictures.restart1;
            this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRestart.Location = new System.Drawing.Point(345, 185);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(163, 37);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackgroundImage = global::SeaBattle.Pictures.random1;
            this.buttonRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRandom.Location = new System.Drawing.Point(44, 346);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(165, 50);
            this.buttonRandom.TabIndex = 7;
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(724, 460);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 39);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Покинуть палубу";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(604, 460);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(98, 39);
            this.back.TabIndex = 9;
            this.back.Text = "Назад в меню";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeaBattle.Pictures.sea1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 511);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.grid_comp);
            this.Controls.Add(this.grid_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской Бой";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_comp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_user;
        private System.Windows.Forms.DataGridView grid_comp;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button back;
    }
}

