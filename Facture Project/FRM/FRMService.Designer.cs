namespace Facture_Project.FRM
{
    partial class FRMService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMService));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Save = new DevExpress.XtraBars.BarButtonItem();
            this.close = new DevExpress.XtraBars.BarButtonItem();
            this.RIBService = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LbNOM = new System.Windows.Forms.Label();
            this.Lbnumero = new System.Windows.Forms.Label();
            this.LBAddresse = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.GRP = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.GRP.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.Save,
            this.close});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RIBService});
            this.ribbonControl1.Size = new System.Drawing.Size(283, 141);
            // 
            // Save
            // 
            this.Save.Caption = "Sauvgarder";
            this.Save.Id = 1;
            this.Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save.ImageOptions.Image")));
            this.Save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Save.ImageOptions.LargeImage")));
            this.Save.Name = "Save";
            this.Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // close
            // 
            this.close.Caption = "Close";
            this.close.Id = 2;
            this.close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("close.ImageOptions.Image")));
            this.close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("close.ImageOptions.LargeImage")));
            this.close.Name = "close";
            this.close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // RIBService
            // 
            this.RIBService.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.RIBService.Name = "RIBService";
            this.RIBService.Text = "Service";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Save);
            this.ribbonPageGroup1.ItemLinks.Add(this.close);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nouveau Service";
            // 
            // LbNOM
            // 
            this.LbNOM.AutoSize = true;
            this.LbNOM.Location = new System.Drawing.Point(6, 42);
            this.LbNOM.Name = "LbNOM";
            this.LbNOM.Size = new System.Drawing.Size(81, 13);
            this.LbNOM.TabIndex = 1;
            this.LbNOM.Text = "Nom de Service";
            // 
            // Lbnumero
            // 
            this.Lbnumero.AutoSize = true;
            this.Lbnumero.Location = new System.Drawing.Point(8, 85);
            this.Lbnumero.Name = "Lbnumero";
            this.Lbnumero.Size = new System.Drawing.Size(97, 13);
            this.Lbnumero.TabIndex = 2;
            this.Lbnumero.Text = "Numero de Service";
            // 
            // LBAddresse
            // 
            this.LBAddresse.AutoSize = true;
            this.LBAddresse.Location = new System.Drawing.Point(6, 129);
            this.LBAddresse.Name = "LBAddresse";
            this.LBAddresse.Size = new System.Drawing.Size(99, 13);
            this.LBAddresse.TabIndex = 3;
            this.LBAddresse.Text = "Adresse de Service";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(121, 39);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 28);
            this.txtNom.TabIndex = 4;
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
            this.GRP.TabIndex = 7;
            this.GRP.TabStop = false;
            this.GRP.Text = "Cordonner";
            // 
            // FRMService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 344);
            this.Controls.Add(this.GRP);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FRMService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMService";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.GRP.ResumeLayout(false);
            this.GRP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage RIBService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Save;
        private DevExpress.XtraBars.BarButtonItem close;
        private System.Windows.Forms.Label LbNOM;
        private System.Windows.Forms.Label Lbnumero;
        private System.Windows.Forms.Label LBAddresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.GroupBox GRP;
    }
}