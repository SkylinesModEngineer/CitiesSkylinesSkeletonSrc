using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIChirperExtension: IChirperExtension
    {
		 //Thread: Main
		public void OnCreated(IChirper chirper)
		{
			ChirpLog.Debug("IChirper Created");
		}
		//Thread: Main
		public void OnReleased()
		{
		 
		}
		//Thread: Main
		public void OnUpdate()
		{
				
		}
		// Thread: Main
		public void OnMessagesUpdated()
		{
		
		}
		// Thread: Main
		public void OnNewMessage(IChirperMessage message)
		{
		
		
		}
		
	 }
}
