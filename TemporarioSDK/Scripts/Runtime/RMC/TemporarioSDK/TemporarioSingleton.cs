using RMC.TemporarioSDK.Data.Types.Observables;
using RMC.TemporarioSDK.DesignPatterns.Singleton;
using UnityEngine;

namespace RMC.TemporarioSDK
{
    
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// The single-entry point to the <see cref="Temporario"/>
    /// without requiring <see cref="Temporario"/> to be a <see cref="MonoBehaviour"/>
    /// </summary>
    public class TemporarioSingleton : SingletonMonoBehaviour<TemporarioSingleton> , ITemporario
    {

        //  Fields ----------------------------------------
        private Temporario _temporario = null;

        //  Unity Methods ---------------------------------
        protected override void Awake()
        {
            base.Awake();
            _temporario = new Temporario();
            
        }

        //  Wrapper Properties ------------------------------------
        public TemporarioConfiguration TemporarioConfiguration
        {
            get
            {
                return _temporario.TemporarioConfiguration;
            }
            set
            {
                _temporario.TemporarioConfiguration = value;
            }
        }
        public Observable<bool> IsTheSkyBlue
        {
            get
            {
                return _temporario.IsTheSkyBlue;
            }
            set
            {
                _temporario.IsTheSkyBlue = value;
            }
        }
        
        //  Wrapper Methods ---------------------------------------
      
    }
}