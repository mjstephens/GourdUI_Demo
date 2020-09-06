using GourdUI;
using TMPro;
using UI.Screens.AlertPopup.Animation;
using UnityEngine;
using UnityEngine.UI;

public class UIView_AlertPopup : UIView<IUIContractScreen_AlertPopup, UIState_AlertPopup>, 
    IUIContractView_AlertPopup
{
    #region Fields

    [Header("References")] 
    public TMP_Text alertTitleText;
    public TMP_Text alertBodyText;
    public TMP_Text alertDismissButtonText;
    public RectTransform alertPanelTransform;
    public Image alertBackground;
    public UIAlertPopupAnimation animationComponent;

    #endregion Fields


    #region Setup

    protected override void OnScreenInstantiated()
    {
        animationComponent.AnimateIn();
    }

    public override void ApplyScreenStateToView(UIState_AlertPopup state)
    {
        alertTitleText.text = state.titleText;
        alertBodyText.text = state.bodyText;
        alertDismissButtonText.text = state.dismissButtonText;
        alertBackground.color = state.backgroundColor;
        alertPanelTransform.position = new Vector3(
            alertPanelTransform.position.x + state.alertPanelOffset.x, 
            alertPanelTransform.position.y + state.alertPanelOffset.y, 
            alertPanelTransform.position.z);
    }

    #endregion Setup
    
    
    #region Teardown

    protected override void OnViewPreDestroy()
    {
        // Optionally do things here before the view is destroyed
    }

    #endregion Teardown


    #region UI

    public void OnDismissAlertPopupSelected()
    {
        screenContract.OnAlertDismissed();
    }

    #endregion UI
}