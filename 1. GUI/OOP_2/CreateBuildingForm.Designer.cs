namespace Studying
{
    partial class CreateBuildingForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NoParameters = new System.Windows.Forms.RadioButton();
            this.OneParameter = new System.Windows.Forms.RadioButton();
            this.TwoParameters = new System.Windows.Forms.RadioButton();
            this.AllParameters = new System.Windows.Forms.RadioButton();
            this.Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StreetTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TypeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.YearTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.WidthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LengthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(406, 356);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество параметров";
            // 
            // NoParameters
            // 
            this.NoParameters.AutoSize = true;
            this.NoParameters.Location = new System.Drawing.Point(15, 34);
            this.NoParameters.Name = "NoParameters";
            this.NoParameters.Size = new System.Drawing.Size(108, 17);
            this.NoParameters.TabIndex = 2;
            this.NoParameters.TabStop = true;
            this.NoParameters.Text = "Без параметров";
            this.NoParameters.UseVisualStyleBackColor = true;
            this.NoParameters.CheckedChanged += new System.EventHandler(this.NoParameters_CheckedChanged);
            // 
            // OneParameter
            // 
            this.OneParameter.AutoSize = true;
            this.OneParameter.Location = new System.Drawing.Point(15, 57);
            this.OneParameter.Name = "OneParameter";
            this.OneParameter.Size = new System.Drawing.Size(94, 17);
            this.OneParameter.TabIndex = 3;
            this.OneParameter.TabStop = true;
            this.OneParameter.Text = "Только город";
            this.OneParameter.UseVisualStyleBackColor = true;
            this.OneParameter.CheckedChanged += new System.EventHandler(this.OneParameter_CheckedChanged);
            // 
            // TwoParameters
            // 
            this.TwoParameters.AutoSize = true;
            this.TwoParameters.Location = new System.Drawing.Point(346, 34);
            this.TwoParameters.Name = "TwoParameters";
            this.TwoParameters.Size = new System.Drawing.Size(135, 17);
            this.TwoParameters.TabIndex = 4;
            this.TwoParameters.TabStop = true;
            this.TwoParameters.Text = "Только город и улица";
            this.TwoParameters.UseVisualStyleBackColor = true;
            this.TwoParameters.CheckedChanged += new System.EventHandler(this.TwoParameters_CheckedChanged);
            // 
            // AllParameters
            // 
            this.AllParameters.AutoSize = true;
            this.AllParameters.Location = new System.Drawing.Point(346, 57);
            this.AllParameters.Name = "AllParameters";
            this.AllParameters.Size = new System.Drawing.Size(104, 17);
            this.AllParameters.TabIndex = 5;
            this.AllParameters.TabStop = true;
            this.AllParameters.Text = "Все параметры";
            this.AllParameters.UseVisualStyleBackColor = true;
            this.AllParameters.CheckedChanged += new System.EventHandler(this.AllParameters_CheckedChanged);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(12, 356);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "Добавить";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Параметры";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Город";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Улица";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Год постройки";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ширина";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Длина";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Высота";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(143, 133);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 16;
            this.CityTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CityTextBox_MaskInputRejected);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(143, 180);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetTextBox.TabIndex = 17;
            this.StreetTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.StreetTextBox_MaskInputRejected);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.TypeTextBox.Location = new System.Drawing.Point(143, 230);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 18;
            this.TypeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TypeTextBox_MaskInputRejected);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(143, 279);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearTextBox.TabIndex = 19;
            this.YearTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.YearTextBox_MaskInputRejected);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(381, 133);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 20;
            this.NumberTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NumberTextBox_MaskInputRejected);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(381, 180);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 21;
            this.WidthTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.WidthTextBox_MaskInputRejected);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(381, 230);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 22;
            this.LengthTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.LengthTextBox_MaskInputRejected);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(381, 279);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 23;
            this.HeightTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.HeightTextBox_MaskInputRejected);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(493, 391);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.AllParameters);
            this.Controls.Add(this.TwoParameters);
            this.Controls.Add(this.OneParameter);
            this.Controls.Add(this.NoParameters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateBuildingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно добавления здания";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton NoParameters;
        private System.Windows.Forms.RadioButton OneParameter;
        private System.Windows.Forms.RadioButton TwoParameters;
        private System.Windows.Forms.RadioButton AllParameters;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox CityTextBox;
        private System.Windows.Forms.MaskedTextBox StreetTextBox;
        private System.Windows.Forms.MaskedTextBox TypeTextBox;
        private System.Windows.Forms.MaskedTextBox YearTextBox;
        private System.Windows.Forms.MaskedTextBox NumberTextBox;
        private System.Windows.Forms.MaskedTextBox WidthTextBox;
        private System.Windows.Forms.MaskedTextBox LengthTextBox;
        private System.Windows.Forms.MaskedTextBox HeightTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}