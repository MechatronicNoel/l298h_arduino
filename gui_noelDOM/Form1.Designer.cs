
namespace gui_noelDOM
{
    partial class GUI
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_load_porst = new System.Windows.Forms.Button();
            this.Btn_conect = new System.Windows.Forms.Button();
            this.Btn_left = new System.Windows.Forms.Button();
            this.Track_Bar_Motor_Pwm = new System.Windows.Forms.TrackBar();
            this.Label_pos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Right = new System.Windows.Forms.Button();
            this.Btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Motor_Pwm)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200",
            "230400",
            "1382400"});
            this.comboBox2.Location = new System.Drawing.Point(131, 63);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 23);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // Btn_load_porst
            // 
            this.Btn_load_porst.Location = new System.Drawing.Point(12, 28);
            this.Btn_load_porst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_load_porst.Name = "Btn_load_porst";
            this.Btn_load_porst.Size = new System.Drawing.Size(87, 34);
            this.Btn_load_porst.TabIndex = 13;
            this.Btn_load_porst.Text = "Load Ports";
            this.Btn_load_porst.UseVisualStyleBackColor = true;
            this.Btn_load_porst.Click += new System.EventHandler(this.Btn_load_porst_Click);
            // 
            // Btn_conect
            // 
            this.Btn_conect.Location = new System.Drawing.Point(12, 67);
            this.Btn_conect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_conect.Name = "Btn_conect";
            this.Btn_conect.Size = new System.Drawing.Size(87, 31);
            this.Btn_conect.TabIndex = 12;
            this.Btn_conect.Text = "Connect";
            this.Btn_conect.UseVisualStyleBackColor = true;
            this.Btn_conect.Click += new System.EventHandler(this.Btn_conect_Click);
            // 
            // Btn_left
            // 
            this.Btn_left.Location = new System.Drawing.Point(34, 174);
            this.Btn_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_left.Name = "Btn_left";
            this.Btn_left.Size = new System.Drawing.Size(87, 31);
            this.Btn_left.TabIndex = 17;
            this.Btn_left.Text = "Left";
            this.Btn_left.UseVisualStyleBackColor = true;
            this.Btn_left.Click += new System.EventHandler(this.btn_send_data_Click);
            // 
            // Track_Bar_Motor_Pwm
            // 
            this.Track_Bar_Motor_Pwm.Location = new System.Drawing.Point(2, 124);
            this.Track_Bar_Motor_Pwm.Maximum = 255;
            this.Track_Bar_Motor_Pwm.Name = "Track_Bar_Motor_Pwm";
            this.Track_Bar_Motor_Pwm.Size = new System.Drawing.Size(299, 45);
            this.Track_Bar_Motor_Pwm.SmallChange = 10;
            this.Track_Bar_Motor_Pwm.TabIndex = 18;
            this.Track_Bar_Motor_Pwm.ValueChanged += new System.EventHandler(this.Track_Bar_Servo_ValueChanged);
            // 
            // Label_pos
            // 
            this.Label_pos.AutoSize = true;
            this.Label_pos.Location = new System.Drawing.Point(262, 154);
            this.Label_pos.Name = "Label_pos";
            this.Label_pos.Size = new System.Drawing.Size(13, 15);
            this.Label_pos.TabIndex = 19;
            this.Label_pos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "L298H GUI";
            // 
            // Btn_Right
            // 
            this.Btn_Right.Location = new System.Drawing.Point(177, 174);
            this.Btn_Right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(87, 31);
            this.Btn_Right.TabIndex = 21;
            this.Btn_Right.Text = "Right";
            this.Btn_Right.UseVisualStyleBackColor = true;
            this.Btn_Right.Click += new System.EventHandler(this.Btn_Right_Click);
            // 
            // Btn_stop
            // 
            this.Btn_stop.Location = new System.Drawing.Point(104, 213);
            this.Btn_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_stop.Name = "Btn_stop";
            this.Btn_stop.Size = new System.Drawing.Size(87, 31);
            this.Btn_stop.TabIndex = 22;
            this.Btn_stop.Text = "Stop";
            this.Btn_stop.UseVisualStyleBackColor = true;
            this.Btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 255);
            this.Controls.Add(this.Btn_stop);
            this.Controls.Add(this.Btn_Right);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_pos);
            this.Controls.Add(this.Track_Bar_Motor_Pwm);
            this.Controls.Add(this.Btn_left);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_load_porst);
            this.Controls.Add(this.Btn_conect);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Motor_Pwm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_load_porst;
        private System.Windows.Forms.Button Btn_conect;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button Btn_left;
        private System.Windows.Forms.TrackBar Track_Bar_Motor_Pwm;
        private System.Windows.Forms.Label Label_pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Right;
        private System.Windows.Forms.Button Btn_stop;
    }
}

