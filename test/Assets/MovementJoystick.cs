using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementJoystick : MonoBehaviour
{
      

    public GameObject joystick;
    public GameObject joystick86;
    public Vector2 joystickVec;
    private Vector2 joystickTouchPos;
    private Vector2 joystickOriginalPos;
    private float joystickRadius;

    // Start is called before the first frame update
    void Start()
    {
        joystickOriginalPos = joystick86.transform.position;
        joystickRadius = joystick86.GetComponent<RectTransform>().sizeDelta.y / 4;

    }

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystick86.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;

    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);

        if (joystickDist < joystickRadius)
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickDist;

        }

        else
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickRadius;
        }


    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        joystick86.transform.position = joystickOriginalPos;
    }
}
