using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
//using DevExpress.XtraLayout.Converter;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace label
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public MainView()
        {
            InitializeComponent();
        }
        private void Show_Picture()//显示全部图片列表
        {
            this.imageList1.Images.Clear();
            this.全部图片列表.Items.Clear();
            config.init();

            for (int i = 0; i < config.ImagePaths.Count; i++)
            {
                string picDirPath = config.ImagePaths[i];//获取文件完整目录
                Image img = ImageRead.justread(picDirPath);
                this.imageList1.Images.Add(img);//图片加载到ImageList控件和imageList图片列表

                config.DisplayArea.Add(new Rectangle(0, 0, img.Width, img.Height));
                config.Thresholds_List.Add(new Point(0, 50));
                config.Original_List.Add(img);
                config.Binary_List.Add(null);
                config.Reco_List.Add(null);
                config.DT_List.Add(null);
            }
            //开始绑定
            this.全部图片列表.BeginUpdate();
            for (int i = 0; i < imageList1.Images.Count; i++)//增加图片至ListView控件中
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "图片" + (i + 1);
                this.全部图片列表.Items.Add(lvi);
            }
            this.全部图片列表.EndUpdate();
        }

        private void 全部图片列表_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectitem = 全部图片列表.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
            if (selectitem != null)
                pictureBox1.Image = imageList1.Images[selectitem.ImageIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 打开按钮_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "请选择图片";
            d.Filter = "图片文件|*.tif;*.tiff;*.jpg;*.jpeg;*.png;*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                config.ImagePaths.Clear();
                foreach (string Path in Directory.GetFiles(System.IO.Path.GetDirectoryName(d.FileName)))
                {
                    config.ImagePaths.Add(Path);
                }
                if (config.ImagePaths.Count != 0)
                {
                    config.ImageCount = config.ImagePaths.Count;
                }

                config.nowCount = config.ImagePaths.IndexOf(d.FileName) + 1;
                //Change.changewindow("图片页", 主界面_tabControl1);
                Show_Picture();//显示全部图片列表
                //Init_picture();//image初始化
                //picturesize_init();//画布尺寸初始化
            }
        }

        private void 生成_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
