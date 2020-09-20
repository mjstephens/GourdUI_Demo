using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestRaycaster : MonoBehaviour
{
    //public EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            PointerEventData m_PointerEventData = new PointerEventData(EventSystem.current);
            m_PointerEventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
           // EventSystem.current.Lin(m_PointerEventData, results);

            if (results.Count == 0)
            {
                Debug.Log("NONE");    
            }
            else
            {
                foreach (RaycastResult result in results)
                {
                    Debug.Log("HIT: " + result.gameObject.name);
                }
            }
        }
    }
}
