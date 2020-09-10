using GourdUI;
using UnityEngine.SceneManagement;

/// <summary>
/// UIScreen implementation.
/// </summary>
public class UIScreen_MainMenu: 
    UIScreen <IUIContractScreen_MainMenu, IUIContractView_MainMenu, UIState_MainMenu>, 
    IUIContractScreen_MainMenu
{
    #region State

    protected override void ResetScreenState()
    {
        // Use "state" variable to access UIState_MainMenu
    }

    protected override void OnViewPreDestroy()
    {
        
    }

    #endregion State


    #region View Events

    void IUIContractScreen_MainMenu.OnViewSceneSelect(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
 
    #endregion View Events

}