
namespace WindowsFormsApp1
{
    partial class CheckGoalForm
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
            this.textBoxProteinChecker = new System.Windows.Forms.TextBox();
            this.ProteinCheckerlabel = new System.Windows.Forms.Label();
            this.textBoxCalorieChecker = new System.Windows.Forms.TextBox();
            this.CalorieCheckerlabel = new System.Windows.Forms.Label();
            this.ProteinCheckerbutton = new System.Windows.Forms.Button();
            this.CalorieCheckerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProteinChecker
            // 
            this.textBoxProteinChecker.Location = new System.Drawing.Point(43, 105);
            this.textBoxProteinChecker.Name = "textBoxProteinChecker";
            this.textBoxProteinChecker.Size = new System.Drawing.Size(158, 20);
            this.textBoxProteinChecker.TabIndex = 0;
            // 
            // ProteinCheckerlabel
            // 
            this.ProteinCheckerlabel.AutoSize = true;
            this.ProteinCheckerlabel.Location = new System.Drawing.Point(63, 74);
            this.ProteinCheckerlabel.Name = "ProteinCheckerlabel";
            this.ProteinCheckerlabel.Size = new System.Drawing.Size(0, 13);
            this.ProteinCheckerlabel.TabIndex = 1;
            // 
            // textBoxCalorieChecker
            // 
            this.textBoxCalorieChecker.Location = new System.Drawing.Point(43, 227);
            this.textBoxCalorieChecker.Name = "textBoxCalorieChecker";
            this.textBoxCalorieChecker.Size = new System.Drawing.Size(158, 20);
            this.textBoxCalorieChecker.TabIndex = 2;
            // 
            // CalorieCheckerlabel
            // 
            this.CalorieCheckerlabel.AutoSize = true;
            this.CalorieCheckerlabel.Location = new System.Drawing.Point(70, 206);
            this.CalorieCheckerlabel.Name = "CalorieCheckerlabel";
            this.CalorieCheckerlabel.Size = new System.Drawing.Size(0, 13);
            this.CalorieCheckerlabel.TabIndex = 3;
            // 
            // ProteinCheckerbutton
            // 
            this.ProteinCheckerbutton.Location = new System.Drawing.Point(43, 74);
            this.ProteinCheckerbutton.Name = "ProteinCheckerbutton";
            this.ProteinCheckerbutton.Size = new System.Drawing.Size(158, 25);
            this.ProteinCheckerbutton.TabIndex = 4;
            this.ProteinCheckerbutton.Text = "Protein Checker";
            this.ProteinCheckerbutton.UseVisualStyleBackColor = true;
            // 
            // CalorieCheckerbutton
            // 
            this.CalorieCheckerbutton.Location = new System.Drawing.Point(43, 196);
            this.CalorieCheckerbutton.Name = "CalorieCheckerbutton";
            this.CalorieCheckerbutton.Size = new System.Drawing.Size(158, 23);
            this.CalorieCheckerbutton.TabIndex = 5;
            this.CalorieCheckerbutton.Text = "Calorie Checker";
            this.CalorieCheckerbutton.UseVisualStyleBackColor = true;
            // 
            // CheckGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalorieCheckerbutton);
            this.Controls.Add(this.ProteinCheckerbutton);
            this.Controls.Add(this.CalorieCheckerlabel);
            this.Controls.Add(this.textBoxCalorieChecker);
            this.Controls.Add(this.ProteinCheckerlabel);
            this.Controls.Add(this.textBoxProteinChecker);
            this.Name = "CheckGoalForm";
            this.Text = "CheckGoalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProteinChecker;
        private System.Windows.Forms.Label ProteinCheckerlabel;
        private System.Windows.Forms.TextBox textBoxCalorieChecker;
        private System.Windows.Forms.Label CalorieCheckerlabel;
        private System.Windows.Forms.Button ProteinCheckerbutton;
        private System.Windows.Forms.Button CalorieCheckerbutton;
    }
}