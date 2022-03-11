namespace RecipesCatalog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnAppetizers = new System.Windows.Forms.Button();
            this.btnSalads = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnFavourites);
            this.panelMenu.Controls.Add(this.btnAddRecipe);
            this.panelMenu.Controls.Add(this.btnCourses);
            this.panelMenu.Controls.Add(this.btnMain);
            this.panelMenu.Controls.Add(this.btnAppetizers);
            this.panelMenu.Controls.Add(this.btnSalads);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 463);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnFavourites
            // 
            this.btnFavourites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavourites.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavourites.ForeColor = System.Drawing.Color.White;
            this.btnFavourites.Image = global::RecipesCatalog.Properties.Resources.rating;
            this.btnFavourites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavourites.Location = new System.Drawing.Point(0, 380);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(200, 60);
            this.btnFavourites.TabIndex = 6;
            this.btnFavourites.Text = " Favourites";
            this.btnFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavourites.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecipe.ForeColor = System.Drawing.Color.White;
            this.btnAddRecipe.Image = global::RecipesCatalog.Properties.Resources.chef;
            this.btnAddRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecipe.Location = new System.Drawing.Point(0, 320);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(200, 60);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = " Add Recipe";
            this.btnAddRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = global::RecipesCatalog.Properties.Resources.donuts;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(0, 260);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(200, 60);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = " Deserts";
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Image = global::RecipesCatalog.Properties.Resources.meals;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(0, 200);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(200, 60);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = " Main Courses";
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppetizers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            this.btnAppetizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizers.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizers.ForeColor = System.Drawing.Color.White;
            this.btnAppetizers.Image = global::RecipesCatalog.Properties.Resources.fish_and_chips;
            this.btnAppetizers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizers.Location = new System.Drawing.Point(0, 140);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(200, 60);
            this.btnAppetizers.TabIndex = 2;
            this.btnAppetizers.Text = " Appetizers";
            this.btnAppetizers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppetizers.UseVisualStyleBackColor = true;
            // 
            // btnSalads
            // 
            this.btnSalads.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalads.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            this.btnSalads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalads.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalads.ForeColor = System.Drawing.Color.White;
            this.btnSalads.Image = global::RecipesCatalog.Properties.Resources.salad;
            this.btnSalads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalads.Location = new System.Drawing.Point(0, 80);
            this.btnSalads.Name = "btnSalads";
            this.btnSalads.Size = new System.Drawing.Size(200, 60);
            this.btnSalads.TabIndex = 1;
            this.btnSalads.Text = " Salads";
            this.btnSalads.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalads.UseVisualStyleBackColor = true;
            this.btnSalads.Click += new System.EventHandler(this.btnSalads_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::RecipesCatalog.Properties.Resources.check_list__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Catalog";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(117)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(600, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(235, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 57);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RecipesCatalog";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSalads;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAppetizers;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}

