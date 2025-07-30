using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name + ", Layer: " + collision.gameObject.layer);
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
