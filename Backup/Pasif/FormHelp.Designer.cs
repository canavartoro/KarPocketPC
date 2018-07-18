namespace AmbarPPC
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.comboMetod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelProc = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSqlProc = new System.Windows.Forms.TextBox();
            this.panelProc.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.Add(this.toolBarButton1);
            this.toolBar1.Buttons.Add(this.toolBarButton2);
            this.toolBar1.Buttons.Add(this.toolBarButton3);
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            // 
            // comboMetod
            // 
            this.comboMetod.Location = new System.Drawing.Point(79, 56);
            this.comboMetod.Name = "comboMetod";
            this.comboMetod.Size = new System.Drawing.Size(158, 23);
            this.comboMetod.TabIndex = 1;
            this.comboMetod.SelectedIndexChanged += new System.EventHandler(this.comboMetod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.Text = "Modül Adi";
            // 
            // txtModul
            // 
            this.txtModul.BackColor = System.Drawing.Color.White;
            this.txtModul.Location = new System.Drawing.Point(79, 27);
            this.txtModul.Name = "txtModul";
            this.txtModul.ReadOnly = true;
            this.txtModul.Size = new System.Drawing.Size(158, 23);
            this.txtModul.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.Text = "Metod Adi";
            // 
            // txtLabel
            // 
            this.txtLabel.BackColor = System.Drawing.Color.White;
            this.txtLabel.Location = new System.Drawing.Point(79, 85);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.ReadOnly = true;
            this.txtLabel.Size = new System.Drawing.Size(158, 23);
            this.txtLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.Text = "Etiket Metni";
            // 
            // txtProc
            // 
            this.txtProc.BackColor = System.Drawing.Color.White;
            this.txtProc.Location = new System.Drawing.Point(79, 114);
            this.txtProc.Multiline = true;
            this.txtProc.Name = "txtProc";
            this.txtProc.ReadOnly = true;
            this.txtProc.Size = new System.Drawing.Size(158, 92);
            this.txtProc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.Text = "Prosedur";
            // 
            // txtDefin
            // 
            this.txtDefin.BackColor = System.Drawing.Color.White;
            this.txtDefin.Location = new System.Drawing.Point(79, 212);
            this.txtDefin.Multiline = true;
            this.txtDefin.Name = "txtDefin";
            this.txtDefin.ReadOnly = true;
            this.txtDefin.Size = new System.Drawing.Size(158, 92);
            this.txtDefin.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.Text = "Açiklama";
            // 
            // panelProc
            // 
            this.panelProc.BackColor = System.Drawing.Color.White;
            this.panelProc.Controls.Add(this.button1);
            this.panelProc.Controls.Add(this.txtSqlProc);
            this.panelProc.Location = new System.Drawing.Point(6, 174);
            this.panelProc.Name = "panelProc";
            this.panelProc.Size = new System.Drawing.Size(234, 290);
            this.panelProc.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSqlProc
            // 
            this.txtSqlProc.BackColor = System.Drawing.SystemColors.Info;
            this.txtSqlProc.Location = new System.Drawing.Point(3, 6);
            this.txtSqlProc.Multiline = true;
            this.txtSqlProc.Name = "txtSqlProc";
            this.txtSqlProc.ReadOnly = true;
            this.txtSqlProc.Size = new System.Drawing.Size(228, 251);
            this.txtSqlProc.TabIndex = 0;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.panelProc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDefin);
            this.Controls.Add(this.txtProc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMetod);
            this.Controls.Add(this.toolBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHelp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHelp_Load);
            this.panelProc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ComboBox comboMetod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelProc;
        private System.Windows.Forms.TextBox txtSqlProc;
        private System.Windows.Forms.Button button1;
    }
}