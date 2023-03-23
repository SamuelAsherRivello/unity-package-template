using RMC.TemporarioSDK.Data.Types.Observables;
using UnityEngine;

namespace RMC.TemporarioSDK
{
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// A main entry-point to the <see cref="Temporario"/>.
    /// Note there is no REQUIREMENT here to have a single-entry point.
    /// </summary>
    public class Temporario : ITemporario
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------
        public TemporarioConfiguration TemporarioConfiguration {  get { return _temporarioConfiguration; }  set { _temporarioConfiguration = value; } }
        public Observable<bool> IsTheSkyBlue {  get { return _isTheSkyBlue; }  set { _isTheSkyBlue = value; } }


        //  Fields ----------------------------------------
        private TemporarioConfiguration _temporarioConfiguration = null;
        private Observable<bool> _isTheSkyBlue = new Observable<bool>();


        //  Initialization Methods ------------------------
        public Temporario()
        {
            // Set defaults
            _isTheSkyBlue.Value = false;
            
            // Load defaults. Depending on if/how users set this, you may want to 
            // change this approach
            _temporarioConfiguration =
                Resources.Load<TemporarioConfiguration>("ScriptableObjects/TemporarioSDKConfiguration");
        }


        //  Methods ---------------------------------------


        //  Event Handlers --------------------------------
    }
}