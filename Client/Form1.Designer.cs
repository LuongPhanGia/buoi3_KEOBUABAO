namespace Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourS = new System.Windows.Forms.TextBox();
            this.txtYourR = new System.Windows.Forms.TextBox();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnKeo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Your Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Your Selection:";
            // 
            // txtYourS
            // 
            this.txtYourS.Location = new System.Drawing.Point(94, 6);
            this.txtYourS.Name = "txtYourS";
            this.txtYourS.Size = new System.Drawing.Size(160, 20);
            this.txtYourS.TabIndex = 45;
            // 
            // txtYourR
            // 
            this.txtYourR.Location = new System.Drawing.Point(94, 156);
            this.txtYourR.Name = "txtYourR";
            this.txtYourR.Size = new System.Drawing.Size(160, 20);
            this.txtYourR.TabIndex = 44;
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(229, 58);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(86, 66);
            this.btnBua.TabIndex = 43;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(122, 58);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(90, 66);
            this.btnBao.TabIndex = 42;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(15, 58);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(88, 66);
            this.btnKeo.TabIndex = 41;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYourS);
            this.Controls.Add(this.txtYourR);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnKeo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYourS;
        private System.Windows.Forms.TextBox txtYourR;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnKeo;
    }
}

