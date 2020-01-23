namespace RecipeHelperApp
{
    partial class frmRecipeHelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFairenheit = new System.Windows.Forms.TextBox();
            this.btnToFairenheit = new System.Windows.Forms.Button();
            this.txtMilliliters = new System.Windows.Forms.TextBox();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.btnToCups = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fairenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Milliliters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cups";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(91, 16);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 4;
            // 
            // txtFairenheit
            // 
            this.txtFairenheit.Location = new System.Drawing.Point(91, 142);
            this.txtFairenheit.Name = "txtFairenheit";
            this.txtFairenheit.ReadOnly = true;
            this.txtFairenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFairenheit.TabIndex = 5;
            this.txtFairenheit.TabStop = false;
            // 
            // btnToFairenheit
            // 
            this.btnToFairenheit.Location = new System.Drawing.Point(104, 63);
            this.btnToFairenheit.Name = "btnToFairenheit";
            this.btnToFairenheit.Size = new System.Drawing.Size(75, 49);
            this.btnToFairenheit.TabIndex = 6;
            this.btnToFairenheit.Text = "Convert to &Fairenheit";
            this.btnToFairenheit.UseVisualStyleBackColor = true;
            // 
            // txtMilliliters
            // 
            this.txtMilliliters.Location = new System.Drawing.Point(277, 16);
            this.txtMilliliters.Name = "txtMilliliters";
            this.txtMilliliters.Size = new System.Drawing.Size(100, 20);
            this.txtMilliliters.TabIndex = 7;
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(277, 142);
            this.txtCups.Name = "txtCups";
            this.txtCups.ReadOnly = true;
            this.txtCups.Size = new System.Drawing.Size(100, 20);
            this.txtCups.TabIndex = 8;
            this.txtCups.TabStop = false;
            // 
            // btnToCups
            // 
            this.btnToCups.Location = new System.Drawing.Point(292, 63);
            this.btnToCups.Name = "btnToCups";
            this.btnToCups.Size = new System.Drawing.Size(75, 49);
            this.btnToCups.TabIndex = 9;
            this.btnToCups.Text = "Convert to &Cups";
            this.btnToCups.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(172, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmRecipeHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(401, 215);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToCups);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.txtMilliliters);
            this.Controls.Add(this.btnToFairenheit);
            this.Controls.Add(this.txtFairenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRecipeHelper";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFairenheit;
        private System.Windows.Forms.Button btnToFairenheit;
        private System.Windows.Forms.TextBox txtMilliliters;
        private System.Windows.Forms.TextBox txtCups;
        private System.Windows.Forms.Button btnToCups;
        private System.Windows.Forms.Button btnExit;
    }
}

