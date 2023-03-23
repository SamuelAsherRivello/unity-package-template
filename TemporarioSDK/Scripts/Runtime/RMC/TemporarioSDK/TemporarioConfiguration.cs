using RMC.TemporarioSDK.Data.Types.Observables;
using UnityEngine;

namespace RMC.TemporarioSDK
{
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// The configuration data
    /// </summary>
    //[CreateAssetMenu( fileName = "TemporarioConfiguration")]
    public class TemporarioConfiguration : ScriptableObject
    {
        //  Properties ------------------------------------
        public Observable<bool> IsWaterWet {  get { return _isWaterWet; } }


        //  Fields ----------------------------------------
        [SerializeField]
        private Observable<bool> _isWaterWet = new Observable<bool>();

    }
}