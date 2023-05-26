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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelMaxVectorValue = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.buttonGetMax = new System.Windows.Forms.Button();
            this.buttonGetTime = new System.Windows.Forms.Button();
            this.buttonGetQuote = new System.Windows.Forms.Button();
            this.labelQuote = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMaxValue = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMaxValue = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxQuote = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelQuote = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTime = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxMaxValue.SuspendLayout();
            this.tableLayoutPanelMaxValue.SuspendLayout();
            this.groupBoxQuote.SuspendLayout();
            this.tableLayoutPanelQuote.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.tableLayoutPanelTime.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaxVectorValue
            // 
            this.labelMaxVectorValue.AutoSize = true;
            this.labelMaxVectorValue.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxVectorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxVectorValue.Location = new System.Drawing.Point(4, 0);
            this.labelMaxVectorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxVectorValue.Name = "labelMaxVectorValue";
            this.labelMaxVectorValue.Size = new System.Drawing.Size(764, 94);
            this.labelMaxVectorValue.TabIndex = 0;
            this.labelMaxVectorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDateTime.Location = new System.Drawing.Point(4, 0);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(764, 94);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGetMax
            // 
            this.buttonGetMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGetMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGetMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonGetMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetMax.Location = new System.Drawing.Point(4, 98);
            this.buttonGetMax.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetMax.Name = "buttonGetMax";
            this.buttonGetMax.Size = new System.Drawing.Size(764, 33);
            this.buttonGetMax.TabIndex = 3;
            this.buttonGetMax.Text = "Получить максимум";
            this.buttonGetMax.UseVisualStyleBackColor = false;
            this.buttonGetMax.Click += new System.EventHandler(this.ButtonGetMax_Click);
            // 
            // buttonGetTime
            // 
            this.buttonGetTime.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGetTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGetTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonGetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetTime.Location = new System.Drawing.Point(4, 98);
            this.buttonGetTime.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetTime.Name = "buttonGetTime";
            this.buttonGetTime.Size = new System.Drawing.Size(764, 33);
            this.buttonGetTime.TabIndex = 4;
            this.buttonGetTime.Text = "Получить время";
            this.buttonGetTime.UseVisualStyleBackColor = false;
            this.buttonGetTime.Click += new System.EventHandler(this.ButtonGetTime_Click);
            // 
            // buttonGetQuote
            // 
            this.buttonGetQuote.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGetQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGetQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonGetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetQuote.Location = new System.Drawing.Point(4, 98);
            this.buttonGetQuote.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetQuote.Name = "buttonGetQuote";
            this.buttonGetQuote.Size = new System.Drawing.Size(764, 33);
            this.buttonGetQuote.TabIndex = 5;
            this.buttonGetQuote.Text = "Получить цитату";
            this.buttonGetQuote.UseVisualStyleBackColor = false;
            this.buttonGetQuote.Click += new System.EventHandler(this.ButtonGetQuote_Click);
            // 
            // labelQuote
            // 
            this.labelQuote.BackColor = System.Drawing.Color.Transparent;
            this.labelQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuote.Location = new System.Drawing.Point(3, 0);
            this.labelQuote.Name = "labelQuote";
            this.labelQuote.Size = new System.Drawing.Size(766, 94);
            this.labelQuote.TabIndex = 6;
            this.labelQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(565, 523);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(209, 32);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // groupBoxMaxValue
            // 
            this.groupBoxMaxValue.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMaxValue.Controls.Add(this.tableLayoutPanelMaxValue);
            this.groupBoxMaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMaxValue.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMaxValue.Name = "groupBoxMaxValue";
            this.groupBoxMaxValue.Size = new System.Drawing.Size(778, 163);
            this.groupBoxMaxValue.TabIndex = 8;
            this.groupBoxMaxValue.TabStop = false;
            this.groupBoxMaxValue.Text = "Асинхронный метод для получения максимального значения";
            // 
            // tableLayoutPanelMaxValue
            // 
            this.tableLayoutPanelMaxValue.ColumnCount = 1;
            this.tableLayoutPanelMaxValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMaxValue.Controls.Add(this.labelMaxVectorValue, 0, 0);
            this.tableLayoutPanelMaxValue.Controls.Add(this.buttonGetMax, 0, 1);
            this.tableLayoutPanelMaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMaxValue.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelMaxValue.Name = "tableLayoutPanelMaxValue";
            this.tableLayoutPanelMaxValue.RowCount = 2;
            this.tableLayoutPanelMaxValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMaxValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMaxValue.Size = new System.Drawing.Size(772, 135);
            this.tableLayoutPanelMaxValue.TabIndex = 0;
            // 
            // groupBoxQuote
            // 
            this.groupBoxQuote.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQuote.Controls.Add(this.tableLayoutPanelQuote);
            this.groupBoxQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQuote.Location = new System.Drawing.Point(3, 341);
            this.groupBoxQuote.Name = "groupBoxQuote";
            this.groupBoxQuote.Size = new System.Drawing.Size(778, 163);
            this.groupBoxQuote.TabIndex = 9;
            this.groupBoxQuote.TabStop = false;
            this.groupBoxQuote.Text = "Асинхронный метод для получения цитаты";
            // 
            // tableLayoutPanelQuote
            // 
            this.tableLayoutPanelQuote.ColumnCount = 1;
            this.tableLayoutPanelQuote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuote.Controls.Add(this.buttonGetQuote, 0, 1);
            this.tableLayoutPanelQuote.Controls.Add(this.labelQuote, 0, 0);
            this.tableLayoutPanelQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQuote.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelQuote.Name = "tableLayoutPanelQuote";
            this.tableLayoutPanelQuote.RowCount = 2;
            this.tableLayoutPanelQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelQuote.Size = new System.Drawing.Size(772, 135);
            this.tableLayoutPanelQuote.TabIndex = 0;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTime.Controls.Add(this.tableLayoutPanelTime);
            this.groupBoxTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTime.Location = new System.Drawing.Point(3, 172);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(778, 163);
            this.groupBoxTime.TabIndex = 10;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Асинхронный метод для получения текущего времени";
            // 
            // tableLayoutPanelTime
            // 
            this.tableLayoutPanelTime.ColumnCount = 1;
            this.tableLayoutPanelTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTime.Controls.Add(this.buttonGetTime, 0, 1);
            this.tableLayoutPanelTime.Controls.Add(this.labelDateTime, 0, 0);
            this.tableLayoutPanelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTime.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelTime.Name = "tableLayoutPanelTime";
            this.tableLayoutPanelTime.RowCount = 2;
            this.tableLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelTime.Size = new System.Drawing.Size(772, 135);
            this.tableLayoutPanelTime.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxMaxValue, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxQuote, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxTime, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(784, 565);
            this.tableLayoutPanelMain.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 565);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("JetBrainsMono Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Многопоточность и асинхронное программирование";
            this.groupBoxMaxValue.ResumeLayout(false);
            this.tableLayoutPanelMaxValue.ResumeLayout(false);
            this.tableLayoutPanelMaxValue.PerformLayout();
            this.groupBoxQuote.ResumeLayout(false);
            this.tableLayoutPanelQuote.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.tableLayoutPanelTime.ResumeLayout(false);
            this.tableLayoutPanelTime.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Label labelMaxVectorValue;
    private Label labelDateTime;
    private Button buttonGetMax;
    private Button buttonGetTime;
    private Button buttonGetQuote;
    private Label labelQuote;
    private Button buttonExit;
    private GroupBox groupBoxMaxValue;
    private TableLayoutPanel tableLayoutPanelMaxValue;
    private GroupBox groupBoxQuote;
    private TableLayoutPanel tableLayoutPanelQuote;
    private GroupBox groupBoxTime;
    private TableLayoutPanel tableLayoutPanelTime;
    private TableLayoutPanel tableLayoutPanelMain;
}