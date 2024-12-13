namespace WinFormsApp6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCurrentPlayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();

           
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPlayer.Location = new System.Drawing.Point(350, 150);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(157, 22);
            this.lblCurrentPlayer.TabIndex = 0;
            this.lblCurrentPlayer.Text = "Gracz X rozpoczyna";

            
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Name = "Form1";
            this.Text = "Kolko i Krzyzyk";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
