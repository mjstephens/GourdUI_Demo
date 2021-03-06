﻿using System.Collections;
using System.Collections.Generic;
using GourdUI;
using UnityEngine;

public class TestDragRectState : MonoBehaviour
{
    public GameObject testDraggerPrefab;
    public DragElement _currentDragger;
    public Transform dragParent;
    
    private bool _hasDragger = true;

    private DragElementState _state;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (_hasDragger)
            {
                _state = _currentDragger.RetrieveState();
                Destroy(_currentDragger.gameObject);
            }
            else
            {
                _currentDragger = Instantiate(testDraggerPrefab, dragParent).GetComponent<DragElement>();
                _currentDragger.ApplyState(_state);
            }

            _hasDragger = !_hasDragger;
        }
    }
}
