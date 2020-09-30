using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownPowerUp : MonoBehaviour
{
    // [SerializeField] float gameTime = 15f;
    GameStatus powerUp;
    bool slowTime;
    float slowCountdown = 3f;
    Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    public void Update()
    {



    }

    public void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, -180 * Time.deltaTime);

    }
}






