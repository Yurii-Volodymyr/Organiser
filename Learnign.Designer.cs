namespace ToDoList
{
    partial class Learnign
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organiser | Learning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(7, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 316);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 316);
            this.panel2.TabIndex = 4;
            // 
            // textBox
            // 
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox.ForeColor = System.Drawing.Color.Transparent;
            this.textBox.HintForeColor = System.Drawing.Color.Transparent;
            this.textBox.HintText = "";
            this.textBox.isPassword = false;
            this.textBox.LineFocusedColor = System.Drawing.Color.Purple;
            this.textBox.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.textBox.LineThickness = 3;
            this.textBox.Location = new System.Drawing.Point(32, 366);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(550, 39);
            this.textBox.TabIndex = 5;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::ToDoList.Properties.Resources.Plus;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(589, 347);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Learnign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Learnign";
            this.Size = new System.Drawing.Size(650, 420);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
