using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D ballRB;
    
    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        ballRB.velocity = Vector2.down * speed;

        
    }

    

    private void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.name == "padelPlayer1")
        {
            float y = CalculatePosition(transform.position, actor.transform.position, actor.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            ballRB.velocity = direction * speed;
        }
    }
    float CalculatePosition(Vector2 ballPosition, Vector2 panelPosition, float panelHeight)
    {
        float value = (ballPosition.y - panelPosition.y) / panelHeight;
        return (value);
    }
}
