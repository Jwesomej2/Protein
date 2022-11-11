
namespace WindowsFormsApp1
{
    partial class InputForm
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
            this.FoodNamelabel = new System.Windows.Forms.Label();
            this.AmountOfCalorieslabel = new System.Windows.Forms.Label();
            this.AmountOfProteinlabel = new System.Windows.Forms.Label();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfCalories = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfProtein = new System.Windows.Forms.TextBox();
            this.FoodNameSavebutton = new System.Windows.Forms.Button();
            this.AmountOfCaloriesSavebutton = new System.Windows.Forms.Button();
            this.AmountOfProteinSavebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodNamelabel
            // 
            this.FoodNamelabel.AutoSize = true;
            this.FoodNamelabel.Location = new System.Drawing.Point(77, 45);
            this.FoodNamelabel.Name = "FoodNamelabel";
            this.FoodNamelabel.Size = new System.Drawing.Size(62, 13);
            this.FoodNamelabel.TabIndex = 0;
            this.FoodNamelabel.Text = "Food Name";
            // 
            // AmountOfCalorieslabel
            // 
            this.AmountOfCalorieslabel.AutoSize = true;
            this.AmountOfCalorieslabel.Location = new System.Drawing.Point(78, 170);
            this.AmountOfCalorieslabel.Name = "AmountOfCalorieslabel";
            this.AmountOfCalorieslabel.Size = new System.Drawing.Size(95, 13);
            this.AmountOfCalorieslabel.TabIndex = 1;
            this.AmountOfCalorieslabel.Text = "Amount of Calories";
            this.AmountOfCalorieslabel.Click += new System.EventHandler(this.AmountOfCalorieslabel_Click);
            // 
            // AmountOfProteinlabel
            // 
            this.AmountOfProteinlabel.AutoSize = true;
            this.AmountOfProteinlabel.Location = new System.Drawing.Point(77, 267);
            this.AmountOfProteinlabel.Name = "AmountOfProteinlabel";
            this.AmountOfProteinlabel.Size = new System.Drawing.Size(91, 13);
            this.AmountOfProteinlabel.TabIndex = 2;
            this.AmountOfProteinlabel.Text = "Amount of Protein";
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(73, 93);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFoodName.TabIndex = 3;
            this.textBoxFoodName.TextChanged += new System.EventHandler(this.textBoxFoodName_TextChanged);
            // 
            // textBoxAmountOfCalories
            // 
            this.textBoxAmountOfCalories.Location = new System.Drawing.Point(81, 216);
            this.textBoxAmountOfCalories.Name = "textBoxAmountOfCalories";
            this.textBoxAmountOfCalories.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountOfCalories.TabIndex = 4;
            // 
            // textBoxAmountOfProtein
            // 
            this.textBoxAmountOfProtein.Location = new System.Drawing.Point(79, 319);
            this.textBoxAmountOfProtein.Name = "textBoxAmountOfProtein";
            this.textBoxAmountOfProtein.Size = new System.Drawing.Size(102, 20);
            this.textBoxAmountOfProtein.TabIndex = 5;
            // 
            // FoodNameSavebutton
            // 
            this.FoodNameSavebutton.Location = new System.Drawing.Point(226, 91);
            this.FoodNameSavebutton.Name = "FoodNameSavebutton";
            this.FoodNameSavebutton.Size = new System.Drawing.Size(75, 23);
            this.FoodNameSavebutton.TabIndex = 6;
            this.FoodNameSavebutton.Text = "Save";
            this.FoodNameSavebutton.UseVisualStyleBackColor = true;
            this.FoodNameSavebutton.Click += new System.EventHandler(this.FoodNameSavebutton_Click);
            // 
            // AmountOfCaloriesSavebutton
            // 
            this.AmountOfCaloriesSavebutton.Location = new System.Drawing.Point(226, 215);
            this.AmountOfCaloriesSavebutton.Name = "AmountOfCaloriesSavebutton";
            this.AmountOfCaloriesSavebutton.Size = new System.Drawing.Size(82, 21);
            this.AmountOfCaloriesSavebutton.TabIndex = 7;
            this.AmountOfCaloriesSavebutton.Text = "Save";
            this.AmountOfCaloriesSavebutton.UseVisualStyleBackColor = true;
            // 
            // AmountOfProteinSavebutton
            // 
            this.AmountOfProteinSavebutton.Location = new System.Drawing.Point(233, 319);
            this.AmountOfProteinSavebutton.Name = "AmountOfProteinSavebutton";
            this.AmountOfProteinSavebutton.Size = new System.Drawing.Size(75, 23);
            this.AmountOfProteinSavebutton.TabIndex = 8;
            this.AmountOfProteinSavebutton.Text = "Save";
            this.AmountOfProteinSavebutton.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmountOfProteinSavebutton);
            this.Controls.Add(this.AmountOfCaloriesSavebutton);
            this.Controls.Add(this.FoodNameSavebutton);
            this.Controls.Add(this.textBoxAmountOfProtein);
            this.Controls.Add(this.textBoxAmountOfCalories);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.AmountOfProteinlabel);
            this.Controls.Add(this.AmountOfCalorieslabel);
            this.Controls.Add(this.FoodNamelabel);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FoodNamelabel;
        private System.Windows.Forms.Label AmountOfCalorieslabel;
        private System.Windows.Forms.Label AmountOfProteinlabel;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.TextBox textBoxAmountOfCalories;
        private System.Windows.Forms.TextBox textBoxAmountOfProtein;
        private System.Windows.Forms.Button FoodNameSavebutton;
        private System.Windows.Forms.Button AmountOfCaloriesSavebutton;
        private System.Windows.Forms.Button AmountOfProteinSavebutton;
    }
}