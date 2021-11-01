
namespace XMLconverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.author_cbx = new System.Windows.Forms.CheckBox();
            this.title_cbx = new System.Windows.Forms.CheckBox();
            this.year_cbx = new System.Windows.Forms.CheckBox();
            this.faculty_cbx = new System.Windows.Forms.CheckBox();
            this.department_cbx = new System.Windows.Forms.CheckBox();
            this.numb_pages_cbx = new System.Windows.Forms.CheckBox();
            this.type_cbx = new System.Windows.Forms.CheckBox();
            this.dom_rb = new System.Windows.Forms.RadioButton();
            this.sax_rb = new System.Windows.Forms.RadioButton();
            this.linq_rb = new System.Windows.Forms.RadioButton();
            this.search_btn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.author_cmb = new System.Windows.Forms.ComboBox();
            this.title_cmb = new System.Windows.Forms.ComboBox();
            this.year_cmb = new System.Windows.Forms.ComboBox();
            this.department_cmb = new System.Windows.Forms.ComboBox();
            this.faculty_cmb = new System.Windows.Forms.ComboBox();
            this.numb_pages_cmb = new System.Windows.Forms.ComboBox();
            this.type_cmb = new System.Windows.Forms.ComboBox();
            this.transform_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // author_cbx
            // 
            this.author_cbx.AutoSize = true;
            this.author_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author_cbx.Location = new System.Drawing.Point(44, 42);
            this.author_cbx.Name = "author_cbx";
            this.author_cbx.Size = new System.Drawing.Size(96, 32);
            this.author_cbx.TabIndex = 6;
            this.author_cbx.Text = "Автор";
            this.author_cbx.UseVisualStyleBackColor = true;
            this.author_cbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // title_cbx
            // 
            this.title_cbx.AutoSize = true;
            this.title_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_cbx.Location = new System.Drawing.Point(44, 95);
            this.title_cbx.Name = "title_cbx";
            this.title_cbx.Size = new System.Drawing.Size(97, 32);
            this.title_cbx.TabIndex = 7;
            this.title_cbx.Text = "Назва";
            this.title_cbx.UseVisualStyleBackColor = true;
            // 
            // year_cbx
            // 
            this.year_cbx.AutoSize = true;
            this.year_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year_cbx.Location = new System.Drawing.Point(43, 145);
            this.year_cbx.Name = "year_cbx";
            this.year_cbx.Size = new System.Drawing.Size(63, 32);
            this.year_cbx.TabIndex = 8;
            this.year_cbx.Text = "Рік";
            this.year_cbx.UseVisualStyleBackColor = true;
            // 
            // faculty_cbx
            // 
            this.faculty_cbx.AutoSize = true;
            this.faculty_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faculty_cbx.Location = new System.Drawing.Point(44, 192);
            this.faculty_cbx.Name = "faculty_cbx";
            this.faculty_cbx.Size = new System.Drawing.Size(144, 32);
            this.faculty_cbx.TabIndex = 9;
            this.faculty_cbx.Text = "Факультет";
            this.faculty_cbx.UseVisualStyleBackColor = true;
            // 
            // department_cbx
            // 
            this.department_cbx.AutoSize = true;
            this.department_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.department_cbx.Location = new System.Drawing.Point(43, 244);
            this.department_cbx.Name = "department_cbx";
            this.department_cbx.Size = new System.Drawing.Size(127, 32);
            this.department_cbx.TabIndex = 10;
            this.department_cbx.Text = "Кафедра";
            this.department_cbx.UseVisualStyleBackColor = true;
            // 
            // numb_pages_cbx
            // 
            this.numb_pages_cbx.AutoSize = true;
            this.numb_pages_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numb_pages_cbx.Location = new System.Drawing.Point(43, 299);
            this.numb_pages_cbx.Name = "numb_pages_cbx";
            this.numb_pages_cbx.Size = new System.Drawing.Size(96, 32);
            this.numb_pages_cbx.TabIndex = 11;
            this.numb_pages_cbx.Text = "Обсяг";
            this.numb_pages_cbx.UseVisualStyleBackColor = true;
            // 
            // type_cbx
            // 
            this.type_cbx.AutoSize = true;
            this.type_cbx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type_cbx.Location = new System.Drawing.Point(44, 346);
            this.type_cbx.Name = "type_cbx";
            this.type_cbx.Size = new System.Drawing.Size(74, 32);
            this.type_cbx.TabIndex = 12;
            this.type_cbx.Text = "Вид";
            this.type_cbx.UseVisualStyleBackColor = true;
            // 
            // dom_rb
            // 
            this.dom_rb.Checked = true;
            this.dom_rb.AutoSize = true;
            this.dom_rb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dom_rb.Location = new System.Drawing.Point(159, 405);
            this.dom_rb.Name = "dom_rb";
            this.dom_rb.Size = new System.Drawing.Size(87, 34);
            this.dom_rb.TabIndex = 13;
            this.dom_rb.TabStop = true;
            this.dom_rb.Text = "DOM";
            this.dom_rb.UseVisualStyleBackColor = true;
            this.dom_rb.CheckedChanged += new System.EventHandler(this.dom_rb_CheckedChanged);
            // 
            // sax_rb
            // 
            this.sax_rb.AutoSize = true;
            this.sax_rb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sax_rb.Location = new System.Drawing.Point(159, 446);
            this.sax_rb.Name = "sax_rb";
            this.sax_rb.Size = new System.Drawing.Size(75, 34);
            this.sax_rb.TabIndex = 14;
            this.sax_rb.TabStop = true;
            this.sax_rb.Text = "SAX";
            this.sax_rb.UseVisualStyleBackColor = true;
            // 
            // linq_rb
            // 
            this.linq_rb.AutoSize = true;
            this.linq_rb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linq_rb.Location = new System.Drawing.Point(159, 487);
            this.linq_rb.Name = "linq_rb";
            this.linq_rb.Size = new System.Drawing.Size(163, 34);
            this.linq_rb.TabIndex = 15;
            this.linq_rb.TabStop = true;
            this.linq_rb.Text = "LINQ to XML";
            this.linq_rb.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(72, 527);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(359, 61);
            this.search_btn.TabIndex = 16;
            this.search_btn.Text = "Пошук";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(599, 29);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(499, 600);
            this.Result.TabIndex = 17;
            this.Result.Text = "";
            this.Result.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // author_cmb
            // 
            this.author_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.author_cmb.FormattingEnabled = true;
            this.author_cmb.Location = new System.Drawing.Point(239, 47);
            this.author_cmb.Name = "author_cmb";
            this.author_cmb.Size = new System.Drawing.Size(215, 28);
            this.author_cmb.TabIndex = 18;
            this.author_cmb.SelectedIndexChanged += new System.EventHandler(this.author_cmb_SelectedIndexChanged);
            // 
            // title_cmb
            // 
            this.title_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.title_cmb.FormattingEnabled = true;
            this.title_cmb.Location = new System.Drawing.Point(239, 95);
            this.title_cmb.Name = "title_cmb";
            this.title_cmb.Size = new System.Drawing.Size(215, 28);
            this.title_cmb.TabIndex = 19;
            // 
            // year_cmb
            // 
            this.year_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_cmb.FormattingEnabled = true;
            this.year_cmb.Location = new System.Drawing.Point(239, 145);
            this.year_cmb.Name = "year_cmb";
            this.year_cmb.Size = new System.Drawing.Size(215, 28);
            this.year_cmb.TabIndex = 20;
            // 
            // department_cmb
            // 
            this.department_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department_cmb.FormattingEnabled = true;
            this.department_cmb.Location = new System.Drawing.Point(239, 248);
            this.department_cmb.Name = "department_cmb";
            this.department_cmb.Size = new System.Drawing.Size(215, 28);
            this.department_cmb.TabIndex = 21;
            // 
            // faculty_cmb
            // 
            this.faculty_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faculty_cmb.FormattingEnabled = true;
            this.faculty_cmb.Location = new System.Drawing.Point(239, 197);
            this.faculty_cmb.Name = "faculty_cmb";
            this.faculty_cmb.Size = new System.Drawing.Size(215, 28);
            this.faculty_cmb.TabIndex = 22;
            // 
            // numb_pages_cmb
            // 
            this.numb_pages_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numb_pages_cmb.FormattingEnabled = true;
            this.numb_pages_cmb.Location = new System.Drawing.Point(239, 299);
            this.numb_pages_cmb.Name = "numb_pages_cmb";
            this.numb_pages_cmb.Size = new System.Drawing.Size(215, 28);
            this.numb_pages_cmb.TabIndex = 23;
            // 
            // type_cmb
            // 
            this.type_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cmb.FormattingEnabled = true;
            this.type_cmb.Location = new System.Drawing.Point(239, 350);
            this.type_cmb.Name = "type_cmb";
            this.type_cmb.Size = new System.Drawing.Size(215, 28);
            this.type_cmb.TabIndex = 24;
            // 
            // transform_btn
            // 
            this.transform_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transform_btn.Location = new System.Drawing.Point(72, 617);
            this.transform_btn.Name = "transform_btn";
            this.transform_btn.Size = new System.Drawing.Size(359, 55);
            this.transform_btn.TabIndex = 25;
            this.transform_btn.Text = "Перетворити до HTML";
            this.transform_btn.UseVisualStyleBackColor = true;
            this.transform_btn.Click += new System.EventHandler(this.transform_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(735, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 55);
            this.button1.TabIndex = 26;
            this.button1.Text = "Очистити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transform_btn);
            this.Controls.Add(this.type_cmb);
            this.Controls.Add(this.numb_pages_cmb);
            this.Controls.Add(this.faculty_cmb);
            this.Controls.Add(this.department_cmb);
            this.Controls.Add(this.year_cmb);
            this.Controls.Add(this.title_cmb);
            this.Controls.Add(this.author_cmb);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.linq_rb);
            this.Controls.Add(this.sax_rb);
            this.Controls.Add(this.dom_rb);
            this.Controls.Add(this.type_cbx);
            this.Controls.Add(this.numb_pages_cbx);
            this.Controls.Add(this.department_cbx);
            this.Controls.Add(this.faculty_cbx);
            this.Controls.Add(this.year_cbx);
            this.Controls.Add(this.title_cbx);
            this.Controls.Add(this.author_cbx);
            this.Name = "Form1";
            this.Text = "Обсяг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox author_cbx;
        private System.Windows.Forms.CheckBox title_cbx;
        private System.Windows.Forms.CheckBox year_cbx;
        private System.Windows.Forms.CheckBox faculty_cbx;
        private System.Windows.Forms.CheckBox department_cbx;
        private System.Windows.Forms.CheckBox numb_pages_cbx;
        private System.Windows.Forms.CheckBox type_cbx;
        private System.Windows.Forms.RadioButton dom_rb;
        private System.Windows.Forms.RadioButton sax_rb;
        private System.Windows.Forms.RadioButton linq_rb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.ComboBox author_cmb;
        private System.Windows.Forms.ComboBox title_cmb;
        private System.Windows.Forms.ComboBox year_cmb;
        private System.Windows.Forms.ComboBox department_cmb;
        private System.Windows.Forms.ComboBox faculty_cmb;
        private System.Windows.Forms.ComboBox numb_pages_cmb;
        private System.Windows.Forms.ComboBox type_cmb;
        private System.Windows.Forms.Button transform_btn;
        private System.Windows.Forms.Button button1;
    }
}

