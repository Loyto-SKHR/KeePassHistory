using System;
using System.Collections.Generic;

using KeePass.Plugins;

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
	}
}
