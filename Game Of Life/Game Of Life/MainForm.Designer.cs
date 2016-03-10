namespace Game_Of_Life
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Create_World = new System.Windows.Forms.Button();
            this.button_Next_Gen = new System.Windows.Forms.Button();
            this.button_Exterminatus = new System.Windows.Forms.Button();
            this.button_Let_Them_Go = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Create_Population = new System.Windows.Forms.Button();
            this.label_Count_Live = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Count_Dead = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Count_Time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 117);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(760, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Click);
            // 
            // button_Create_World
            // 
            this.button_Create_World.Location = new System.Drawing.Point(6, 19);
            this.button_Create_World.Name = "button_Create_World";
            this.button_Create_World.Size = new System.Drawing.Size(85, 23);
            this.button_Create_World.TabIndex = 1;
            this.button_Create_World.Text = "Create world";
            this.button_Create_World.UseVisualStyleBackColor = true;
            this.button_Create_World.Click += new System.EventHandler(this.button_Create_World_Click);
            // 
            // button_Next_Gen
            // 
            this.button_Next_Gen.Location = new System.Drawing.Point(6, 48);
            this.button_Next_Gen.Name = "button_Next_Gen";
            this.button_Next_Gen.Size = new System.Drawing.Size(190, 23);
            this.button_Next_Gen.TabIndex = 2;
            this.button_Next_Gen.Text = "Next generation";
            this.button_Next_Gen.UseVisualStyleBackColor = true;
            this.button_Next_Gen.Click += new System.EventHandler(this.button_Next_Gen_Click);
            // 
            // button_Exterminatus
            // 
            this.button_Exterminatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exterminatus.Location = new System.Drawing.Point(579, 41);
            this.button_Exterminatus.Name = "button_Exterminatus";
            this.button_Exterminatus.Size = new System.Drawing.Size(175, 35);
            this.button_Exterminatus.TabIndex = 3;
            this.button_Exterminatus.Text = "EXTERMINATUS";
            this.button_Exterminatus.UseVisualStyleBackColor = true;
            this.button_Exterminatus.Click += new System.EventHandler(this.button_Exterminatus_Click);
            // 
            // button_Let_Them_Go
            // 
            this.button_Let_Them_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Let_Them_Go.Location = new System.Drawing.Point(6, 76);
            this.button_Let_Them_Go.Name = "button_Let_Them_Go";
            this.button_Let_Them_Go.Size = new System.Drawing.Size(190, 23);
            this.button_Let_Them_Go.TabIndex = 4;
            this.button_Let_Them_Go.Text = "HOLY SHIT! THEY ARE ALIVE!";
            this.button_Let_Them_Go.UseVisualStyleBackColor = true;
            this.button_Let_Them_Go.Click += new System.EventHandler(this.button_Let_Them_Go_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Create_Population
            // 
            this.button_Create_Population.Location = new System.Drawing.Point(97, 19);
            this.button_Create_Population.Name = "button_Create_Population";
            this.button_Create_Population.Size = new System.Drawing.Size(99, 23);
            this.button_Create_Population.TabIndex = 5;
            this.button_Create_Population.Text = "Create population";
            this.button_Create_Population.UseVisualStyleBackColor = true;
            this.button_Create_Population.Click += new System.EventHandler(this.button_Create_Population_Click);
            // 
            // label_Count_Live
            // 
            this.label_Count_Live.AutoSize = true;
            this.label_Count_Live.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Count_Live.Location = new System.Drawing.Point(81, 16);
            this.label_Count_Live.Name = "label_Count_Live";
            this.label_Count_Live.Size = new System.Drawing.Size(17, 17);
            this.label_Count_Live.TabIndex = 6;
            this.label_Count_Live.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "still live:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "already dead:";
            // 
            // label_Count_Dead
            // 
            this.label_Count_Dead.AutoSize = true;
            this.label_Count_Dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Count_Dead.Location = new System.Drawing.Point(121, 38);
            this.label_Count_Dead.Name = "label_Count_Dead";
            this.label_Count_Dead.Size = new System.Drawing.Size(17, 17);
            this.label_Count_Dead.TabIndex = 9;
            this.label_Count_Dead.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_Exterminatus);
            this.groupBox1.Controls.Add(this.button_Create_World);
            this.groupBox1.Controls.Add(this.button_Create_Population);
            this.groupBox1.Controls.Add(this.button_Next_Gen);
            this.groupBox1.Controls.Add(this.button_Let_Them_Go);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Count_Time);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_Count_Dead);
            this.groupBox2.Controls.Add(this.label_Count_Live);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(202, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistic";
            // 
            // label_Count_Time
            // 
            this.label_Count_Time.AutoSize = true;
            this.label_Count_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Count_Time.Location = new System.Drawing.Point(84, 63);
            this.label_Count_Time.Name = "label_Count_Time";
            this.label_Count_Time.Size = new System.Drawing.Size(17, 17);
            this.label_Count_Time.TabIndex = 11;
            this.label_Count_Time.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "time left:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Create_World;
        private System.Windows.Forms.Button button_Next_Gen;
        private System.Windows.Forms.Button button_Exterminatus;
        private System.Windows.Forms.Button button_Let_Them_Go;
        internal System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Create_Population;
        private System.Windows.Forms.Label label_Count_Live;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Count_Dead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Count_Time;
        private System.Windows.Forms.Label label4;
    }
}

