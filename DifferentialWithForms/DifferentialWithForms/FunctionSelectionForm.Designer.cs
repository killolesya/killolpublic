namespace DifferentialWithForms
{
    partial class FunctionSelectionForm
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
            this.FunctionSelectionLabel = new System.Windows.Forms.Label();
            this.FunctionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.FunctionSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FunctionSelectionLabel
            // 
            this.FunctionSelectionLabel.AutoSize = true;
            this.FunctionSelectionLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionSelectionLabel.Location = new System.Drawing.Point(15, 170);
            this.FunctionSelectionLabel.Name = "FunctionSelectionLabel";
            this.FunctionSelectionLabel.Size = new System.Drawing.Size(276, 26);
            this.FunctionSelectionLabel.TabIndex = 0;
            this.FunctionSelectionLabel.Text = "Выберите тип функции:";
            // 
            // FunctionSelectionComboBox
            // 
            this.FunctionSelectionComboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionSelectionComboBox.FormattingEnabled = true;
            this.FunctionSelectionComboBox.Items.AddRange(new object[] {
            "Степенная",
            "Тригонометрическая"});
            this.FunctionSelectionComboBox.Location = new System.Drawing.Point(297, 164);
            this.FunctionSelectionComboBox.Name = "FunctionSelectionComboBox";
            this.FunctionSelectionComboBox.Size = new System.Drawing.Size(322, 34);
            this.FunctionSelectionComboBox.TabIndex = 1;
            this.FunctionSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionSelectionComboBox_SelectedIndexChanged);
            // 
            // FunctionSelectionButton
            // 
            this.FunctionSelectionButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionSelectionButton.Location = new System.Drawing.Point(654, 164);
            this.FunctionSelectionButton.Name = "FunctionSelectionButton";
            this.FunctionSelectionButton.Size = new System.Drawing.Size(123, 34);
            this.FunctionSelectionButton.TabIndex = 2;
            this.FunctionSelectionButton.Text = "Выбрать";
            this.FunctionSelectionButton.UseVisualStyleBackColor = true;
            this.FunctionSelectionButton.Click += new System.EventHandler(this.FunctionSelectionButton_Click);
            // 
            // FunctionSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 368);
            this.Controls.Add(this.FunctionSelectionButton);
            this.Controls.Add(this.FunctionSelectionComboBox);
            this.Controls.Add(this.FunctionSelectionLabel);
            this.Name = "FunctionSelectionForm";
            this.Text = "FunctionSelectionForm";
            this.Load += new System.EventHandler(this.FunctionSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionSelectionLabel;
        private System.Windows.Forms.ComboBox FunctionSelectionComboBox;
        private System.Windows.Forms.Button FunctionSelectionButton;
    }
}