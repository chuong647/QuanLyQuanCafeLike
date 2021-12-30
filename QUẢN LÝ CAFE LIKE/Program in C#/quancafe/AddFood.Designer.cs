
namespace quancafe
{
    partial class frmAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFood));
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.txtSTT = new System.Windows.Forms.Label();
            this.txtBan = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbFood
            // 
            this.cbbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(130, 138);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(283, 30);
            this.cbbFood.TabIndex = 38;
            // 
            // txtSTT
            // 
            this.txtSTT.BackColor = System.Drawing.Color.White;
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtSTT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSTT.Location = new System.Drawing.Point(130, 30);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(283, 27);
            this.txtSTT.TabIndex = 37;
            // 
            // txtBan
            // 
            this.txtBan.BackColor = System.Drawing.Color.White;
            this.txtBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBan.Location = new System.Drawing.Point(130, 81);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(283, 29);
            this.txtBan.TabIndex = 36;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1.Location = new System.Drawing.Point(10, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 25);
            this.lbl1.TabIndex = 32;
            this.lbl1.Text = "Trạng thái:";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMon.Location = new System.Drawing.Point(59, 138);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(57, 25);
            this.lblMon.TabIndex = 28;
            this.lblMon.Text = "Món:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTable.Location = new System.Drawing.Point(63, 81);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(53, 25);
            this.lblTable.TabIndex = 27;
            this.lblTable.Text = "Bàn:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cbbFood);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.txtBan);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.cbbCount);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.lblMon);
            this.groupBox1.Controls.Add(this.lblTable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm món";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(352, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 53);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbCount
            // 
            this.cbbCount.BackColor = System.Drawing.Color.White;
            this.cbbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbbCount.Location = new System.Drawing.Point(130, 195);
            this.cbbCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cbbCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbCount.Name = "cbbCount";
            this.cbbCount.Size = new System.Drawing.Size(190, 28);
            this.cbbCount.TabIndex = 31;
            this.cbbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbbCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCount.Location = new System.Drawing.Point(20, 195);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(96, 25);
            this.lblCount.TabIndex = 30;
            this.lblCount.Text = "Số lượng:";
            // 
            // frmAddFood
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(497, 306);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món";
            this.Load += new System.EventHandler(this.frmAddFood_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Label txtSTT;
        private System.Windows.Forms.Label txtBan;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.NumericUpDown cbbCount;
        private System.Windows.Forms.Label lblCount;
    }
}