namespace DifferentialWithForms
{
    partial class TrigonometricFunctionForm
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
            this.TFLabel1 = new System.Windows.Forms.Label();
            this.TFLabel2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.TFtextBox = new System.Windows.Forms.TextBox();
            this.TFComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TFLabel1
            // 
            this.TFLabel1.AutoSize = true;
            this.TFLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TFLabel1.Location = new System.Drawing.Point(168, 23);
            this.TFLabel1.Name = "TFLabel1";
            this.TFLabel1.Size = new System.Drawing.Size(400, 32);
            this.TFLabel1.TabIndex = 0;
            this.TFLabel1.Text = "Тригонометрическая функция";
            // 
            // TFLabel2
            // 
            this.TFLabel2.AutoSize = true;
            this.TFLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TFLabel2.Location = new System.Drawing.Point(101, 94);
            this.TFLabel2.Name = "TFLabel2";
            this.TFLabel2.Size = new System.Drawing.Size(221, 27);
            this.TFLabel2.TabIndex = 1;
            this.TFLabel2.Text = "Выберите функцию:";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(480, 94);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(159, 74);
            this.button.TabIndex = 4;
            this.button.Text = "Найти дифференциал";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // TFtextBox
            // 
            this.TFtextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFtextBox.Location = new System.Drawing.Point(106, 245);
            this.TFtextBox.Name = "TFtextBox";
            this.TFtextBox.ReadOnly = true;
            this.TFtextBox.Size = new System.Drawing.Size(533, 34);
            this.TFtextBox.TabIndex = 5;
            // 
            // TFComboBox
            // 
            this.TFComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TFComboBox.FormattingEnabled = true;
            this.TFComboBox.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "tg(x)",
            "ctg(x)"});
            this.TFComboBox.Location = new System.Drawing.Point(106, 137);
            this.TFComboBox.Name = "TFComboBox";
            this.TFComboBox.Size = new System.Drawing.Size(216, 31);
            this.TFComboBox.TabIndex = 6;
            // 
            // TrigonometricFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 362);
            this.Controls.Add(this.TFComboBox);
            this.Controls.Add(this.TFtextBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.TFLabel2);
            this.Controls.Add(this.TFLabel1);
            this.Name = "TrigonometricFunctionForm";
            this.Text = "TrigonometricFunctionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TFLabel1;
        private System.Windows.Forms.Label TFLabel2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox TFtextBox;
        private System.Windows.Forms.ComboBox TFComboBox;
    }
}