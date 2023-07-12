namespace CatFacts
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
            this.lblCatFactText = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCatFactText
            // 
            this.lblCatFactText.AutoSize = true;
            this.lblCatFactText.Font = new System.Drawing.Font("Domkrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatFactText.Location = new System.Drawing.Point(226, 76);
            this.lblCatFactText.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCatFactText.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblCatFactText.Name = "lblCatFactText";
            this.lblCatFactText.Size = new System.Drawing.Size(135, 30);
            this.lblCatFactText.TabIndex = 0;
            this.lblCatFactText.Text = "Cat Fact Here";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(204, 410);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(178, 73);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(587, 502);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCatFactText);
            this.Font = new System.Drawing.Font("Domkrat", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cat Fact Provider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatFactText;
        private System.Windows.Forms.Button btnRefresh;
    }
}

