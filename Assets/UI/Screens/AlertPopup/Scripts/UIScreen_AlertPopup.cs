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

    public static int activeCount = 0;

    #endregion Data
    
    
    #region Setup

    public override void OnScreenInstantiated()
    {
        base.OnScreenInstantiated();
        
        activeCount++;
        FindObjectOfType<SceneController_Popups>().PopulateAlert(this);
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
        state = new UIState_AlertPopup
        {
            titleText = "AlertTitle",
            bodyText = "Alert Body",
            dismissButtonText = "Button Text",
            backgroundColor = Color.white,
            alertPanelOffset = Vector2.zero
        };
    }

    #endregion State


    #region Content

    public void SetAlertScreenContent(
        string titleText,
        string bodyText,
        Color backgroundColor,
        string dismissButtonText = "Okay")
    {
        state = new UIState_AlertPopup
        {
            titleText = titleText,
            bodyText = bodyText,
            dismissButtonText = dismissButtonText,
            backgroundColor = backgroundColor,
            alertPanelOffset = GetAlertPanelOffset()
        };
        viewContract.ApplyScreenStateToView(state);
    }

    #endregion Content


    #region View

    void IUIContractScreen_AlertPopup.OnAlertDismissed()
    {
        Destroy(gameObject);
    }

    #endregion View


    #region Utility

    private Vector2 GetAlertPanelOffset()
    {
        float x = Random.Range(-randomPosOffsetRange, randomPosOffsetRange);
        float y = Random.Range(-randomPosOffsetRange, randomPosOffsetRange);
        return new Vector2(x, y);
    }

    #endregion Utility
}