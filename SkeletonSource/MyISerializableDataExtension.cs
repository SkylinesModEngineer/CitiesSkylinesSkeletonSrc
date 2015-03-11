using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyISerializableDataExtension: ISerializableDataExtension
    {
		//Thread: Main
		public void OnCreated(ISerializableData serializedData)
		{
			ChirpLog.Debug("ISerialization Created");
		}
		//Thread: Main
		public void OnReleased()
		{
		 
		}
		//Thread: Simulation
		public void OnLoadData()
		{
		
		}
		//Thread: Simulation
		public void OnSaveData()
		{
		
		}

	 }
}
