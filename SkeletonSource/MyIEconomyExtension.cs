using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIEconomyExtension: IEconomyExtension
    {
		// Thread: Main
		public void OnCreated(IEconomy economy)
		{
			ChirpLog.Debug("IEconomy Created");
		}
		// Thread: Main
		public void OnReleased()
		{
		
		}
		//Thread: Simulation
		public long OnUpdateMoneyAmount(long internalMoneyAmount)
		{
			return internalMoneyAmount;
		}
		//Thread: Simulation
		public int OnPeekResource(EconomyResource resource, int amount)
		{
			return amount;
		}
		//Thread: Simulation
		public bool OverrideDefaultPeekResource 
		{ 
			get{return false;} 
		}
		 //Thread: Simulation
		public int OnFetchResource(EconomyResource resource, int amount, Service service, SubService subService, Level level)
		{
			return amount;
		}
		public int OnAddResource(EconomyResource resource, int amount, Service service, SubService subService, Level level)
		{
			return amount;
			
		}
		//Thread: Any
		public int OnGetConstructionCost(int originalConstructionCost, Service service, SubService subService, Level level)
		{
			return originalConstructionCost;
		}
		//Thread: Any
		public int OnGetMaintenanceCost(int originalMaintenanceCost, Service service, SubService subService, Level level)
		{
			return originalMaintenanceCost;
		}
		//Thread: Any
		public int OnGetRelocationCost(int constructionCost, int relocationCost, Service service, SubService subService, Level level)
		{
			return relocationCost;
		}
		//Thread: Any
		public int OnGetRefundAmount(int constructionCost, int refundAmount, Service service, SubService subService, Level level)
		{
			return refundAmount;
		}
		
		
		
		
		
		

		
	 }
}
