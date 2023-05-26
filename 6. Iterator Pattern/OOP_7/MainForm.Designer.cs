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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonNext = new System.Windows.Forms.Button();
            this.listBoxCurrentHouse = new System.Windows.Forms.ListBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.Index = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxHouseInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelForAmountOfAdded = new System.Windows.Forms.Label();
            this.labelForAmountOfDeleted = new System.Windows.Forms.Label();
            this.labelForAmountOfTransitions = new System.Windows.Forms.Label();
            this.labelForHousesAmount = new System.Windows.Forms.Label();
            this.labelForCurrentHouseIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Index)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxHouseInformation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(3, 14);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(171, 30);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Вперед";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // listBoxCurrentHouse
            // 
            this.listBoxCurrentHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.listBoxCurrentHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCurrentHouse.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCurrentHouse.FormattingEnabled = true;
            this.listBoxCurrentHouse.HorizontalScrollbar = true;
            this.listBoxCurrentHouse.ItemHeight = 21;
            this.listBoxCurrentHouse.Location = new System.Drawing.Point(3, 4);
            this.listBoxCurrentHouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCurrentHouse.Name = "listBoxCurrentHouse";
            this.listBoxCurrentHouse.Size = new System.Drawing.Size(488, 240);
            this.listBoxCurrentHouse.TabIndex = 2;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.Location = new System.Drawing.Point(3, 73);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(171, 30);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "Назад";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(3, 132);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 30);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(3, 191);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(171, 30);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Добавить";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGo.Location = new System.Drawing.Point(3, 250);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(171, 30);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Перейти к";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(3, 309);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(171, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amount.Location = new System.Drawing.Point(180, 193);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(171, 27);
            this.Amount.TabIndex = 8;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Index
            // 
            this.Index.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Index.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Index.Location = new System.Drawing.Point(180, 252);
            this.Index.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Index.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(171, 27);
            this.Index.TabIndex = 9;
            this.Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Index.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonClear, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonGo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrevious, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Index, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Amount, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 354);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(707, 406);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(171, 30);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxActions.Location = new System.Drawing.Point(518, 12);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxActions.Size = new System.Drawing.Size(360, 382);
            this.groupBoxActions.TabIndex = 11;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // groupBoxHouseInformation
            // 
            this.groupBoxHouseInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxHouseInformation.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxHouseInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHouseInformation.Name = "groupBoxHouseInformation";
            this.groupBoxHouseInformation.Size = new System.Drawing.Size(500, 424);
            this.groupBoxHouseInformation.TabIndex = 13;
            this.groupBoxHouseInformation.TabStop = false;
            this.groupBoxHouseInformation.Text = "Информация о текущем здании";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxCurrentHouse, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelForAmountOfAdded, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelForAmountOfDeleted, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelForAmountOfTransitions, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelForHousesAmount, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelForCurrentHouseIndex, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 398);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelForAmountOfAdded
            // 
            this.labelForAmountOfAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForAmountOfAdded.AutoSize = true;
            this.labelForAmountOfAdded.Location = new System.Drawing.Point(3, 311);
            this.labelForAmountOfAdded.Name = "labelForAmountOfAdded";
            this.labelForAmountOfAdded.Size = new System.Drawing.Size(488, 19);
            this.labelForAmountOfAdded.TabIndex = 5;
            this.labelForAmountOfAdded.Text = "Кол-во добавленных зданий: ";
            // 
            // labelForAmountOfDeleted
            // 
            this.labelForAmountOfDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForAmountOfDeleted.AutoSize = true;
            this.labelForAmountOfDeleted.Location = new System.Drawing.Point(3, 340);
            this.labelForAmountOfDeleted.Name = "labelForAmountOfDeleted";
            this.labelForAmountOfDeleted.Size = new System.Drawing.Size(488, 19);
            this.labelForAmountOfDeleted.TabIndex = 6;
            this.labelForAmountOfDeleted.Text = "Кол-во удаленных зданий: ";
            // 
            // labelForAmountOfTransitions
            // 
            this.labelForAmountOfTransitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForAmountOfTransitions.AutoSize = true;
            this.labelForAmountOfTransitions.Location = new System.Drawing.Point(3, 371);
            this.labelForAmountOfTransitions.Name = "labelForAmountOfTransitions";
            this.labelForAmountOfTransitions.Size = new System.Drawing.Size(488, 19);
            this.labelForAmountOfTransitions.TabIndex = 7;
            this.labelForAmountOfTransitions.Text = "Кол-во переходов: ";
            // 
            // labelForHousesAmount
            // 
            this.labelForHousesAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForHousesAmount.AutoSize = true;
            this.labelForHousesAmount.Location = new System.Drawing.Point(3, 282);
            this.labelForHousesAmount.Name = "labelForHousesAmount";
            this.labelForHousesAmount.Size = new System.Drawing.Size(488, 19);
            this.labelForHousesAmount.TabIndex = 3;
            this.labelForHousesAmount.Text = "Кол-во зданий  в списке:";
            // 
            // labelForCurrentHouseIndex
            // 
            this.labelForCurrentHouseIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForCurrentHouseIndex.AutoSize = true;
            this.labelForCurrentHouseIndex.Location = new System.Drawing.Point(3, 253);
            this.labelForCurrentHouseIndex.Name = "labelForCurrentHouseIndex";
            this.labelForCurrentHouseIndex.Size = new System.Drawing.Size(488, 19);
            this.labelForCurrentHouseIndex.TabIndex = 4;
            this.labelForCurrentHouseIndex.Text = "Номер текущего здания:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(884, 447);
            this.Controls.Add(this.groupBoxHouseInformation);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Паттерн программирования Iterator";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Index)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxHouseInformation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNext;
        private ListBox listBoxCurrentHouse;
        private Button buttonPrevious;
        private Button buttonDelete;
        private Button buttonGenerate;
        private Button buttonGo;
        private Button buttonClear;
        private NumericUpDown Amount;
        private NumericUpDown Index;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxActions;
        private Button buttonExit;
        private GroupBox groupBoxHouseInformation;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelForHousesAmount;
        private Label labelForCurrentHouseIndex;
        private Label labelForAmountOfAdded;
        private Label labelForAmountOfDeleted;
        private Label labelForAmountOfTransitions;
    }
}