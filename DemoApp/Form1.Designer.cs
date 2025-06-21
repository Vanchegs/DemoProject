namespace DemoApp
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
            this.ViewProductionButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewSuppliersButton = new System.Windows.Forms.Button();
            this.ViewMaterialsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewProductionButton
            // 
            this.ViewProductionButton.Location = new System.Drawing.Point(196, 305);
            this.ViewProductionButton.Name = "ViewProductionButton";
            this.ViewProductionButton.Size = new System.Drawing.Size(119, 97);
            this.ViewProductionButton.TabIndex = 1;
            this.ViewProductionButton.Text = "Посмотреть продукцию";
            this.ViewProductionButton.UseVisualStyleBackColor = true;
            this.ViewProductionButton.Click += new System.EventHandler(this.ViewProductionButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // ViewSuppliersButton
            // 
            this.ViewSuppliersButton.Location = new System.Drawing.Point(359, 305);
            this.ViewSuppliersButton.Name = "ViewSuppliersButton";
            this.ViewSuppliersButton.Size = new System.Drawing.Size(112, 97);
            this.ViewSuppliersButton.TabIndex = 3;
            this.ViewSuppliersButton.Text = "Посмотреть поставщиков";
            this.ViewSuppliersButton.UseVisualStyleBackColor = true;
            this.ViewSuppliersButton.Click += new System.EventHandler(this.ViewSuppliersButton_Click);
            // 
            // ViewMaterialsButton
            // 
            this.ViewMaterialsButton.Location = new System.Drawing.Point(519, 305);
            this.ViewMaterialsButton.Name = "ViewMaterialsButton";
            this.ViewMaterialsButton.Size = new System.Drawing.Size(105, 97);
            this.ViewMaterialsButton.TabIndex = 4;
            this.ViewMaterialsButton.Text = "Посмотреть материалы";
            this.ViewMaterialsButton.UseVisualStyleBackColor = true;
            this.ViewMaterialsButton.Click += new System.EventHandler(this.ViewProductsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewMaterialsButton);
            this.Controls.Add(this.ViewSuppliersButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewProductionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ViewProductionButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewSuppliersButton;
        private System.Windows.Forms.Button ViewMaterialsButton;
    }
}

