namespace PathFinding_C
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isNode = new System.Windows.Forms.RadioButton();
            this.isVertecie = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // isNode
            // 
            this.isNode.AutoSize = true;
            this.isNode.Location = new System.Drawing.Point(797, -1);
            this.isNode.Name = "isNode";
            this.isNode.Size = new System.Drawing.Size(73, 17);
            this.isNode.TabIndex = 1;
            this.isNode.TabStop = true;
            this.isNode.Text = "Add Node";
            this.isNode.UseVisualStyleBackColor = true;
            // 
            // isVertecie
            // 
            this.isVertecie.AutoSize = true;
            this.isVertecie.Location = new System.Drawing.Point(893, -1);
            this.isVertecie.Name = "isVertecie";
            this.isVertecie.Size = new System.Drawing.Size(89, 17);
            this.isVertecie.TabIndex = 2;
            this.isVertecie.TabStop = true;
            this.isVertecie.Text = "Add Verteces";
            this.isVertecie.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.isVertecie);
            this.Controls.Add(this.isNode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Pathfinding v0.001";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton isNode;
        private System.Windows.Forms.RadioButton isVertecie;
    }
}

