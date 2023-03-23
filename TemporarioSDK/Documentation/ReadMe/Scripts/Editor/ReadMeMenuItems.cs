using RMC.Core.ReadMe;
using UnityEditor;

namespace RMC.TemporarioSDK.ReadMe
{
	public static class ReadMeMenuItems
	{
		//  Fields ----------------------------------------
		public const string PathMenuItemWindowCompanyProject = "Window/" + CompanyName + "/" + ProjectName;
		public const string CompanyName = "RMC";
		public const string ProjectName = "TemporarioSDK";
		public const int PriorityMenuItem_Examples = 1;
        
		//  Fields ----------------------------------------
		
		[MenuItem( PathMenuItemWindowCompanyProject + "/" + "Open ReadMe", 
			false,
						PriorityMenuItem_Examples)]
		public static void SelectReadmes()
		{
			ReadMeHelper.SelectReadmes();
		}
	}
}
