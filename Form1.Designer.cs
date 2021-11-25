
namespace Stand_7872_11_00_400
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
            this.components = new System.ComponentModel.Container();
            this.buttonInit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxBright1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownBright1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxMotor1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownSpeed1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxBright2 = new System.Windows.Forms.CheckBox();
            this.numericUpDownBright2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxMotor2 = new System.Windows.Forms.CheckBox();
            this.numericUpDownSpeed2 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCollimators = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonStartAll = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.buttonApplyName = new System.Windows.Forms.Button();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.labelInit = new System.Windows.Forms.Label();
            this.buttonShowAllSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBright1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBright2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed2)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInit.Location = new System.Drawing.Point(22, 18);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(152, 38);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "Инициализация коллиматоров";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сетка 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.checkBoxBright1);
            this.groupBox3.Controls.Add(this.numericUpDownBright1);
            this.groupBox3.Location = new System.Drawing.Point(165, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Яркость";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(143, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 75);
            this.panel1.TabIndex = 8;
            // 
            // checkBoxBright1
            // 
            this.checkBoxBright1.AutoSize = true;
            this.checkBoxBright1.Enabled = false;
            this.checkBoxBright1.Location = new System.Drawing.Point(6, 54);
            this.checkBoxBright1.Name = "checkBoxBright1";
            this.checkBoxBright1.Size = new System.Drawing.Size(130, 17);
            this.checkBoxBright1.TabIndex = 1;
            this.checkBoxBright1.Text = "Включить подсветку";
            this.checkBoxBright1.UseVisualStyleBackColor = true;
            this.checkBoxBright1.CheckedChanged += new System.EventHandler(this.checkBoxBright1Events);
            // 
            // numericUpDownBright1
            // 
            this.numericUpDownBright1.Enabled = false;
            this.numericUpDownBright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBright1.Location = new System.Drawing.Point(41, 18);
            this.numericUpDownBright1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBright1.Name = "numericUpDownBright1";
            this.numericUpDownBright1.Size = new System.Drawing.Size(56, 29);
            this.numericUpDownBright1.TabIndex = 0;
            this.numericUpDownBright1.ValueChanged += new System.EventHandler(this.numericUpDownBright1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxMotor1);
            this.groupBox2.Controls.Add(this.numericUpDownSpeed1);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скорость";
            // 
            // checkBoxMotor1
            // 
            this.checkBoxMotor1.AutoSize = true;
            this.checkBoxMotor1.Enabled = false;
            this.checkBoxMotor1.Location = new System.Drawing.Point(6, 54);
            this.checkBoxMotor1.Name = "checkBoxMotor1";
            this.checkBoxMotor1.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMotor1.TabIndex = 1;
            this.checkBoxMotor1.Text = "Старт двигателя";
            this.checkBoxMotor1.UseVisualStyleBackColor = true;
            this.checkBoxMotor1.CheckedChanged += new System.EventHandler(this.checkBoxStart1Events);
            // 
            // numericUpDownSpeed1
            // 
            this.numericUpDownSpeed1.Enabled = false;
            this.numericUpDownSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSpeed1.Location = new System.Drawing.Point(39, 19);
            this.numericUpDownSpeed1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownSpeed1.Name = "numericUpDownSpeed1";
            this.numericUpDownSpeed1.Size = new System.Drawing.Size(56, 29);
            this.numericUpDownSpeed1.TabIndex = 0;
            this.numericUpDownSpeed1.ValueChanged += new System.EventHandler(this.numericUpDownSpeed1_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(22, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 109);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сетка 2";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(344, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(142, 142);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxBright2);
            this.groupBox5.Controls.Add(this.numericUpDownBright2);
            this.groupBox5.Location = new System.Drawing.Point(165, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(137, 75);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Яркость";
            // 
            // checkBoxBright2
            // 
            this.checkBoxBright2.AutoSize = true;
            this.checkBoxBright2.Enabled = false;
            this.checkBoxBright2.Location = new System.Drawing.Point(6, 54);
            this.checkBoxBright2.Name = "checkBoxBright2";
            this.checkBoxBright2.Size = new System.Drawing.Size(130, 17);
            this.checkBoxBright2.TabIndex = 1;
            this.checkBoxBright2.Text = "Включить подсветку";
            this.checkBoxBright2.UseVisualStyleBackColor = true;
            this.checkBoxBright2.CheckedChanged += new System.EventHandler(this.checkBoxBright2Events);
            // 
            // numericUpDownBright2
            // 
            this.numericUpDownBright2.Enabled = false;
            this.numericUpDownBright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBright2.Location = new System.Drawing.Point(41, 18);
            this.numericUpDownBright2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBright2.Name = "numericUpDownBright2";
            this.numericUpDownBright2.Size = new System.Drawing.Size(56, 29);
            this.numericUpDownBright2.TabIndex = 0;
            this.numericUpDownBright2.ValueChanged += new System.EventHandler(this.numericUpDownBright2_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxMotor2);
            this.groupBox6.Controls.Add(this.numericUpDownSpeed2);
            this.groupBox6.Location = new System.Drawing.Point(15, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(137, 75);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Скорость";
            // 
            // checkBoxMotor2
            // 
            this.checkBoxMotor2.AutoSize = true;
            this.checkBoxMotor2.Enabled = false;
            this.checkBoxMotor2.Location = new System.Drawing.Point(6, 54);
            this.checkBoxMotor2.Name = "checkBoxMotor2";
            this.checkBoxMotor2.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMotor2.TabIndex = 1;
            this.checkBoxMotor2.Text = "Старт двигателя";
            this.checkBoxMotor2.UseVisualStyleBackColor = true;
            this.checkBoxMotor2.CheckedChanged += new System.EventHandler(this.checkBoxStart2Events);
            // 
            // numericUpDownSpeed2
            // 
            this.numericUpDownSpeed2.Enabled = false;
            this.numericUpDownSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSpeed2.Location = new System.Drawing.Point(39, 19);
            this.numericUpDownSpeed2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownSpeed2.Name = "numericUpDownSpeed2";
            this.numericUpDownSpeed2.Size = new System.Drawing.Size(56, 29);
            this.numericUpDownSpeed2.TabIndex = 0;
            this.numericUpDownSpeed2.ValueChanged += new System.EventHandler(this.numericUpDownSpeed2_ValueChanged);
            // 
            // comboBoxCollimators
            // 
            this.comboBoxCollimators.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCollimators.Enabled = false;
            this.comboBoxCollimators.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCollimators.FormattingEnabled = true;
            this.comboBoxCollimators.Location = new System.Drawing.Point(15, 19);
            this.comboBoxCollimators.Name = "comboBoxCollimators";
            this.comboBoxCollimators.Size = new System.Drawing.Size(148, 24);
            this.comboBoxCollimators.TabIndex = 2;
            this.comboBoxCollimators.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollimators_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(22, 320);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 36);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(187, 33);
            this.progressBar1.Maximum = 7;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(154, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(12, 55);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(151, 35);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Загрузить настройки из файла";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 105);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 35);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить настройки в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartAll.Enabled = false;
            this.buttonStartAll.Location = new System.Drawing.Point(187, 320);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(154, 36);
            this.buttonStartAll.TabIndex = 3;
            this.buttonStartAll.Text = "Старт для всех доступных коллиматоров";
            this.buttonStartAll.UseVisualStyleBackColor = true;
            this.buttonStartAll.Click += new System.EventHandler(this.buttonStartAll_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.Location = new System.Drawing.Point(15, 49);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(148, 22);
            this.textBoxUserName.TabIndex = 6;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(436, 150);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 13);
            this.labelFileName.TabIndex = 7;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.buttonSave);
            this.groupBox8.Controls.Add(this.buttonLoad);
            this.groupBox8.Location = new System.Drawing.Point(369, 201);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(177, 155);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelFile);
            this.groupBox9.Location = new System.Drawing.Point(14, 13);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(149, 36);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Файл";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFile.Location = new System.Drawing.Point(10, 16);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(130, 15);
            this.labelFile.TabIndex = 9;
            this.labelFile.Text = ".........................................";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxPort);
            this.groupBox10.Location = new System.Drawing.Point(369, 18);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(81, 45);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Порт";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Enabled = false;
            this.textBoxPort.Location = new System.Drawing.Point(9, 15);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(61, 20);
            this.textBoxPort.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.buttonApplyName);
            this.groupBox11.Controls.Add(this.buttonChangeName);
            this.groupBox11.Controls.Add(this.comboBoxCollimators);
            this.groupBox11.Controls.Add(this.textBoxUserName);
            this.groupBox11.Location = new System.Drawing.Point(369, 77);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(177, 109);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Коллиматоры";
            // 
            // buttonApplyName
            // 
            this.buttonApplyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApplyName.Enabled = false;
            this.buttonApplyName.Location = new System.Drawing.Point(91, 77);
            this.buttonApplyName.Name = "buttonApplyName";
            this.buttonApplyName.Size = new System.Drawing.Size(72, 23);
            this.buttonApplyName.TabIndex = 7;
            this.buttonApplyName.Text = "Применить";
            this.buttonApplyName.UseVisualStyleBackColor = true;
            this.buttonApplyName.Click += new System.EventHandler(this.buttonApplyName_Click);
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeName.Enabled = false;
            this.buttonChangeName.Location = new System.Drawing.Point(15, 77);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(72, 23);
            this.buttonChangeName.TabIndex = 7;
            this.buttonChangeName.Text = "Изменить ";
            this.buttonChangeName.UseVisualStyleBackColor = true;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // labelInit
            // 
            this.labelInit.AutoSize = true;
            this.labelInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInit.Location = new System.Drawing.Point(184, 17);
            this.labelInit.Name = "labelInit";
            this.labelInit.Size = new System.Drawing.Size(119, 12);
            this.labelInit.TabIndex = 10;
            this.labelInit.Text = "Процесс инициализации...";
            this.labelInit.Visible = false;
            // 
            // buttonShowAllSettings
            // 
            this.buttonShowAllSettings.Enabled = false;
            this.buttonShowAllSettings.Location = new System.Drawing.Point(471, 23);
            this.buttonShowAllSettings.Name = "buttonShowAllSettings";
            this.buttonShowAllSettings.Size = new System.Drawing.Size(75, 40);
            this.buttonShowAllSettings.TabIndex = 11;
            this.buttonShowAllSettings.Text = "Показать настройки";
            this.buttonShowAllSettings.UseVisualStyleBackColor = true;
            this.buttonShowAllSettings.Click += new System.EventHandler(this.buttonShowAllSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 374);
            this.Controls.Add(this.buttonShowAllSettings);
            this.Controls.Add(this.labelInit);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStartAll);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "7872_11_00_400";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBright1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBright2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxBright1;
        private System.Windows.Forms.NumericUpDown numericUpDownBright1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxMotor1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxBright2;
        private System.Windows.Forms.NumericUpDown numericUpDownBright2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxMotor2;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed2;
        private System.Windows.Forms.ComboBox comboBoxCollimators;
        private System.Windows.Forms.Button buttonStart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonStartAll;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button buttonChangeName;
        private System.Windows.Forms.Label labelInit;
        private System.Windows.Forms.Button buttonApplyName;
        private System.Windows.Forms.Button buttonShowAllSettings;
    }
}

