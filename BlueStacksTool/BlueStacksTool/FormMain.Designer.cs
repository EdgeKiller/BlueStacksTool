namespace BlueStacksTool
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.checkBox_fullscreen = new System.Windows.Forms.CheckBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.comboBox_width = new System.Windows.Forms.ComboBox();
            this.comboBox_height = new System.Windows.Forms.ComboBox();
            this.label_labelstatus = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_creator = new System.Windows.Forms.Label();
            this.timer_bluestacks = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkBox_fullscreen
            // 
            this.checkBox_fullscreen.AutoSize = true;
            this.checkBox_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_fullscreen.Location = new System.Drawing.Point(124, 151);
            this.checkBox_fullscreen.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_fullscreen.Name = "checkBox_fullscreen";
            this.checkBox_fullscreen.Size = new System.Drawing.Size(93, 22);
            this.checkBox_fullscreen.TabIndex = 0;
            this.checkBox_fullscreen.Text = "Fullscreen";
            this.checkBox_fullscreen.UseVisualStyleBackColor = false;
            this.checkBox_fullscreen.CheckedChanged += new System.EventHandler(this.checkBox_fullscreen_CheckedChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Ubuntu", 14F);
            this.label_name.Location = new System.Drawing.Point(97, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(141, 24);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "BlueStacksTool";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.BackColor = System.Drawing.Color.Transparent;
            this.label_width.Location = new System.Drawing.Point(66, 91);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(52, 18);
            this.label_width.TabIndex = 2;
            this.label_width.Text = "Width :";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.BackColor = System.Drawing.Color.Transparent;
            this.label_height.Location = new System.Drawing.Point(61, 122);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(57, 18);
            this.label_height.TabIndex = 3;
            this.label_height.Text = "Height :";
            // 
            // comboBox_width
            // 
            this.comboBox_width.FormattingEnabled = true;
            this.comboBox_width.Items.AddRange(new object[] {
            "800",
            "1024",
            "1280",
            "1440",
            "1600",
            "1920"});
            this.comboBox_width.Location = new System.Drawing.Point(124, 88);
            this.comboBox_width.Name = "comboBox_width";
            this.comboBox_width.Size = new System.Drawing.Size(150, 25);
            this.comboBox_width.TabIndex = 4;
            this.comboBox_width.TextChanged += new System.EventHandler(this.comboBox_width_TextChanged);
            this.comboBox_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_width_KeyPress);
            // 
            // comboBox_height
            // 
            this.comboBox_height.FormattingEnabled = true;
            this.comboBox_height.Items.AddRange(new object[] {
            "600",
            "666",
            "768",
            "720",
            "900",
            "960",
            "1080"});
            this.comboBox_height.Location = new System.Drawing.Point(124, 119);
            this.comboBox_height.Name = "comboBox_height";
            this.comboBox_height.Size = new System.Drawing.Size(150, 25);
            this.comboBox_height.TabIndex = 5;
            this.comboBox_height.TextChanged += new System.EventHandler(this.comboBox_height_TextChanged);
            this.comboBox_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_height_KeyPress);
            // 
            // label_labelstatus
            // 
            this.label_labelstatus.AutoSize = true;
            this.label_labelstatus.Location = new System.Drawing.Point(12, 234);
            this.label_labelstatus.Name = "label_labelstatus";
            this.label_labelstatus.Size = new System.Drawing.Size(54, 18);
            this.label_labelstatus.TabIndex = 6;
            this.label_labelstatus.Text = "Status :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(63, 234);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(30, 18);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "Off";
            // 
            // button_close
            // 
            this.button_close.Enabled = false;
            this.button_close.Location = new System.Drawing.Point(99, 229);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 26);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_creator
            // 
            this.label_creator.AutoSize = true;
            this.label_creator.Font = new System.Drawing.Font("Ubuntu", 7F);
            this.label_creator.Location = new System.Drawing.Point(266, 240);
            this.label_creator.Name = "label_creator";
            this.label_creator.Size = new System.Drawing.Size(56, 15);
            this.label_creator.TabIndex = 9;
            this.label_creator.Text = "EdgeKiller";
            // 
            // timer_bluestacks
            // 
            this.timer_bluestacks.Interval = 250;
            this.timer_bluestacks.Tick += new System.EventHandler(this.timer_bluestacks_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_creator);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_labelstatus);
            this.Controls.Add(this.comboBox_height);
            this.Controls.Add(this.comboBox_width);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.checkBox_fullscreen);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "BlueStacksTool • Alpha 0.1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_fullscreen;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.ComboBox comboBox_width;
        private System.Windows.Forms.ComboBox comboBox_height;
        private System.Windows.Forms.Label label_labelstatus;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_creator;
        private System.Windows.Forms.Timer timer_bluestacks;
    }
}

