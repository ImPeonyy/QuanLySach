namespace QuanLySach
{
    partial class Main
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.timKiemInput = new System.Windows.Forms.TextBox();
            this.timKiemLabel = new System.Windows.Forms.Label();
            this.theLoaiLabel = new System.Windows.Forms.Label();
            this.theLoaiInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tacGiaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maSachInput = new System.Windows.Forms.TextBox();
            this.timBtn = new System.Windows.Forms.Button();
            this.timBtnTG = new System.Windows.Forms.Button();
            this.timBtnTM = new System.Windows.Forms.Button();
            this.timBtnTL = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(357, 89);
            this.dtgv.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(557, 421);
            this.dtgv.TabIndex = 0;
            // 
            // timKiemInput
            // 
            this.timKiemInput.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemInput.Location = new System.Drawing.Point(13, 115);
            this.timKiemInput.Margin = new System.Windows.Forms.Padding(4);
            this.timKiemInput.Multiline = true;
            this.timKiemInput.Name = "timKiemInput";
            this.timKiemInput.Size = new System.Drawing.Size(250, 43);
            this.timKiemInput.TabIndex = 1;
            // 
            // timKiemLabel
            // 
            this.timKiemLabel.AutoSize = true;
            this.timKiemLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemLabel.Location = new System.Drawing.Point(13, 89);
            this.timKiemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timKiemLabel.Name = "timKiemLabel";
            this.timKiemLabel.Size = new System.Drawing.Size(90, 22);
            this.timKiemLabel.TabIndex = 2;
            this.timKiemLabel.Text = "Tìm Kiếm";
            // 
            // theLoaiLabel
            // 
            this.theLoaiLabel.AutoSize = true;
            this.theLoaiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theLoaiLabel.Location = new System.Drawing.Point(13, 417);
            this.theLoaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.theLoaiLabel.Name = "theLoaiLabel";
            this.theLoaiLabel.Size = new System.Drawing.Size(180, 22);
            this.theLoaiLabel.TabIndex = 3;
            this.theLoaiLabel.Text = "Tìm Kiếm (Thể Loại)";
            // 
            // theLoaiInput
            // 
            this.theLoaiInput.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theLoaiInput.FormattingEnabled = true;
            this.theLoaiInput.Location = new System.Drawing.Point(17, 453);
            this.theLoaiInput.Name = "theLoaiInput";
            this.theLoaiInput.Size = new System.Drawing.Size(251, 39);
            this.theLoaiInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm Kiếm (Theo Tác Giả)";
            // 
            // tacGiaInput
            // 
            this.tacGiaInput.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tacGiaInput.Location = new System.Drawing.Point(13, 227);
            this.tacGiaInput.Margin = new System.Windows.Forms.Padding(4);
            this.tacGiaInput.Multiline = true;
            this.tacGiaInput.Name = "tacGiaInput";
            this.tacGiaInput.Size = new System.Drawing.Size(250, 48);
            this.tacGiaInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(348, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peonyy~ Coffee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tìm Kiếm (Theo Mã)";
            // 
            // maSachInput
            // 
            this.maSachInput.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSachInput.Location = new System.Drawing.Point(12, 342);
            this.maSachInput.Margin = new System.Windows.Forms.Padding(4);
            this.maSachInput.Multiline = true;
            this.maSachInput.Name = "maSachInput";
            this.maSachInput.Size = new System.Drawing.Size(250, 48);
            this.maSachInput.TabIndex = 9;
            // 
            // timBtn
            // 
            this.timBtn.Location = new System.Drawing.Point(270, 115);
            this.timBtn.Name = "timBtn";
            this.timBtn.Size = new System.Drawing.Size(52, 43);
            this.timBtn.TabIndex = 10;
            this.timBtn.Text = "Tìm";
            this.timBtn.UseVisualStyleBackColor = true;
            this.timBtn.Click += new System.EventHandler(this.timBtn_Click);
            // 
            // timBtnTG
            // 
            this.timBtnTG.Location = new System.Drawing.Point(274, 227);
            this.timBtnTG.Name = "timBtnTG";
            this.timBtnTG.Size = new System.Drawing.Size(52, 48);
            this.timBtnTG.TabIndex = 11;
            this.timBtnTG.Text = "Tìm";
            this.timBtnTG.UseVisualStyleBackColor = true;
            this.timBtnTG.Click += new System.EventHandler(this.timBtnTG_Click);
            // 
            // timBtnTM
            // 
            this.timBtnTM.Location = new System.Drawing.Point(274, 342);
            this.timBtnTM.Name = "timBtnTM";
            this.timBtnTM.Size = new System.Drawing.Size(52, 48);
            this.timBtnTM.TabIndex = 12;
            this.timBtnTM.Text = "Tìm";
            this.timBtnTM.UseVisualStyleBackColor = true;
            this.timBtnTM.Click += new System.EventHandler(this.timBtnTM_Click);
            // 
            // timBtnTL
            // 
            this.timBtnTL.Location = new System.Drawing.Point(274, 453);
            this.timBtnTL.Name = "timBtnTL";
            this.timBtnTL.Size = new System.Drawing.Size(52, 30);
            this.timBtnTL.TabIndex = 13;
            this.timBtnTL.Text = "Tìm";
            this.timBtnTL.UseVisualStyleBackColor = true;
            this.timBtnTL.Click += new System.EventHandler(this.timBtnTL_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(36, 16);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(78, 49);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(825, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(78, 49);
            this.refresh.TabIndex = 15;
            this.refresh.Text = "Làm mới";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(961, 535);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.timBtnTL);
            this.Controls.Add(this.timBtnTM);
            this.Controls.Add(this.timBtnTG);
            this.Controls.Add(this.timBtn);
            this.Controls.Add(this.maSachInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tacGiaInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.theLoaiInput);
            this.Controls.Add(this.theLoaiLabel);
            this.Controls.Add(this.timKiemLabel);
            this.Controls.Add(this.timKiemInput);
            this.Controls.Add(this.dtgv);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox timKiemInput;
        private System.Windows.Forms.Label timKiemLabel;
        private System.Windows.Forms.Label theLoaiLabel;
        private System.Windows.Forms.ComboBox theLoaiInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tacGiaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maSachInput;
        private System.Windows.Forms.Button timBtn;
        private System.Windows.Forms.Button timBtnTG;
        private System.Windows.Forms.Button timBtnTM;
        private System.Windows.Forms.Button timBtnTL;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button refresh;
    }
}