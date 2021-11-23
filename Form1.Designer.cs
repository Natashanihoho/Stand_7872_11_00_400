
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
            this.checkBoxBright1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownBright1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxMotor1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownSpeed1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.textBoxUserNote = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(22, 18);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(131, 38);
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
            this.groupBox3.Controls.Add(this.checkBoxBright1);
            this.groupBox3.Controls.Add(this.numericUpDownBright1);
            this.groupBox3.Location = new System.Drawing.Point(165, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Яркость";
            // 
            // checkBoxBright1
            // 
            this.checkBoxBright1.AutoSize = true;
            this.checkBoxBright1.Location = new System.Drawing.Point(6, 54);
            this.checkBoxBright1.Name = "checkBoxBright1";
            this.checkBoxBright1.Size = new System.Drawing.Size(130, 17);
            this.checkBoxBright1.TabIndex = 1;
            this.checkBoxBright1.Text = "Включить подсветку";
            this.checkBoxBright1.UseVisualStyleBackColor = true;
            this.checkBoxBright1.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // numericUpDownBright1
            // 
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
            this.checkBoxMotor1.Location = new System.Drawing.Point(6, 54);
            this.checkBoxMotor1.Name = "checkBoxMotor1";
            this.checkBoxMotor1.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMotor1.TabIndex = 1;
            this.checkBoxMotor1.Text = "Старт двигателя";
            this.checkBoxMotor1.UseVisualStyleBackColor = true;
            this.checkBoxMotor1.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // numericUpDownSpeed1
            // 
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
            this.checkBoxBright2.Location = new System.Drawing.Point(6, 54);
            this.checkBoxBright2.Name = "checkBoxBright2";
            this.checkBoxBright2.Size = new System.Drawing.Size(130, 17);
            this.checkBoxBright2.TabIndex = 1;
            this.checkBoxBright2.Text = "Включить подсветку";
            this.checkBoxBright2.UseVisualStyleBackColor = true;
            this.checkBoxBright2.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // numericUpDownBright2
            // 
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
            this.checkBoxMotor2.Location = new System.Drawing.Point(6, 54);
            this.checkBoxMotor2.Name = "checkBoxMotor2";
            this.checkBoxMotor2.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMotor2.TabIndex = 1;
            this.checkBoxMotor2.Text = "Старт двигателя";
            this.checkBoxMotor2.UseVisualStyleBackColor = true;
            this.checkBoxMotor2.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // numericUpDownSpeed2
            // 
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
            this.comboBoxCollimators.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCollimators.FormattingEnabled = true;
            this.comboBoxCollimators.Location = new System.Drawing.Point(366, 33);
            this.comboBoxCollimators.Name = "comboBoxCollimators";
            this.comboBoxCollimators.Size = new System.Drawing.Size(142, 24);
            this.comboBoxCollimators.TabIndex = 2;
            this.comboBoxCollimators.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollimators_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(22, 320);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 36);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
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
            this.buttonLoad.Location = new System.Drawing.Point(366, 274);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(142, 35);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Загрузить настройки из файла";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(366, 320);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 35);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить настройки     в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.Location = new System.Drawing.Point(187, 320);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(154, 36);
            this.buttonStartAll.TabIndex = 3;
            this.buttonStartAll.Text = "Старт для всех доступных коллиматоров";
            this.buttonStartAll.UseVisualStyleBackColor = true;
            this.buttonStartAll.Click += new System.EventHandler(this.buttonStartAll_Click);
            // 
            // textBoxUserNote
            // 
            this.textBoxUserNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserNote.Location = new System.Drawing.Point(366, 86);
            this.textBoxUserNote.Name = "textBoxUserNote";
            this.textBoxUserNote.Size = new System.Drawing.Size(142, 22);
            this.textBoxUserNote.TabIndex = 6;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(372, 249);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(33, 13);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "файл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 368);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxUserNote);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStartAll);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxCollimators);
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
        private System.Windows.Forms.TextBox textBoxUserNote;
        private System.Windows.Forms.Label labelFileName;
    }
}

