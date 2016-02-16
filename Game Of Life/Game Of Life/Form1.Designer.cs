namespace Game_Of_Life
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(760, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Click);
            // 
            // button_Create_World
            // 
            this.button_Create_World.Location = new System.Drawing.Point(12, 12);
            this.button_Create_World.Name = "button_Create_World";
            this.button_Create_World.Size = new System.Drawing.Size(85, 23);
            this.button_Create_World.TabIndex = 1;
            this.button_Create_World.Text = "Создать мир";
            this.button_Create_World.UseVisualStyleBackColor = true;
            this.button_Create_World.Click += new System.EventHandler(this.button_Create_World_Click);
            // 
            // button_Next_Gen
            // 
            this.button_Next_Gen.Location = new System.Drawing.Point(243, 12);
            this.button_Next_Gen.Name = "button_Next_Gen";
            this.button_Next_Gen.Size = new System.Drawing.Size(132, 23);
            this.button_Next_Gen.TabIndex = 2;
            this.button_Next_Gen.Text = "Следующее поколение";
            this.button_Next_Gen.UseVisualStyleBackColor = true;
            this.button_Next_Gen.Click += new System.EventHandler(this.button_Next_Gen_Click);
            // 
            // button_Exterminatus
            // 
            this.button_Exterminatus.Location = new System.Drawing.Point(595, 6);
            this.button_Exterminatus.Name = "button_Exterminatus";
            this.button_Exterminatus.Size = new System.Drawing.Size(177, 35);
            this.button_Exterminatus.TabIndex = 3;
            this.button_Exterminatus.Text = "ЭКСТЕРМИНАТУС";
            this.button_Exterminatus.UseVisualStyleBackColor = true;
            this.button_Exterminatus.Click += new System.EventHandler(this.button_Exterminatus_Click);
            // 
            // button_Let_Them_Go
            // 
            this.button_Let_Them_Go.Location = new System.Drawing.Point(381, 12);
            this.button_Let_Them_Go.Name = "button_Let_Them_Go";
            this.button_Let_Them_Go.Size = new System.Drawing.Size(171, 23);
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
            this.button_Create_Population.Location = new System.Drawing.Point(103, 12);
            this.button_Create_Population.Name = "button_Create_Population";
            this.button_Create_Population.Size = new System.Drawing.Size(118, 23);
            this.button_Create_Population.TabIndex = 5;
            this.button_Create_Population.Text = "Создать популяцию";
            this.button_Create_Population.UseVisualStyleBackColor = true;
            this.button_Create_Population.Click += new System.EventHandler(this.button_Create_Population_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_Create_Population);
            this.Controls.Add(this.button_Let_Them_Go);
            this.Controls.Add(this.button_Exterminatus);
            this.Controls.Add(this.button_Next_Gen);
            this.Controls.Add(this.button_Create_World);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
    }
}

