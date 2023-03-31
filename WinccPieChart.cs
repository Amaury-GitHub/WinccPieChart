using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinccPieChart
{
    public partial class WinccPieChart: UserControl
    {
        //图表参数//
        //背景色
        private Color iBackColor = Color.White;
        //背景的宽度
        private short iBackWidth = 200;
        //背景的高度
        private short iBackHeight = 200;
        //标签的字体
        private Font iElementFont = new Font("微软雅黑", 9);
        //是否使用3D饼图, false=2D, true=3D
        private bool iEnable3D = false;
        //是否将标签移动到外面, false=显示在饼图内部, true=显示在饼图外部
        private bool iPieLabelStyle = false;
        //是否显示元素名称, false=不显示, true=显示
        private bool iEnableLabel = false;
        //是否显示元素数值, false=不显示, true=显示
        private bool iEnableValue = false;
        //图表参数//

        //元素参数//
        //元素的启用与屏蔽,默认使用2个元素
        private bool iElement0Enable = true;
        private bool iElement1Enable = true;
        private bool iElement2Enable = false;
        private bool iElement3Enable = false;
        private bool iElement4Enable = false;
        private bool iElement5Enable = false;
        private bool iElement6Enable = false;
        private bool iElement7Enable = false;
        //元素的初始值
        private short iElement0Value = 1;
        private short iElement1Value = 1;
        private short iElement2Value = 1;
        private short iElement3Value = 1;
        private short iElement4Value = 1;
        private short iElement5Value = 1;
        private short iElement6Value = 1;
        private short iElement7Value = 1;
        //元素的初始颜色
        private Color iElement0Color = Color.Green;
        private Color iElement1Color = Color.Red;
        private Color iElement2Color = Color.Yellow;
        private Color iElement3Color = Color.Green;
        private Color iElement4Color = Color.Red;
        private Color iElement5Color = Color.Yellow;
        private Color iElement6Color = Color.Green;
        private Color iElement7Color = Color.Red;
        //元素的初始名称
        private string iElement0Label = "Element0";
        private string iElement1Label = "Element1";
        private string iElement2Label = "Element2";
        private string iElement3Label = "Element3";
        private string iElement4Label = "Element4";
        private string iElement5Label = "Element5";
        private string iElement6Label = "Element6";
        private string iElement7Label = "Element7";
        //元素参数//

        //映射参数到Wincc的控件区, 分为两个组, 图表组与元素组, 数据改变时调用图表刷新子程序
        //图表参数组
        [Category("Chart Parameters")]
        public Color ChartBackColor
        {
            get
            {
                return iBackColor;
            }
            set
            {
                iBackColor = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public short BackWidth
        {
            get
            {
                return iBackWidth;
            }
            set
            {
                iBackWidth = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public short BackHeight
        {
            get
            {
                return iBackHeight;
            }
            set
            {
                iBackHeight = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public Font ElementFont
        {
            get
            {
                return iElementFont;
            }
            set
            {
                iElementFont = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public bool Enable3D
        {
            get
            {
                return iEnable3D;
            }
            set
            {
                iEnable3D = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public bool PieLabelStyle
        {
            get
            {
                return iPieLabelStyle;
            }
            set
            {
                iPieLabelStyle = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public bool EnableLabel
        {
            get
            {
                return iEnableLabel;
            }
            set
            {
                iEnableLabel = value;
                ChartRefresh();
            }
        }
        [Category("Chart Parameters")]
        public bool EnableValue
        {
            get
            {
                return iEnableValue;
            }
            set
            {
                iEnableValue = value;
                ChartRefresh();
            }
        }
        //图表参数组

        //元素参数组
        [Category("Element Parameters")]
        public bool Element0Enable
        {
            get
            {
                return iElement0Enable;
            }
            set
            {
                iElement0Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element1Enable
        {
            get
            {
                return iElement1Enable;
            }
            set
            {
                iElement1Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element2Enable
        {
            get
            {
                return iElement2Enable;
            }
            set
            {
                iElement2Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element3Enable
        {
            get
            {
                return iElement3Enable;
            }
            set
            {
                iElement3Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element4Enable
        {
            get
            {
                return iElement4Enable;
            }
            set
            {
                iElement4Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element5Enable
        {
            get
            {
                return iElement5Enable;
            }
            set
            {
                iElement5Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element6Enable
        {
            get
            {
                return iElement6Enable;
            }
            set
            {
                iElement6Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public bool Element7Enable
        {
            get
            {
                return iElement7Enable;
            }
            set
            {
                iElement7Enable = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element0Value
        {
            get
            {
                return iElement0Value;
            }
            set
            {
                iElement0Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element1Value
        {
            get
            {
                return iElement1Value;
            }
            set
            {
                iElement1Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element2Value
        {
            get
            {
                return iElement2Value;
            }
            set
            {
                iElement2Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element3Value
        {
            get
            {
                return iElement3Value;
            }
            set
            {
                iElement3Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element4Value
        {
            get
            {
                return iElement4Value;
            }
            set
            {
                iElement4Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element5Value
        {
            get
            {
                return iElement5Value;
            }
            set
            {
                iElement5Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element6Value
        {
            get
            {
                return iElement6Value;
            }
            set
            {
                iElement6Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public short Element7Value
        {
            get
            {
                return iElement7Value;
            }
            set
            {
                iElement7Value = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element0Color
        {
            get
            {
                return iElement0Color;
            }
            set
            {
                iElement0Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element1Color
        {
            get
            {
                return iElement1Color;
            }
            set
            {
                iElement1Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element2Color
        {
            get
            {
                return iElement2Color;
            }
            set
            {
                iElement2Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element3Color
        {
            get
            {
                return iElement3Color;
            }
            set
            {
                iElement3Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element4Color
        {
            get
            {
                return iElement4Color;
            }
            set
            {
                iElement4Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element5Color
        {
            get
            {
                return iElement5Color;
            }
            set
            {
                iElement5Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element6Color
        {
            get
            {
                return iElement6Color;
            }
            set
            {
                iElement6Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public Color Element7Color
        {
            get
            {
                return iElement7Color;
            }
            set
            {
                iElement7Color = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element0Label
        {
            get
            {
                return iElement0Label;
            }
            set
            {
                iElement0Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element1Label
        {
            get
            {
                return iElement1Label;
            }
            set
            {
                iElement1Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element2Label
        {
            get
            {
                return iElement2Label;
            }
            set
            {
                iElement2Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element3Label
        {
            get
            {
                return iElement3Label;
            }
            set
            {
                iElement3Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element4Label
        {
            get
            {
                return iElement4Label;
            }
            set
            {
                iElement4Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element5Label
        {
            get
            {
                return iElement5Label;
            }
            set
            {
                iElement5Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element6Label
        {
            get
            {
                return iElement6Label;
            }
            set
            {
                iElement6Label = value;
                ChartRefresh();
            }
        }
        [Category("Element Parameters")]
        public string Element7Label
        {
            get
            {
                return iElement7Label;
            }
            set
            {
                iElement7Label = value;
                ChartRefresh();
            }
        }
        //元素参数组
        public WinccPieChart()
        {
            InitializeComponent();
        }

        //图表第一次加载
        private void WinccPieChart_Load(object sender, EventArgs e)
        {
            //修改饼图左上角坐标
            chart1.Location = new Point(0, 0);
            //修改饼图边距
            chart1.Margin = new Padding(0);
            //关闭图例
            chart1.Legends[0].Enabled = false;
            //修改图表类型为饼图
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            //修改标签为字符
            chart1.Series[0].XValueType = ChartValueType.String;
            //修改Label在外部时连线的颜色
            chart1.Series[0]["PieLineColor"] = "Black";
            ChartRefresh();
        }

        //图表刷新子程序
        private void ChartRefresh()
        {
            //图表参数组//
            //设置背景色, 同时改变底图的颜色与饼图的颜色
            chart1.ChartAreas[0].BackColor = iBackColor;
            chart1.BackColor = iBackColor;
            //设置底图的尺寸
            chart1.Size = new Size(iBackWidth, iBackHeight);
            //设置标签的字体
            chart1.Series[0].Font = iElementFont;
            //设置饼图的样式
            chart1.ChartAreas[0].Area3DStyle.Enable3D = iEnable3D;
            //设置标签的位置
            if (iPieLabelStyle)
            {
                chart1.Series[0]["PieLabelStyle"] = "Outside";
            }
            else
            {
                chart1.Series[0]["PieLabelStyle"] = "Inside";
            }
            //设置标签的样式, 是否显示名称, 是否显示数值
            if (iEnableLabel && iEnableValue)
            {
                chart1.Series[0].Label = "#VALX\n#VAL\n#PERCENT";
            }
            else if (iEnableLabel && !iEnableValue)
            {
                chart1.Series[0].Label = "#VALX\n#PERCENT";
            }
            else if (!iEnableLabel && iEnableValue)
            {
                chart1.Series[0].Label = "#VAL\n#PERCENT";
            }
            else
            {
                chart1.Series[0].Label = "#PERCENT";
            }
            //图表参数组//

            //元素参数组//
            //判断元素是否启用, 非启用状态数值清0, 避免计算出来的百分比不正确
            if (!iElement0Enable)
            {
                iElement0Value = 0;
            }
            if (!iElement1Enable)
            {
                iElement1Value = 0;
            }
            if (!iElement2Enable)
            {
                iElement2Value = 0;
            }
            if (!iElement3Enable)
            {
                iElement3Value = 0;
            }
            if (!iElement4Enable)
            {
                iElement4Value = 0;
            }
            if (!iElement5Enable)
            {
                iElement5Value = 0;
            }
            if (!iElement6Enable)
            {
                iElement6Value = 0;
            }
            if (!iElement7Enable)
            {
                iElement7Value = 0;
            }
            //启用标志
            chart1.Series[0].Points[0].IsEmpty = !iElement0Enable;
            chart1.Series[0].Points[1].IsEmpty = !iElement1Enable;
            chart1.Series[0].Points[2].IsEmpty = !iElement2Enable;
            chart1.Series[0].Points[3].IsEmpty = !iElement3Enable;
            chart1.Series[0].Points[4].IsEmpty = !iElement4Enable;
            chart1.Series[0].Points[5].IsEmpty = !iElement5Enable;
            chart1.Series[0].Points[6].IsEmpty = !iElement6Enable;
            chart1.Series[0].Points[7].IsEmpty = !iElement7Enable;
            //数值
            chart1.Series[0].Points[0].YValues[0] = iElement0Value;
            chart1.Series[0].Points[1].YValues[0] = iElement1Value;
            chart1.Series[0].Points[2].YValues[0] = iElement2Value;
            chart1.Series[0].Points[3].YValues[0] = iElement3Value;
            chart1.Series[0].Points[4].YValues[0] = iElement4Value;
            chart1.Series[0].Points[5].YValues[0] = iElement5Value;
            chart1.Series[0].Points[6].YValues[0] = iElement6Value;
            chart1.Series[0].Points[7].YValues[0] = iElement7Value;
            //颜色
            chart1.Series[0].Points[0].Color = iElement0Color;
            chart1.Series[0].Points[1].Color = iElement1Color;
            chart1.Series[0].Points[2].Color = iElement2Color;
            chart1.Series[0].Points[3].Color = iElement3Color;
            chart1.Series[0].Points[4].Color = iElement4Color;
            chart1.Series[0].Points[5].Color = iElement5Color;
            chart1.Series[0].Points[6].Color = iElement6Color;
            chart1.Series[0].Points[7].Color = iElement7Color;
            //名称
            chart1.Series[0].Points[0].AxisLabel = iElement0Label;
            chart1.Series[0].Points[1].AxisLabel = iElement1Label;
            chart1.Series[0].Points[2].AxisLabel = iElement2Label;
            chart1.Series[0].Points[3].AxisLabel = iElement3Label;
            chart1.Series[0].Points[4].AxisLabel = iElement4Label;
            chart1.Series[0].Points[5].AxisLabel = iElement5Label;
            chart1.Series[0].Points[6].AxisLabel = iElement6Label;
            chart1.Series[0].Points[7].AxisLabel = iElement7Label;
            //元素参数组//

            //重绘图表
            chart1.Invalidate();
        }
    }
}
