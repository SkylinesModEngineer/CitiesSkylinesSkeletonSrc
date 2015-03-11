using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyIThreadingExtension: IThreadingExtension
    {
		//Thread: Main
		public void OnCreated(IThreading threading)
		{
			ChirpLog.Debug("IThreading Created");
		}
		//Thread: Main
		public void OnReleased()
		{
		
		}
		//Thread: Main
		public void OnUpdate(float realTimeDelta, float simulationTimeDelta)
		{
		
		}
		//Thread: Simulation
		public void OnBeforeSimulationTick()
		{
		
		}
		//Thread: Simulation
		public void OnBeforeSimulationFrame()
		{
		
		}
		//Thread: Simulation
		public void OnAfterSimulationFrame()
		{
		
		}
		//Thread: Simulation
		public void OnAfterSimulationTick()
		{
		
		}

	 }
}
