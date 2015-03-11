using ICities;
using UnityEngine;
using ChirpLogger;

namespace YourNameSpaceHere
{

    public class MyISerializableDataExtensionBase: SerializableDataExtensionBase
    {
		//Thread: Main
		public override void OnCreated(ISerializableData serializedData)
		{
			ChirpLog.Debug("ISerialization Created");
		}
		//Thread: Main
		public override void OnReleased()
		{
		 
		}
		

	 }
}
