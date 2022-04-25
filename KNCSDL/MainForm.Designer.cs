
namespace BaiTap22032022
{
    partial class MainForm
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
            this.label_lopsinhhoat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_lopsinhhoat = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_sort = new System.Windows.Forms.Button();
            this.comboBox_Sort = new System.Windows.Forms.ComboBox();
            this.comboBox_direct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_lopsinhhoat
            // 
            this.label_lopsinhhoat.AutoSize = true;
            this.label_lopsinhhoat.Location = new System.Drawing.Point(95, 71);
            this.label_lopsinhhoat.Name = "label_lopsinhhoat";
            this.label_lopsinhhoat.Size = new System.Drawing.Size(98, 17);
            this.label_lopsinhhoat.TabIndex = 0;
            this.label_lopsinhhoat.Text = "Lop Sinh Hoat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox_lopsinhhoat
            // 
            this.comboBox_lopsinhhoat.FormattingEnabled = true;
            this.comboBox_lopsinhhoat.Location = new System.Drawing.Point(242, 71);
            this.comboBox_lopsinhhoat.Name = "comboBox_lopsinhhoat";
            this.comboBox_lopsinhhoat.Size = new System.Drawing.Size(121, 24);
            this.comboBox_lopsinhhoat.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(804, 72);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 22);
            this.textBox_search.TabIndex = 4;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(673, 71);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(98, 449);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 6;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(242, 449);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(389, 449);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(529, 449);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 9;
            this.button_del.Text = "Del";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(649, 449);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(75, 23);
            this.button_sort.TabIndex = 10;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // comboBox_Sort
            // 
            this.comboBox_Sort.FormattingEnabled = true;
            this.comboBox_Sort.Items.AddRange(new object[] {
            "Ten",
            "Ma Sinh vien"});
            this.comboBox_Sort.Location = new System.Drawing.Point(768, 448);
            this.comboBox_Sort.Name = "comboBox_Sort";
            this.comboBox_Sort.Size = new System.Drawing.Size(109, 24);
            this.comboBox_Sort.TabIndex = 11;
            // 
            // comboBox_direct
            // 
            this.comboBox_direct.FormattingEnabled = true;
            this.comboBox_direct.Items.AddRange(new object[] {
            "Giam",
            "Tang"});
            this.comboBox_direct.Location = new System.Drawing.Point(909, 448);
            this.comboBox_direct.Name = "comboBox_direct";
            this.comboBox_direct.Size = new System.Drawing.Size(112, 24);
            this.comboBox_direct.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 563);
            this.Controls.Add(this.comboBox_direct);
            this.Controls.Add(this.comboBox_Sort);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.comboBox_lopsinhhoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_lopsinhhoat);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_lopsinhhoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_lopsinhhoat;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.ComboBox comboBox_Sort;
        private System.Windows.Forms.ComboBox comboBox_direct;
    }
}

