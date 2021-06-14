
namespace UI.Library.CustonControls
{
    partial class PaginatorCustomControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnViewDown = new System.Windows.Forms.Panel();
            this.lbTotalElements = new System.Windows.Forms.Label();
            this.pnPaginateButtons = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbNumPag = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnGoToNext = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnGoToLast = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnGoToFirst = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnGoToBefore = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnNumElement = new System.Windows.Forms.Panel();
            this.pnViewDown.SuspendLayout();
            this.pnPaginateButtons.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnNumElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnViewDown
            // 
            this.pnViewDown.Controls.Add(this.tableLayoutPanel1);
            this.pnViewDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnViewDown.Location = new System.Drawing.Point(0, 0);
            this.pnViewDown.Name = "pnViewDown";
            this.pnViewDown.Size = new System.Drawing.Size(662, 41);
            this.pnViewDown.TabIndex = 2;
            // 
            // lbTotalElements
            // 
            this.lbTotalElements.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalElements.Location = new System.Drawing.Point(176, 0);
            this.lbTotalElements.Name = "lbTotalElements";
            this.lbTotalElements.Size = new System.Drawing.Size(40, 35);
            this.lbTotalElements.TabIndex = 0;
            this.lbTotalElements.Text = "0/0";
            this.lbTotalElements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPaginateButtons
            // 
            this.pnPaginateButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPaginateButtons.Controls.Add(this.panel10);
            this.pnPaginateButtons.Controls.Add(this.panel16);
            this.pnPaginateButtons.Controls.Add(this.panel13);
            this.pnPaginateButtons.Location = new System.Drawing.Point(223, 3);
            this.pnPaginateButtons.Name = "pnPaginateButtons";
            this.pnPaginateButtons.Size = new System.Drawing.Size(214, 35);
            this.pnPaginateButtons.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(74, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(66, 35);
            this.panel10.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbNumPag);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(66, 35);
            this.panel11.TabIndex = 0;
            // 
            // lbNumPag
            // 
            this.lbNumPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumPag.Location = new System.Drawing.Point(0, 0);
            this.lbNumPag.Name = "lbNumPag";
            this.lbNumPag.Size = new System.Drawing.Size(66, 35);
            this.lbNumPag.TabIndex = 4;
            this.lbNumPag.Text = "1/1";
            this.lbNumPag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.tableLayoutPanel3);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(140, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(74, 35);
            this.panel16.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel18, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(74, 35);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnGoToNext);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(31, 29);
            this.panel17.TabIndex = 0;
            // 
            // btnGoToNext
            // 
            this.btnGoToNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToNext.Location = new System.Drawing.Point(0, 0);
            this.btnGoToNext.Name = "btnGoToNext";
            this.btnGoToNext.Size = new System.Drawing.Size(31, 29);
            this.btnGoToNext.TabIndex = 2;
            this.btnGoToNext.Text = ">";
            this.btnGoToNext.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnGoToLast);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(40, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(31, 29);
            this.panel18.TabIndex = 1;
            // 
            // btnGoToLast
            // 
            this.btnGoToLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToLast.Location = new System.Drawing.Point(0, 0);
            this.btnGoToLast.Name = "btnGoToLast";
            this.btnGoToLast.Size = new System.Drawing.Size(31, 29);
            this.btnGoToLast.TabIndex = 0;
            this.btnGoToLast.Text = ">>";
            this.btnGoToLast.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tableLayoutPanel2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(74, 35);
            this.panel13.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel15, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(74, 35);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnGoToFirst);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(31, 29);
            this.panel14.TabIndex = 0;
            // 
            // btnGoToFirst
            // 
            this.btnGoToFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToFirst.Location = new System.Drawing.Point(0, 0);
            this.btnGoToFirst.Name = "btnGoToFirst";
            this.btnGoToFirst.Size = new System.Drawing.Size(31, 29);
            this.btnGoToFirst.TabIndex = 2;
            this.btnGoToFirst.Text = "<<";
            this.btnGoToFirst.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnGoToBefore);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(40, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(31, 29);
            this.panel15.TabIndex = 1;
            // 
            // btnGoToBefore
            // 
            this.btnGoToBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToBefore.Location = new System.Drawing.Point(0, 0);
            this.btnGoToBefore.Name = "btnGoToBefore";
            this.btnGoToBefore.Size = new System.Drawing.Size(31, 29);
            this.btnGoToBefore.TabIndex = 0;
            this.btnGoToBefore.Text = "<";
            this.btnGoToBefore.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnPaginateButtons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnNumElement, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 41);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pnNumElement
            // 
            this.pnNumElement.Controls.Add(this.lbTotalElements);
            this.pnNumElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNumElement.Location = new System.Drawing.Point(443, 3);
            this.pnNumElement.Name = "pnNumElement";
            this.pnNumElement.Size = new System.Drawing.Size(216, 35);
            this.pnNumElement.TabIndex = 5;
            // 
            // PaginatorCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnViewDown);
            this.Name = "PaginatorCustomControl";
            this.Size = new System.Drawing.Size(662, 41);
            this.pnViewDown.ResumeLayout(false);
            this.pnPaginateButtons.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnNumElement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnViewDown;
        private System.Windows.Forms.Label lbTotalElements;
        private System.Windows.Forms.Panel pnPaginateButtons;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbNumPag;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.Button btnGoToNext;
        private System.Windows.Forms.Panel panel18;
        public System.Windows.Forms.Button btnGoToLast;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.Button btnGoToFirst;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.Button btnGoToBefore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnNumElement;
    }
}
