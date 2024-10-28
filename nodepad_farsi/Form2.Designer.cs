namespace nodepad_farsi
{
    partial class frmsearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.rdbnone = new System.Windows.Forms.RadioButton();
            this.rdbwholeword = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جست و جو ";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(226, 25);
            this.textsearch.Multiline = true;
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(170, 20);
            this.textsearch.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(126, 25);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "کاووش";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(12, 22);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "لغو";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // rdbnone
            // 
            this.rdbnone.AutoSize = true;
            this.rdbnone.Location = new System.Drawing.Point(66, 78);
            this.rdbnone.Name = "rdbnone";
            this.rdbnone.Size = new System.Drawing.Size(134, 17);
            this.rdbnone.TabIndex = 4;
            this.rdbnone.TabStop = true;
            this.rdbnone.Text = "شامل همین کلمه باشد";
            this.rdbnone.UseVisualStyleBackColor = true;
            this.rdbnone.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbwholeword
            // 
            this.rdbwholeword.AutoSize = true;
            this.rdbwholeword.Location = new System.Drawing.Point(97, 33);
            this.rdbwholeword.Name = "rdbwholeword";
            this.rdbwholeword.Size = new System.Drawing.Size(103, 17);
            this.rdbwholeword.TabIndex = 5;
            this.rdbwholeword.TabStop = true;
            this.rdbwholeword.Text = "دقیقا همین کلمه";
            this.rdbwholeword.UseVisualStyleBackColor = true;
            this.rdbwholeword.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbwholeword);
            this.groupBox1.Controls.Add(this.rdbnone);
            this.groupBox1.Location = new System.Drawing.Point(249, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نحوه کاووش";
            // 
            // frmsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmsearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmsearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsearch_FormClosing);
            this.Load += new System.EventHandler(this.frmsearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.RadioButton rdbnone;
        private System.Windows.Forms.RadioButton rdbwholeword;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}