
namespace RecipesCatalog.Forms
{
    partial class MainCoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCoursesForm));
            this.btnAddMainCourses = new System.Windows.Forms.Button();
            this.btnRemoveMainCourses = new System.Windows.Forms.Button();
            this.btnOpenMainCourses = new System.Windows.Forms.Button();
            this.dataMainCourses = new System.Windows.Forms.DataGridView();
            this.btnMainCoursesUnfavourite = new System.Windows.Forms.Button();
            this.picBoxMainCourses = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainCoursesFavourite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMainCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMainCourses
            // 
            this.btnAddMainCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMainCourses.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMainCourses.Location = new System.Drawing.Point(137, 397);
            this.btnAddMainCourses.Name = "btnAddMainCourses";
            this.btnAddMainCourses.Size = new System.Drawing.Size(95, 40);
            this.btnAddMainCourses.TabIndex = 12;
            this.btnAddMainCourses.Text = "Add";
            this.btnAddMainCourses.UseVisualStyleBackColor = true;
            this.btnAddMainCourses.Click += new System.EventHandler(this.btnAddMainCourses_Click);
            // 
            // btnRemoveMainCourses
            // 
            this.btnRemoveMainCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMainCourses.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveMainCourses.Location = new System.Drawing.Point(255, 397);
            this.btnRemoveMainCourses.Name = "btnRemoveMainCourses";
            this.btnRemoveMainCourses.Size = new System.Drawing.Size(95, 40);
            this.btnRemoveMainCourses.TabIndex = 11;
            this.btnRemoveMainCourses.Text = "Remove";
            this.btnRemoveMainCourses.UseVisualStyleBackColor = true;
            this.btnRemoveMainCourses.Click += new System.EventHandler(this.btnRemoveMainCourses_Click_1);
            // 
            // btnOpenMainCourses
            // 
            this.btnOpenMainCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMainCourses.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainCourses.Location = new System.Drawing.Point(18, 397);
            this.btnOpenMainCourses.Name = "btnOpenMainCourses";
            this.btnOpenMainCourses.Size = new System.Drawing.Size(95, 40);
            this.btnOpenMainCourses.TabIndex = 10;
            this.btnOpenMainCourses.Text = "Open";
            this.btnOpenMainCourses.UseVisualStyleBackColor = true;
            this.btnOpenMainCourses.Click += new System.EventHandler(this.btnOpenMainCourses_Click);
            // 
            // dataMainCourses
            // 
            this.dataMainCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMainCourses.Location = new System.Drawing.Point(450, 72);
            this.dataMainCourses.Name = "dataMainCourses";
            this.dataMainCourses.Size = new System.Drawing.Size(322, 365);
            this.dataMainCourses.TabIndex = 8;
            this.dataMainCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMainCourses_CellContentClick);
            // 
            // btnMainCoursesUnfavourite
            // 
            this.btnMainCoursesUnfavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCoursesUnfavourite.FlatAppearance.BorderSize = 0;
            this.btnMainCoursesUnfavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCoursesUnfavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCoursesUnfavourite.Image")));
            this.btnMainCoursesUnfavourite.Location = new System.Drawing.Point(370, 397);
            this.btnMainCoursesUnfavourite.Name = "btnMainCoursesUnfavourite";
            this.btnMainCoursesUnfavourite.Size = new System.Drawing.Size(50, 40);
            this.btnMainCoursesUnfavourite.TabIndex = 14;
            this.btnMainCoursesUnfavourite.UseVisualStyleBackColor = true;
            this.btnMainCoursesUnfavourite.Visible = false;
            this.btnMainCoursesUnfavourite.Click += new System.EventHandler(this.btnMainCoursesUnfavourite_Click);
            // 
            // picBoxMainCourses
            // 
            this.picBoxMainCourses.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMainCourses.Image")));
            this.picBoxMainCourses.Location = new System.Drawing.Point(88, 79);
            this.picBoxMainCourses.Name = "picBoxMainCourses";
            this.picBoxMainCourses.Size = new System.Drawing.Size(258, 278);
            this.picBoxMainCourses.TabIndex = 13;
            this.picBoxMainCourses.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(452, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Main Courses Recipes:";
            // 
            // btnMainCoursesFavourite
            // 
            this.btnMainCoursesFavourite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCoursesFavourite.FlatAppearance.BorderSize = 0;
            this.btnMainCoursesFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCoursesFavourite.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCoursesFavourite.Image")));
            this.btnMainCoursesFavourite.Location = new System.Drawing.Point(370, 397);
            this.btnMainCoursesFavourite.Name = "btnMainCoursesFavourite";
            this.btnMainCoursesFavourite.Size = new System.Drawing.Size(50, 40);
            this.btnMainCoursesFavourite.TabIndex = 16;
            this.btnMainCoursesFavourite.UseVisualStyleBackColor = true;
            this.btnMainCoursesFavourite.Click += new System.EventHandler(this.btnMainCoursesFavourite_Click);
            // 
            // MainCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.btnMainCoursesFavourite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainCoursesUnfavourite);
            this.Controls.Add(this.picBoxMainCourses);
            this.Controls.Add(this.btnAddMainCourses);
            this.Controls.Add(this.btnRemoveMainCourses);
            this.Controls.Add(this.btnOpenMainCourses);
            this.Controls.Add(this.dataMainCourses);
            this.Name = "MainCoursesForm";
            this.Text = "MainCoursesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataMainCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainCoursesUnfavourite;
        private System.Windows.Forms.PictureBox picBoxMainCourses;
        private System.Windows.Forms.Button btnAddMainCourses;
        private System.Windows.Forms.Button btnRemoveMainCourses;
        private System.Windows.Forms.Button btnOpenMainCourses;
        private System.Windows.Forms.DataGridView dataMainCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainCoursesFavourite;
    }
}