namespace CopyDirTaskOs
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
            this.Copybtn = new System.Windows.Forms.Button();
            this.Copybar = new System.Windows.Forms.ProgressBar();
            this.sourcePathtxt = new System.Windows.Forms.TextBox();
            this.destinationPathtxt = new System.Windows.Forms.TextBox();
            this.sourceDirBtn = new System.Windows.Forms.Button();
            this.destinationPathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Copybtn
            // 
            this.Copybtn.Location = new System.Drawing.Point(423, 260);
            this.Copybtn.Name = "Copybtn";
            this.Copybtn.Size = new System.Drawing.Size(94, 29);
            this.Copybtn.TabIndex = 0;
            this.Copybtn.Text = "Copy";
            this.Copybtn.UseVisualStyleBackColor = true;
            this.Copybtn.Click += new System.EventHandler(this.Copybtn_Click);
            // 
            // Copybar
            // 
            this.Copybar.Location = new System.Drawing.Point(12, 183);
            this.Copybar.Name = "Copybar";
            this.Copybar.Size = new System.Drawing.Size(505, 50);
            this.Copybar.TabIndex = 1;
            // 
            // sourcePathtxt
            // 
            this.sourcePathtxt.Location = new System.Drawing.Point(12, 42);
            this.sourcePathtxt.Name = "sourcePathtxt";
            this.sourcePathtxt.Size = new System.Drawing.Size(448, 27);
            this.sourcePathtxt.TabIndex = 2;
            // 
            // destinationPathtxt
            // 
            this.destinationPathtxt.Location = new System.Drawing.Point(12, 116);
            this.destinationPathtxt.Name = "destinationPathtxt";
            this.destinationPathtxt.Size = new System.Drawing.Size(448, 27);
            this.destinationPathtxt.TabIndex = 3;
            // 
            // sourceDirBtn
            // 
            this.sourceDirBtn.Location = new System.Drawing.Point(484, 42);
            this.sourceDirBtn.Name = "sourceDirBtn";
            this.sourceDirBtn.Size = new System.Drawing.Size(33, 29);
            this.sourceDirBtn.TabIndex = 4;
            this.sourceDirBtn.Text = "...";
            this.sourceDirBtn.UseVisualStyleBackColor = true;
            this.sourceDirBtn.Click += new System.EventHandler(this.sourceDirBtn_Click);
            // 
            // destinationPathBtn
            // 
            this.destinationPathBtn.Location = new System.Drawing.Point(484, 116);
            this.destinationPathBtn.Name = "destinationPathBtn";
            this.destinationPathBtn.Size = new System.Drawing.Size(33, 29);
            this.destinationPathBtn.TabIndex = 5;
            this.destinationPathBtn.Text = "...";
            this.destinationPathBtn.UseVisualStyleBackColor = true;
            this.destinationPathBtn.Click += new System.EventHandler(this.destinationPathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder Source Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folder destination Path";
            // 
            // progressNum
            // 
            this.progressNum.AutoSize = true;
            this.progressNum.Location = new System.Drawing.Point(484, 160);
            this.progressNum.Name = "progressNum";
            this.progressNum.Size = new System.Drawing.Size(29, 20);
            this.progressNum.TabIndex = 8;
            this.progressNum.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 310);
            this.Controls.Add(this.progressNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationPathBtn);
            this.Controls.Add(this.sourceDirBtn);
            this.Controls.Add(this.destinationPathtxt);
            this.Controls.Add(this.sourcePathtxt);
            this.Controls.Add(this.Copybar);
            this.Controls.Add(this.Copybtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Copybtn;
        private ProgressBar Copybar;
        private TextBox sourcePathtxt;
        private TextBox destinationPathtxt;
        private Button sourceDirBtn;
        private Button destinationPathBtn;
        private Label label1;
        private Label label2;
        private Label progressNum;
    }
}