using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    [SerializeField] PaddleMove paddle;
    [SerializeField] float ballX = 2f;
    [SerializeField] float ballY = 15f;
    Vector2 paddleToBallVector;
    bool hasBegun = false;
	// Use this for initialization

	void Start () {
        paddleToBallVector = transform.position - paddle.transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (hasBegun == false)
        {
            lockBallToPaddle();
            launchBall();
        }
    }

    private void launchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasBegun = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(ballX, ballY);
        }
    }

    private void lockBallToPaddle() { 
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
	}
}
