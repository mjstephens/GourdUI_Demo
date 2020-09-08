/// <summary>
/// Defines implementation requirements for the screen from the view.
/// </summary>
public interface IUIContractScreen_DemoMainMenu : IUIContractScreen
{
    void OnBeginGameSelect();
    void OnOptionsSelect();
    void OnExitGameSelect();
    void OnExitGameConfirm();
    void OnExitGameCancel();
}