using GourdUI;
using UnityEngine;
using UnityEngine.UI;

public class UIView_MainMenu : UIView<IUIContractScreen_MainMenu, UIState_MainMenu>, 
    IUIContractView_MainMenu
{
    #region Fields
    
    

    #endregion Fields


    #region Setup

    protected override void OnScreenInstantiated()
    {
        
    }

    public override void ApplyScreenStateToView(UIState_MainMenu state)
    {
        
    }
    
    #endregion Setup
    
    
    #region Teardown

    protected override void OnViewPreDestroy()
    {
        // Optionally do things here before the view is destroyed
    }

    #endregion Teardown


    #region UI

    public void OnSceneSelectButtonPress(int sceneIndex)
    {
        screenContract.OnViewSceneSelect(sceneIndex);
    }

    #endregion UI


    #region Screen Updates

    

    #endregion Screen Updates
}