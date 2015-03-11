using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIDemandExtension: IDemandExtension
    {
		 //Thread: Main
		public void OnCreated(IDemand demand)
		{
			ChirpLog.Debug("IDemand Created");
		}
		//Thread: Main
		public void OnReleased()
		{
		 
		}
		//Thread: Simulation
		public int OnCalculateResidentialDemand(int originalDemand)
		{
			return originalDemand;
		}
		//Thread: Simulation
		public int OnCalculateCommercialDemand(int originalDemand)
		{
			return originalDemand;
		}
		//Thread: Simulation
		public int OnCalculateWorkplaceDemand(int originalDemand)
		{
			return originalDemand;
		}
		//Thread: Simulation
		public int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand)
		{
			return nextDemand;
		}
		
	 }
}
