namespace WinFormsApp2ndTry
{
    partial class Form1
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
            btnMagicButton = new Button();
            lblHelloLiudmyla = new Label();
            SuspendLayout();
            // 
            // btnMagicButton
            // 
            btnMagicButton.Location = new Point(230, 146);
            btnMagicButton.Name = "btnMagicButton";
            btnMagicButton.Size = new Size(303, 75);
            btnMagicButton.TabIndex = 0;
            btnMagicButton.Text = "Magic Button";
            btnMagicButton.UseVisualStyleBackColor = true;
            btnMagicButton.Click += btnMagicButton_Click;
            // 
            // lblHelloLiudmyla
            // 
            lblHelloLiudmyla.AutoSize = true;
            lblHelloLiudmyla.Location = new Point(356, 252);
            lblHelloLiudmyla.Name = "lblHelloLiudmyla";
            lblHelloLiudmyla.Size = new Size(49, 20);
            lblHelloLiudmyla.TabIndex = 1;
            lblHelloLiudmyla.Text = "Hello!";
            lblHelloLiudmyla.Click += lblHelloLiudmyla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloLiudmyla);
            Controls.Add(btnMagicButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMagicButton;
        private Label lblHelloLiudmyla;
    }
}