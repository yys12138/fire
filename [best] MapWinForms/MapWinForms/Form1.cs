using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
//新添加命名空间  
using System.Net;
using System.IO;
using System.Security.Permissions;  //交互JS
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace MapWinForms
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public class PublicValue
        {
            public static double[] startposi= { 116.404, 39.915 };
            public static string q = "河北";
            public static DataTable ds;//医院数据
           

        }

        //读取数据
        public DataSet getData()
        {

            //打开文件

            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";

            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.Cancel)

                return null;

            //判断文件后缀

            //var path = file.FileName;
            var path = "C:/Users/k/Desktop/[best] MapWinForms/新建 Microsoft Excel 工作表.xlsx";

            string fileSuffix = System.IO.Path.GetExtension(path);

            if (string.IsNullOrEmpty(fileSuffix))

                return null;

            using (DataSet ds = new DataSet())
            {

                //判断Excel文件是2003版本还是2007版本

                string connString = "";

                if (fileSuffix == ".xls")

                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";

                else

                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";

                //读取文件

                string sql_select = " SELECT * FROM [Sheet1$]";

                using (OleDbConnection conn = new OleDbConnection(connString))

                using (OleDbDataAdapter cmd = new OleDbDataAdapter(sql_select, conn))
                {

                    conn.Open();

                    cmd.Fill(ds);

                }

                if (ds == null || ds.Tables.Count <= 0) return null;

                return ds;

            }

        }
        //datatable转json
        public string DataTableToJsonWithJavaScriptSerializer(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return jsSerializer.Serialize(parentRow);
        }

        //获取最佳地点
        private void Best_hospital_site()
        {
            webBrowser1.Document.InvokeScript("Routeplanning", new object[] { PublicValue.startposi[0],PublicValue.startposi[1]});

        }
        //载入加载地图
        private void Form1_Load(object sender, EventArgs e)
        {
            //本地文件 MapWinForms\bin\Debug
            string url = Application.StartupPath + "\\BaiMapJS.html";
            //string url = Application.StartupPath + "\\now.html";
            string file = "file:///E:\\WinFormBaiduMap\\test.html";

            webBrowser1.ScriptErrorsSuppressed = true;   //屏蔽js相关错误
            webBrowser1.Navigate(url);                   //导航显示本地HTML文件
        }
        
        public string callForJs()
        {
            string c = Application.StartupPath;
            return c;
        }

        //城市搜索
        private void button1_Click(object sender, EventArgs e)
        {
            /**
                * 参考资料：
                * http://bbs.csdn.net/topics/390935011
                * http://www.sufeinet.com/thread-7897-1-1.html
                */

            //C#调用JS函数
            string city;
            if (comboBox1.SelectedIndex == -1)
            {
                city = "北京";
            }
            else 
            {
                city = comboBox1.SelectedItem.ToString();
            }
            webBrowser1.Document.InvokeScript("LoadMap", new object[] { city });
        }

        //车位搜索
        private void button2_Click(object sender, EventArgs e)
        {
            string city;
            if (comboBox1.SelectedIndex == -1)
            {
                city = "北京";
            }
            else
            {
                city = comboBox1.SelectedItem.ToString();
            }
            webBrowser1.Document.InvokeScript("SearchCarMap", new object[] { });
        }

        //附近热点搜索
        private void button3_Click(object sender, EventArgs e)
        {
            string city;
            if (comboBox1.SelectedIndex == -1)
            {
                city = "北京";
            }
            else
            {
                city = comboBox1.SelectedItem.ToString();
            }
            string key;
            if (comboBox2.SelectedIndex == -1)
            {
                key = "学校";
            }
            else
            {
                key = comboBox2.SelectedItem.ToString();
            }
            webBrowser1.Document.InvokeScript("SearchNearbyMap", new object[] { city, key });
        }

        //当前位置定位
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("LocateMyPlcae", new object[] { });
        }

        //路线规划
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                PublicValue.startposi[0] = (Double)PublicValue.ds.Rows[0][1];
                PublicValue.startposi[1] = (Double)PublicValue.ds.Rows[0][2];
                webBrowser1.Document.InvokeScript("Routeplanning", new object[] { PublicValue.startposi[0], PublicValue.startposi[1] });
            }
            catch(NullReferenceException a)
            {
                MessageBox.Show("请先导入表格数据.");
            }
        }

        //模拟行进过程
        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("moni", new object[] { });
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 模拟演练ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //模拟事故的发生，flag=0为火灾,尚未完成随机过程
        private void Menu_1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            double jing = 116.355442;
            double wei = 40.003664;
            string name = "矿大";
            webBrowser1.Document.InvokeScript("start1", new object[] { jing,wei,name,flag});
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void 事故现场管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 模拟演练场景ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("moni", new object[] { });
        }

        

        

        private void menu_2_2_Click(object sender, EventArgs e)
        {

        }

        private void menu_2_1_Click(object sender, EventArgs e)
        {
            DataTable dt = getData().Tables[0];
            PublicValue.ds = dt;
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = null; //每次打开清空内容

            DataTable dt = getData().Tables[0];
            PublicValue.ds = dt;
            dataGridView1.DataSource = dt;
        }

        private void 救援路径规划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PublicValue.startposi[0] = (Double)PublicValue.ds.Rows[0][1];
                PublicValue.startposi[1] = (Double)PublicValue.ds.Rows[0][2];
                webBrowser1.Document.InvokeScript("Routeplanning", new object[] { PublicValue.startposi[0], PublicValue.startposi[1] });
            }
            catch (NullReferenceException a)
            {
                MessageBox.Show("请先导入表格数据.");
            }
        }

        private void 地点标注ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string points = DataTableToJsonWithJavaScriptSerializer(PublicValue.ds);
            webBrowser1.Document.InvokeScript("Mark_hospital", new object[] {points});
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("real_time_traffic", new object[] { });
        }
    }
}
