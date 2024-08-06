using KeePass.Plugins;
using System.Windows.Forms;


namespace KeePassHistory.src
{
    public partial class SelectDate : Form
    {
        private System.ComponentModel.IContainer components = null;

        private IPluginHost m_host = null;

        public SelectDate(IPluginHost m_host)
        {

            InitializeComponent();
            this.m_host = m_host;
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDate));
            this.SuspendLayout();
            // 
            // SelectDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDate";
            this.Text = "Select date";
            this.ResumeLayout(false);

        }

        #endregion
    }
}