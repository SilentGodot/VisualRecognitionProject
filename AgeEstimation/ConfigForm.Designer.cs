namespace AgeEstimation
{
    partial class ConfigForm
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
            this.txtComponents = new System.Windows.Forms.TextBox();
            this.txtFaceSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCutTesting = new System.Windows.Forms.CheckBox();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.txtCutPrecent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComponents);
            this.groupBox1.Controls.Add(this.txtFaceSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eigenfaces Settings";
            // 
            // txtComponents
            // 
            this.txtComponents.Location = new System.Drawing.Point(132, 47);
            this.txtComponents.Name = "txtComponents";
            this.txtComponents.Size = new System.Drawing.Size(100, 20);
            this.txtComponents.TabIndex = 1;
            // 
            // txtFaceSize
            // 
            this.txtFaceSize.Location = new System.Drawing.Point(132, 17);
            this.txtFaceSize.Name = "txtFaceSize";
            this.txtFaceSize.Size = new System.Drawing.Size(100, 20);
            this.txtFaceSize.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Num of Eigen Values";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCutTesting);
            this.groupBox2.Controls.Add(this.cbGender);
            this.groupBox2.Controls.Add(this.txtIterations);
            this.groupBox2.Controls.Add(this.txtCutPrecent);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm Settings";
            // 
            // cbCutTesting
            // 
            this.cbCutTesting.AutoSize = true;
            this.cbCutTesting.Location = new System.Drawing.Point(6, 107);
            this.cbCutTesting.Name = "cbCutTesting";
            this.cbCutTesting.Size = new System.Drawing.Size(216, 17);
            this.cbCutTesting.TabIndex = 3;
            this.cbCutTesting.Text = "Remove Testing Cut From Training Data";
            this.cbCutTesting.UseVisualStyleBackColor = true;
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(6, 84);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(104, 17);
            this.cbGender.TabIndex = 2;
            this.cbGender.Text = "Estimate Gender";
            this.cbGender.UseVisualStyleBackColor = true;
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(132, 51);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 20);
            this.txtIterations.TabIndex = 1;
            // 
            // txtCutPrecent
            // 
            this.txtCutPrecent.Location = new System.Drawing.Point(132, 19);
            this.txtCutPrecent.Name = "txtCutPrecent";
            this.txtCutPrecent.Size = new System.Drawing.Size(100, 20);
            this.txtCutPrecent.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Testing Iterations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Testing Cut Precent";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(145, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Load Default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(267, 320);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComponents;
        private System.Windows.Forms.TextBox txtFaceSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.TextBox txtCutPrecent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbCutTesting;
        private System.Windows.Forms.Button button3;
    }
}