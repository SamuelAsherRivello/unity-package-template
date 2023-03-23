using RMC.TemporarioSDK.Data.Types.Observables;
using UnityEngine;

namespace RMC.TemporarioSDK
{
    /// <summary>
    /// Interface for <see cref="Temporario"/>
    /// </summary>
    public interface ITemporario
    {
        //  Properties ------------------------------------
        TemporarioConfiguration TemporarioConfiguration { get; set; }
        Observable<bool> IsTheSkyBlue { get; set; }
        
        //  Methods ---------------------------------------

    }
}