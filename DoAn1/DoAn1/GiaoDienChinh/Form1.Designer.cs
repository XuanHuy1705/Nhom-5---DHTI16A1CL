namespace DoAn1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            OrderPhong = new Button();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button2 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 8);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 2;
            label1.Text = "Quản lý khách sạn";
            label1.Click += label1_Click;
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(4, 6);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(49, 30);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(button1);
            sidebar.Controls.Add(button5);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button6);
            sidebar.Controls.Add(button2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 41);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(185, 521);
            sidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuContainer.Controls.Add(OrderPhong);
            menuContainer.Controls.Add(button7);
            menuContainer.Controls.Add(button8);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(181, 53);
            menuContainer.TabIndex = 8;
            // 
            // OrderPhong
            // 
            OrderPhong.AccessibleRole = AccessibleRole.PageTabList;
            OrderPhong.BackColor = Color.FromArgb(23, 24, 29);
            OrderPhong.ForeColor = Color.Cornsilk;
            OrderPhong.Image = (Image)resources.GetObject("OrderPhong.Image");
            OrderPhong.ImageAlign = ContentAlignment.MiddleLeft;
            OrderPhong.Location = new Point(0, 0);
            OrderPhong.Margin = new Padding(0);
            OrderPhong.Name = "OrderPhong";
            OrderPhong.Size = new Size(182, 53);
            OrderPhong.TabIndex = 4;
            OrderPhong.Text = "    Đặt / trả phòng";
            OrderPhong.UseVisualStyleBackColor = false;
            OrderPhong.Click += OrderPhong_Click;
            // 
            // button7
            // 
            button7.AccessibleRole = AccessibleRole.PageTabList;
            button7.BackColor = Color.FromArgb(32, 33, 36);
            button7.ForeColor = Color.Cornsilk;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 53);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(182, 53);
            button7.TabIndex = 5;
            button7.Text = "    Đặt phòng";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AccessibleRole = AccessibleRole.PageTabList;
            button8.BackColor = Color.FromArgb(32, 33, 36);
            button8.ForeColor = Color.Cornsilk;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 106);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(182, 53);
            button8.TabIndex = 6;
            button8.Text = "    Trả phòng";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.PageTabList;
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.ForeColor = Color.Cornsilk;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 60);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(182, 53);
            button1.TabIndex = 0;
            button1.Text = "    Cập nhật thông tin ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.AccessibleRole = AccessibleRole.PageTabList;
            button5.BackColor = Color.FromArgb(23, 24, 29);
            button5.ForeColor = Color.Cornsilk;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1, 115);
            button5.Margin = new Padding(1);
            button5.Name = "button5";
            button5.Size = new Size(182, 53);
            button5.TabIndex = 7;
            button5.Text = "    Dịch vụ thêm";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AccessibleRole = AccessibleRole.PageTabList;
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.ForeColor = Color.Cornsilk;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1, 170);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(182, 53);
            button4.TabIndex = 6;
            button4.Text = "    Danh sách phòng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.AccessibleRole = AccessibleRole.PageTabList;
            button6.BackColor = Color.FromArgb(23, 24, 29);
            button6.ForeColor = Color.Cornsilk;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(1, 225);
            button6.Margin = new Padding(1);
            button6.Name = "button6";
            button6.Size = new Size(182, 53);
            button6.TabIndex = 7;
            button6.Text = "Thanh toán";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.PageTabList;
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.ForeColor = Color.Cornsilk;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1, 280);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(182, 53);
            button2.TabIndex = 8;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 562);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button OrderPhong;
        private Button button4;
        private Button button5;
        private Button button6;
        private FlowLayoutPanel menuContainer;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button1;
        private Button button2;
    }
}
