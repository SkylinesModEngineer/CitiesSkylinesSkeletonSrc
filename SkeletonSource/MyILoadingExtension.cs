using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyILoadingExtension: ILoadingExtension
    {
		// Thread: Main
		public void OnCreated(ILoading loading)
		{
			ChirpLog.Debug("ILoading Created");
		}
		// Thread: Main
		public void OnReleased()
		{
	
		}
		public void OnLevelLoaded(LoadMode mode)
		{
			ChirpLog.Flush();
		}
		public void OnLevelUnloading()
		{
			
		}
		
	 }
}
