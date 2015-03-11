using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIMilestoneExtensionBase: MilestonesExtensionBase
    {
		// Thread: Main
		public override void OnCreated(IMilestones milestones)
		{
			ChirpLog.Debug("IMilestones Created");
		}
		// Thread: Main
		public override void OnReleased()
		{
		
		}
	 }
	 
}
