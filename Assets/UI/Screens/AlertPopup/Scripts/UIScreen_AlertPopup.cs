using GourdUI;
using Scenes;
using UnityEngine;

/// <summary>
/// UIScreen implementation.
/// </summary>
public class UIScreen_AlertPopup: 
    UIScreen <IUIContractScreen_AlertPopup, IUIContractView_AlertPopup, UIState_AlertPopup>, 
    IUIContractScreen_AlertPopup
{
    #region Data

    [Header("Values")] 
    public float randomPosOffsetRange = 20;

    public static int activeCount;

    #endregion Data
    
    
    #region Setup

    public override void OnScreenInstantiated()
    {
        base.OnScreenInstantiated();
        
        activeCount++;
        //FindObjectOfType<SceneController_Popups>().PopulateAlert(this);
    }

    #endregion Setup


    #region Teardown

    protected override void OnDestroy()
    {
        base.OnDestroy();
        activeCount--;
    }

    #endregion Teardown


    #region State
    
    protected override void ResetScreenState()
    {
        // Use "state" variable to access UIState_AlertPopup
        state = SceneController_Popups.GetNewPopupState(randomPosOffsetRange);
    }

    #endregion State
    

    #region View

    void IUIContractScreen_AlertPopup.OnAlertDismissed()
    {
        Destroy(gameObject);
    }

    public void OnUpdateDragState(RectDragSourceState s)
    {
        state.dragState = s;
    }

    #endregion View
}