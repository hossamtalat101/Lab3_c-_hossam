namespace Lab3_Najm
{
    partial class Form4
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSumation = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacorial = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.labResultOfRoot = new System.Windows.Forms.Label();
            this.labResultOfSum = new System.Windows.Forms.Label();
            this.labResultOfFact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(27, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(253, 32);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSumation
            // 
            this.btnSumation.BackColor = System.Drawing.Color.Teal;
            this.btnSumation.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumation.ForeColor = System.Drawing.Color.White;
            this.btnSumation.Location = new System.Drawing.Point(164, 84);
            this.btnSumation.Name = "btnSumation";
            this.btnSumation.Size = new System.Drawing.Size(116, 37);
            this.btnSumation.TabIndex = 15;
            this.btnSumation.Text = "المجموع";
            this.btnSumation.UseVisualStyleBackColor = false;
            this.btnSumation.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(27, 46);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(253, 24);
            this.txtNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "أدخل العدد";
            // 
            // btnFacorial
            // 
            this.btnFacorial.BackColor = System.Drawing.Color.Teal;
            this.btnFacorial.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacorial.ForeColor = System.Drawing.Color.White;
            this.btnFacorial.Location = new System.Drawing.Point(164, 141);
            this.btnFacorial.Name = "btnFacorial";
            this.btnFacorial.Size = new System.Drawing.Size(116, 37);
            this.btnFacorial.TabIndex = 21;
            this.btnFacorial.Text = "المضروب";
            this.btnFacorial.UseVisualStyleBackColor = false;
            this.btnFacorial.Click += new System.EventHandler(this.btnFacorial_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.Teal;
            this.btnRoot.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.ForeColor = System.Drawing.Color.White;
            this.btnRoot.Location = new System.Drawing.Point(164, 199);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(116, 37);
            this.btnRoot.TabIndex = 22;
            this.btnRoot.Text = "الجذر";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // labResultOfRoot
            // 
            this.labResultOfRoot.AutoSize = true;
            this.labResultOfRoot.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultOfRoot.Location = new System.Drawing.Point(59, 205);
            this.labResultOfRoot.Name = "labResultOfRoot";
            this.labResultOfRoot.Size = new System.Drawing.Size(24, 21);
            this.labResultOfRoot.TabIndex = 27;
            this.labResultOfRoot.Text = "=";
            // 
            // labResultOfSum
            // 
            this.labResultOfSum.AutoSize = true;
            this.labResultOfSum.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultOfSum.Location = new System.Drawing.Point(59, 84);
            this.labResultOfSum.Name = "labResultOfSum";
            this.labResultOfSum.Size = new System.Drawing.Size(24, 21);
            this.labResultOfSum.TabIndex = 26;
            this.labResultOfSum.Text = "=";
            // 
            // labResultOfFact
            // 
            this.labResultOfFact.AutoSize = true;
            this.labResultOfFact.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultOfFact.Location = new System.Drawing.Point(59, 141);
            this.labResultOfFact.Name = "labResultOfFact";
            this.labResultOfFact.Size = new System.Drawing.Size(24, 21);
            this.labResultOfFact.TabIndex = 25;
            this.labResultOfFact.Text = "=";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(311, 311);
            this.Controls.Add(this.labResultOfRoot);
            this.Controls.Add(this.labResultOfSum);
            this.Controls.Add(this.labResultOfFact);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnFacorial);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSumation);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSumation;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFacorial;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Label labResultOfRoot;
        private System.Windows.Forms.Label labResultOfSum;
        private System.Windows.Forms.Label labResultOfFact;
    }
}