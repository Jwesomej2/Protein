
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonSetGoal = new System.Windows.Forms.Button();
            this.buttonCheckGoals = new System.Windows.Forms.Button();
            this.buttonInputFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Homepage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSetGoal
            // 
            this.buttonSetGoal.Location = new System.Drawing.Point(111, 114);
            this.buttonSetGoal.Name = "buttonSetGoal";
            this.buttonSetGoal.Size = new System.Drawing.Size(182, 115);
            this.buttonSetGoal.TabIndex = 1;
            this.buttonSetGoal.Text = "Set Goal";
            this.buttonSetGoal.UseVisualStyleBackColor = true;
            this.buttonSetGoal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCheckGoals
            // 
            this.buttonCheckGoals.Location = new System.Drawing.Point(694, 114);
            this.buttonCheckGoals.Name = "buttonCheckGoals";
            this.buttonCheckGoals.Size = new System.Drawing.Size(155, 111);
            this.buttonCheckGoals.TabIndex = 2;
            this.buttonCheckGoals.Text = "Check Goals";
            this.buttonCheckGoals.UseVisualStyleBackColor = true;
            this.buttonCheckGoals.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInputFood
            // 
            this.buttonInputFood.Location = new System.Drawing.Point(111, 282);
            this.buttonInputFood.Name = "buttonInputFood";
            this.buttonInputFood.Size = new System.Drawing.Size(182, 104);
            this.buttonInputFood.TabIndex = 3;
            this.buttonInputFood.Text = "Input Food";
            this.buttonInputFood.UseVisualStyleBackColor = true;
            this.buttonInputFood.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.buttonInputFood);
            this.Controls.Add(this.buttonCheckGoals);
            this.Controls.Add(this.buttonSetGoal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetGoal;
        private System.Windows.Forms.Button buttonCheckGoals;
        private System.Windows.Forms.Button buttonInputFood;
    }
}

