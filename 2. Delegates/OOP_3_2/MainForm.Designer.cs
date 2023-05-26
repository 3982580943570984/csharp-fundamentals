namespace Studying;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Array",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hashtable",
            "",
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxHouses = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHouseCollectionCreate = new System.Windows.Forms.Button();
            this.buttonHouseCollectionRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHouseCollectionGenerate = new System.Windows.Forms.Button();
            this.numericUpDownHousesAmount = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewPerfomanceEvaluation = new System.Windows.Forms.ListView();
            this.Collection = new System.Windows.Forms.ColumnHeader();
            this.GenerationResult = new System.Windows.Forms.ColumnHeader();
            this.SequentialSearchResult = new System.Windows.Forms.ColumnHeader();
            this.RandomSearchResult = new System.Windows.Forms.ColumnHeader();
            this.buttonTest = new System.Windows.Forms.Button();
            this.listBoxHousesGenerated = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHousesAmount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTabs
            // 
            this.tabControlTabs.Controls.Add(this.tabPage1);
            this.tabControlTabs.Controls.Add(this.tabPage2);
            this.tabControlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTabs.Location = new System.Drawing.Point(3, 3);
            this.tabControlTabs.Name = "tabControlTabs";
            this.tabControlTabs.SelectedIndex = 0;
            this.tabControlTabs.Size = new System.Drawing.Size(1002, 690);
            this.tabControlTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с коллекцией";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.listBoxHouses, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(988, 650);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // listBoxHouses
            // 
            this.listBoxHouses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.listBoxHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHouses.Font = new System.Drawing.Font("JetBrainsMono Nerd Font", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxHouses.FormattingEnabled = true;
            this.listBoxHouses.ItemHeight = 16;
            this.listBoxHouses.Location = new System.Drawing.Point(3, 3);
            this.listBoxHouses.Name = "listBoxHouses";
            this.listBoxHouses.Size = new System.Drawing.Size(982, 579);
            this.listBoxHouses.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.buttonHouseCollectionCreate, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonHouseCollectionRemove, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 588);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(982, 59);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // buttonHouseCollectionCreate
            // 
            this.buttonHouseCollectionCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHouseCollectionCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonHouseCollectionCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHouseCollectionCreate.Location = new System.Drawing.Point(88, 14);
            this.buttonHouseCollectionCreate.Name = "buttonHouseCollectionCreate";
            this.buttonHouseCollectionCreate.Size = new System.Drawing.Size(150, 30);
            this.buttonHouseCollectionCreate.TabIndex = 0;
            this.buttonHouseCollectionCreate.Text = "Создать";
            this.buttonHouseCollectionCreate.UseVisualStyleBackColor = false;
            this.buttonHouseCollectionCreate.Click += new System.EventHandler(this.ButtonHouseCollectionAdd_Click);
            // 
            // buttonHouseCollectionRemove
            // 
            this.buttonHouseCollectionRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHouseCollectionRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonHouseCollectionRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHouseCollectionRemove.Location = new System.Drawing.Point(743, 14);
            this.buttonHouseCollectionRemove.Name = "buttonHouseCollectionRemove";
            this.buttonHouseCollectionRemove.Size = new System.Drawing.Size(150, 30);
            this.buttonHouseCollectionRemove.TabIndex = 1;
            this.buttonHouseCollectionRemove.Text = "Удалить";
            this.buttonHouseCollectionRemove.UseVisualStyleBackColor = false;
            this.buttonHouseCollectionRemove.Click += new System.EventHandler(this.ButtonHouseCollectionRemove_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonHouseCollectionGenerate, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDownHousesAmount, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(330, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(321, 53);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // buttonHouseCollectionGenerate
            // 
            this.buttonHouseCollectionGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHouseCollectionGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonHouseCollectionGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHouseCollectionGenerate.Location = new System.Drawing.Point(5, 11);
            this.buttonHouseCollectionGenerate.Name = "buttonHouseCollectionGenerate";
            this.buttonHouseCollectionGenerate.Size = new System.Drawing.Size(150, 30);
            this.buttonHouseCollectionGenerate.TabIndex = 3;
            this.buttonHouseCollectionGenerate.Text = "Сгенерировать";
            this.buttonHouseCollectionGenerate.UseVisualStyleBackColor = false;
            this.buttonHouseCollectionGenerate.Click += new System.EventHandler(this.ButtonHouseCollectionGenerate_Click);
            // 
            // numericUpDownHousesAmount
            // 
            this.numericUpDownHousesAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownHousesAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.numericUpDownHousesAmount.Location = new System.Drawing.Point(165, 12);
            this.numericUpDownHousesAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHousesAmount.Name = "numericUpDownHousesAmount";
            this.numericUpDownHousesAmount.Size = new System.Drawing.Size(150, 29);
            this.numericUpDownHousesAmount.TabIndex = 4;
            this.numericUpDownHousesAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Замер производительности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listViewPerfomanceEvaluation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonTest, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.listBoxHousesGenerated, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 650);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // listViewPerfomanceEvaluation
            // 
            this.listViewPerfomanceEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.listViewPerfomanceEvaluation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Collection,
            this.GenerationResult,
            this.SequentialSearchResult,
            this.RandomSearchResult});
            this.listViewPerfomanceEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPerfomanceEvaluation.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewPerfomanceEvaluation.Location = new System.Drawing.Point(3, 3);
            this.listViewPerfomanceEvaluation.Name = "listViewPerfomanceEvaluation";
            this.listViewPerfomanceEvaluation.Size = new System.Drawing.Size(982, 302);
            this.listViewPerfomanceEvaluation.TabIndex = 1;
            this.listViewPerfomanceEvaluation.UseCompatibleStateImageBehavior = false;
            this.listViewPerfomanceEvaluation.View = System.Windows.Forms.View.Details;
            // 
            // Collection
            // 
            this.Collection.Text = "Коллекция";
            this.Collection.Width = 300;
            // 
            // GenerationResult
            // 
            this.GenerationResult.Text = "Время генерации";
            // 
            // SequentialSearchResult
            // 
            this.SequentialSearchResult.Text = "Время последовательного поиска";
            // 
            // RandomSearchResult
            // 
            this.RandomSearchResult.Text = "Время случайного поиска";
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Location = new System.Drawing.Point(419, 619);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(149, 27);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // listBoxHousesGenerated
            // 
            this.listBoxHousesGenerated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(237)))));
            this.listBoxHousesGenerated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHousesGenerated.Font = new System.Drawing.Font("JetBrainsMono Nerd Font", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxHousesGenerated.FormattingEnabled = true;
            this.listBoxHousesGenerated.ItemHeight = 16;
            this.listBoxHousesGenerated.Location = new System.Drawing.Point(3, 311);
            this.listBoxHousesGenerated.Name = "listBoxHousesGenerated";
            this.listBoxHousesGenerated.Size = new System.Drawing.Size(982, 302);
            this.listBoxHousesGenerated.TabIndex = 2;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tabControlTabs, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1008, 733);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(899, 699);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 30);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("JetBrainsMono Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Делегаты и события";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControlTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHousesAmount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabControlTabs;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button buttonHouseCollectionRemove;
    private Button buttonHouseCollectionCreate;
    private TableLayoutPanel tableLayoutPanelMain;
    private Button buttonExit;
    private Button buttonHouseCollectionGenerate;
    private NumericUpDown numericUpDownHousesAmount;
    private ListBox listBoxHouses;
    private Button buttonTest;
    private TableLayoutPanel tableLayoutPanel2;
    private ListView listViewPerfomanceEvaluation;
    private ColumnHeader Collection;
    private ColumnHeader GenerationResult;
    private ListBox listBoxHousesGenerated;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
    private TableLayoutPanel tableLayoutPanel5;
    private ColumnHeader SequentialSearchResult;
    private ColumnHeader RandomSearchResult;
}