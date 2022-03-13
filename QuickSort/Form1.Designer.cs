
namespace QuickSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbArray4 = new System.Windows.Forms.PictureBox();
            this.pbArray5 = new System.Windows.Forms.PictureBox();
            this.pbArray2 = new System.Windows.Forms.PictureBox();
            this.pbArray3 = new System.Windows.Forms.PictureBox();
            this.pbArray6 = new System.Windows.Forms.PictureBox();
            this.pbArray1 = new System.Windows.Forms.PictureBox();
            this.tbArray1 = new System.Windows.Forms.TextBox();
            this.tbArray5 = new System.Windows.Forms.TextBox();
            this.tbArray6 = new System.Windows.Forms.TextBox();
            this.tbArray4 = new System.Windows.Forms.TextBox();
            this.tbArray3 = new System.Windows.Forms.TextBox();
            this.tbArray2 = new System.Windows.Forms.TextBox();
            this.btnMixed = new System.Windows.Forms.Button();
            this.btnBinSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArray4
            // 
            this.pbArray4.Image = global::QuickSort.Properties.Resources.m;
            this.pbArray4.Location = new System.Drawing.Point(27, 370);
            this.pbArray4.Name = "pbArray4";
            this.pbArray4.Size = new System.Drawing.Size(270, 270);
            this.pbArray4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArray4.TabIndex = 0;
            this.pbArray4.TabStop = false;
            // 
            // pbArray5
            // 
            this.pbArray5.Image = global::QuickSort.Properties.Resources.s;
            this.pbArray5.Location = new System.Drawing.Point(511, 370);
            this.pbArray5.Name = "pbArray5";
            this.pbArray5.Size = new System.Drawing.Size(270, 270);
            this.pbArray5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArray5.TabIndex = 1;
            this.pbArray5.TabStop = false;
            // 
            // pbArray2
            // 
            this.pbArray2.Image = global::QuickSort.Properties.Resources.b;
            this.pbArray2.Location = new System.Drawing.Point(511, 58);
            this.pbArray2.Name = "pbArray2";
            this.pbArray2.Size = new System.Drawing.Size(270, 270);
            this.pbArray2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArray2.TabIndex = 2;
            this.pbArray2.TabStop = false;
            // 
            // pbArray3
            // 
            this.pbArray3.Image = global::QuickSort.Properties.Resources.i;
            this.pbArray3.Location = new System.Drawing.Point(954, 58);
            this.pbArray3.Name = "pbArray3";
            this.pbArray3.Size = new System.Drawing.Size(270, 270);
            this.pbArray3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArray3.TabIndex = 3;
            this.pbArray3.TabStop = false;
            // 
            // pbArray6
            // 
            this.pbArray6.Image = global::QuickSort.Properties.Resources.f;
            this.pbArray6.Location = new System.Drawing.Point(937, 370);
            this.pbArray6.Name = "pbArray6";
            this.pbArray6.Size = new System.Drawing.Size(270, 270);
            this.pbArray6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArray6.TabIndex = 4;
            this.pbArray6.TabStop = false;
            // 
            // pbArray1
            // 
            this.pbArray1.Image = ((System.Drawing.Image)(resources.GetObject("pbArray1.Image")));
            this.pbArray1.Location = new System.Drawing.Point(27, 58);
            this.pbArray1.Name = "pbArray1";
            this.pbArray1.Size = new System.Drawing.Size(270, 270);
            this.pbArray1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArray1.TabIndex = 5;
            this.pbArray1.TabStop = false;
            // 
            // tbArray1
            // 
            this.tbArray1.Location = new System.Drawing.Point(149, 334);
            this.tbArray1.Name = "tbArray1";
            this.tbArray1.ReadOnly = true;
            this.tbArray1.Size = new System.Drawing.Size(100, 20);
            this.tbArray1.TabIndex = 6;
            this.tbArray1.Text = "Наруто";
            this.tbArray1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArray5
            // 
            this.tbArray5.Location = new System.Drawing.Point(627, 663);
            this.tbArray5.Name = "tbArray5";
            this.tbArray5.ReadOnly = true;
            this.tbArray5.Size = new System.Drawing.Size(100, 20);
            this.tbArray5.TabIndex = 7;
            this.tbArray5.Text = "Саске";
            this.tbArray5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArray6
            // 
            this.tbArray6.Location = new System.Drawing.Point(1039, 663);
            this.tbArray6.Name = "tbArray6";
            this.tbArray6.ReadOnly = true;
            this.tbArray6.Size = new System.Drawing.Size(100, 20);
            this.tbArray6.TabIndex = 8;
            this.tbArray6.Text = "Фукаку";
            this.tbArray6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArray4
            // 
            this.tbArray4.Location = new System.Drawing.Point(149, 663);
            this.tbArray4.Name = "tbArray4";
            this.tbArray4.ReadOnly = true;
            this.tbArray4.Size = new System.Drawing.Size(100, 20);
            this.tbArray4.TabIndex = 9;
            this.tbArray4.Text = "Минато";
            this.tbArray4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArray3
            // 
            this.tbArray3.Location = new System.Drawing.Point(1039, 334);
            this.tbArray3.Name = "tbArray3";
            this.tbArray3.ReadOnly = true;
            this.tbArray3.Size = new System.Drawing.Size(100, 20);
            this.tbArray3.TabIndex = 10;
            this.tbArray3.Text = "Итачи";
            this.tbArray3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArray2
            // 
            this.tbArray2.Location = new System.Drawing.Point(609, 334);
            this.tbArray2.Name = "tbArray2";
            this.tbArray2.ReadOnly = true;
            this.tbArray2.Size = new System.Drawing.Size(100, 20);
            this.tbArray2.TabIndex = 11;
            this.tbArray2.Text = "Боруто";
            this.tbArray2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMixed
            // 
            this.btnMixed.BackColor = System.Drawing.Color.Yellow;
            this.btnMixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMixed.Location = new System.Drawing.Point(111, 707);
            this.btnMixed.Name = "btnMixed";
            this.btnMixed.Size = new System.Drawing.Size(121, 68);
            this.btnMixed.TabIndex = 12;
            this.btnMixed.Text = "Mixed";
            this.btnMixed.UseVisualStyleBackColor = false;
            // 
            // btnBinSearch
            // 
            this.btnBinSearch.BackColor = System.Drawing.Color.Orange;
            this.btnBinSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBinSearch.Location = new System.Drawing.Point(1000, 706);
            this.btnBinSearch.Name = "btnBinSearch";
            this.btnBinSearch.Size = new System.Drawing.Size(176, 69);
            this.btnBinSearch.TabIndex = 13;
            this.btnBinSearch.Text = "Binary Search!";
            this.btnBinSearch.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(582, 705);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(135, 69);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1261, 808);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnBinSearch);
            this.Controls.Add(this.btnMixed);
            this.Controls.Add(this.tbArray2);
            this.Controls.Add(this.tbArray3);
            this.Controls.Add(this.tbArray4);
            this.Controls.Add(this.tbArray6);
            this.Controls.Add(this.tbArray5);
            this.Controls.Add(this.tbArray1);
            this.Controls.Add(this.pbArray1);
            this.Controls.Add(this.pbArray6);
            this.Controls.Add(this.pbArray3);
            this.Controls.Add(this.pbArray2);
            this.Controls.Add(this.pbArray5);
            this.Controls.Add(this.pbArray4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbArray4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArray1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArray4;
        private System.Windows.Forms.PictureBox pbArray5;
        private System.Windows.Forms.PictureBox pbArray2;
        private System.Windows.Forms.PictureBox pbArray3;
        private System.Windows.Forms.PictureBox pbArray6;
        private System.Windows.Forms.PictureBox pbArray1;
        private System.Windows.Forms.TextBox tbArray1;
        private System.Windows.Forms.TextBox tbArray5;
        private System.Windows.Forms.TextBox tbArray6;
        private System.Windows.Forms.TextBox tbArray4;
        private System.Windows.Forms.TextBox tbArray3;
        private System.Windows.Forms.TextBox tbArray2;
        private System.Windows.Forms.Button btnMixed;
        private System.Windows.Forms.Button btnBinSearch;
        private System.Windows.Forms.Button btnSort;
    }
}

