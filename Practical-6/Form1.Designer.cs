namespace StudentForm
{
    partial class Form1
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
this.txtfname = new System.Windows.Forms.TextBox();
this.lblfname = new System.Windows.Forms.Label();
this.txtlname = new System.Windows.Forms.TextBox();
this.lbllname = new System.Windows.Forms.Label();
this.btnsave = new System.Windows.Forms.Button();
this.lblGender = new System.Windows.Forms.Label();
this.genMale = new System.Windows.Forms.RadioButton();
this.genFemale = new System.Windows.Forms.RadioButton();
this.ck1 = new System.Windows.Forms.CheckBox();
this.ck2 = new System.Windows.Forms.CheckBox();
this.groupBox1 = new System.Windows.Forms.GroupBox();
this.label1 = new System.Windows.Forms.Label();
this.pictureBox = new System.Windows.Forms.PictureBox();
this.btnimg = new System.Windows.Forms.Button();
this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
this.groupBox1.SuspendLayout();
((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
this.SuspendLayout();
// 
// txtfname
// 
this.txtfname.Location = new System.Drawing.Point(229, 31);
this.txtfname.Name = "txtfname";
this.txtfname.Size = new System.Drawing.Size(100, 20);
this.txtfname.TabIndex = 0;
// 
// lblfname
// 
this.lblfname.AutoSize = true;
this.lblfname.Location = new System.Drawing.Point(147, 34);
this.lblfname.Name = "lblfname";
this.lblfname.Size = new System.Drawing.Size(57, 13);
this.lblfname.TabIndex = 1;
this.lblfname.Text = "First Name";
// 
// txtlname
// 
this.txtlname.Location = new System.Drawing.Point(229, 75);
this.txtlname.Name = "txtlname";
this.txtlname.Size = new System.Drawing.Size(100, 20);
this.txtlname.TabIndex = 2;
// 
// lbllname
// 
this.lbllname.AutoSize = true;
this.lbllname.Location = new System.Drawing.Point(147, 78);
this.lbllname.Name = "lbllname";
this.lbllname.Size = new System.Drawing.Size(58, 13);
this.lbllname.TabIndex = 3;
this.lbllname.Text = "Last Name";
// 
// btnsave
// 
this.btnsave.Location = new System.Drawing.Point(150, 190);
this.btnsave.Name = "btnsave";
this.btnsave.Size = new System.Drawing.Size(75, 23);
this.btnsave.TabIndex = 4;
this.btnsave.Text = "Save";
this.btnsave.UseVisualStyleBackColor = true;
this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
// 
// lblGender
// 
this.lblGender.AutoSize = true;
this.lblGender.Location = new System.Drawing.Point(147, 116);
this.lblGender.Name = "lblGender";
this.lblGender.Size = new System.Drawing.Size(42, 13);
this.lblGender.TabIndex = 5;
this.lblGender.Text = "Gender";
// 
// genMale
// 
this.genMale.AutoSize = true;
this.genMale.Location = new System.Drawing.Point(6, 13);
this.genMale.Name = "genMale";
this.genMale.Size = new System.Drawing.Size(48, 17);
this.genMale.TabIndex = 6;
this.genMale.TabStop = true;
this.genMale.Text = "Male";
this.genMale.UseVisualStyleBackColor = true;
// 
// genFemale
// 
this.genFemale.AutoSize = true;
this.genFemale.Location = new System.Drawing.Point(60, 13);
this.genFemale.Name = "genFemale";
this.genFemale.Size = new System.Drawing.Size(59, 17);
this.genFemale.TabIndex = 7;
this.genFemale.TabStop = true;
this.genFemale.Text = "Female";
this.genFemale.UseVisualStyleBackColor = true;
// 
// ck1
// 
this.ck1.AutoSize = true;
this.ck1.Location = new System.Drawing.Point(229, 148);
this.ck1.Name = "ck1";
this.ck1.Size = new System.Drawing.Size(37, 17);
this.ck1.TabIndex = 8;
this.ck1.Text = "s1";
this.ck1.UseVisualStyleBackColor = true;
// 
// ck2
// 
this.ck2.AutoSize = true;
this.ck2.Location = new System.Drawing.Point(283, 148);
this.ck2.Name = "ck2";
this.ck2.Size = new System.Drawing.Size(37, 17);
this.ck2.TabIndex = 9;
this.ck2.Text = "s2";
this.ck2.UseVisualStyleBackColor = true;
// 
// groupBox1
// 
this.groupBox1.Controls.Add(this.genMale);
this.groupBox1.Controls.Add(this.genFemale);
this.groupBox1.Location = new System.Drawing.Point(220, 101);
this.groupBox1.Name = "groupBox1";
this.groupBox1.Size = new System.Drawing.Size(126, 41);
this.groupBox1.TabIndex = 11;
this.groupBox1.TabStop = false;
// 
// label1
// 
this.label1.AutoSize = true;
this.label1.Location = new System.Drawing.Point(147, 148);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(41, 13);
this.label1.TabIndex = 12;
this.label1.Text = "subject";
// 
// pictureBox
// 
this.pictureBox.Location = new System.Drawing.Point(415, 34);
this.pictureBox.Name = "pictureBox";
this.pictureBox.Size = new System.Drawing.Size(100, 108);
this.pictureBox.TabIndex = 13;
this.pictureBox.TabStop = false;
// 
// btnimg
// 
this.btnimg.Location = new System.Drawing.Point(428, 165);
this.btnimg.Name = "btnimg";
this.btnimg.Size = new System.Drawing.Size(75, 23);
this.btnimg.TabIndex = 14;
this.btnimg.Text = "Upload ";
this.btnimg.UseVisualStyleBackColor = true;
this.btnimg.Click += new System.EventHandler(this.btnimg_Click);
// 
// openFileDialog1
// 
this.openFileDialog1.FileName = "openFileDialog1";
// 
// Form1
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(728, 357);
this.Controls.Add(this.btnimg);
this.Controls.Add(this.pictureBox);
this.Controls.Add(this.label1);
this.Controls.Add(this.groupBox1);
this.Controls.Add(this.ck2);
this.Controls.Add(this.ck1);
this.Controls.Add(this.lblGender);
this.Controls.Add(this.btnsave);
this.Controls.Add(this.lbllname);
this.Controls.Add(this.txtlname);
this.Controls.Add(this.lblfname);
this.Controls.Add(this.txtfname);
this.Name = "Form1";
this.Load += new System.EventHandler(this.Form1_Load);
this.groupBox1.ResumeLayout(false);
this.groupBox1.PerformLayout();
((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
this.ResumeLayout(false);
this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton genMale;
        private System.Windows.Forms.RadioButton genFemale;
        private System.Windows.Forms.CheckBox ck1;
        private System.Windows.Forms.CheckBox ck2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

