namespace Studying
{
    partial class CreationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationForm));
            this.Exit = new System.Windows.Forms.Button();
            this.NumberOfFloorsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfApartmentsTextBox = new System.Windows.Forms.TextBox();
            this.YearBuiltTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.YearBuiltLabel = new System.Windows.Forms.Label();
            this.NumberOfApartmentsLabel = new System.Windows.Forms.Label();
            this.NumberOfFloorsLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PerformAddition = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxValues = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxValues.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(336, 31);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(168, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Отмена";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NumberOfFloorsTextBox
            // 
            this.NumberOfFloorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfFloorsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.NumberOfFloorsTextBox, 5);
            this.NumberOfFloorsTextBox.Location = new System.Drawing.Point(3, 249);
            this.NumberOfFloorsTextBox.Name = "NumberOfFloorsTextBox";
            this.NumberOfFloorsTextBox.Size = new System.Drawing.Size(232, 27);
            this.NumberOfFloorsTextBox.TabIndex = 13;
            this.NumberOfFloorsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberOfFloorsTextBox_Validating);
            // 
            // NumberOfApartmentsTextBox
            // 
            this.NumberOfApartmentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfApartmentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.NumberOfApartmentsTextBox, 5);
            this.NumberOfApartmentsTextBox.Location = new System.Drawing.Point(3, 206);
            this.NumberOfApartmentsTextBox.Name = "NumberOfApartmentsTextBox";
            this.NumberOfApartmentsTextBox.Size = new System.Drawing.Size(232, 27);
            this.NumberOfApartmentsTextBox.TabIndex = 12;
            this.NumberOfApartmentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberOfApartmentsTextBox_Validating);
            // 
            // YearBuiltTextBox
            // 
            this.YearBuiltTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.YearBuiltTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.YearBuiltTextBox, 5);
            this.YearBuiltTextBox.Location = new System.Drawing.Point(3, 166);
            this.YearBuiltTextBox.Name = "YearBuiltTextBox";
            this.YearBuiltTextBox.Size = new System.Drawing.Size(232, 27);
            this.YearBuiltTextBox.TabIndex = 11;
            this.YearBuiltTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.YearBuiltTextBox_Validating);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.NumberTextBox, 5);
            this.NumberTextBox.Location = new System.Drawing.Point(3, 126);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(232, 27);
            this.NumberTextBox.TabIndex = 10;
            this.NumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberTextBox_Validating);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.TypeTextBox, 5);
            this.TypeTextBox.Location = new System.Drawing.Point(3, 86);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(232, 27);
            this.TypeTextBox.TabIndex = 9;
            this.TypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TypeTextBox_Validating);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.StreetTextBox, 5);
            this.StreetTextBox.Location = new System.Drawing.Point(3, 46);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(232, 27);
            this.StreetTextBox.TabIndex = 8;
            this.StreetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.StreetTextBox_Validating);
            // 
            // StreetLabel
            // 
            this.StreetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetLabel.ForeColor = System.Drawing.Color.Black;
            this.StreetLabel.Location = new System.Drawing.Point(3, 40);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(276, 40);
            this.StreetLabel.TabIndex = 1;
            this.StreetLabel.Text = "Улица";
            this.StreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(3, 80);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(276, 40);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Тип";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberLabel
            // 
            this.NumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberLabel.Location = new System.Drawing.Point(3, 120);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(276, 40);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "Номер здания";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearBuiltLabel
            // 
            this.YearBuiltLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearBuiltLabel.ForeColor = System.Drawing.Color.Black;
            this.YearBuiltLabel.Location = new System.Drawing.Point(3, 160);
            this.YearBuiltLabel.Name = "YearBuiltLabel";
            this.YearBuiltLabel.Size = new System.Drawing.Size(276, 40);
            this.YearBuiltLabel.TabIndex = 4;
            this.YearBuiltLabel.Text = "Год постройки";
            this.YearBuiltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfApartmentsLabel
            // 
            this.NumberOfApartmentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfApartmentsLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberOfApartmentsLabel.Location = new System.Drawing.Point(3, 200);
            this.NumberOfApartmentsLabel.Name = "NumberOfApartmentsLabel";
            this.NumberOfApartmentsLabel.Size = new System.Drawing.Size(276, 40);
            this.NumberOfApartmentsLabel.TabIndex = 5;
            this.NumberOfApartmentsLabel.Text = "Количество квартир";
            this.NumberOfApartmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfFloorsLabel
            // 
            this.NumberOfFloorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfFloorsLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberOfFloorsLabel.Location = new System.Drawing.Point(3, 240);
            this.NumberOfFloorsLabel.Name = "NumberOfFloorsLabel";
            this.NumberOfFloorsLabel.Size = new System.Drawing.Size(276, 45);
            this.NumberOfFloorsLabel.TabIndex = 6;
            this.NumberOfFloorsLabel.Text = "Количество этажей";
            this.NumberOfFloorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.errorProvider.SetIconPadding(this.CityTextBox, 5);
            this.CityTextBox.Location = new System.Drawing.Point(3, 6);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(232, 27);
            this.CityTextBox.TabIndex = 7;
            this.CityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityTextBox_Validating);
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityLabel.ForeColor = System.Drawing.Color.Black;
            this.CityLabel.Location = new System.Drawing.Point(3, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(276, 40);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "Город";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformAddition
            // 
            this.PerformAddition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.PerformAddition.FlatAppearance.BorderSize = 0;
            this.PerformAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformAddition.Location = new System.Drawing.Point(82, 31);
            this.PerformAddition.Margin = new System.Windows.Forms.Padding(4);
            this.PerformAddition.Name = "PerformAddition";
            this.PerformAddition.Size = new System.Drawing.Size(168, 30);
            this.PerformAddition.TabIndex = 0;
            this.PerformAddition.Text = "Добавить";
            this.PerformAddition.UseVisualStyleBackColor = false;
            this.PerformAddition.Click += new System.EventHandler(this.PerformCreation_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.003F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.003F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tableLayoutPanel1.Controls.Add(this.PerformAddition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 93);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 341);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(600, 125);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParameters.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxParameters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(294, 317);
            this.groupBoxParameters.TabIndex = 4;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CityLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StreetLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TypeLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.NumberLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.YearBuiltLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.NumberOfApartmentsLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.NumberOfFloorsLabel, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 285);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxValues
            // 
            this.groupBoxValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxValues.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxValues.Location = new System.Drawing.Point(303, 3);
            this.groupBoxValues.Name = "groupBoxValues";
            this.groupBoxValues.Size = new System.Drawing.Size(294, 317);
            this.groupBoxValues.TabIndex = 5;
            this.groupBoxValues.TabStop = false;
            this.groupBoxValues.Text = "Значения";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.NumberOfFloorsTextBox, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.NumberOfApartmentsTextBox, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.CityTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.YearBuiltTextBox, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.StreetTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.NumberTextBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TypeTextBox, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(281, 285);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBoxParameters, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBoxValues, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(600, 323);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(624, 478);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBoxActions);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "CreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового дома";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxValues.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Exit;
        private Button PerformAddition;
        private Label CityLabel;
        private Label StreetLabel;
        private Label TypeLabel;
        private Label NumberLabel;
        private Label YearBuiltLabel;
        private Label NumberOfApartmentsLabel;
        private Label NumberOfFloorsLabel;
        private TextBox CityTextBox;
        private TextBox NumberOfFloorsTextBox;
        private TextBox NumberOfApartmentsTextBox;
        private TextBox YearBuiltTextBox;
        private TextBox NumberTextBox;
        private TextBox TypeTextBox;
        private TextBox StreetTextBox;
        private ErrorProvider errorProvider;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxActions;
        private GroupBox groupBoxValues;
        private GroupBox groupBoxParameters;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}

