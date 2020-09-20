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
    public Image alertBackground;
    public UIAlertPopupAnimation animationComponent;
    public DragElement dragSource;

    #endregion Fields


    #region Setup

    protected override void OnScreenInstantiated()
    {
        animationComponent.AnimateIn();
    }

    public override void ApplyScreenStateToView(UIState_AlertPopup state, bool isScreenInstantiation)
    {
        alertTitleText.text = state.titleText;
        alertBodyText.text = state.bodyText;
        alertDismissButtonText.text = state.dismissButtonText;
        alertBackground.color = state.backgroundColor;
        
        // Update drag position
        if (isScreenInstantiation)
        {
            dragSource.dynamicTransform.localPosition += state.alertPanelPositionOffset;
        }
        else
        {
            dragSource.ApplyState(state.dragState);
        }
    }

    #endregion Setup
    
    
    #region Teardown

    protected override void OnViewPreDestroy()
    {
        // Optionally do things here before the view is destroyed
        screenContract.OnUpdateDragState(dragSource.RetrieveState());
    }

    #endregion Teardown


    #region UI

    public void OnDismissAlertPopupSelected()
    {
        screenContract.OnAlertDismissed();
    }

    #endregion UI
}