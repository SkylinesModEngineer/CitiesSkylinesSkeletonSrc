using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyILevelUp: ILevelUpExtension
    {
		 //Thread: Main
		public void OnCreated(ILevelUp levelUp)
		{
		 ChirpLog.Debug("ILevelUp Created");
		}
		//Thread: Main
		public void OnReleased()
		{
		 
		}
		// Thread: Simulation
		public ResidentialLevelUp OnCalculateResidentialLevelUp(ResidentialLevelUp levelUp, int averageEducation, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
		{
			return levelUp;
		}
		// Thread: Simulation
		public CommercialLevelUp OnCalculateCommercialLevelUp(CommercialLevelUp levelUp, int averageWealth, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
		{
			return levelUp;
		}
		// Thread: Simulation
		public IndustrialLevelUp OnCalculateIndustrialLevelUp(IndustrialLevelUp levelUp, int averageEducation, int serviceScore, ushort buildingID, Service service, SubService subService, Level currentLevel)
		{
			return levelUp;
		}
		// Thread: Simulation
		public OfficeLevelUp OnCalculateOfficeLevelUp(OfficeLevelUp levelUp, int averageEducation, int serviceScore, ushort buildingID, Service service, SubService subService, Level currentLevel)
		{
			return levelUp;
		}

	 }
}
