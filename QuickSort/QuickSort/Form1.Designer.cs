namespace QuickSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSleep = new System.Windows.Forms.Label();
            this.txtSleep = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.radQS = new System.Windows.Forms.RadioButton();
            this.radBS = new System.Windows.Forms.RadioButton();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.txtLoops = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(800, 281);
            this.txtInput.TabIndex = 0;
            this.txtInput.TabStop = false;
            this.txtInput.Text = resources.GetString("txtInput.Text");
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(646, 684);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(555, 684);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(737, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Location = new System.Drawing.Point(12, 689);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(32, 13);
            this.lblSleep.TabIndex = 4;
            this.lblSleep.Text = "sleep";
            // 
            // txtSleep
            // 
            this.txtSleep.Location = new System.Drawing.Point(50, 686);
            this.txtSleep.Name = "txtSleep";
            this.txtSleep.Size = new System.Drawing.Size(50, 20);
            this.txtSleep.TabIndex = 5;
            this.txtSleep.Text = "300";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(464, 684);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // radQS
            // 
            this.radQS.AutoSize = true;
            this.radQS.Checked = true;
            this.radQS.Location = new System.Drawing.Point(150, 687);
            this.radQS.Name = "radQS";
            this.radQS.Size = new System.Drawing.Size(75, 17);
            this.radQS.TabIndex = 7;
            this.radQS.TabStop = true;
            this.radQS.Text = "Quick Sort";
            this.radQS.UseVisualStyleBackColor = true;
            // 
            // radBS
            // 
            this.radBS.AutoSize = true;
            this.radBS.Location = new System.Drawing.Point(242, 687);
            this.radBS.Name = "radBS";
            this.radBS.Size = new System.Drawing.Size(80, 17);
            this.radBS.TabIndex = 8;
            this.radBS.Text = "Bubble Sort";
            this.radBS.UseVisualStyleBackColor = true;
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(395, 687);
            this.txtRec.Name = "txtRec";
            this.txtRec.ReadOnly = true;
            this.txtRec.Size = new System.Drawing.Size(50, 20);
            this.txtRec.TabIndex = 9;
            this.txtRec.Text = "0";
            // 
            // txtLoops
            // 
            this.txtLoops.Location = new System.Drawing.Point(339, 687);
            this.txtLoops.Name = "txtLoops";
            this.txtLoops.ReadOnly = true;
            this.txtLoops.Size = new System.Drawing.Size(50, 20);
            this.txtLoops.TabIndex = 10;
            this.txtLoops.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 719);
            this.Controls.Add(this.txtLoops);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.radBS);
            this.Controls.Add(this.radQS);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSleep);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.TextBox txtSleep;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton radQS;
        private System.Windows.Forms.RadioButton radBS;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.TextBox txtLoops;
    }
}

