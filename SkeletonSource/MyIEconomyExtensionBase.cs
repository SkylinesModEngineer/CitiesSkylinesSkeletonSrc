using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIEconomyExtensionBase: EconomyExtensionBase
    {
		// Thread: Main
		public override void OnCreated(IEconomy economy)
		{
			ChirpLog.Debug("IEconomy Created");
		}
		// Thread: Main
		public override void OnReleased()
		{
		
		
		}
	 }
}
