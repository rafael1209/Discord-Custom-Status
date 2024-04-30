namespace Discord_Custom_Status
{
    partial class DiscordCustomStatusForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordCustomStatusForm));
            runButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            detailsFild = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            smallImgKeyFild = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            largeImgKeyFild = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            smallImgTextFild = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            largeImgTextFild = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            label9 = new System.Windows.Forms.Label();
            stateTextFild = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            label14 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            timer = new System.Windows.Forms.Timer(components);
            textBox3 = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            ClientIDFild = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            isAddButtonsChecked = new System.Windows.Forms.CheckBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            label21 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            label22 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            runButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            runButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            runButton.Location = new System.Drawing.Point(327, 547);
            runButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            runButton.Name = "runButton";
            runButton.Size = new System.Drawing.Size(118, 44);
            runButton.TabIndex = 0;
            runButton.Text = "UPDATE";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(11, 117);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Client ID";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(251, 117);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "DETAILS";
            // 
            // detailsFild
            // 
            detailsFild.Anchor = System.Windows.Forms.AnchorStyles.None;
            detailsFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            detailsFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            detailsFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            detailsFild.Location = new System.Drawing.Point(251, 127);
            detailsFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            detailsFild.MaxLength = 100;
            detailsFild.Name = "detailsFild";
            detailsFild.Size = new System.Drawing.Size(195, 23);
            detailsFild.TabIndex = 3;
            detailsFild.Text = "Premium Plus";
            detailsFild.TextChanged += detailsFild_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(251, 323);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "START TIMESTAMP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(8, 322);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 15);
            label5.TabIndex = 16;
            label5.Text = "SMALL IMAGE KEY";
            // 
            // smallImgKeyFild
            // 
            smallImgKeyFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            smallImgKeyFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            smallImgKeyFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            smallImgKeyFild.Location = new System.Drawing.Point(11, 341);
            smallImgKeyFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            smallImgKeyFild.MaxLength = 100;
            smallImgKeyFild.Name = "smallImgKeyFild";
            smallImgKeyFild.Size = new System.Drawing.Size(195, 23);
            smallImgKeyFild.TabIndex = 15;
            smallImgKeyFild.Text = "verified";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(11, 187);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 15);
            label6.TabIndex = 14;
            label6.Text = "LARGE IMAGE KEY";
            // 
            // largeImgKeyFild
            // 
            largeImgKeyFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            largeImgKeyFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            largeImgKeyFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            largeImgKeyFild.Location = new System.Drawing.Point(11, 208);
            largeImgKeyFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            largeImgKeyFild.MaxLength = 100;
            largeImgKeyFild.Name = "largeImgKeyFild";
            largeImgKeyFild.Size = new System.Drawing.Size(195, 23);
            largeImgKeyFild.TabIndex = 13;
            largeImgKeyFild.Text = "_premium_";
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(0, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 23);
            label7.TabIndex = 49;
            // 
            // smallImgTextFild
            // 
            smallImgTextFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            smallImgTextFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            smallImgTextFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            smallImgTextFild.Location = new System.Drawing.Point(11, 404);
            smallImgTextFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            smallImgTextFild.MaxLength = 100;
            smallImgTextFild.Name = "smallImgTextFild";
            smallImgTextFild.Size = new System.Drawing.Size(195, 23);
            smallImgTextFild.TabIndex = 11;
            smallImgTextFild.Text = "Verified";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label8.Location = new System.Drawing.Point(11, 257);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(109, 15);
            label8.TabIndex = 10;
            label8.Text = "LARGE IMAGE TEXT";
            // 
            // largeImgTextFild
            // 
            largeImgTextFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            largeImgTextFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            largeImgTextFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            largeImgTextFild.Location = new System.Drawing.Point(11, 277);
            largeImgTextFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            largeImgTextFild.MaxLength = 100;
            largeImgTextFild.Name = "largeImgTextFild";
            largeImgTextFild.Size = new System.Drawing.Size(195, 23);
            largeImgTextFild.TabIndex = 9;
            largeImgTextFild.Text = "Premium Plus";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox1.Location = new System.Drawing.Point(392, 318);
            checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(64, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Disable";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label9.Location = new System.Drawing.Point(251, 187);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(37, 15);
            label9.TabIndex = 24;
            label9.Text = "STATE";
            // 
            // stateTextFild
            // 
            stateTextFild.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            stateTextFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            stateTextFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            stateTextFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            stateTextFild.Location = new System.Drawing.Point(251, 208);
            stateTextFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            stateTextFild.MaxLength = 100;
            stateTextFild.Name = "stateTextFild";
            stateTextFild.Size = new System.Drawing.Size(195, 23);
            stateTextFild.TabIndex = 23;
            stateTextFild.Text = "https://premiumplus-il.com/";
            stateTextFild.TextChanged += stateTextFild_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(108, 9);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 20);
            label4.TabIndex = 27;
            label4.Text = "Custom Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label10.Location = new System.Drawing.Point(108, 32);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(173, 20);
            label10.TabIndex = 28;
            label10.Text = "Discord Custom Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label11.Location = new System.Drawing.Point(108, 55);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(204, 20);
            label11.TabIndex = 29;
            label11.Text = "By rafael1209 and yawaflua";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label12.Location = new System.Drawing.Point(108, 80);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(110, 20);
            label12.TabIndex = 30;
            label12.Text = "Passed: 00:00";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label13.Location = new System.Drawing.Point(251, 257);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(40, 15);
            label13.TabIndex = 31;
            label13.Text = "PARTY";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox1.Location = new System.Drawing.Point(251, 277);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(46, 23);
            textBox1.TabIndex = 32;
            textBox1.Text = "1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox2.Location = new System.Drawing.Point(315, 256);
            checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(64, 19);
            checkBox2.TabIndex = 33;
            checkBox2.Text = "Disable";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label14.AutoSize = true;
            label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label14.Location = new System.Drawing.Point(305, 280);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(22, 15);
            label14.TabIndex = 34;
            label14.Text = "OF";
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox2.Location = new System.Drawing.Point(340, 277);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox2.MaxLength = 4;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(46, 23);
            textBox2.TabIndex = 35;
            textBox2.Text = "10";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // textBox3
            // 
            textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox3.Location = new System.Drawing.Point(329, 341);
            textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(33, 23);
            textBox3.TabIndex = 36;
            textBox3.Text = "0";
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label15.AutoSize = true;
            label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label15.Location = new System.Drawing.Point(370, 344);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(65, 15);
            label15.TabIndex = 37;
            label15.Text = "hour/s ago";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label17.Location = new System.Drawing.Point(244, 13);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(37, 15);
            label17.TabIndex = 39;
            label17.Text = "v6.0.0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label18.Location = new System.Drawing.Point(474, 9);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(15, 15);
            label18.TabIndex = 40;
            label18.Text = "X";
            label18.Click += label18_Click;
            label18.MouseEnter += label18_MouseEnter;
            label18.MouseLeave += label18_MouseLeave;
            // 
            // ClientIDFild
            // 
            ClientIDFild.BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientIDFild.Cursor = System.Windows.Forms.Cursors.IBeam;
            ClientIDFild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ClientIDFild.Location = new System.Drawing.Point(15, 139);
            ClientIDFild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ClientIDFild.MaxLength = 100;
            ClientIDFild.Name = "ClientIDFild";
            ClientIDFild.Size = new System.Drawing.Size(191, 23);
            ClientIDFild.TabIndex = 45;
            ClientIDFild.Text = "1168313472384249986";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.verifylogo;
            pictureBox2.Location = new System.Drawing.Point(78, 80);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(23, 23);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logorafael;
            pictureBox1.Location = new System.Drawing.Point(8, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(93, 92);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // isAddButtonsChecked
            // 
            isAddButtonsChecked.AutoSize = true;
            isAddButtonsChecked.Checked = true;
            isAddButtonsChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            isAddButtonsChecked.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            isAddButtonsChecked.Location = new System.Drawing.Point(251, 406);
            isAddButtonsChecked.Name = "isAddButtonsChecked";
            isAddButtonsChecked.Size = new System.Drawing.Size(93, 19);
            isAddButtonsChecked.TabIndex = 46;
            isAddButtonsChecked.Text = "Add button1";
            isAddButtonsChecked.UseVisualStyleBackColor = true;
            isAddButtonsChecked.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox4.Location = new System.Drawing.Point(11, 453);
            textBox4.MaxLength = 32;
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(195, 23);
            textBox4.TabIndex = 48;
            textBox4.Text = "https://yawaflua.ru/";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label16.Location = new System.Drawing.Point(11, 383);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(111, 15);
            label16.TabIndex = 50;
            label16.Text = "SMALL IMAGE TEXT";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label19.Location = new System.Drawing.Point(8, 435);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(67, 15);
            label19.TabIndex = 51;
            label19.Text = "Button Text";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label20.Location = new System.Drawing.Point(8, 489);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(67, 15);
            label20.TabIndex = 53;
            label20.Text = "Button URL";
            // 
            // textBox5
            // 
            textBox5.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox5.Location = new System.Drawing.Point(11, 510);
            textBox5.MaxLength = 32;
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(195, 23);
            textBox5.TabIndex = 52;
            textBox5.Text = "https://yawaflua.ru/";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label21.Location = new System.Drawing.Point(251, 489);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(73, 15);
            label21.TabIndex = 57;
            label21.Text = "Button2 URL";
            // 
            // textBox6
            // 
            textBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox6.Location = new System.Drawing.Point(251, 510);
            textBox6.MaxLength = 32;
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(194, 23);
            textBox6.TabIndex = 56;
            textBox6.Text = "https://rafaelchasman.ru/";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label22.Location = new System.Drawing.Point(251, 435);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(73, 15);
            label22.TabIndex = 55;
            label22.Text = "Button2 Text";
            // 
            // textBox7
            // 
            textBox7.BackColor = System.Drawing.SystemColors.WindowFrame;
            textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox7.Location = new System.Drawing.Point(251, 453);
            textBox7.MaxLength = 32;
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(194, 23);
            textBox7.TabIndex = 54;
            textBox7.Text = "https://rafaelchasman.ru/";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox3.Location = new System.Drawing.Point(353, 406);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(93, 19);
            checkBox3.TabIndex = 58;
            checkBox3.Text = "Add button2";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(11, 547);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 44);
            button1.TabIndex = 59;
            button1.Text = "Save settings";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SaveSettings;
            // 
            // DiscordCustomStatusForm
            // 
            AcceptButton = runButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(463, 603);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(label21);
            Controls.Add(textBox6);
            Controls.Add(label22);
            Controls.Add(textBox7);
            Controls.Add(label20);
            Controls.Add(textBox5);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(textBox4);
            Controls.Add(isAddButtonsChecked);
            Controls.Add(ClientIDFild);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label14);
            Controls.Add(checkBox2);
            Controls.Add(textBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(stateTextFild);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(smallImgKeyFild);
            Controls.Add(label6);
            Controls.Add(largeImgKeyFild);
            Controls.Add(label7);
            Controls.Add(smallImgTextFild);
            Controls.Add(label8);
            Controls.Add(largeImgTextFild);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(detailsFild);
            Controls.Add(label1);
            Controls.Add(runButton);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(479, 642);
            MinimumSize = new System.Drawing.Size(479, 642);
            Name = "DiscordCustomStatusForm";
            Text = "Discord Custom Status";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detailsFild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox smallImgKeyFild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox largeImgKeyFild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox smallImgTextFild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox largeImgTextFild;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stateTextFild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ClientIDFild;
        private System.Windows.Forms.CheckBox isAddButtonsChecked;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
    }
}

