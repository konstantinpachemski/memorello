namespace _28ProektnaFormsMemorello
{
    partial class ShowCards
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.buttonDecrement = new System.Windows.Forms.Button();
            this.createCardButton = new System.Windows.Forms.Button();
            this.deleteCardButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 23);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 343);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(100, 150);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cards";
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIncrement.Location = new System.Drawing.Point(654, 175);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(43, 23);
            this.buttonIncrement.TabIndex = 2;
            this.buttonIncrement.Text = "++";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            // 
            // buttonDecrement
            // 
            this.buttonDecrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecrement.Location = new System.Drawing.Point(605, 175);
            this.buttonDecrement.Name = "buttonDecrement";
            this.buttonDecrement.Size = new System.Drawing.Size(43, 23);
            this.buttonDecrement.TabIndex = 3;
            this.buttonDecrement.Text = "--";
            this.buttonDecrement.UseVisualStyleBackColor = true;
            // 
            // createCardButton
            // 
            this.createCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCardButton.Location = new System.Drawing.Point(606, 23);
            this.createCardButton.Name = "createCardButton";
            this.createCardButton.Size = new System.Drawing.Size(91, 35);
            this.createCardButton.TabIndex = 4;
            this.createCardButton.Text = "Add card";
            this.createCardButton.UseVisualStyleBackColor = true;
            this.createCardButton.Click += new System.EventHandler(this.createCardButton_Click);
            // 
            // deleteCardButton
            // 
            this.deleteCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCardButton.Location = new System.Drawing.Point(606, 64);
            this.deleteCardButton.Name = "deleteCardButton";
            this.deleteCardButton.Size = new System.Drawing.Size(92, 35);
            this.deleteCardButton.TabIndex = 5;
            this.deleteCardButton.Text = "Delete card";
            this.deleteCardButton.UseVisualStyleBackColor = true;
            this.deleteCardButton.Click += new System.EventHandler(this.deleteCardButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "   Change priority";
            // 
            // toggleStatusButton
            // 
            this.toggleStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleStatusButton.Location = new System.Drawing.Point(608, 105);
            this.toggleStatusButton.Name = "toggleStatusButton";
            this.toggleStatusButton.Size = new System.Drawing.Size(90, 35);
            this.toggleStatusButton.TabIndex = 7;
            this.toggleStatusButton.Text = "Toggle status";
            this.toggleStatusButton.UseVisualStyleBackColor = true;
            // 
            // ShowCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 378);
            this.Controls.Add(this.toggleStatusButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteCardButton);
            this.Controls.Add(this.createCardButton);
            this.Controls.Add(this.buttonDecrement);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 417);
            this.Name = "ShowCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cards";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowCards_FormClosed);
            this.Load += new System.EventHandler(this.ShowCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Button buttonDecrement;
        private System.Windows.Forms.Button createCardButton;
        private System.Windows.Forms.Button deleteCardButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toggleStatusButton;
    }
}