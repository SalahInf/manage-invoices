namespace Facture_Project.FRM
{
    partial class FRMSocieté
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSocieté));
            this.GRP = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.LbNOM = new System.Windows.Forms.Label();
            this.Lbnumero = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.LBAddresse = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Societé = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // GRP
            // 
            this.GRP.Controls.Add(this.txtNumero);
            this.GRP.Controls.Add(this.txtAdresse);
            this.GRP.Controls.Add(this.LbNOM);
            this.GRP.Controls.Add(this.Lbnumero);
            this.GRP.Controls.Add(this.txtNom);
            this.GRP.Controls.Add(this.LBAddresse);
            this.GRP.Location = new System.Drawing.Point(12, 147);
            this.GRP.Name = "GRP";
            this.GRP.Size = new System.Drawing.Size(259, 180);
            this.GRP.TabIndex = 8;
            this.GRP.TabStop = false;
            this.GRP.Text = "Cordonner";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(121, 82);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 27);
            this.txtNumero.TabIndex = 5;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(121, 126);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(129, 48);
            this.txtAdresse.TabIndex = 6;
            // 
            // LbNOM
            // 
            this.LbNOM.AutoSize = true;
            this.LbNOM.Location = new System.Drawing.Point(6, 42);
            this.LbNOM.Name = "LbNOM";
            this.LbNOM.Size = new System.Drawing.Size(80, 13);
            this.LbNOM.TabIndex = 1;
            this.LbNOM.Text = "Nom de societé";
            // 
            // Lbnumero
            // 
            this.Lbnumero.AutoSize = true;
            this.Lbnumero.Location = new System.Drawing.Point(8, 85);
            this.Lbnumero.Name = "Lbnumero";
            this.Lbnumero.Size = new System.Drawing.Size(96, 13);
            this.Lbnumero.TabIndex = 2;
            this.Lbnumero.Text = "Numero de societé";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(121, 39);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 28);
            this.txtNom.TabIndex = 4;
            // 
            // LBAddresse
            // 
            this.LBAddresse.AutoSize = true;
            this.LBAddresse.Location = new System.Drawing.Point(6, 129);
            this.LBAddresse.Name = "LBAddresse";
            this.LBAddresse.Size = new System.Drawing.Size(98, 13);
            this.LBAddresse.TabIndex = 3;
            this.LBAddresse.Text = "Adresse de societé";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Societé});
            this.ribbonControl1.Size = new System.Drawing.Size(277, 141);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sauvgarder";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // Societé
            // 
            this.Societé.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Societé.Name = "Societé";
            this.Societé.Text = "Societé";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nouveau Service";
            // 
            // FRMSocieté
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 342);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.GRP);
            this.Name = "FRMSocieté";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMSocieté";
            this.GRP.ResumeLayout(false);
            this.GRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GRP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label LbNOM;
        private System.Windows.Forms.Label Lbnumero;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label LBAddresse;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage Societé;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}