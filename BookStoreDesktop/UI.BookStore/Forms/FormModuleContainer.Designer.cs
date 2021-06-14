
namespace UI.BookStore.Forms
{
    partial class FormModuleContainer
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
            this.pnTopLeft = new System.Windows.Forms.Panel();
            this.pnLabelNameDatas = new System.Windows.Forms.Panel();
            this.lbNameDatas = new System.Windows.Forms.Label();
            this.pnImageLogoDatas = new System.Windows.Forms.Panel();
            this.ptbxLogoDatas = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnTopLeft.SuspendLayout();
            this.pnLabelNameDatas.SuspendLayout();
            this.pnImageLogoDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogoDatas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.pnTopLeft);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(3);
            this.pnTop.Size = new System.Drawing.Size(948, 40);
            this.pnTop.TabIndex = 0;
            // 
            // pnTopLeft
            // 
            this.pnTopLeft.Controls.Add(this.pnLabelNameDatas);
            this.pnTopLeft.Controls.Add(this.pnImageLogoDatas);
            this.pnTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTopLeft.Location = new System.Drawing.Point(3, 3);
            this.pnTopLeft.Name = "pnTopLeft";
            this.pnTopLeft.Size = new System.Drawing.Size(170, 34);
            this.pnTopLeft.TabIndex = 3;
            // 
            // pnLabelNameDatas
            // 
            this.pnLabelNameDatas.Controls.Add(this.lbNameDatas);
            this.pnLabelNameDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLabelNameDatas.Location = new System.Drawing.Point(36, 0);
            this.pnLabelNameDatas.Name = "pnLabelNameDatas";
            this.pnLabelNameDatas.Size = new System.Drawing.Size(134, 34);
            this.pnLabelNameDatas.TabIndex = 4;
            // 
            // lbNameDatas
            // 
            this.lbNameDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNameDatas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameDatas.Location = new System.Drawing.Point(0, 0);
            this.lbNameDatas.Name = "lbNameDatas";
            this.lbNameDatas.Size = new System.Drawing.Size(134, 34);
            this.lbNameDatas.TabIndex = 1;
            this.lbNameDatas.Text = "HELLO";
            this.lbNameDatas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnImageLogoDatas
            // 
            this.pnImageLogoDatas.Controls.Add(this.ptbxLogoDatas);
            this.pnImageLogoDatas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImageLogoDatas.Location = new System.Drawing.Point(0, 0);
            this.pnImageLogoDatas.Name = "pnImageLogoDatas";
            this.pnImageLogoDatas.Size = new System.Drawing.Size(36, 34);
            this.pnImageLogoDatas.TabIndex = 3;
            // 
            // ptbxLogoDatas
            // 
            this.ptbxLogoDatas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbxLogoDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxLogoDatas.Location = new System.Drawing.Point(0, 0);
            this.ptbxLogoDatas.Name = "ptbxLogoDatas";
            this.ptbxLogoDatas.Size = new System.Drawing.Size(36, 34);
            this.ptbxLogoDatas.TabIndex = 2;
            this.ptbxLogoDatas.TabStop = false;
            // 
            // pnBody
            // 
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 40);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(948, 674);
            this.pnBody.TabIndex = 1;
            // 
            // FormModuleContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 714);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModuleContainer";
            this.Text = "FormViewDatas";
            this.pnTop.ResumeLayout(false);
            this.pnTopLeft.ResumeLayout(false);
            this.pnLabelNameDatas.ResumeLayout(false);
            this.pnImageLogoDatas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogoDatas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBody;
        public System.Windows.Forms.Label lbNameDatas;
        public System.Windows.Forms.Panel pnTopLeft;
        public System.Windows.Forms.Panel pnLabelNameDatas;
        public System.Windows.Forms.PictureBox ptbxLogoDatas;
        public System.Windows.Forms.Panel pnImageLogoDatas;
    }
}