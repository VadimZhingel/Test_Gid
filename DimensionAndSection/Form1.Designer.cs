namespace DimensionAndSection
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
            this.distance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // distance
            // 
            this.distance.Dock = System.Windows.Forms.DockStyle.Top;
            this.distance.Location = new System.Drawing.Point(0, 0);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(313, 32);
            this.distance.TabIndex = 0;
            this.distance.Text = "Run";
            this.distance.UseVisualStyleBackColor = true;
            this.distance.Click += new System.EventHandler(this.distance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(313, 186);
            this.Controls.Add(this.distance);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button distance;
    }
}

