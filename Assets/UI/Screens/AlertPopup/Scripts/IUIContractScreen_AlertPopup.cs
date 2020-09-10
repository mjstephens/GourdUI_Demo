using GourdUI;

/// <summary>
/// Defines implementation requirements for the screen from the view.
/// </summary>
public interface IUIContractScreen_AlertPopup : IUIContractScreen
{
    void OnAlertDismissed();
    void OnUpdateDragState(RectDragSourceState state);
}