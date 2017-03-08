namespace DollarComputers_Assignment4
{
    partial class SelectForm
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
            this.ComputerListLabel = new System.Windows.Forms.Label();
            this.ProductListDataGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerListLabel
            // 
            this.ComputerListLabel.AutoSize = true;
            this.ComputerListLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComputerListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerListLabel.Location = new System.Drawing.Point(13, 13);
            this.ComputerListLabel.Name = "ComputerListLabel";
            this.ComputerListLabel.Size = new System.Drawing.Size(257, 22);
            this.ComputerListLabel.TabIndex = 0;
            this.ComputerListLabel.Text = "Dollar Computer Hardware List";
            // 
            // ProductListDataGridView
            // 
            this.ProductListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDataGridView.Location = new System.Drawing.Point(13, 38);
            this.ProductListDataGridView.Name = "ProductListDataGridView";
            this.ProductListDataGridView.ReadOnly = true;
            this.ProductListDataGridView.Size = new System.Drawing.Size(796, 371);
            this.ProductListDataGridView.TabIndex = 1;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionLabel.Location = new System.Drawing.Point(12, 427);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(109, 16);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.BackColor = System.Drawing.Color.White;
            this.YourSelectionTextBox.Location = new System.Drawing.Point(127, 426);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.ReadOnly = true;
            this.YourSelectionTextBox.Size = new System.Drawing.Size(433, 20);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(626, 424);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(719, 424);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 459);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.ProductListDataGridView);
            this.Controls.Add(this.ComputerListLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComputerListLabel;
        private System.Windows.Forms.DataGridView ProductListDataGridView;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}