using System;

/// <summary>
/// Defines implementation requirements for views from the screen.
/// </summary>
public interface IUIContractView_DemoMainMenu : IUIContractView<UIState_DemoMainMenu>
{
    void OnSystemTimeUpdated(DateTime d);
}