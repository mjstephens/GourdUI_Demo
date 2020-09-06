/// <summary>
/// Defines implementation requirements for the screen from the view.
/// </summary>
public interface IUIContractScreen_MainMenu : IUIContractScreen
{
    void OnViewSceneSelect(int sceneIndex);
}