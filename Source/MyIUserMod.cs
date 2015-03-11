using ICities;
using UnityEngine;

namespace YourNameSpaceHere
{

    public class MyIUserMod: IUserMod
    {

        public string Name 
        {
            get { return "Your mod name here"; }
        }

        public string Description 
        {
            get { return "Your mod description here"; }
			
        }
    }

    // Inherit interfaces and implement your mod logic here
    // You can use as many files and subfolders as you wish to organise your code, as long
    // as it remains located under the Source folder.
}
