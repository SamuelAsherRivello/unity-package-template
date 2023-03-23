using UnityEngine;
using UnityEngine.UI;

namespace RMC.TemporarioSDK.Samples
{
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// Demonstrates the <see cref="TemporarioHUD"/> prefab
    /// workflow.
    /// </summary>
    public class TemporarioHUD : MonoBehaviour
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------


        //  Fields ----------------------------------------
        [SerializeField] 
        private Text _outputText = null;


        //  Unity Methods ---------------------------------
        protected void Awake()
        {
            //The HUD users the single-entry point
            TemporarioSingleton.Instance.IsTheSkyBlue.OnValueChanged.AddListener(IsTheSkyBlue_OnValueChanged);
        }


        //  Methods ---------------------------------------


        //  Event Handlers --------------------------------
        private void IsTheSkyBlue_OnValueChanged(bool previousValue, bool currentValue)
        {
            string currentValueString = "false";
            if (currentValue)
            {
                currentValueString = "true";
            }
            
            _outputText.text = $"IsTheSkyBlue = {currentValueString}";
        }
    }
}