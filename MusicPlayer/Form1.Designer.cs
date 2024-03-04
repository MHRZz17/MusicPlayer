namespace MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            picLogo = new PictureBox();
            btnMinimize = new Button();
            btnMaximize = new Button();
            lbNameApp = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            button13 = new Button();
            label4 = new Label();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button9 = new Button();
            button8 = new Button();
            button5 = new Button();
            button14 = new Button();
            button6 = new Button();
            trackBar1 = new TrackBar();
            button10 = new Button();
            button4 = new Button();
            button15 = new Button();
            button12 = new Button();
            textBox1 = new TextBox();
            panel5 = new Panel();
            button7 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(lbNameApp);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 58);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Center;
            picLogo.Location = new Point(3, 6);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(45, 50);
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1098, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(51, 52);
            btnMinimize.TabIndex = 8;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Center;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(1155, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(52, 52);
            btnMaximize.TabIndex = 7;
            btnMaximize.UseVisualStyleBackColor = false;
            // 
            // lbNameApp
            // 
            lbNameApp.AutoSize = true;
            lbNameApp.Font = new Font("WAGHU", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbNameApp.ForeColor = SystemColors.ButtonHighlight;
            lbNameApp.Location = new Point(54, 20);
            lbNameApp.Name = "lbNameApp";
            lbNameApp.Size = new Size(116, 22);
            lbNameApp.TabIndex = 5;
            lbNameApp.Text = "MusicPlayer";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1205, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(53, 52);
            btnExit.TabIndex = 6;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(333, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 657);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(253, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 335);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 453);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "singer name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 402);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "song name";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Location = new Point(16, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 482);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 20);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "about song";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Purple;
            panel3.Controls.Add(button10);
            panel3.Controls.Add(trackBar1);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button13);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(progressBar1);
            panel3.Location = new Point(0, 529);
            panel3.Name = "panel3";
            panel3.Size = new Size(912, 119);
            panel3.TabIndex = 0;
            // 
            // button13
            // 
            button13.BackColor = Color.Transparent;
            button13.BackgroundImage = (Image)resources.GetObject("button13.BackgroundImage");
            button13.BackgroundImageLayout = ImageLayout.Center;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(447, 17);
            button13.Name = "button13";
            button13.Size = new Size(53, 52);
            button13.TabIndex = 10;
            button13.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(710, 44);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 5;
            label4.Text = "all_time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(156, 44);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 6;
            label5.Text = "time_spend";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(166, 84);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(605, 10);
            progressBar1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(510, 17);
            button2.Name = "button2";
            button2.Size = new Size(53, 52);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(378, 17);
            button1.Name = "button1";
            button1.Size = new Size(53, 52);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(591, 17);
            button3.Name = "button3";
            button3.Size = new Size(53, 52);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(307, 17);
            button9.Name = "button9";
            button9.Size = new Size(53, 52);
            button9.TabIndex = 14;
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(102, 59);
            button8.Name = "button8";
            button8.Size = new Size(53, 52);
            button8.TabIndex = 15;
            button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(53, 59);
            button5.Name = "button5";
            button5.Size = new Size(53, 52);
            button5.TabIndex = 16;
            button5.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Transparent;
            button14.BackgroundImage = (Image)resources.GetObject("button14.BackgroundImage");
            button14.BackgroundImageLayout = ImageLayout.Center;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(3, 59);
            button14.Name = "button14";
            button14.Size = new Size(53, 52);
            button14.TabIndex = 17;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(823, 12);
            button6.Name = "button6";
            button6.Size = new Size(53, 52);
            button6.TabIndex = 18;
            button6.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(777, 55);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 19;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(6, 12);
            button10.Name = "button10";
            button10.Size = new Size(53, 52);
            button10.TabIndex = 20;
            button10.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(451, 56);
            button4.Name = "button4";
            button4.Size = new Size(53, 58);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Transparent;
            button15.BackgroundImage = (Image)resources.GetObject("button15.BackgroundImage");
            button15.BackgroundImageLayout = ImageLayout.Center;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(333, 58);
            button15.Name = "button15";
            button15.Size = new Size(53, 54);
            button15.TabIndex = 18;
            button15.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Center;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(9, 8);
            button12.Name = "button12";
            button12.Size = new Size(60, 47);
            button12.TabIndex = 19;
            button12.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Controls.Add(listBox1);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button12);
            panel5.Location = new Point(2, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 708);
            panel5.TabIndex = 22;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(392, 56);
            button7.Name = "button7";
            button7.Size = new Size(53, 58);
            button7.TabIndex = 23;
            button7.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(10, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(295, 624);
            listBox1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1257, 770);
            ControlBox = false;
            Controls.Add(button7);
            Controls.Add(panel5);
            Controls.Add(button15);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private ProgressBar progressBar1;
        private Label lbNameApp;
        private Button btnExit;
        private Button btnMinimize;
        private Button btnMaximize;
        private PictureBox picLogo;
        private Label label4;
        private Label label5;
        private Button button13;
        private Button button9;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button10;
        private TrackBar trackBar1;
        private Button button6;
        private Button button14;
        private Button button5;
        private Button button8;
        private Button button4;
        private Button button15;
        private Button button12;
        private TextBox textBox1;
        private Panel panel5;
        private Button button7;
        private ListBox listBox1;
    }
}