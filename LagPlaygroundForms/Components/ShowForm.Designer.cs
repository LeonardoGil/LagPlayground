namespace LagPlaygroundForms.Components
{
    partial class ShowForm
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
            panelArcControl1 = new PanelArcControl();
            SuspendLayout();
            // 
            // panelArcControl1
            // 
            panelArcControl1.BackColor = Color.White;
            panelArcControl1.Location = new Point(110, 84);
            panelArcControl1.Name = "panelArcControl1";
            panelArcControl1.Size = new Size(222, 300);
            panelArcControl1.TabIndex = 0;
            panelArcControl1.Text = "panelArcControl1";
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(panelArcControl1);
            Name = "ShowForm";
            Text = "ShowForm";
            ResumeLayout(false);
        }

        #endregion

        private PanelArcControl panelArcControl1;
    }
}