using UnityEngine;

namespace RMC.TemporarioSDK.Samples
{
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// Demonstrates the <see cref="TemporarioSingleton"/>
    /// as single-entry point to the <see cref="Temporario"/>.
    /// </summary>
    public class TemporarioSample : MonoBehaviour
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------


        //  Fields ----------------------------------------


        //  Unity Methods ---------------------------------
        protected void Awake()
        {
            // Get runtime values
            bool isTheSkyBlue = TemporarioSingleton.Instance.IsTheSkyBlue.Value;
            Debug.Log($"isTheSkyBlue: {isTheSkyBlue}");
            
            // Get configuration values
            bool isWaterWet = TemporarioSingleton.Instance.TemporarioConfiguration.IsWaterWet.Value;
            Debug.Log($"isWaterWet: {isWaterWet}");
        }


        //  Methods ---------------------------------------


        //  Event Handlers --------------------------------
    }
}