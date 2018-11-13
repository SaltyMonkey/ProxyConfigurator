namespace Configurator
{
    partial class Form1
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
            this.CB_updatelog = new System.Windows.Forms.CheckBox();
            this.B_apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_na = new System.Windows.Forms.RadioButton();
            this.RB_eu = new System.Windows.Forms.RadioButton();
            this.RB_ru = new System.Windows.Forms.RadioButton();
            this.RB_kr = new System.Windows.Forms.RadioButton();
            this.RB_tw = new System.Windows.Forms.RadioButton();
            this.RB_se = new System.Windows.Forms.RadioButton();
            this.B_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_updatelog
            // 
            this.CB_updatelog.AutoSize = true;
            this.CB_updatelog.Location = new System.Drawing.Point(6, 19);
            this.CB_updatelog.Name = "CB_updatelog";
            this.CB_updatelog.Size = new System.Drawing.Size(106, 17);
            this.CB_updatelog.TabIndex = 0;
            this.CB_updatelog.Text = "Show update log";
            this.CB_updatelog.UseVisualStyleBackColor = true;
            // 
            // B_apply
            // 
            this.B_apply.Location = new System.Drawing.Point(160, 81);
            this.B_apply.Name = "B_apply";
            this.B_apply.Size = new System.Drawing.Size(142, 47);
            this.B_apply.TabIndex = 3;
            this.B_apply.Text = "Apply changes";
            this.B_apply.UseVisualStyleBackColor = true;
            this.B_apply.Click += new System.EventHandler(this.B_apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_se);
            this.groupBox1.Controls.Add(this.RB_tw);
            this.groupBox1.Controls.Add(this.RB_kr);
            this.groupBox1.Controls.Add(this.RB_ru);
            this.groupBox1.Controls.Add(this.RB_eu);
            this.groupBox1.Controls.Add(this.RB_na);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your publisher:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_updatelog);
            this.groupBox2.Location = new System.Drawing.Point(160, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other options:";
            // 
            // RB_na
            // 
            this.RB_na.AutoSize = true;
            this.RB_na.Location = new System.Drawing.Point(7, 20);
            this.RB_na.Name = "RB_na";
            this.RB_na.Size = new System.Drawing.Size(92, 17);
            this.RB_na.TabIndex = 0;
            this.RB_na.TabStop = true;
            this.RB_na.Text = "NA (Enmasse)";
            this.RB_na.UseVisualStyleBackColor = true;
            this.RB_na.CheckedChanged += new System.EventHandler(this.RB_na_CheckedChanged);
            // 
            // RB_eu
            // 
            this.RB_eu.AutoSize = true;
            this.RB_eu.Location = new System.Drawing.Point(7, 43);
            this.RB_eu.Name = "RB_eu";
            this.RB_eu.Size = new System.Drawing.Size(101, 17);
            this.RB_eu.TabIndex = 1;
            this.RB_eu.TabStop = true;
            this.RB_eu.Text = "EU (Gameforge)";
            this.RB_eu.UseVisualStyleBackColor = true;
            this.RB_eu.CheckedChanged += new System.EventHandler(this.RB_eu_CheckedChanged);
            // 
            // RB_ru
            // 
            this.RB_ru.AutoSize = true;
            this.RB_ru.Location = new System.Drawing.Point(7, 66);
            this.RB_ru.Name = "RB_ru";
            this.RB_ru.Size = new System.Drawing.Size(85, 17);
            this.RB_ru.TabIndex = 2;
            this.RB_ru.TabStop = true;
            this.RB_ru.Text = "RU (Destiny)";
            this.RB_ru.UseVisualStyleBackColor = true;
            this.RB_ru.CheckedChanged += new System.EventHandler(this.RB_ru_CheckedChanged);
            // 
            // RB_kr
            // 
            this.RB_kr.AutoSize = true;
            this.RB_kr.Location = new System.Drawing.Point(7, 89);
            this.RB_kr.Name = "RB_kr";
            this.RB_kr.Size = new System.Drawing.Size(80, 17);
            this.RB_kr.TabIndex = 3;
            this.RB_kr.TabStop = true;
            this.RB_kr.Text = "KR (Nexon)";
            this.RB_kr.UseVisualStyleBackColor = true;
            this.RB_kr.CheckedChanged += new System.EventHandler(this.RB_kr_CheckedChanged);
            // 
            // RB_tw
            // 
            this.RB_tw.AutoSize = true;
            this.RB_tw.Location = new System.Drawing.Point(7, 112);
            this.RB_tw.Name = "RB_tw";
            this.RB_tw.Size = new System.Drawing.Size(43, 17);
            this.RB_tw.TabIndex = 6;
            this.RB_tw.TabStop = true;
            this.RB_tw.Text = "TW";
            this.RB_tw.UseVisualStyleBackColor = true;
            this.RB_tw.CheckedChanged += new System.EventHandler(this.RB_tw_CheckedChanged);
            // 
            // RB_se
            // 
            this.RB_se.AutoSize = true;
            this.RB_se.Location = new System.Drawing.Point(7, 135);
            this.RB_se.Name = "RB_se";
            this.RB_se.Size = new System.Drawing.Size(39, 17);
            this.RB_se.TabIndex = 7;
            this.RB_se.TabStop = true;
            this.RB_se.Text = "SE";
            this.RB_se.UseVisualStyleBackColor = true;
            this.RB_se.CheckedChanged += new System.EventHandler(this.RB_se_CheckedChanged);
            // 
            // B_reset
            // 
            this.B_reset.Location = new System.Drawing.Point(160, 132);
            this.B_reset.Name = "B_reset";
            this.B_reset.Size = new System.Drawing.Size(142, 35);
            this.B_reset.TabIndex = 6;
            this.B_reset.Text = "Reset to default";
            this.B_reset.UseVisualStyleBackColor = true;
            this.B_reset.Click += new System.EventHandler(this.B_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(9, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Done by SaltyMonkey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caali proxy configurator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_updatelog;
        private System.Windows.Forms.Button B_apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_ru;
        private System.Windows.Forms.RadioButton RB_eu;
        private System.Windows.Forms.RadioButton RB_na;
        private System.Windows.Forms.RadioButton RB_tw;
        private System.Windows.Forms.RadioButton RB_kr;
        private System.Windows.Forms.RadioButton RB_se;
        private System.Windows.Forms.Button B_reset;
        private System.Windows.Forms.Label label1;
    }
}

