namespace GuessingGame
{
    partial class Statistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.ogLabel = new System.Windows.Forms.Label();
            this.sortOrder = new System.Windows.Forms.Label();
            this.ogOrder = new System.Windows.Forms.Label();
            this.guessnumLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.victoryLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortLabel);
            this.groupBox1.Controls.Add(this.ogLabel);
            this.groupBox1.Controls.Add(this.sortOrder);
            this.groupBox1.Controls.Add(this.ogOrder);
            this.groupBox1.Controls.Add(this.guessnumLabel);
            this.groupBox1.Controls.Add(this.resultsLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // sortLabel
            // 
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.Location = new System.Drawing.Point(10, 124);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(101, 20);
            this.sortLabel.TabIndex = 5;
            this.sortLabel.Text = "Sorted Order";
            // 
            // ogLabel
            // 
            this.ogLabel.AutoSize = true;
            this.ogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogLabel.Location = new System.Drawing.Point(10, 71);
            this.ogLabel.Name = "ogLabel";
            this.ogLabel.Size = new System.Drawing.Size(106, 20);
            this.ogLabel.TabIndex = 4;
            this.ogLabel.Text = "Original Order";
            // 
            // sortOrder
            // 
            this.sortOrder.AutoSize = true;
            this.sortOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrder.Location = new System.Drawing.Point(10, 144);
            this.sortOrder.Name = "sortOrder";
            this.sortOrder.Size = new System.Drawing.Size(0, 20);
            this.sortOrder.TabIndex = 3;
            // 
            // ogOrder
            // 
            this.ogOrder.AutoSize = true;
            this.ogOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogOrder.Location = new System.Drawing.Point(10, 91);
            this.ogOrder.Name = "ogOrder";
            this.ogOrder.Size = new System.Drawing.Size(0, 20);
            this.ogOrder.TabIndex = 2;
            // 
            // guessnumLabel
            // 
            this.guessnumLabel.AutoSize = true;
            this.guessnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessnumLabel.Location = new System.Drawing.Point(10, 33);
            this.guessnumLabel.Name = "guessnumLabel";
            this.guessnumLabel.Size = new System.Drawing.Size(13, 20);
            this.guessnumLabel.TabIndex = 1;
            this.guessnumLabel.Text = ".";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(6, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(71, 24);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.Text = "Results";
            // 
            // victoryLabel
            // 
            this.victoryLabel.AutoSize = true;
            this.victoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryLabel.Location = new System.Drawing.Point(66, 21);
            this.victoryLabel.Name = "victoryLabel";
            this.victoryLabel.Size = new System.Drawing.Size(144, 31);
            this.victoryLabel.TabIndex = 2;
            this.victoryLabel.Text = "You Got It!";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.victoryLabel);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(275, 252);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label victoryLabel;
        private System.Windows.Forms.Label guessnumLabel;
        private System.Windows.Forms.Label sortOrder;
        private System.Windows.Forms.Label ogOrder;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label ogLabel;
    }
}
