namespace BDS北斗定位
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Location = new System.Drawing.Point(536, 46);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(121, 38);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "获取信息";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.Location = new System.Drawing.Point(536, 101);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(121, 36);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "显示位置";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 20);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "小车编号";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(88, 53);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PlaceholderText = "0-99";
            this.TextBox1.Size = new System.Drawing.Size(176, 27);
            this.TextBox1.TabIndex = 7;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(88, 101);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PlaceholderText = "E为东经   W为西经 0-180°";
            this.TextBox2.Size = new System.Drawing.Size(176, 27);
            this.TextBox2.TabIndex = 8;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(88, 149);
            this.TextBox3.Multiline = true;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PlaceholderText = "N为北    S为南 0~90°";
            this.TextBox3.Size = new System.Drawing.Size(176, 27);
            this.TextBox3.TabIndex = 9;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "经度";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 20);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "纬度";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(834, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "—";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(867, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webView21.Location = new System.Drawing.Point(0, 199);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(900, 401);
            this.webView21.TabIndex = 16;
            this.webView21.ZoomFactor = 1D;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(313, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "显示编号";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(313, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 24);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "显示经度";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(313, 149);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 24);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "显示纬度";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 199);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(900, 401);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(536, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 36);
            this.button5.TabIndex = 21;
            this.button5.Text = "显示原始数据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::BDS北斗定位.Properties.Resources.ea4ad4ab1e1195f6435863a2278997351656598950810;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDS北斗定位系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Button1;
        private Button Button2;
        private Label Label1;
        private TextBox TextBox1;
        private TextBox TextBox2;
        private TextBox TextBox3;
        private Label Label2;
        private Label Label3;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RichTextBox richTextBox1;
        private Button button5;
    }
}