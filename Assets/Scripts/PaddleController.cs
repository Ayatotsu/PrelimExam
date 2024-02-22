using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public float boundY;

    public Rigidbody2D playerPanel;
    
    
    void Start()
    {
        playerPanel = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        var panelVelocity = playerPanel.velocity;
        if (Input.GetKey(KeyCode.D))
        {
            panelVelocity.x = speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            panelVelocity.x = -speed;
        }
        else
        {
            panelVelocity.x = 0;
        }
        playerPanel.velocity = panelVelocity;

        var panelPos = transform.position;

        if (panelPos.x > boundY)
        {
            panelPos.x = boundY;
        }
        else if (panelPos.x < boundY) 
        {
            panelPos.y = -boundY;
        }
        transform.position = panelPos;

    }
}
