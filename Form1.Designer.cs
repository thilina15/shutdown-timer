namespace shoutDowwnTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.NUM_Seconds = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_SP = new Guna.UI2.WinForms.Guna2CircleButton();
            this.NUM_Minutes = new System.Windows.Forms.NumericUpDown();
            this.NUM_Hours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.DarkRed;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(481, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(440, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.AliceBlue;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(398, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // NUM_Seconds
            // 
            this.NUM_Seconds.BackColor = System.Drawing.Color.DimGray;
            this.NUM_Seconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUM_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_Seconds.Location = new System.Drawing.Point(249, 73);
            this.NUM_Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUM_Seconds.Name = "NUM_Seconds";
            this.NUM_Seconds.Size = new System.Drawing.Size(100, 79);
            this.NUM_Seconds.TabIndex = 4;
            this.NUM_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTN_SP
            // 
            this.BTN_SP.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SP.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.BTN_SP.CheckedState.Parent = this.BTN_SP;
            this.BTN_SP.CustomImages.Parent = this.BTN_SP;
            this.BTN_SP.FillColor = System.Drawing.Color.LightSlateGray;
            this.BTN_SP.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.BTN_SP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_SP.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.BTN_SP.HoverState.Parent = this.BTN_SP;
            this.BTN_SP.Location = new System.Drawing.Point(378, 35);
            this.BTN_SP.Name = "BTN_SP";
            this.BTN_SP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_SP.ShadowDecoration.Parent = this.BTN_SP;
            this.BTN_SP.Size = new System.Drawing.Size(148, 148);
            this.BTN_SP.TabIndex = 5;
            this.BTN_SP.Text = "start";
            this.BTN_SP.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // NUM_Minutes
            // 
            this.NUM_Minutes.BackColor = System.Drawing.Color.DimGray;
            this.NUM_Minutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUM_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_Minutes.Location = new System.Drawing.Point(143, 73);
            this.NUM_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUM_Minutes.Name = "NUM_Minutes";
            this.NUM_Minutes.Size = new System.Drawing.Size(100, 79);
            this.NUM_Minutes.TabIndex = 6;
            this.NUM_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUM_Hours
            // 
            this.NUM_Hours.BackColor = System.Drawing.Color.DimGray;
            this.NUM_Hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUM_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_Hours.Location = new System.Drawing.Point(37, 73);
            this.NUM_Hours.Name = "NUM_Hours";
            this.NUM_Hours.Size = new System.Drawing.Size(100, 79);
            this.NUM_Hours.TabIndex = 7;
            this.NUM_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUM_Hours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Shut Down Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "seconds";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(-1, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "about";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(525, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUM_Hours);
            this.Controls.Add(this.NUM_Minutes);
            this.Controls.Add(this.BTN_SP);
            this.Controls.Add(this.NUM_Seconds);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.NumericUpDown NUM_Seconds;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_SP;
        private System.Windows.Forms.NumericUpDown NUM_Hours;
        private System.Windows.Forms.NumericUpDown NUM_Minutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

