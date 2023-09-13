namespace cs_Lab1_Medvedev_8I21
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonGetRand = new System.Windows.Forms.Button();
            this.buttonGetUser = new System.Windows.Forms.Button();
            this.listBoxGame = new System.Windows.Forms.ListBox();
            this.listBoxCurrent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Левая часть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Правая часть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Игра";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Текущая кость";
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(224, 272);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(100, 22);
            this.textBoxRight.TabIndex = 22;
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(35, 272);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(100, 22);
            this.textBoxLeft.TabIndex = 21;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(644, 370);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(89, 30);
            this.buttonNewGame.TabIndex = 20;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(422, 216);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(99, 23);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(422, 164);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(99, 46);
            this.buttonStep.TabIndex = 18;
            this.buttonStep.Text = "Сделать ход";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Visible = false;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonGetRand
            // 
            this.buttonGetRand.Location = new System.Drawing.Point(75, 314);
            this.buttonGetRand.Name = "buttonGetRand";
            this.buttonGetRand.Size = new System.Drawing.Size(204, 29);
            this.buttonGetRand.TabIndex = 17;
            this.buttonGetRand.Text = "Задать случайные значения";
            this.buttonGetRand.UseVisualStyleBackColor = true;
            this.buttonGetRand.Click += new System.EventHandler(this.buttonGetRand_Click);
            // 
            // buttonGetUser
            // 
            this.buttonGetUser.Location = new System.Drawing.Point(141, 259);
            this.buttonGetUser.Name = "buttonGetUser";
            this.buttonGetUser.Size = new System.Drawing.Size(75, 49);
            this.buttonGetUser.TabIndex = 16;
            this.buttonGetUser.Text = "Задать кость";
            this.buttonGetUser.UseVisualStyleBackColor = true;
            this.buttonGetUser.Click += new System.EventHandler(this.buttonGetUser_Click);
            // 
            // listBoxGame
            // 
            this.listBoxGame.FormattingEnabled = true;
            this.listBoxGame.ItemHeight = 16;
            this.listBoxGame.Location = new System.Drawing.Point(614, 74);
            this.listBoxGame.Name = "listBoxGame";
            this.listBoxGame.Size = new System.Drawing.Size(154, 276);
            this.listBoxGame.TabIndex = 15;
            // 
            // listBoxCurrent
            // 
            this.listBoxCurrent.FormattingEnabled = true;
            this.listBoxCurrent.ItemHeight = 16;
            this.listBoxCurrent.Location = new System.Drawing.Point(422, 74);
            this.listBoxCurrent.Name = "listBoxCurrent";
            this.listBoxCurrent.Size = new System.Drawing.Size(99, 84);
            this.listBoxCurrent.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxLeft);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.buttonGetRand);
            this.Controls.Add(this.buttonGetUser);
            this.Controls.Add(this.listBoxGame);
            this.Controls.Add(this.listBoxCurrent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonGetRand;
        private System.Windows.Forms.Button buttonGetUser;
        private System.Windows.Forms.ListBox listBoxGame;
        private System.Windows.Forms.ListBox listBoxCurrent;
    }
}

