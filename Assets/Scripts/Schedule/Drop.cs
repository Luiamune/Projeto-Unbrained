using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Vector2 originalGameObjectPosition;

   

    public void OnCollisionStay2D(Collision2D collision)
    {
        OnTouch(collision);
        SendTagToSchedule(collision, originalGameObjectPosition);
    }

    public void OnTouch(Collision2D collision)
    {
        if (collision.gameObject && Input.GetMouseButton(0) == false)
        {
            originalGameObjectPosition = gameObject.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");
    }

    public string SendTagToSchedule(Collision2D collision, Vector2 OriginalPosition)
    {
        if (collision.gameObject && Input.GetMouseButton(0) == false)
        {
            collision.gameObject.transform.position = gameObject.transform.position;
            return gameObject.tag;
        }
        else
        {
            gameObject.transform.position = OriginalPosition;
            return "nill";
        }
    }
}