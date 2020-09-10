using System;
using GourdUI;
using TMPro;
using UnityEngine;

public class UIView_DemoMainMenu : UIView<IUIContractScreen_DemoMainMenu, UIState_DemoMainMenu>, 
    IUIContractView_DemoMainMenu
{
    #region Fields

    [Header("References")] 
    public TMP_Text timeLabel;

    public GameObject exitConfirmPanel;

    #endregion Fields


    #region Setup
    
    protected override void OnScreenInstantiated()
    {
        // Called when the view is instantiated along with the screen.
        // You can use this to call setup animations, fx, etc
        
        // Is NOT called when a view is being instantiated because of a device/filter change - only when
        // a screen is being instantiated for the first time.
    }

    public override void ApplyScreenStateToView(UIState_DemoMainMenu state, bool isScreenInstantiation)
    {
        exitConfirmPanel.SetActive(state.confirmingExit);
    }

    #endregion Setup
    
    
    #region Teardown

    protected override void OnViewPreDestroy()
    {
        // Optionally do things here before the view is destroyed
    }

    #endregion Teardown


    #region UI Events

    public void OnStartButtonPressed()
    {
        screenContract.OnBeginGameSelect();
    }
    
    public void OnOptionsButtonPressed()
    {
        screenContract.OnOptionsSelect();
    }
    
    public void OnExitButtonPressed()
    {
        screenContract.OnExitGameSelect();
        exitConfirmPanel.SetActive(true);
    }
    
    public void OnExitCancelButtonPressed()
    {
        screenContract.OnExitGameCancel();
        exitConfirmPanel.SetActive(false);
    }
    
    public void OnExitConfirmButtonPressed()
    {
        screenContract.OnExitGameConfirm();
    }

    #endregion


    #region Screen Updates

    public void OnSystemTimeUpdated(DateTime d)
    {
        timeLabel.text = d.ToShortTimeString();
    }

    #endregion Screen Updates
}