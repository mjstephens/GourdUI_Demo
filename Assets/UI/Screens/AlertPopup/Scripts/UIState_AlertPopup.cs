using GourdUI;
using UnityEngine;

/// <summary>
/// Defines transient UI state information for view hot-swapping.
/// </summary>
public class UIState_AlertPopup : UIState
{
    public string titleText;
    public string bodyText;
    public string dismissButtonText;
    public Color backgroundColor;

    public Vector3 alertPanelPositionOffset;
    public DragElementState dragState;
}