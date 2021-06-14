
namespace UI.BookStore
{
    partial class FormBase
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.TLWindowsButtons = new System.Windows.Forms.TableLayoutPanel();
            this.pnClose = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnResize = new System.Windows.Forms.Panel();
            this.btnResize = new System.Windows.Forms.Button();
            this.pnMin = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.TLWindowsButtons.SuspendLayout();
            this.pnClose.SuspendLayout();
            this.pnResize.SuspendLayout();
            this.pnMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.TLWindowsButtons);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1110, 36);
            this.pnTop.TabIndex = 0;
            // 
            // TLWindowsButtons
            // 
            this.TLWindowsButtons.ColumnCount = 3;
            this.TLWindowsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLWindowsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLWindowsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLWindowsButtons.Controls.Add(this.pnClose, 2, 0);
            this.TLWindowsButtons.Controls.Add(this.pnResize, 1, 0);
            this.TLWindowsButtons.Controls.Add(this.pnMin, 0, 0);
            this.TLWindowsButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.TLWindowsButtons.Location = new System.Drawing.Point(1000, 0);
            this.TLWindowsButtons.Name = "TLWindowsButtons";
            this.TLWindowsButtons.RowCount = 1;
            this.TLWindowsButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLWindowsButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLWindowsButtons.Size = new System.Drawing.Size(110, 36);
            this.TLWindowsButtons.TabIndex = 0;
            // 
            // pnClose
            // 
            this.pnClose.Controls.Add(this.btnClose);
            this.pnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnClose.Location = new System.Drawing.Point(75, 3);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(32, 30);
            this.pnClose.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnResize
            // 
            this.pnResize.Controls.Add(this.btnResize);
            this.pnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnResize.Location = new System.Drawing.Point(39, 3);
            this.pnResize.Name = "pnResize";
            this.pnResize.Size = new System.Drawing.Size(30, 30);
            this.pnResize.TabIndex = 1;
            // 
            // btnResize
            // 
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResize.Location = new System.Drawing.Point(0, 0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(30, 30);
            this.btnResize.TabIndex = 3;
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // pnMin
            // 
            this.pnMin.Controls.Add(this.btnMin);
            this.pnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMin.Location = new System.Drawing.Point(3, 3);
            this.pnMin.Name = "pnMin";
            this.pnMin.Size = new System.Drawing.Size(30, 30);
            this.pnMin.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // pnBody
            // 
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 36);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1110, 773);
            this.pnBody.TabIndex = 1;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 809);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.pnTop.ResumeLayout(false);
            this.TLWindowsButtons.ResumeLayout(false);
            this.pnClose.ResumeLayout(false);
            this.pnResize.ResumeLayout(false);
            this.pnMin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnTop;
        public System.Windows.Forms.Panel pnBody;
        public System.Windows.Forms.TableLayoutPanel TLWindowsButtons;
        public System.Windows.Forms.Panel pnClose;
        public System.Windows.Forms.Panel pnResize;
        public System.Windows.Forms.Panel pnMin;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnResize;
        public System.Windows.Forms.Button btnMin;
    }
}