using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

    private Vector3 startPos = Vector3.zero;
    private Vector3 endPos = Vector3.zero;
    private Vector3 targetPos = Vector3.zero;
    private bool isClicked = false;
    public float playerSpeed;

    void Update()
    {
        DragObject();
        if(transform.position.x<=-0.5f)
        {
            transform.position = new Vector3(-0.5f, -0.75f, -0.1f);
        }
        if (transform.position.x >= 0.5f)
        {
            transform.position = new Vector3(0.5f, -0.75f, -0.1f);
        }
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    // Get movement of the finger since last frame
        //    Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

        //    // Move object across XY plane
        //    transform.Translate(touchDeltaPosition.x * playerSpeed*Time.deltaTime,0, 0);
        //}
    }

    void DragObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isClicked = true;
        }

        if(isClicked==true)
        {
            if (Input.GetMouseButton(0))
                endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            targetPos = endPos - startPos;
            startPos = endPos;

            targetPos = new Vector3(targetPos.x*playerSpeed*Time.deltaTime, 0, 0);
            transform.position += targetPos;
        }
    }
}
