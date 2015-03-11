using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIMilestoneExtension: IMilestonesExtension
    {
		// Thread: Main
		public void OnCreated(IMilestones milestones)
		{
			ChirpLog.Debug("IMilestones Created");
		}
		// Thread: Main
		public void OnReleased()
		{
		
		}
		public  void OnRefreshMilestones()
		{
			
		}
		public int OnGetPopulationTarget(int originalTarget, int scaledTarget)
		{
			return originalTarget;
		}
		
	 }
	 
}
