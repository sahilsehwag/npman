namespace Npman.Dialogs
{
    partial class Selector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Note = new System.Windows.Forms.Label();
            this.flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow
            // 
            resources.ApplyResources(this.flow, "flow");
            this.flow.Controls.Add(this.Note);
            this.flow.Name = "flow";
            // 
            // Note
            // 
            resources.ApplyResources(this.Note, "Note");
            this.Note.Name = "Note";
            // 
            // Selector
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selector";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.flow.ResumeLayout(false);
            this.flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.Label Note;
    }
}