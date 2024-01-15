namespace LagPlaygroundForms.Basketball
{
    partial class BasketballForm
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
            basketballControl1 = new BasketballControl();
            SuspendLayout();
            // 
            // basketballControl1
            // 
            basketballControl1.Anchor = AnchorStyles.None;
            basketballControl1.Location = new Point(383, 226);
            basketballControl1.MinimumSize = new Size(24, 24);
            basketballControl1.Name = "basketballControl1";
            basketballControl1.Size = new Size(96, 96);
            basketballControl1.TabIndex = 0;
            // 
            // BasketballForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(basketballControl1);
            Name = "BasketballForm";
            Text = "BasketballForms";
            ResumeLayout(false);
        }

        #endregion

        private BasketballControl basketballControl1;
    }
}