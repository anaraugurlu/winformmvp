
namespace winformmvp.View
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.literrdbtn = new System.Windows.Forms.RadioButton();
            this.litertxtb = new System.Windows.Forms.MaskedTextBox();
            this.aznttxtb = new System.Windows.Forms.MaskedTextBox();
            this.aznrdbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.totallbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loadbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.loadbtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.totallbl);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.calculatebtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aznrdbtn);
            this.groupBox1.Controls.Add(this.aznttxtb);
            this.groupBox1.Controls.Add(this.litertxtb);
            this.groupBox1.Controls.Add(this.literrdbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pricelbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "oil";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(158, 69);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(13, 13);
            this.pricelbl.TabIndex = 2;
            this.pricelbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRICE";
            // 
            // literrdbtn
            // 
            this.literrdbtn.AutoSize = true;
            this.literrdbtn.Location = new System.Drawing.Point(22, 103);
            this.literrdbtn.Name = "literrdbtn";
            this.literrdbtn.Size = new System.Drawing.Size(41, 17);
            this.literrdbtn.TabIndex = 4;
            this.literrdbtn.TabStop = true;
            this.literrdbtn.Text = "liter";
            this.literrdbtn.UseVisualStyleBackColor = true;
            this.literrdbtn.CheckedChanged += new System.EventHandler(this.litertxtb_CheckedChanged);
            // 
            // litertxtb
            // 
            this.litertxtb.Location = new System.Drawing.Point(71, 103);
            this.litertxtb.Mask = "00000";
            this.litertxtb.Name = "litertxtb";
            this.litertxtb.Size = new System.Drawing.Size(100, 20);
            this.litertxtb.TabIndex = 5;
            this.litertxtb.ValidatingType = typeof(int);
            this.litertxtb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // aznttxtb
            // 
            this.aznttxtb.Location = new System.Drawing.Point(94, 138);
            this.aznttxtb.Mask = "00000";
            this.aznttxtb.Name = "aznttxtb";
            this.aznttxtb.Size = new System.Drawing.Size(100, 20);
            this.aznttxtb.TabIndex = 6;
            this.aznttxtb.ValidatingType = typeof(int);
            this.aznttxtb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.aznttxtb_MaskInputRejected);
            // 
            // aznrdbtn
            // 
            this.aznrdbtn.AutoSize = true;
            this.aznrdbtn.Location = new System.Drawing.Point(41, 141);
            this.aznrdbtn.Name = "aznrdbtn";
            this.aznrdbtn.Size = new System.Drawing.Size(47, 17);
            this.aznrdbtn.TabIndex = 7;
            this.aznrdbtn.TabStop = true;
            this.aznrdbtn.Text = "AZN";
            this.aznrdbtn.UseVisualStyleBackColor = true;
            this.aznrdbtn.CheckedChanged += new System.EventHandler(this.aznrdbtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Azn";
            // 
            // calculatebtn
            // 
            this.calculatebtn.Location = new System.Drawing.Point(12, 232);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(75, 23);
            this.calculatebtn.TabIndex = 10;
            this.calculatebtn.Text = "calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(277, 231);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(27, 13);
            this.totallbl.TabIndex = 12;
            this.totallbl.Text = "total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "payment";
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(361, 141);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(75, 23);
            this.loadbtn.TabIndex = 15;
            this.loadbtn.Text = "load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(361, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 108);
            this.listBox1.TabIndex = 16;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton aznrdbtn;
        private System.Windows.Forms.MaskedTextBox aznttxtb;
        private System.Windows.Forms.MaskedTextBox litertxtb;
        private System.Windows.Forms.RadioButton literrdbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}