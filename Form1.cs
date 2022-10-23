using Microsoft.Web.WebView2.Core;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Runtime;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Globalization;

namespace BDS北斗定位
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //关闭按钮
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //最小化按钮
            this.WindowState = FormWindowState.Minimized;
        }

        
        private bool isMouseDown = false;//表示鼠标当前是否处于按下状态，初始值为否 

        MouseDirection direction = MouseDirection.None;//表示拖动的方向，起始为None，表示不拖动

        private Point mPoint;//鼠标坐标

        private bool zhuangtai = true;//是否是改变窗体大小，true为不是，false为是

        //定义一个枚举，表示拖动方向
        public enum MouseDirection
        {
            Herizontal,//水平方向拖动，只改变窗体的宽度   
            Vertical,//垂直方向拖动，只改变窗体的高度 
            Declining,//倾斜方向，同时改变窗体的宽度和高度
            None//不做标志，即不拖动窗体改变大小
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
            isMouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // 鼠标弹起，
            isMouseDown = false;
            //既然鼠标弹起了，那么就不能再改变窗体尺寸，拖拽方向置 none
            direction = MouseDirection.None;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标移动过程中，坐标时刻在改变 
            //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Declining 
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE;
                direction = MouseDirection.Declining;
                zhuangtai = false;
            }
            else if (e.Location.X >= this.Width - 5)
            //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Herizontal else if (e.Location.X >= this.Width - 5) 
            {
                this.Cursor = Cursors.SizeWE;
                direction = MouseDirection.Herizontal;
                zhuangtai = false;
            }
            else if (e.Location.Y > this.Height - 5)
            //同理当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Vertical else if (e.Location.Y >= this.Height - 5) 
            {
                this.Cursor = Cursors.SizeNS;
                direction = MouseDirection.Vertical;
                zhuangtai = false;
            }
            else
            {
                //否则，以外的窗体区域，鼠标星座均为单向箭头（默认） else
                this.Cursor = Cursors.Arrow;
                zhuangtai = true;
            }
            //设定好方向后，调用下面方法，改变窗体大小  
            if (zhuangtai)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
                    return;
                }
            }
            else
            {
                ResizeWindow();
            }
        }
        private void ResizeWindow()
        {
            //这个判断很重要，只有在鼠标按下时才能拖拽改变窗体大小，如果不作判断，那么鼠标弹起和按下时，窗体都可以改变 
            if (!isMouseDown)
                return;
            //MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标this.left和this.top的参考点也是屏幕，属性MousePosition是该程序的重点
            if (direction == MouseDirection.Declining)
            {
                //此行代码在mousemove事件中已经写过，在此再写一遍，并不多余，一定要写
                this.Cursor = Cursors.SizeNWSE;
                //下面是改变窗体宽和高的代码，不明白的可以仔细思考一下
                this.Width = MousePosition.X - this.Left;
                this.Height = MousePosition.Y - this.Top;
            }
            //以下同理
            if (direction == MouseDirection.Herizontal)
            {
                this.Cursor = Cursors.SizeWE;
                this.Width = MousePosition.X - this.Left;
            }
            else if (direction == MouseDirection.Vertical)
            {
                this.Cursor = Cursors.SizeNS;
                this.Height = MousePosition.Y - this.Top;
            }
            //即使鼠标按下，但是不在窗口右和下边缘，那么也不能改变窗口大小 else 
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        public class Loadd
        {
            public double pi = 3.14159265358979324 * 3000.0 / 180.0;
            /// <summary>
            /// 输入字符串转化为只含有经纬度的数组
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
            public string[] infomation(string s)
            {
                string p1 = @"GNGGA.{34}";

                MatchCollection match = Regex.Matches(s, p1);
                string ss = "";

                string p2 = @"[0-9]+\.[0-9]{4}";
                MatchCollection matchCollection = Regex.Matches(s, p2);
                foreach (Match m in matchCollection)
                {
                    string p = m + "|";
                    ss += p;
                }
                string[] strings = ss.Split('|');
                return strings;
            }
            /// <summary>
            /// 调用纬度的方法
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
            public double Lat(string[] s)
            {
                double lat = 0;
                int len = s.Length / 2;
                for (int i = 0; i < len; i++)
                {
                    lat = double.Parse(s[i * 2]);
                }
                lat = Convert.ToInt32(lat / 100) + (lat % 100) / 60;
                return lat-1.000001;
            }

            /// <summary>
            /// 调用经度的方法
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
            public double Lon(string[] s)
            {
                double lon = 0;
                int len = s.Length / 2;
                for (int i = 0; i < len; i++)
                {
                    lon = double.Parse(s[i * 2 + 1]);
                }
                lon = Convert.ToInt32(lon / 100) + (lon % 100) / 60;
                return lon+0.000004;
            }
            
        }




        /******************************************************
        调用Sql数据库的类
        *****************************************************/
        public class Sql_class
        {
            /// <summary>
            /// 数据库操作类
            /// </summary>
            /// <param name="s"></param>
            public void Sql_table(string svname, string dbname, string tbname)
            {
                Sql_class sd = new Sql_class();
                string s = sd.ID_IDENTIFY(svname, dbname);//验证用户信息并返回连接字符串
                SqlConnection sql = new SqlConnection(s);
                try
                {
                    sql.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("连接失败" + e.Message);
                }
                SqlCommand com = new SqlCommand("select * from " + tbname, sql);//执行sql语句
                SqlDataReader sdr = com.ExecuteReader();
                ArrayList l = new ArrayList();
                l = sd.TABLE_NAME(svname, dbname, tbname);
                while (sdr.Read())
                {
                    for (int i = 0; i < l.Count; i++)
                    {
                        Console.WriteLine("{0}\t",sdr[i]);
                    }
                }
                sdr.Close();
                if (sql.State == ConnectionState.Open)
                {
                    sql.Close();
                }
            }


            public ArrayList TABLE_NAME(string svname, string dbname, string tbname)//获取数据库的列名
            {
                ArrayList list = new ArrayList();
                Sql_class s = new Sql_class();
                string n = s.ID_IDENTIFY(svname, dbname);
                SqlConnection con = new SqlConnection(n);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接失败", ex.Message);
                }
                SqlCommand cm = new SqlCommand("select name from syscolumns where id = object_id('" + tbname + "')", con);
                SqlDataReader rdr = cm.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr[0].ToString());
                }
                foreach (string dr in list)
                {
                    MessageBox.Show("{0}\t", dr);
                }
                
                con.Close();
                return list;
            }


            public void Insert(string svname, string dbname, string tbname, double lat,double lon)
            {
                Sql_class s = new Sql_class();
                string n = s.ID_IDENTIFY(svname, dbname);
                SqlConnection con = new SqlConnection(n);
                
                try
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand("insert into " + tbname + "(lat,lon) values(" + lat+","+lon+ ")", con);
                    SqlDataReader sqlDataReader = cm.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }


            public string ID_IDENTIFY(string svname, string dbname)//数据库账户权限的验证
            {
                if (svname == "." && dbname == "Mydatabase2")
                {
                    string constr = "Server=WIN-8V7TR6GNSD9 ;Database= Mydatabase2;uid= cdh;pwd= 1531079";
                    return constr;
                }
                else if (svname == "Azure")
                {
                    string constr = "Server=tcp:dh-001.database.windows.net,1433;Initial Catalog=database-01;Persist Security Info=False;User ID=cdh;Password=Cd1531079;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                    return constr;
                }
                else if (svname == "." && dbname == "Mydatabase1")
                {
                    string constr = "Server=WIN-8V7TR6GNSD9 ;Database= Mydatabase1;uid= cdh;pwd= 1531079";
                    return constr;
                }
                else
                {
                    string m = "找不到服务器";
                    return m;
                }
            }
        }






        //正文开始
        private void button2_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.PostWebMessageAsString(TextBox2.Text+","+TextBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //登陆界面的初始化
            Login g = new Login();
            g.Show();
            Thread.Sleep(2000);
            g.Close();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.webView21.Source = new Uri("C:\\Users\\Administrator\\source\\repos\\BDS北斗定位\\MAP.html");
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TextBox1.Text = "01";
            }
            else
            {
                TextBox1.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                TextBox2.Visible = true;
            }
            else
            {
                TextBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                TextBox3.Visible = true;
            }
            else
            {
                TextBox3.Visible = false;
            }
        }

        Socket socketsd;
        Socket socketls;
        //监听客户端的信息
        void listen()
        {
            while (true)
            {
                try
                {
                    //连接客户端
                    socketsd = socketls.Accept();
                    richTextBox1.AppendText("客户端"+socketsd.RemoteEndPoint.ToString() + "连接成功" + "\r\n");
                    //开始不间断接收客户端信息
                    Thread thread = new Thread(Recived);
                    thread.IsBackground = true;
                    thread.Start();

                }
                catch { }
            }
        }

        /*//向客户端发送信息
        void Send()
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(TextBox1.Text);
                socketsd.Send(buffer);

            }
            catch { }
        }*/

        //接收客户端的信息
        void Recived()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int l = socketsd.Receive(buffer);
                    if (l == 0)
                    {
                        break;
                    }
                    try
                    {
                        //客户端的接收的信息暂时储存在str中，供后面调配
                        string str = Encoding.UTF8.GetString(buffer, 0, l);
                        richTextBox1.AppendText(str + "\r\n");
                        Loadd p = new Loadd();
                        string[] strings = p.infomation(str);
                        TextBox2.Text = (p.Lon(strings)).ToString();
                        TextBox3.Text = (p.Lat(strings)).ToString();
                        double lon = p.Lon(strings);
                        double lat = p.Lat(strings);
                        if(lon != 0&& lat != 0)
                        {
                            Sql_class sql = new Sql_class();
                            sql.Insert(".", "Mydatabase2", "BDS", lat, lon);
                        }
                        lon = 0;
                        lat = 0;
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }

            catch { }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //开始监听
            socketsd = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketls = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            //建立窗口对象
            IPEndPoint point = new IPEndPoint(ip, 4000);
            socketls.Bind(point);
            richTextBox1.AppendText("监听成功"+"\r\n");
            socketls.Listen(10);
            // 

            //开始监听线程
            Thread thread = new Thread(listen);
            thread.IsBackground = true;
            thread.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
            }
            else
            {
                richTextBox1.Visible = true;
            }
        }

     
    }
}