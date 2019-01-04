using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 dist;
    private float posX;
    private float posY;

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    void OnMouseDrag()
    {
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, 9.998f);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        gameObject.transform.position = worldPos;
    }
}
