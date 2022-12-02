using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetGoalForm : Form
    {
        public SetGoalForm()
        {
            InitializeComponent();
        }

        private void SetGoalForm_Load(object sender, EventArgs e)
        {
        {
		/// <summary>
		///   When the food was consumed.
		/// </summary>
		public DateTime When { get; set; }

		/// <summary>
		///   How much of the food was consumed.
		/// </summary>
		/// <remarks>
		///   This is in the food's reference size units, e.g. "25" for 25 grams of chocolate (per 100g),
		///   or "2" for 2 eggs.
		/// </remarks>
		public float Amount { get; set; }

		/// <summary>
		///   What food was eaten.
		/// </summary>
		public Food Food { get; set; }
	}
}

        }
    }
}
