using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyITerrainExtensionBase: TerrainExtensionBase
    {
		//Thread: Main
		public override void OnCreated(ITerrain terrain)
		{
			ChirpLog.Debug("ITerrain Created");
		}
		//Thread: Main
		public override void OnReleased()
		{
		
		}
		

	 }
}
