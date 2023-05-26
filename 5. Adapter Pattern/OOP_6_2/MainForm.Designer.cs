namespace Studying
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGetJSON = new System.Windows.Forms.Button();
            this.buttonGetXML = new System.Windows.Forms.Button();
            this.buttonGetYAML = new System.Windows.Forms.Button();
            this.buttonGetCSV = new System.Windows.Forms.Button();
            this.groupBoxObjectsAdaptation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxObjectsManipulation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOfHouses = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.DeletionSignal = new System.Windows.Forms.Label();
            this.groupBoxObjectsAdaptation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxObjectsManipulation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.Location = new System.Drawing.Point(3, 18);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(152, 32);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(3, 75);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 32);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonGetJSON
            // 
            this.buttonGetJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonGetJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetJSON.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetJSON.Location = new System.Drawing.Point(3, 25);
            this.buttonGetJSON.Name = "buttonGetJSON";
            this.buttonGetJSON.Size = new System.Drawing.Size(152, 30);
            this.buttonGetJSON.TabIndex = 2;
            this.buttonGetJSON.Text = "JSON";
            this.buttonGetJSON.UseVisualStyleBackColor = false;
            this.buttonGetJSON.Click += new System.EventHandler(this.buttonGetJSON_Click);
            // 
            // buttonGetXML
            // 
            this.buttonGetXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonGetXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetXML.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetXML.Location = new System.Drawing.Point(3, 85);
            this.buttonGetXML.Name = "buttonGetXML";
            this.buttonGetXML.Size = new System.Drawing.Size(152, 30);
            this.buttonGetXML.TabIndex = 3;
            this.buttonGetXML.Text = "XML";
            this.buttonGetXML.UseVisualStyleBackColor = false;
            this.buttonGetXML.Click += new System.EventHandler(this.buttonGetXML_Click);
            // 
            // buttonGetYAML
            // 
            this.buttonGetYAML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetYAML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonGetYAML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetYAML.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetYAML.Location = new System.Drawing.Point(3, 145);
            this.buttonGetYAML.Name = "buttonGetYAML";
            this.buttonGetYAML.Size = new System.Drawing.Size(152, 30);
            this.buttonGetYAML.TabIndex = 4;
            this.buttonGetYAML.Text = "YAML";
            this.buttonGetYAML.UseVisualStyleBackColor = false;
            this.buttonGetYAML.Click += new System.EventHandler(this.buttonGetYAML_Click);
            // 
            // buttonGetCSV
            // 
            this.buttonGetCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonGetCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetCSV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetCSV.Location = new System.Drawing.Point(3, 205);
            this.buttonGetCSV.Name = "buttonGetCSV";
            this.buttonGetCSV.Size = new System.Drawing.Size(152, 30);
            this.buttonGetCSV.TabIndex = 5;
            this.buttonGetCSV.Text = "CSV";
            this.buttonGetCSV.UseVisualStyleBackColor = false;
            this.buttonGetCSV.Click += new System.EventHandler(this.buttonGetCSV_Click);
            // 
            // groupBoxObjectsAdaptation
            // 
            this.groupBoxObjectsAdaptation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxObjectsAdaptation.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxObjectsAdaptation.Location = new System.Drawing.Point(802, 189);
            this.groupBoxObjectsAdaptation.Name = "groupBoxObjectsAdaptation";
            this.groupBoxObjectsAdaptation.Size = new System.Drawing.Size(170, 294);
            this.groupBoxObjectsAdaptation.TabIndex = 7;
            this.groupBoxObjectsAdaptation.TabStop = false;
            this.groupBoxObjectsAdaptation.Text = "Адаптирование объектов";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonGetJSON, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGetCSV, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonGetXML, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonGetYAML, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxObjectsManipulation
            // 
            this.groupBoxObjectsManipulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxObjectsManipulation.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxObjectsManipulation.Location = new System.Drawing.Point(802, 12);
            this.groupBoxObjectsManipulation.Name = "groupBoxObjectsManipulation";
            this.groupBoxObjectsManipulation.Size = new System.Drawing.Size(170, 159);
            this.groupBoxObjectsManipulation.TabIndex = 8;
            this.groupBoxObjectsManipulation.TabStop = false;
            this.groupBoxObjectsManipulation.Text = "Работа с объектами";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonCreate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DeletionSignal, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewOfHouses
            // 
            this.dataGridViewOfHouses.AllowUserToAddRows = false;
            this.dataGridViewOfHouses.AllowUserToOrderColumns = true;
            this.dataGridViewOfHouses.AllowUserToResizeRows = false;
            this.dataGridViewOfHouses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOfHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOfHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.dataGridViewOfHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfHouses.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOfHouses.MultiSelect = false;
            this.dataGridViewOfHouses.Name = "dataGridViewOfHouses";
            this.dataGridViewOfHouses.RowHeadersWidth = 50;
            this.dataGridViewOfHouses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewOfHouses.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOfHouses.RowTemplate.Height = 25;
            this.dataGridViewOfHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOfHouses.Size = new System.Drawing.Size(784, 541);
            this.dataGridViewOfHouses.TabIndex = 9;
            this.dataGridViewOfHouses.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOfHouses_DataError);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(811, 524);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 29);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DeletionSignal
            // 
            this.DeletionSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletionSignal.AutoSize = true;
            this.DeletionSignal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletionSignal.Location = new System.Drawing.Point(3, 114);
            this.DeletionSignal.Name = "DeletionSignal";
            this.DeletionSignal.Size = new System.Drawing.Size(152, 14);
            this.DeletionSignal.TabIndex = 2;
            this.DeletionSignal.Text = "Успешное удаление";
            this.DeletionSignal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeletionSignal.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewOfHouses);
            this.Controls.Add(this.groupBoxObjectsManipulation);
            this.Controls.Add(this.groupBoxObjectsAdaptation);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Паттерн программирования Adapter";
            this.groupBoxObjectsAdaptation.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxObjectsManipulation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCreate;
        private Button buttonDelete;
        private Button buttonGetJSON;
        private Button buttonGetXML;
        private Button buttonGetYAML;
        private Button buttonGetCSV;
        private GroupBox groupBoxObjectsAdaptation;
        private GroupBox groupBoxObjectsManipulation;
        private DataGridView dataGridViewOfHouses;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfFloorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfApartmentsDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonExit;
        private Label DeletionSignal;
    }
}