using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIDemandExtensionBase: DemandExtensionBase
    {
		 //Thread: Main
		public override void OnCreated(IDemand demand)
		{
			ChirpLog.Debug("IDemand Created");
		}
		//Thread: Main
		public override void OnReleased()
		{
		 
		}
	 }
}
