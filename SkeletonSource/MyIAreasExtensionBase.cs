using ICities;
using UnityEngine;
using ChirpLogger;

namespace YouNameSpaceHere
{

    public class MyIAreasExtensionBase: AreasExtensionBase
    {
		//Thread: Main
		public override void OnCreated(IAreas areas)
		{
			ChirpLog.Debug("IAreas Created");
		}
		//Thread: Main
		public override void OnReleased()
		{
			
		}
	 }
}
