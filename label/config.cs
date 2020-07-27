using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace label
{
    public partial class config
    {
        public static int ImageCount;//图片总数
        public static List<string> ImagePaths = new List<string>();//图片路径列表
        public static int nowCount;//当前图片数索引

        public static double zoom_step = 1.2;//缩放比例
        public static Point mouseDownPoint = new Point();//鼠标按下时的坐标，用于移动和裁剪图片
        public static Point mouseUpPoint = new Point();//鼠标按下时的坐标，用于裁剪图片
        public static Boolean isSelected = false;//鼠标是否按下

        public static int TypeFromIndex;//当前类型表格的行索引
        public static Bitmap g_image;//被修改后的图片
        public static float pixel_step = 1;//比例尺的换算系数

        public static List<Rectangle> DisplayArea = new List<Rectangle>();//识别区域列表
        public static List<Point> Thresholds_List = new List<Point>();//阈值区间列表

        public static List<Image> Original_List = new List<Image>();//原图列表
        public static List<Image> Binary_List = new List<Image>();//二值图列表
        public static List<Image> Reco_List = new List<Image>();//识别图列表
        public static List<DataTable> DT_List = new List<DataTable>();//表格列表

        public static void init()
        {
            Original_List.Clear();
            Binary_List.Clear();
            Reco_List.Clear();
            DisplayArea.Clear();
            Thresholds_List.Clear();
        }
    }
}
