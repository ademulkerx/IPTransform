namespace IPTransform
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
            this.Btn_Set_Ip = new DevExpress.XtraEditors.SimpleButton();
            this.RBtn_Oto = new System.Windows.Forms.RadioButton();
            this.RBtn_Man = new System.Windows.Forms.RadioButton();
            this.Cbox_NetworkList = new System.Windows.Forms.ComboBox();
            this.Txt_Ip = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Mask = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Ip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mask.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Set_Ip
            // 
            this.Btn_Set_Ip.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Set_Ip.Appearance.Options.UseFont = true;
            this.Btn_Set_Ip.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Set_Ip.ImageOptions.Image")));
            this.Btn_Set_Ip.Location = new System.Drawing.Point(59, 149);
            this.Btn_Set_Ip.Name = "Btn_Set_Ip";
            this.Btn_Set_Ip.Size = new System.Drawing.Size(101, 48);
            this.Btn_Set_Ip.TabIndex = 0;
            this.Btn_Set_Ip.Text = "SET IP";
            this.Btn_Set_Ip.Click += new System.EventHandler(this.Btn_Set_Ip_Click);
            // 
            // RBtn_Oto
            // 
            this.RBtn_Oto.AutoSize = true;
            this.RBtn_Oto.Location = new System.Drawing.Point(59, 19);
            this.RBtn_Oto.Name = "RBtn_Oto";
            this.RBtn_Oto.Size = new System.Drawing.Size(81, 17);
            this.RBtn_Oto.TabIndex = 1;
            this.RBtn_Oto.TabStop = true;
            this.RBtn_Oto.Text = "OTOMATİK";
            this.RBtn_Oto.UseVisualStyleBackColor = true;
            this.RBtn_Oto.CheckedChanged += new System.EventHandler(this.RBtn_Oto_CheckedChanged);
            // 
            // RBtn_Man
            // 
            this.RBtn_Man.AutoSize = true;
            this.RBtn_Man.Location = new System.Drawing.Point(173, 19);
            this.RBtn_Man.Name = "RBtn_Man";
            this.RBtn_Man.Size = new System.Drawing.Size(70, 17);
            this.RBtn_Man.TabIndex = 2;
            this.RBtn_Man.TabStop = true;
            this.RBtn_Man.Text = "MANUEL";
            this.RBtn_Man.UseVisualStyleBackColor = true;
            this.RBtn_Man.CheckedChanged += new System.EventHandler(this.RBtn_Man_CheckedChanged);
            // 
            // Cbox_NetworkList
            // 
            this.Cbox_NetworkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_NetworkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cbox_NetworkList.FormattingEnabled = true;
            this.Cbox_NetworkList.Location = new System.Drawing.Point(2, 12);
            this.Cbox_NetworkList.Name = "Cbox_NetworkList";
            this.Cbox_NetworkList.Size = new System.Drawing.Size(391, 28);
            this.Cbox_NetworkList.TabIndex = 4;
            this.Cbox_NetworkList.SelectedIndexChanged += new System.EventHandler(this.Cbox_NetworkList_SelectedIndexChanged);
            // 
            // Txt_Ip
            // 
            this.Txt_Ip.Location = new System.Drawing.Point(99, 75);
            this.Txt_Ip.Name = "Txt_Ip";
            this.Txt_Ip.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Ip.Properties.Appearance.Options.UseFont = true;
            this.Txt_Ip.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.Txt_Ip.Properties.MaskSettings.Set("mask", "999.999.999.999");
            this.Txt_Ip.Size = new System.Drawing.Size(160, 22);
            this.Txt_Ip.TabIndex = 5;
            this.Txt_Ip.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_Ip_PreviewKeyDown);
            // 
            // Txt_Mask
            // 
            this.Txt_Mask.Location = new System.Drawing.Point(99, 103);
            this.Txt_Mask.Name = "Txt_Mask";
            this.Txt_Mask.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Mask.Properties.Appearance.Options.UseFont = true;
            this.Txt_Mask.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.Txt_Mask.Properties.MaskSettings.Set("mask", "999.999.999.999");
            this.Txt_Mask.Size = new System.Drawing.Size(160, 22);
            this.Txt_Mask.TabIndex = 6;
            this.Txt_Mask.Click += new System.EventHandler(this.Txt_Mask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MASK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtn_Oto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_Set_Ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RBtn_Man);
            this.groupBox1.Controls.Add(this.Txt_Mask);
            this.groupBox1.Controls.Add(this.Txt_Ip);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 220);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(396, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cbox_NetworkList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "IP Transform V1.02";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Ip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mask.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_Set_Ip;
        private System.Windows.Forms.RadioButton RBtn_Oto;
        private System.Windows.Forms.RadioButton RBtn_Man;
        private System.Windows.Forms.ComboBox Cbox_NetworkList;
        private DevExpress.XtraEditors.TextEdit Txt_Ip;
        private DevExpress.XtraEditors.TextEdit Txt_Mask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

