using System;
using GourdUI;
using UnityEngine;

/// <summary>
/// UIScreen implementation.
/// </summary>
public class UIScreen_DemoMainMenu: 
    UIScreen <IUIContractScreen_DemoMainMenu, IUIContractView_DemoMainMenu, UIState_DemoMainMenu>, 
    IUIContractScreen_DemoMainMenu
{
    #region Setup

    public override void OnScreenInstantiated()
    {
        base.OnScreenInstantiated();
        
        // Opportunity to establish state from external sources before view is updated
    }

    #endregion Setup


    #region State

    protected override void ResetScreenState()
    {
        // Use "state" variable to access UIState_DemoMainMenu
        state.confirmingExit = false;
    }

    #endregion State


    #region Update

    private void Update()
    {
        viewContract.OnSystemTimeUpdated(DateTime.Now);
    }

    #endregion


    #region View Events

    public void OnBeginGameSelect()
    {
        
    }

    public void OnOptionsSelect()
    {
        
    }

    public void OnExitGameSelect()
    {
        state.confirmingExit = true;
    }

    public void OnExitGameConfirm()
    {
        state.confirmingExit = false;
    }

    public void OnExitGameCancel()
    {
        state.confirmingExit = false;
    }

    #endregion View Events
}