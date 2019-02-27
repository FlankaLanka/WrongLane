namespace WrongLane
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
            this.zebra1 = new System.Windows.Forms.PictureBox();
            this.zebra2 = new System.Windows.Forms.PictureBox();
            this.zebra3 = new System.Windows.Forms.PictureBox();
            this.zebra4 = new System.Windows.Forms.PictureBox();
            this.zebra5 = new System.Windows.Forms.PictureBox();
            this.zebra6 = new System.Windows.Forms.PictureBox();
            this.zebra7 = new System.Windows.Forms.PictureBox();
            this.zebra8 = new System.Windows.Forms.PictureBox();
            this.ZebraMover = new System.Windows.Forms.Timer(this.components);
            this.OrangeCar = new System.Windows.Forms.PictureBox();
            this.MoveUp = new System.Windows.Forms.Timer(this.components);
            this.MoveDown = new System.Windows.Forms.Timer(this.components);
            this.MoveRight = new System.Windows.Forms.Timer(this.components);
            this.MoveLeft = new System.Windows.Forms.Timer(this.components);
            this.BlueCar = new System.Windows.Forms.PictureBox();
            this.BlueMove = new System.Windows.Forms.Timer(this.components);
            this.PurpleCar = new System.Windows.Forms.PictureBox();
            this.GreenCar = new System.Windows.Forms.PictureBox();
            this.PurpleMove = new System.Windows.Forms.Timer(this.components);
            this.GreenMove = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameEnd = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zebra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangeCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // zebra1
            // 
            this.zebra1.BackColor = System.Drawing.SystemColors.Window;
            this.zebra1.Location = new System.Drawing.Point(21, 90);
            this.zebra1.Name = "zebra1";
            this.zebra1.Size = new System.Drawing.Size(160, 20);
            this.zebra1.TabIndex = 0;
            this.zebra1.TabStop = false;
            // 
            // zebra2
            // 
            this.zebra2.BackColor = System.Drawing.SystemColors.Window;
            this.zebra2.Location = new System.Drawing.Point(212, 90);
            this.zebra2.Name = "zebra2";
            this.zebra2.Size = new System.Drawing.Size(160, 20);
            this.zebra2.TabIndex = 1;
            this.zebra2.TabStop = false;
            // 
            // zebra3
            // 
            this.zebra3.BackColor = System.Drawing.SystemColors.Window;
            this.zebra3.Location = new System.Drawing.Point(404, 90);
            this.zebra3.Name = "zebra3";
            this.zebra3.Size = new System.Drawing.Size(160, 20);
            this.zebra3.TabIndex = 2;
            this.zebra3.TabStop = false;
            // 
            // zebra4
            // 
            this.zebra4.BackColor = System.Drawing.SystemColors.Window;
            this.zebra4.Location = new System.Drawing.Point(598, 90);
            this.zebra4.Name = "zebra4";
            this.zebra4.Size = new System.Drawing.Size(160, 20);
            this.zebra4.TabIndex = 3;
            this.zebra4.TabStop = false;
            // 
            // zebra5
            // 
            this.zebra5.BackColor = System.Drawing.SystemColors.Window;
            this.zebra5.Location = new System.Drawing.Point(21, 203);
            this.zebra5.Name = "zebra5";
            this.zebra5.Size = new System.Drawing.Size(160, 20);
            this.zebra5.TabIndex = 4;
            this.zebra5.TabStop = false;
            // 
            // zebra6
            // 
            this.zebra6.BackColor = System.Drawing.SystemColors.Window;
            this.zebra6.Location = new System.Drawing.Point(212, 203);
            this.zebra6.Name = "zebra6";
            this.zebra6.Size = new System.Drawing.Size(160, 20);
            this.zebra6.TabIndex = 5;
            this.zebra6.TabStop = false;
            // 
            // zebra7
            // 
            this.zebra7.BackColor = System.Drawing.SystemColors.Window;
            this.zebra7.Location = new System.Drawing.Point(404, 203);
            this.zebra7.Name = "zebra7";
            this.zebra7.Size = new System.Drawing.Size(160, 20);
            this.zebra7.TabIndex = 6;
            this.zebra7.TabStop = false;
            // 
            // zebra8
            // 
            this.zebra8.BackColor = System.Drawing.SystemColors.Window;
            this.zebra8.Location = new System.Drawing.Point(598, 203);
            this.zebra8.Name = "zebra8";
            this.zebra8.Size = new System.Drawing.Size(160, 20);
            this.zebra8.TabIndex = 7;
            this.zebra8.TabStop = false;
            // 
            // ZebraMover
            // 
            this.ZebraMover.Enabled = true;
            this.ZebraMover.Interval = 10;
            this.ZebraMover.Tick += new System.EventHandler(this.ZebraMover_Tick);
            // 
            // OrangeCar
            // 
            this.OrangeCar.Image = ((System.Drawing.Image)(resources.GetObject("OrangeCar.Image")));
            this.OrangeCar.Location = new System.Drawing.Point(44, 132);
            this.OrangeCar.Name = "OrangeCar";
            this.OrangeCar.Size = new System.Drawing.Size(100, 50);
            this.OrangeCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrangeCar.TabIndex = 10;
            this.OrangeCar.TabStop = false;
            // 
            // MoveUp
            // 
            this.MoveUp.Interval = 10;
            this.MoveUp.Tick += new System.EventHandler(this.MoveUp_Tick);
            // 
            // MoveDown
            // 
            this.MoveDown.Interval = 10;
            this.MoveDown.Tick += new System.EventHandler(this.MoveDown_Tick);
            // 
            // MoveRight
            // 
            this.MoveRight.Interval = 10;
            this.MoveRight.Tick += new System.EventHandler(this.MoveRight_Tick);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Interval = 10;
            this.MoveLeft.Tick += new System.EventHandler(this.MoveLeft_Tick);
            // 
            // BlueCar
            // 
            this.BlueCar.Image = ((System.Drawing.Image)(resources.GetObject("BlueCar.Image")));
            this.BlueCar.Location = new System.Drawing.Point(773, 28);
            this.BlueCar.Name = "BlueCar";
            this.BlueCar.Size = new System.Drawing.Size(100, 50);
            this.BlueCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlueCar.TabIndex = 11;
            this.BlueCar.TabStop = false;
            // 
            // BlueMove
            // 
            this.BlueMove.Enabled = true;
            this.BlueMove.Interval = 10;
            this.BlueMove.Tick += new System.EventHandler(this.BlueMove_Tick);
            // 
            // PurpleCar
            // 
            this.PurpleCar.Image = ((System.Drawing.Image)(resources.GetObject("PurpleCar.Image")));
            this.PurpleCar.Location = new System.Drawing.Point(773, 132);
            this.PurpleCar.Name = "PurpleCar";
            this.PurpleCar.Size = new System.Drawing.Size(100, 50);
            this.PurpleCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PurpleCar.TabIndex = 12;
            this.PurpleCar.TabStop = false;
            // 
            // GreenCar
            // 
            this.GreenCar.Image = ((System.Drawing.Image)(resources.GetObject("GreenCar.Image")));
            this.GreenCar.Location = new System.Drawing.Point(773, 246);
            this.GreenCar.Name = "GreenCar";
            this.GreenCar.Size = new System.Drawing.Size(100, 50);
            this.GreenCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenCar.TabIndex = 13;
            this.GreenCar.TabStop = false;
            // 
            // PurpleMove
            // 
            this.PurpleMove.Enabled = true;
            this.PurpleMove.Interval = 10;
            this.PurpleMove.Tick += new System.EventHandler(this.PurpleMove_Tick);
            // 
            // GreenMove
            // 
            this.GreenMove.Enabled = true;
            this.GreenMove.Interval = 10;
            this.GreenMove.Tick += new System.EventHandler(this.GreenMove_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 26);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // GameEnd
            // 
            this.GameEnd.AutoSize = true;
            this.GameEnd.BackColor = System.Drawing.Color.Orange;
            this.GameEnd.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameEnd.ForeColor = System.Drawing.Color.Blue;
            this.GameEnd.Location = new System.Drawing.Point(185, 390);
            this.GameEnd.Name = "GameEnd";
            this.GameEnd.Size = new System.Drawing.Size(221, 45);
            this.GameEnd.TabIndex = 15;
            this.GameEnd.Text = "Game Over";
            this.GameEnd.Visible = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.Red;
            this.ScoreText.Location = new System.Drawing.Point(17, 368);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(102, 29);
            this.ScoreText.TabIndex = 16;
            this.ScoreText.Text = "Score: 0";
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.Location = new System.Drawing.Point(231, 470);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(118, 54);
            this.PlayAgainButton.TabIndex = 17;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Visible = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(617, 635);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.GameEnd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GreenCar);
            this.Controls.Add(this.PurpleCar);
            this.Controls.Add(this.BlueCar);
            this.Controls.Add(this.OrangeCar);
            this.Controls.Add(this.zebra8);
            this.Controls.Add(this.zebra7);
            this.Controls.Add(this.zebra6);
            this.Controls.Add(this.zebra5);
            this.Controls.Add(this.zebra4);
            this.Controls.Add(this.zebra3);
            this.Controls.Add(this.zebra2);
            this.Controls.Add(this.zebra1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.zebra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zebra8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangeCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zebra1;
        private System.Windows.Forms.PictureBox zebra2;
        private System.Windows.Forms.PictureBox zebra3;
        private System.Windows.Forms.PictureBox zebra4;
        private System.Windows.Forms.PictureBox zebra5;
        private System.Windows.Forms.PictureBox zebra6;
        private System.Windows.Forms.PictureBox zebra7;
        private System.Windows.Forms.PictureBox zebra8;
        private System.Windows.Forms.Timer ZebraMover;
        private System.Windows.Forms.PictureBox OrangeCar;
        private System.Windows.Forms.Timer MoveUp;
        private System.Windows.Forms.Timer MoveDown;
        private System.Windows.Forms.Timer MoveRight;
        private System.Windows.Forms.Timer MoveLeft;
        private System.Windows.Forms.PictureBox BlueCar;
        private System.Windows.Forms.Timer BlueMove;
        private System.Windows.Forms.PictureBox PurpleCar;
        private System.Windows.Forms.PictureBox GreenCar;
        private System.Windows.Forms.Timer PurpleMove;
        private System.Windows.Forms.Timer GreenMove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GameEnd;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}

