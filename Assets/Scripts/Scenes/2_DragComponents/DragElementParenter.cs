using System.Collections;
using System.Collections.Generic;
using GourdUI;
using TMPro;
using UnityEngine;

public class DragElementParenter : MonoBehaviour
{
    public RectDragSource[] innerDraggers;
    public Transform dragParent;
    public TMP_Text buttonText;

    private bool _parented = true;

    public void ToggleParenting()
    {
        _parented = !_parented;
        if (_parented)
        {
            foreach (var d in innerDraggers)
            {
                d.transform.SetParent(dragParent);
            }
        }
        else
        {
            foreach (var d in innerDraggers)
            {
                d.transform.SetParent(dragParent.parent);
            }
        }

        buttonText.text = _parented ? 
            "Toggle Elements Parenting (ON)" : 
            "Toggle Elements Parenting (OFF)";
    }
}
