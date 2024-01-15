namespace LagPlaygroundForms
{
    partial class DragToTrashForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreateControl = new Button();
            pictureBoxTrash = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrash).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateControl
            // 
            buttonCreateControl.BackColor = Color.DimGray;
            buttonCreateControl.FlatAppearance.BorderColor = Color.DimGray;
            buttonCreateControl.FlatAppearance.BorderSize = 2;
            buttonCreateControl.FlatStyle = FlatStyle.Flat;
            buttonCreateControl.Location = new Point(12, 12);
            buttonCreateControl.Name = "buttonCreateControl";
            buttonCreateControl.Size = new Size(90, 60);
            buttonCreateControl.TabIndex = 0;
            buttonCreateControl.Text = "Create Control";
            buttonCreateControl.UseVisualStyleBackColor = false;
            buttonCreateControl.Click += CreateControl_ClickEvent;
            // 
            // pictureBoxTrash
            // 
            pictureBoxTrash.BackColor = Color.Transparent;
            pictureBoxTrash.Location = new Point(780, 444);
            pictureBoxTrash.Name = "pictureBoxTrash";
            pictureBoxTrash.Size = new Size(80, 100);
            pictureBoxTrash.TabIndex = 1;
            pictureBoxTrash.TabStop = false;
            // 
            // DragToTrashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(864, 552);
            Controls.Add(pictureBoxTrash);
            Controls.Add(buttonCreateControl);
            Font = new Font("MesloLGM NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DragToTrashForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateControl;
        private PictureBox pictureBoxTrash;
    }
}