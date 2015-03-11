using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyITerrainExtension: ITerrainExtension
    {
		//Thread: Main
		public void OnCreated(ITerrain terrain)
		{
			ChirpLog.Debug("ITerrain Created");
		}
		//Thread: Main
		public void OnReleased()
		{
		
		}
		//Thread: Simulation
		public void OnAfterHeightsModified(float minX, float minZ, float maxX, float maxZ)
		{
		
		
		}

	 }
}
