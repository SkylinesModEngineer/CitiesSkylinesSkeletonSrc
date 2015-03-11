using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIChirperExtensionBase: ChirperExtensionBase
    {
		 //Thread: Main
		public override void OnCreated(IChirper chirper)
		{
			ChirpLog.Debug("IChirper Created");
		}
		//Thread: Main
		public override void OnReleased()
		{
		 
		}
		//Thread: Main
		public override void OnUpdate()
		{
				
		}
	 }
}
