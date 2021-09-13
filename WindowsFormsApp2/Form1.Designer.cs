
namespace WindowsFormsApp2
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
            this.sqft_lot = new System.Windows.Forms.NumericUpDown();
            this.sqft_living = new System.Windows.Forms.NumericUpDown();
            this.condition = new System.Windows.Forms.NumericUpDown();
            this.waterfront = new System.Windows.Forms.NumericUpDown();
            this.view = new System.Windows.Forms.NumericUpDown();
            this.floors = new System.Windows.Forms.NumericUpDown();
            this.bedrooms = new System.Windows.Forms.NumericUpDown();
            this.bathrooms = new System.Windows.Forms.NumericUpDown();
            this.zipcode = new System.Windows.Forms.NumericUpDown();
            this.grade = new System.Windows.Forms.NumericUpDown();
            this.yr_built = new System.Windows.Forms.NumericUpDown();
            this.yr_renovated = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqft_lot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqft_living)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yr_built)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yr_renovated)).BeginInit();
            this.SuspendLayout();
            // 
            // sqft_lot
            // 
            this.sqft_lot.Location = new System.Drawing.Point(100, 234);
            this.sqft_lot.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sqft_lot.Name = "sqft_lot";
            this.sqft_lot.Size = new System.Drawing.Size(120, 22);
            this.sqft_lot.TabIndex = 1;
            // 
            // sqft_living
            // 
            this.sqft_living.Location = new System.Drawing.Point(100, 157);
            this.sqft_living.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.sqft_living.Name = "sqft_living";
            this.sqft_living.Size = new System.Drawing.Size(120, 22);
            this.sqft_living.TabIndex = 2;
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(382, 31);
            this.condition.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.condition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(120, 22);
            this.condition.TabIndex = 3;
            this.condition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // waterfront
            // 
            this.waterfront.Location = new System.Drawing.Point(100, 367);
            this.waterfront.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waterfront.Name = "waterfront";
            this.waterfront.Size = new System.Drawing.Size(120, 22);
            this.waterfront.TabIndex = 4;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(100, 416);
            this.view.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(120, 22);
            this.view.TabIndex = 5;
            // 
            // floors
            // 
            this.floors.Location = new System.Drawing.Point(100, 296);
            this.floors.Name = "floors";
            this.floors.Size = new System.Drawing.Size(120, 22);
            this.floors.TabIndex = 6;
            // 
            // bedrooms
            // 
            this.bedrooms.Location = new System.Drawing.Point(100, 29);
            this.bedrooms.Name = "bedrooms";
            this.bedrooms.Size = new System.Drawing.Size(120, 22);
            this.bedrooms.TabIndex = 7;
            // 
            // bathrooms
            // 
            this.bathrooms.Location = new System.Drawing.Point(100, 87);
            this.bathrooms.Name = "bathrooms";
            this.bathrooms.Size = new System.Drawing.Size(120, 22);
            this.bathrooms.TabIndex = 8;
            // 
            // zipcode
            // 
            this.zipcode.Location = new System.Drawing.Point(382, 299);
            this.zipcode.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(120, 22);
            this.zipcode.TabIndex = 9;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(382, 92);
            this.grade.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.grade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(120, 22);
            this.grade.TabIndex = 10;
            this.grade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yr_built
            // 
            this.yr_built.Location = new System.Drawing.Point(382, 157);
            this.yr_built.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yr_built.Name = "yr_built";
            this.yr_built.Size = new System.Drawing.Size(120, 22);
            this.yr_built.TabIndex = 11;
            // 
            // yr_renovated
            // 
            this.yr_renovated.Location = new System.Drawing.Point(382, 234);
            this.yr_renovated.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yr_renovated.Name = "yr_renovated";
            this.yr_renovated.Size = new System.Drawing.Size(120, 22);
            this.yr_renovated.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "bedrooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "bathrooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "sqft_living";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "sqft_lot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "floors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "waterfront";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "view";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "condition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "grade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "yr_built";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "yr_renovated";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "zipcode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "EVALUATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yr_renovated);
            this.Controls.Add(this.yr_built);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.zipcode);
            this.Controls.Add(this.bathrooms);
            this.Controls.Add(this.bedrooms);
            this.Controls.Add(this.floors);
            this.Controls.Add(this.view);
            this.Controls.Add(this.waterfront);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.sqft_living);
            this.Controls.Add(this.sqft_lot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sqft_lot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqft_living)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterfront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yr_built)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yr_renovated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sqft_lot;
        private System.Windows.Forms.NumericUpDown sqft_living;
        private System.Windows.Forms.NumericUpDown condition;
        private System.Windows.Forms.NumericUpDown waterfront;
        private System.Windows.Forms.NumericUpDown view;
        private System.Windows.Forms.NumericUpDown floors;
        private System.Windows.Forms.NumericUpDown bedrooms;
        private System.Windows.Forms.NumericUpDown bathrooms;
        private System.Windows.Forms.NumericUpDown zipcode;
        private System.Windows.Forms.NumericUpDown grade;
        private System.Windows.Forms.NumericUpDown yr_built;
        private System.Windows.Forms.NumericUpDown yr_renovated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

