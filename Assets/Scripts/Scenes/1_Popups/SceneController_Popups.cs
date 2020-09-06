using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes
{
    public class SceneController_Popups : MonoBehaviour
    {
        #region Variables

        public UIScreen_AlertPopup popupsUIScreen;

        private bool _flag;

        #endregion Variables
        

        #region UI

        public void OnSpawnAlertScreenButton()
        {
            Instantiate(popupsUIScreen.gameObject);
        }

        public void OnReturnToMenuButtonPressed()
        {
            SceneManager.LoadScene(0);
        }

        #endregion UI


        public void PopulateAlert(UIScreen_AlertPopup alert)
        {
            _flag = !_flag;
            alert.SetAlertScreenContent(
                "Alert " + UIScreen_AlertPopup.activeCount,
                "This is alert number " + UIScreen_AlertPopup.activeCount,
                Color.Lerp(Color.white, Color.gray, Random.value),
                "Cool!");
        }
    }
}