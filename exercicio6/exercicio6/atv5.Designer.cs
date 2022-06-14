namespace exercicio6
{
    partial class atv5
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
            this.components = new System.ComponentModel.Container();
            this.txtValT = new System.Windows.Forms.TextBox();
            this.txtValP = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValT
            // 
            this.txtValT.Location = new System.Drawing.Point(386, 154);
            this.txtValT.Name = "txtValT";
            this.txtValT.Size = new System.Drawing.Size(117, 20);
            this.txtValT.TabIndex = 0;
            // 
            // txtValP
            // 
            this.txtValP.Location = new System.Drawing.Point(248, 154);
            this.txtValP.Name = "txtValP";
            this.txtValP.Size = new System.Drawing.Size(117, 20);
            this.txtValP.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(248, 199);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(43, 23);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "OSWALDO MITO";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // atv5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtValP);
            this.Controls.Add(this.txtValT);
            this.Name = "atv5";
            this.Text = "atv5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValT;
        private System.Windows.Forms.TextBox txtValP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTotal;
    }
}