using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapWinForms
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
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
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f1 = (MainForm)this.Owner;
            
            dataGridView1.DataSource = null; //每次打开清空内容

            DataTable dt = getData().Tables[0];
            dataGridView1.DataSource = dt;
            


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
