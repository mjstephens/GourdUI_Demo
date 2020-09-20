using GourdUI;
using UnityEngine;
using UnityEngine.UI;

public class DnD_DepositAreaInstance : DepositAreaDecorator
{
    #region Variables

    [Header("Reference")] 
    [SerializeField] 
    private Image _image;

    [Header("Values")] 
    [SerializeField] 
    private float _hoverScale;
    [SerializeField] 
    private Color _hoverColor;

    private Color _defaultColor;

    #endregion Variables


    #region Initialization

    protected override void Awake()
    {
        base.Awake();
        _defaultColor = _image.color;
    }

    #endregion Initialization


    #region Hover Events

    public override void OnDroppableRaycastReceiveEnter(IUIDroppable droppable)
    {
        //if (!_depositArea.currentItems.Contains(droppable))
        //{
            _image.color = _hoverColor;
            transform.localScale = Vector3.one * _hoverScale;
        //}
    }

    public override void OnDroppableRaycastReceiveExit(IUIDroppable droppable)
    {
        //if (!_depositArea.currentItems.Contains(droppable))
        //{
            _image.color = _defaultColor;
            transform.localScale = Vector3.one;
        //}
    }

    public override void OnDroppableDrop(IUIDroppable droppable)
    {
        _image.color = _defaultColor;
        transform.localScale = Vector3.one;
    }

    #endregion Hover Events
}
