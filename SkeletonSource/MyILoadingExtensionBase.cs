using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyILoadingExtensionBase: LoadingExtensionBase
    {
		// Thread: Main
		public override void OnCreated(ILoading loading)
		{
			ChirpLog.Debug("ILoading Created");
		}
		// Thread: Main
		public override void OnReleased()
		{
	
		}		
	 }
}
