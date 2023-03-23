using UnityEngine;

#pragma warning disable CS0414
namespace RMC.TemporarioSDK.Samples
{
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// Demonstrates the <see cref="TemporarioHUD"/> prefab
    /// workflow.
    /// </summary>
    public class TemporarioHUDSample : MonoBehaviour
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------


        //  Fields ----------------------------------------
        [SerializeField] 
        private TemporarioHUD _temporarioHUD = null;


        //  Unity Methods ---------------------------------
        protected void Awake()
        {
            Debug.Log("Mouse-click to change value");
        }

        protected void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //The sample can interact with the HUD if desired
                //_temporarioHUD.Blah = foo;
                
                //The sample can interact with the SDK if desired
                //Here notice that the HUD 'automagically' updates per
                //best practices on the SDK structure
                TemporarioSingleton.Instance.IsTheSkyBlue.Value =
                    !TemporarioSingleton.Instance.IsTheSkyBlue.Value;
            }
        }
        
        //  Methods ---------------------------------------


        //  Event Handlers --------------------------------
    }
}