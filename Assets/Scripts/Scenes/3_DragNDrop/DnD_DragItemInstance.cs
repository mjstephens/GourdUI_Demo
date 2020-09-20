using System.Collections;
using System.Collections.Generic;
using GourdUI;
using UnityEngine;

public class DnD_DragItemInstance : DragElementDecorator
{
    #region Variables

    [Header("References")] 
    [SerializeField]
    private GameObject _dropIconObject;
    [SerializeField]
    private GameObject _deParentIconObject;

    #endregion Variables
    

    #region Drop Events
    
    public override void OnDragElementContainerHoverExit(DepositArea outContainer, DepositArea inContainer)
    {
        base.OnDragElementContainerHoverExit(outContainer, inContainer);
        if (outContainer != null && 
            inContainer == null &&
            _dragElement.originalDepositArea != null)
        {
            _deParentIconObject.SetActive(true);
        }
    }

    public override void OnDragElementContainerHoverEnter(DepositArea container)
    {
        base.OnDragElementContainerHoverEnter(container);
        if (container != null)
        {
            _deParentIconObject.SetActive(false);
        }
    }

    public override void OnDragElementDrop(DepositArea container)
    {
        base.OnDragElementDrop(container);
        _deParentIconObject.SetActive(false);
    }

    #endregion Drop Events
}
