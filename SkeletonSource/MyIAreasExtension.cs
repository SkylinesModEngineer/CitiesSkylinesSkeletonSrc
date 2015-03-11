using ICities;
using UnityEngine;
using ChirpLogger;

namespace YouNameSpaceHere
{

    public class MyIAreasExtension: IAreasExtension
    {
		//Thread: Main
		public void OnCreated(IAreas areas)
		{
			ChirpLog.Debug("IAreas Created");
		}
		//Thread: Main
		public void OnReleased()
		{
			
		}
		//Thread: Any
		public bool OnCanUnlockArea(int x, int z, bool originalResult)
		{
			return originalResult;
		}
		//Thread: Any
		public int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
		{
			return originalPrice;
		}
		//Thread: Simulation
		public void OnUnlockArea(int x, int z)
		{
		
		}
	 }
}
