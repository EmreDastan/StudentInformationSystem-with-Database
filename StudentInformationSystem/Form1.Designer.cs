
namespace StudentInformationSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_mark = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_deletebyname = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(139, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 20);
            this.textBox5.TabIndex = 4;
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_insert.Location = new System.Drawing.Point(19, 169);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(91, 67);
            this.button_insert.TabIndex = 5;
            this.button_insert.Text = "INSERT";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_load
            // 
            this.button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_load.Location = new System.Drawing.Point(298, 169);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(91, 67);
            this.button_load.TabIndex = 6;
            this.button_load.Text = "LOAD";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.Location = new System.Drawing.Point(49, 21);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(56, 20);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Term";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_surname
            // 
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_surname.Location = new System.Drawing.Point(17, 47);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(116, 20);
            this.label_surname.TabIndex = 9;
            this.label_surname.Text = "Course Code";
            // 
            // label_gender
            // 
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_gender.Location = new System.Drawing.Point(15, 73);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(118, 20);
            this.label_gender.TabIndex = 10;
            this.label_gender.Text = "Course Name";
            // 
            // label_age
            // 
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_age.Location = new System.Drawing.Point(49, 99);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(56, 20);
            this.label_age.TabIndex = 11;
            this.label_age.Text = "ECTS";
            // 
            // label_mark
            // 
            this.label_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mark.Location = new System.Drawing.Point(19, 125);
            this.label_mark.Name = "label_mark";
            this.label_mark.Size = new System.Drawing.Size(115, 20);
            this.label_mark.TabIndex = 12;
            this.label_mark.Text = "Letter Grade";
            this.label_mark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(139, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 124);
            this.dataGridView1.TabIndex = 14;
            // 
            // button_deletebyname
            // 
            this.button_deletebyname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_deletebyname.Location = new System.Drawing.Point(116, 169);
            this.button_deletebyname.Name = "button_deletebyname";
            this.button_deletebyname.Size = new System.Drawing.Size(176, 67);
            this.button_deletebyname.TabIndex = 15;
            this.button_deletebyname.Text = "DELETE BY NAME";
            this.button_deletebyname.UseVisualStyleBackColor = false;
            this.button_deletebyname.Click += new System.EventHandler(this.button_deletebyname_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_exit.Location = new System.Drawing.Point(423, 169);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(350, 67);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 247);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_deletebyname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_mark);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "StudentInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_mark;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_deletebyname;
        private System.Windows.Forms.Button button_exit;
    }
}

