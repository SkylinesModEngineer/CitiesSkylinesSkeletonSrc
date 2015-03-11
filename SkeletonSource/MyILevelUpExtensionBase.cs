using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyILevelUpBase: LevelUpExtensionBase
    {
		 //Thread: Main
		public override void OnCreated(ILevelUp levelUp)
		{
		 ChirpLog.Debug("ILevelUp Created");
		}
		//Thread: Main
		public override void OnReleased()
		{
		 
		}
	 }
}
