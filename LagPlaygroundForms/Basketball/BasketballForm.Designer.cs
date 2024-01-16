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
            basketballControl = new BasketballControl();
            SuspendLayout();
            // 
            // basketballControl
            // 
            basketballControl.Anchor = AnchorStyles.None;
            basketballControl.Location = new Point(214, 278);
            basketballControl.MinimumSize = new Size(24, 24);
            basketballControl.Name = "basketballControl";
            basketballControl.Size = new Size(96, 96);
            basketballControl.TabIndex = 0;
            // 
            // BasketballForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(basketballControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BasketballForm";
            Text = "BasketballForms";
            ResumeLayout(false);
        }

        #endregion

        private BasketballControl basketballControl;
    }
}