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

        public static UIState_AlertPopup GetNewPopupState(float randomOffsetRange)
        {
            return new UIState_AlertPopup
            {
                titleText = "Alert " + UIScreen_AlertPopup.activeCount,
                bodyText = "This is alert number " + UIScreen_AlertPopup.activeCount,
                dismissButtonText = "Cool!",
                backgroundColor = Color.Lerp(Color.white, Color.gray, Random.value),
                alertPanelPositionOffset = GetAlertPanelOffset(randomOffsetRange)
            };
        }

        #region Utility

        private static Vector2 GetAlertPanelOffset(float randomOffsetRange)
        {
            float x = Random.Range(-randomOffsetRange, randomOffsetRange);
            float y = Random.Range(-randomOffsetRange, randomOffsetRange);
            return new Vector2(x, y);
        }

        #endregion Utility
    }
}