namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.right_UP = new System.Windows.Forms.Button();
            this.straight_UP = new System.Windows.Forms.Button();
            this.straight_down = new System.Windows.Forms.Button();
            this.right_DOWN = new System.Windows.Forms.Button();
            this.left_LEFT = new System.Windows.Forms.Button();
            this.straight_LEFT = new System.Windows.Forms.Button();
            this.straight_RIGHT = new System.Windows.Forms.Button();
            this.left_RIGHT = new System.Windows.Forms.Button();
            this.tram_UP = new System.Windows.Forms.Button();
            this.tram_DOWN = new System.Windows.Forms.Button();
            this.right_LEFT = new System.Windows.Forms.Button();
            this.left_down = new System.Windows.Forms.Button();
            this.right_RIGHT = new System.Windows.Forms.Button();
            this.left_UP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // right_UP
            // 
            this.right_UP.Location = new System.Drawing.Point(257, 6);
            this.right_UP.Name = "right_UP";
            this.right_UP.Size = new System.Drawing.Size(75, 23);
            this.right_UP.TabIndex = 1;
            this.right_UP.Text = "right";
            this.right_UP.UseVisualStyleBackColor = true;
            this.right_UP.Click += new System.EventHandler(this.right_UP_Click);
            // 
            // straight_UP
            // 
            this.straight_UP.Location = new System.Drawing.Point(338, 6);
            this.straight_UP.Name = "straight_UP";
            this.straight_UP.Size = new System.Drawing.Size(75, 23);
            this.straight_UP.TabIndex = 2;
            this.straight_UP.Text = "straight";
            this.straight_UP.UseVisualStyleBackColor = true;
            this.straight_UP.Click += new System.EventHandler(this.straight_UP_Click);
            // 
            // straight_down
            // 
            this.straight_down.Location = new System.Drawing.Point(370, 641);
            this.straight_down.Name = "straight_down";
            this.straight_down.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.straight_down.Size = new System.Drawing.Size(75, 23);
            this.straight_down.TabIndex = 3;
            this.straight_down.Text = "straight";
            this.straight_down.UseVisualStyleBackColor = true;
            this.straight_down.Click += new System.EventHandler(this.straight_down_Click);
            // 
            // right_DOWN
            // 
            this.right_DOWN.Location = new System.Drawing.Point(451, 641);
            this.right_DOWN.Name = "right_DOWN";
            this.right_DOWN.Size = new System.Drawing.Size(75, 23);
            this.right_DOWN.TabIndex = 4;
            this.right_DOWN.Text = "right";
            this.right_DOWN.UseVisualStyleBackColor = true;
            this.right_DOWN.Click += new System.EventHandler(this.right_DOWN_Click);
            // 
            // left_LEFT
            // 
            this.left_LEFT.Location = new System.Drawing.Point(12, 348);
            this.left_LEFT.Name = "left_LEFT";
            this.left_LEFT.Size = new System.Drawing.Size(75, 23);
            this.left_LEFT.TabIndex = 5;
            this.left_LEFT.Text = "left";
            this.left_LEFT.UseVisualStyleBackColor = true;
            this.left_LEFT.Click += new System.EventHandler(this.left_LEFT_Click);
            // 
            // straight_LEFT
            // 
            this.straight_LEFT.Location = new System.Drawing.Point(12, 377);
            this.straight_LEFT.Name = "straight_LEFT";
            this.straight_LEFT.Size = new System.Drawing.Size(75, 23);
            this.straight_LEFT.TabIndex = 6;
            this.straight_LEFT.Text = "straight";
            this.straight_LEFT.UseVisualStyleBackColor = true;
            this.straight_LEFT.Click += new System.EventHandler(this.straight_LEFT_Click);
            // 
            // straight_RIGHT
            // 
            this.straight_RIGHT.Location = new System.Drawing.Point(897, 242);
            this.straight_RIGHT.Name = "straight_RIGHT";
            this.straight_RIGHT.Size = new System.Drawing.Size(75, 23);
            this.straight_RIGHT.TabIndex = 7;
            this.straight_RIGHT.Text = "straight";
            this.straight_RIGHT.UseVisualStyleBackColor = true;
            this.straight_RIGHT.Click += new System.EventHandler(this.straight_RIGHT_Click);
            // 
            // left_RIGHT
            // 
            this.left_RIGHT.Location = new System.Drawing.Point(897, 271);
            this.left_RIGHT.Name = "left_RIGHT";
            this.left_RIGHT.Size = new System.Drawing.Size(75, 23);
            this.left_RIGHT.TabIndex = 8;
            this.left_RIGHT.Text = "left";
            this.left_RIGHT.UseVisualStyleBackColor = true;
            this.left_RIGHT.Click += new System.EventHandler(this.left_RIGHT_Click);
            // 
            // tram_UP
            // 
            this.tram_UP.Location = new System.Drawing.Point(666, 6);
            this.tram_UP.Name = "tram_UP";
            this.tram_UP.Size = new System.Drawing.Size(75, 23);
            this.tram_UP.TabIndex = 9;
            this.tram_UP.Text = "tram";
            this.tram_UP.UseVisualStyleBackColor = true;
            this.tram_UP.Click += new System.EventHandler(this.tram_UP_Click);
            // 
            // tram_DOWN
            // 
            this.tram_DOWN.Location = new System.Drawing.Point(666, 641);
            this.tram_DOWN.Name = "tram_DOWN";
            this.tram_DOWN.Size = new System.Drawing.Size(75, 23);
            this.tram_DOWN.TabIndex = 10;
            this.tram_DOWN.Text = "tram";
            this.tram_DOWN.UseVisualStyleBackColor = true;
            this.tram_DOWN.Click += new System.EventHandler(this.tram_DOWN_Click);
            // 
            // right_LEFT
            // 
            this.right_LEFT.Location = new System.Drawing.Point(12, 406);
            this.right_LEFT.Name = "right_LEFT";
            this.right_LEFT.Size = new System.Drawing.Size(75, 23);
            this.right_LEFT.TabIndex = 11;
            this.right_LEFT.Text = "right";
            this.right_LEFT.UseVisualStyleBackColor = true;
            this.right_LEFT.Click += new System.EventHandler(this.right_LEFT_Click);
            // 
            // left_down
            // 
            this.left_down.Location = new System.Drawing.Point(289, 641);
            this.left_down.Name = "left_down";
            this.left_down.Size = new System.Drawing.Size(75, 23);
            this.left_down.TabIndex = 12;
            this.left_down.Text = "left";
            this.left_down.UseVisualStyleBackColor = true;
            this.left_down.Click += new System.EventHandler(this.left_down_Click);
            // 
            // right_RIGHT
            // 
            this.right_RIGHT.Location = new System.Drawing.Point(897, 213);
            this.right_RIGHT.Name = "right_RIGHT";
            this.right_RIGHT.Size = new System.Drawing.Size(75, 23);
            this.right_RIGHT.TabIndex = 13;
            this.right_RIGHT.Text = "right";
            this.right_RIGHT.UseVisualStyleBackColor = true;
            this.right_RIGHT.Click += new System.EventHandler(this.right_RIGHT_Click);
            // 
            // left_UP
            // 
            this.left_UP.Location = new System.Drawing.Point(419, 6);
            this.left_UP.Name = "left_UP";
            this.left_UP.Size = new System.Drawing.Size(75, 23);
            this.left_UP.TabIndex = 14;
            this.left_UP.Text = "left";
            this.left_UP.UseVisualStyleBackColor = true;
            this.left_UP.Click += new System.EventHandler(this.left_UP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.left_UP);
            this.Controls.Add(this.right_RIGHT);
            this.Controls.Add(this.left_down);
            this.Controls.Add(this.right_LEFT);
            this.Controls.Add(this.tram_DOWN);
            this.Controls.Add(this.tram_UP);
            this.Controls.Add(this.left_RIGHT);
            this.Controls.Add(this.straight_RIGHT);
            this.Controls.Add(this.straight_LEFT);
            this.Controls.Add(this.left_LEFT);
            this.Controls.Add(this.right_DOWN);
            this.Controls.Add(this.straight_down);
            this.Controls.Add(this.straight_UP);
            this.Controls.Add(this.right_UP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Skrzyzowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button right_UP;
        private System.Windows.Forms.Button straight_UP;
        private System.Windows.Forms.Button straight_down;
        private System.Windows.Forms.Button right_DOWN;
        private System.Windows.Forms.Button left_LEFT;
        private System.Windows.Forms.Button straight_LEFT;
        private System.Windows.Forms.Button straight_RIGHT;
        private System.Windows.Forms.Button left_RIGHT;
        private System.Windows.Forms.Button tram_UP;
        private System.Windows.Forms.Button tram_DOWN;
        private System.Windows.Forms.Button right_LEFT;
        private System.Windows.Forms.Button left_down;
        private System.Windows.Forms.Button right_RIGHT;
        private System.Windows.Forms.Button left_UP;
    }
}

