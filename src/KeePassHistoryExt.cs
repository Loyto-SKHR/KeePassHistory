using System;

using System.Windows.Forms;
using KeePass.Plugins;
using KeePassHistory.src;


namespace KeePassHistory
{
	public sealed class KeePassHistoryExt : Plugin
	{
		private IPluginHost m_host = null;

		public override bool Initialize(IPluginHost host)
		{
			if(host == null) return false; // Fail; we need the host
			m_host = host;

			return true;
		}
		public override void Terminate()
		{
		}

        public override ToolStripMenuItem GetMenuItem(PluginMenuType pluginMenuType)
		{
			if (pluginMenuType != PluginMenuType.Main) return null;

			ToolStripMenuItem tsmi = new ToolStripMenuItem("History");

            //View
            ToolStripMenuItem tsmiView = new ToolStripMenuItem("View");
			tsmiView.Click += this.OnMenuViewClicked;
			tsmi.DropDownItems.Add(tsmiView);

            //reset
            ToolStripMenuItem tsmiReset = new ToolStripMenuItem("Reset");
            tsmiView.Click += this.OnMenuResetClicked;
            tsmi.DropDownItems.Add(tsmiReset);

            return tsmi;
        }

        private void OnMenuViewClicked(object sender, EventArgs e)
        {
			var selectDate = new SelectDate(this.m_host);

			selectDate.ShowDialog(this.m_host.MainWindow);
        }

        private void OnMenuResetClicked(object sender, EventArgs e)
        {

        }
    }
}
