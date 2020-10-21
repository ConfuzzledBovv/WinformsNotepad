namespace Notes
{
    partial class Notes
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
            this.Data = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.FileButton = new System.Windows.Forms.MenuItem();
            this.NewButton = new System.Windows.Forms.MenuItem();
            this.OpenButton = new System.Windows.Forms.MenuItem();
            this.SaveButton = new System.Windows.Forms.MenuItem();
            this.CloseButton = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.Location = new System.Drawing.Point(0, 0);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(801, 453);
            this.Data.TabIndex = 0;
            this.Data.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileButton});
            // 
            // FileButton
            // 
            this.FileButton.Index = 0;
            this.FileButton.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewButton,
            this.OpenButton,
            this.SaveButton,
            this.CloseButton});
            this.FileButton.Text = "File";
            // 
            // NewButton
            // 
            this.NewButton.Index = 0;
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Index = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Index = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Index = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Menu = this.mainMenu1;
            this.Name = "Notes";
            this.Text = "NewNotes.txt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem FileButton;
        private System.Windows.Forms.MenuItem NewButton;
        private System.Windows.Forms.MenuItem OpenButton;
        private System.Windows.Forms.MenuItem SaveButton;
        private System.Windows.Forms.MenuItem CloseButton;
    }
}

