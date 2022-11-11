
namespace WindowsFormsApp1
{
    partial class SetGoalForm
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
            this.textBoxProteinGoal = new System.Windows.Forms.TextBox();
            this.ProteinGoallabel = new System.Windows.Forms.Label();
            this.Calorielabel = new System.Windows.Forms.Label();
            this.textBoxCalorieGoal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxProteinGoal
            // 
            this.textBoxProteinGoal.Location = new System.Drawing.Point(62, 107);
            this.textBoxProteinGoal.Name = "textBoxProteinGoal";
            this.textBoxProteinGoal.Size = new System.Drawing.Size(100, 20);
            this.textBoxProteinGoal.TabIndex = 0;
            // 
            // ProteinGoallabel
            // 
            this.ProteinGoallabel.AutoSize = true;
            this.ProteinGoallabel.Location = new System.Drawing.Point(68, 68);
            this.ProteinGoallabel.Name = "ProteinGoallabel";
            this.ProteinGoallabel.Size = new System.Drawing.Size(65, 13);
            this.ProteinGoallabel.TabIndex = 1;
            this.ProteinGoallabel.Text = "Protein Goal";
            // 
            // Calorielabel
            // 
            this.Calorielabel.AutoSize = true;
            this.Calorielabel.Location = new System.Drawing.Point(68, 230);
            this.Calorielabel.Name = "Calorielabel";
            this.Calorielabel.Size = new System.Drawing.Size(64, 13);
            this.Calorielabel.TabIndex = 2;
            this.Calorielabel.Text = "Calorie Goal";
            // 
            // textBoxCalorieGoal
            // 
            this.textBoxCalorieGoal.Location = new System.Drawing.Point(62, 275);
            this.textBoxCalorieGoal.Name = "textBoxCalorieGoal";
            this.textBoxCalorieGoal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalorieGoal.TabIndex = 3;
            // 
            // SetGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCalorieGoal);
            this.Controls.Add(this.Calorielabel);
            this.Controls.Add(this.ProteinGoallabel);
            this.Controls.Add(this.textBoxProteinGoal);
            this.Name = "SetGoalForm";
            this.Text = "SetGoalForm";
            this.Load += new System.EventHandler(this.SetGoalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProteinGoal;
        private System.Windows.Forms.Label ProteinGoallabel;
        private System.Windows.Forms.Label Calorielabel;
        private System.Windows.Forms.TextBox textBoxCalorieGoal;
    }
}