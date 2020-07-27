namespace label
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.全部图片列表 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.打开按钮 = new DevExpress.XtraBars.BarButtonItem();
            this.存储文件夹 = new DevExpress.XtraBars.BarButtonItem();
            this.切换 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.下一张 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.划定 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.生成 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.智能框取 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemBreadCrumbEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.标签名称 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBreadCrumbEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 全部图片列表
            // 
            this.全部图片列表.HideSelection = false;
            this.全部图片列表.LargeImageList = this.imageList1;
            this.全部图片列表.Location = new System.Drawing.Point(0, 204);
            this.全部图片列表.Name = "全部图片列表";
            this.全部图片列表.Size = new System.Drawing.Size(285, 834);
            this.全部图片列表.TabIndex = 1;
            this.全部图片列表.UseCompatibleStateImageBehavior = false;
            this.全部图片列表.SelectedIndexChanged += new System.EventHandler(this.全部图片列表_SelectedIndexChanged_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 834);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.切换,
            this.划定});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "打标签";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.打开按钮);
            this.ribbonPageGroup2.ItemLinks.Add(this.存储文件夹);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "文件";
            // 
            // 打开按钮
            // 
            this.打开按钮.Caption = "打开文件夹";
            this.打开按钮.Id = 2;
            this.打开按钮.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("打开按钮.ImageOptions.Image")));
            this.打开按钮.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("打开按钮.ImageOptions.LargeImage")));
            this.打开按钮.Name = "打开按钮";
            this.打开按钮.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.打开按钮_ItemClick);
            // 
            // 存储文件夹
            // 
            this.存储文件夹.Caption = "存储文件夹";
            this.存储文件夹.Id = 9;
            this.存储文件夹.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("存储文件夹.ImageOptions.Image")));
            this.存储文件夹.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("存储文件夹.ImageOptions.LargeImage")));
            this.存储文件夹.Name = "存储文件夹";
            // 
            // 切换
            // 
            this.切换.ItemLinks.Add(this.下一张);
            this.切换.ItemLinks.Add(this.barButtonItem5);
            this.切换.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.切换.Name = "切换";
            this.切换.Text = "切换";
            // 
            // 下一张
            // 
            this.下一张.Caption = "下一张";
            this.下一张.Id = 6;
            this.下一张.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("下一张.ImageOptions.Image")));
            this.下一张.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("下一张.ImageOptions.LargeImage")));
            this.下一张.Name = "下一张";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "上一张";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // 划定
            // 
            this.划定.ItemLinks.Add(this.生成);
            this.划定.ItemLinks.Add(this.barButtonItem4);
            this.划定.ItemLinks.Add(this.智能框取);
            this.划定.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.划定.Name = "划定";
            this.划定.Text = "划定";
            // 
            // 生成
            // 
            this.生成.Caption = "生成矩形框";
            this.生成.Id = 8;
            this.生成.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("生成.ImageOptions.Image")));
            this.生成.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("生成.ImageOptions.LargeImage")));
            this.生成.Name = "生成";
            this.生成.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.生成_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "取消矩形框";
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // 智能框取
            // 
            this.智能框取.Caption = "智能框取";
            this.智能框取.Id = 15;
            this.智能框取.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("智能框取.ImageOptions.Image")));
            this.智能框取.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("智能框取.ImageOptions.LargeImage")));
            this.智能框取.Name = "智能框取";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "打开";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "更改";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.打开按钮,
            this.barButtonItem3,
            this.下一张,
            this.barButtonItem5,
            this.生成,
            this.存储文件夹,
            this.barSubItem1,
            this.barButtonItem4,
            this.barEditItem1,
            this.barButtonItem6,
            this.智能框取});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemBreadCrumbEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(2993, 197);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 10;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemBreadCrumbEdit1;
            this.barEditItem1.Id = 13;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemBreadCrumbEdit1
            // 
            this.repositoryItemBreadCrumbEdit1.AutoHeight = false;
            this.repositoryItemBreadCrumbEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBreadCrumbEdit1.Name = "repositoryItemBreadCrumbEdit1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 14;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1040);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.标签名称);
            this.panel1.Location = new System.Drawing.Point(1505, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 545);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // 标签名称
            // 
            this.标签名称.AutoSize = true;
            this.标签名称.Location = new System.Drawing.Point(45, 56);
            this.标签名称.Name = "标签名称";
            this.标签名称.Size = new System.Drawing.Size(73, 18);
            this.标签名称.TabIndex = 0;
            this.标签名称.Text = "标签名称:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1040);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.全部图片列表);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "古生物智能鉴定系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBreadCrumbEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView 全部图片列表;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem 打开按钮;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup 切换;
        private DevExpress.XtraBars.BarButtonItem 下一张;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup 划定;
        private DevExpress.XtraBars.BarButtonItem 生成;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem 存储文件夹;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit repositoryItemBreadCrumbEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem 智能框取;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label 标签名称;
    }
}

