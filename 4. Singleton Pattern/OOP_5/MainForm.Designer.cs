namespace Studying
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Exit = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NumberOfFloorsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfApartmentsTextBox = new System.Windows.Forms.TextBox();
            this.YearBuiltTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.YearBuiltLabel = new System.Windows.Forms.Label();
            this.NumberOfApartmentsLabel = new System.Windows.Forms.Label();
            this.NumberOfFloorsLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.PerformChange = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Parameters = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(454, 30);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(142, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.ColumnCount = 3;
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19355F));
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19355F));
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.612906F));
            this.MenuPanel.Controls.Add(this.NumberOfFloorsTextBox, 1, 6);
            this.MenuPanel.Controls.Add(this.NumberOfApartmentsTextBox, 1, 5);
            this.MenuPanel.Controls.Add(this.YearBuiltTextBox, 1, 4);
            this.MenuPanel.Controls.Add(this.NumberTextBox, 1, 3);
            this.MenuPanel.Controls.Add(this.TypeTextBox, 1, 2);
            this.MenuPanel.Controls.Add(this.StreetTextBox, 1, 1);
            this.MenuPanel.Controls.Add(this.CityLabel, 0, 0);
            this.MenuPanel.Controls.Add(this.StreetLabel, 0, 1);
            this.MenuPanel.Controls.Add(this.TypeLabel, 0, 2);
            this.MenuPanel.Controls.Add(this.NumberLabel, 0, 3);
            this.MenuPanel.Controls.Add(this.YearBuiltLabel, 0, 4);
            this.MenuPanel.Controls.Add(this.NumberOfApartmentsLabel, 0, 5);
            this.MenuPanel.Controls.Add(this.NumberOfFloorsLabel, 0, 6);
            this.MenuPanel.Controls.Add(this.CityTextBox, 1, 0);
            this.MenuPanel.Location = new System.Drawing.Point(12, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.RowCount = 7;
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MenuPanel.Size = new System.Drawing.Size(600, 330);
            this.MenuPanel.TabIndex = 1;
            // 
            // NumberOfFloorsTextBox
            // 
            this.NumberOfFloorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfFloorsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.NumberOfFloorsTextBox, 5);
            this.NumberOfFloorsTextBox.Location = new System.Drawing.Point(286, 292);
            this.NumberOfFloorsTextBox.Name = "NumberOfFloorsTextBox";
            this.NumberOfFloorsTextBox.Size = new System.Drawing.Size(277, 27);
            this.NumberOfFloorsTextBox.TabIndex = 13;
            this.NumberOfFloorsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberOfFloorsTextBox_Validating);
            // 
            // NumberOfApartmentsTextBox
            // 
            this.NumberOfApartmentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfApartmentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.NumberOfApartmentsTextBox, 5);
            this.NumberOfApartmentsTextBox.Location = new System.Drawing.Point(286, 245);
            this.NumberOfApartmentsTextBox.Name = "NumberOfApartmentsTextBox";
            this.NumberOfApartmentsTextBox.Size = new System.Drawing.Size(277, 27);
            this.NumberOfApartmentsTextBox.TabIndex = 12;
            this.NumberOfApartmentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberOfApartmentsTextBox_Validating);
            // 
            // YearBuiltTextBox
            // 
            this.YearBuiltTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.YearBuiltTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.YearBuiltTextBox, 5);
            this.YearBuiltTextBox.Location = new System.Drawing.Point(286, 198);
            this.YearBuiltTextBox.Name = "YearBuiltTextBox";
            this.YearBuiltTextBox.Size = new System.Drawing.Size(277, 27);
            this.YearBuiltTextBox.TabIndex = 11;
            this.YearBuiltTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.YearBuiltTextBox_Validating);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.NumberTextBox, 5);
            this.NumberTextBox.Location = new System.Drawing.Point(286, 151);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(277, 27);
            this.NumberTextBox.TabIndex = 10;
            this.NumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberTextBox_Validating);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.TypeTextBox, 5);
            this.TypeTextBox.Location = new System.Drawing.Point(286, 104);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(277, 27);
            this.TypeTextBox.TabIndex = 9;
            this.TypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TypeTextBox_Validating);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.StreetTextBox, 5);
            this.StreetTextBox.Location = new System.Drawing.Point(286, 57);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(277, 27);
            this.StreetTextBox.TabIndex = 8;
            this.StreetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.StreetTextBox_Validating);
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CityLabel.ForeColor = System.Drawing.Color.Black;
            this.CityLabel.Location = new System.Drawing.Point(3, 6);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(277, 35);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "Город";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreetLabel
            // 
            this.StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StreetLabel.ForeColor = System.Drawing.Color.Black;
            this.StreetLabel.Location = new System.Drawing.Point(3, 53);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(277, 35);
            this.StreetLabel.TabIndex = 1;
            this.StreetLabel.Text = "Улица";
            this.StreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(3, 100);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(277, 35);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Тип";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberLabel
            // 
            this.NumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberLabel.Location = new System.Drawing.Point(3, 147);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(277, 35);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "Номер здания";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearBuiltLabel
            // 
            this.YearBuiltLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearBuiltLabel.ForeColor = System.Drawing.Color.Black;
            this.YearBuiltLabel.Location = new System.Drawing.Point(3, 194);
            this.YearBuiltLabel.Name = "YearBuiltLabel";
            this.YearBuiltLabel.Size = new System.Drawing.Size(277, 35);
            this.YearBuiltLabel.TabIndex = 4;
            this.YearBuiltLabel.Text = "Год постройки";
            this.YearBuiltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfApartmentsLabel
            // 
            this.NumberOfApartmentsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfApartmentsLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberOfApartmentsLabel.Location = new System.Drawing.Point(3, 241);
            this.NumberOfApartmentsLabel.Name = "NumberOfApartmentsLabel";
            this.NumberOfApartmentsLabel.Size = new System.Drawing.Size(277, 35);
            this.NumberOfApartmentsLabel.TabIndex = 5;
            this.NumberOfApartmentsLabel.Text = "Количество квартир";
            this.NumberOfApartmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfFloorsLabel
            // 
            this.NumberOfFloorsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfFloorsLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberOfFloorsLabel.Location = new System.Drawing.Point(3, 288);
            this.NumberOfFloorsLabel.Name = "NumberOfFloorsLabel";
            this.NumberOfFloorsLabel.Size = new System.Drawing.Size(277, 35);
            this.NumberOfFloorsLabel.TabIndex = 6;
            this.NumberOfFloorsLabel.Text = "Количество этажей";
            this.NumberOfFloorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.CityTextBox, 5);
            this.CityTextBox.Location = new System.Drawing.Point(286, 10);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(277, 27);
            this.CityTextBox.TabIndex = 7;
            this.CityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityTextBox_Validating);
            // 
            // PerformChange
            // 
            this.PerformChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.PerformChange.FlatAppearance.BorderSize = 0;
            this.PerformChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformChange.Location = new System.Drawing.Point(4, 30);
            this.PerformChange.Margin = new System.Windows.Forms.Padding(4);
            this.PerformChange.Name = "PerformChange";
            this.PerformChange.Size = new System.Drawing.Size(142, 30);
            this.PerformChange.TabIndex = 0;
            this.PerformChange.Text = "Изменить";
            this.PerformChange.UseVisualStyleBackColor = false;
            this.PerformChange.Click += new System.EventHandler(this.PerformChange_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.PerformChange, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Parameters, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 348);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 90);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Parameters
            // 
            this.Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.Parameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parameters.Location = new System.Drawing.Point(229, 30);
            this.Parameters.Margin = new System.Windows.Forms.Padding(4);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(142, 30);
            this.Parameters.TabIndex = 1;
            this.Parameters.Text = "Параметры";
            this.Parameters.UseVisualStyleBackColor = false;
            this.Parameters.Click += new System.EventHandler(this.Parameters_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(624, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singleton";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TableLayoutPanel MenuPanel;
        private System.Windows.Forms.Button PerformChange;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label YearBuiltLabel;
        private System.Windows.Forms.Label NumberOfApartmentsLabel;
        private System.Windows.Forms.Label NumberOfFloorsLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox NumberOfFloorsTextBox;
        private System.Windows.Forms.TextBox NumberOfApartmentsTextBox;
        private System.Windows.Forms.TextBox YearBuiltTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Parameters;
    }
}

