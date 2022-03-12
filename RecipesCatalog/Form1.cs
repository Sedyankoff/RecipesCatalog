using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesCatalog
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SaladsForm(), sender);
        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelButtons.Controls.Add(childForm);
            this.panelButtons.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ProductsForm(), sender);
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FavouritesForm(), sender);
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddRecipeForm(), sender);
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AppetizerForm(), sender);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MainCoursesForm(), sender);

        }
    }
}
