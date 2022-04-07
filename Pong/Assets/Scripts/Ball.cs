using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private SpriteRenderer sprite;
    private SpriteRenderer playerToColor;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        Launch();
    }
    
    void Update()
    {
        
    }

    private void Launch(){
        float x = Random.Range(0, 2) == 0? -1 : 1;
        float y = Random.Range(0, 2) == 0? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        sprite.color = Color.white;
        Launch();
    }

    public void TouchedPlayer1()
    {
        playerToColor = GameObject.Find("Player1").GetComponent<SpriteRenderer>();
        sprite.color = playerToColor.color;
    }
    public void TouchedPlayer2()
    {
        playerToColor = GameObject.Find("Player2").GetComponent<SpriteRenderer>();
        sprite.color = playerToColor.color;
    }
}
