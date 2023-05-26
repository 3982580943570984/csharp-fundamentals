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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateBuilding = new System.Windows.Forms.Button();
            this.ModifyBuilding = new System.Windows.Forms.Button();
            this.DeleteBuilding = new System.Windows.Forms.Button();
            this.ExceptionGenerator = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BuildingsItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateBuilding
            // 
            this.CreateBuilding.Location = new System.Drawing.Point(12, 327);
            this.CreateBuilding.Name = "CreateBuilding";
            this.CreateBuilding.Size = new System.Drawing.Size(158, 23);
            this.CreateBuilding.TabIndex = 0;
            this.CreateBuilding.Text = "Добавить здание";
            this.CreateBuilding.UseVisualStyleBackColor = true;
            this.CreateBuilding.Click += new System.EventHandler(this.CreateBuilding_Click);
            // 
            // ModifyBuilding
            // 
            this.ModifyBuilding.Location = new System.Drawing.Point(12, 356);
            this.ModifyBuilding.Name = "ModifyBuilding";
            this.ModifyBuilding.Size = new System.Drawing.Size(158, 23);
            this.ModifyBuilding.TabIndex = 1;
            this.ModifyBuilding.Text = "Изменить здание";
            this.ModifyBuilding.UseVisualStyleBackColor = true;
            this.ModifyBuilding.Click += new System.EventHandler(this.ModifyBuilding_Click);
            // 
            // DeleteBuilding
            // 
            this.DeleteBuilding.Location = new System.Drawing.Point(176, 327);
            this.DeleteBuilding.Name = "DeleteBuilding";
            this.DeleteBuilding.Size = new System.Drawing.Size(158, 23);
            this.DeleteBuilding.TabIndex = 2;
            this.DeleteBuilding.Text = "Удалить здание";
            this.DeleteBuilding.UseVisualStyleBackColor = true;
            this.DeleteBuilding.Click += new System.EventHandler(this.DeleteBuilding_Click);
            // 
            // ExceptionGenerator
            // 
            this.ExceptionGenerator.Location = new System.Drawing.Point(176, 356);
            this.ExceptionGenerator.Name = "ExceptionGenerator";
            this.ExceptionGenerator.Size = new System.Drawing.Size(158, 23);
            this.ExceptionGenerator.TabIndex = 3;
            this.ExceptionGenerator.Text = "Сгенерировать исключение";
            this.ExceptionGenerator.UseVisualStyleBackColor = true;
            this.ExceptionGenerator.Click += new System.EventHandler(this.ExceptionGenerator_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(672, 356);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BuildingsItems
            // 
            this.BuildingsItems.FormattingEnabled = true;
            this.BuildingsItems.Location = new System.Drawing.Point(12, 12);
            this.BuildingsItems.Name = "BuildingsItems";
            this.BuildingsItems.Size = new System.Drawing.Size(735, 303);
            this.BuildingsItems.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(759, 391);
            this.Controls.Add(this.BuildingsItems);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExceptionGenerator);
            this.Controls.Add(this.DeleteBuilding);
            this.Controls.Add(this.ModifyBuilding);
            this.Controls.Add(this.CreateBuilding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главный экран";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBuilding;
        private System.Windows.Forms.Button ModifyBuilding;
        private System.Windows.Forms.Button DeleteBuilding;
        private System.Windows.Forms.Button ExceptionGenerator;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox BuildingsItems;
    }
}

