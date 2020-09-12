using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownPowerUp : MonoBehaviour {
   // [SerializeField] float gameTime = 15f;
    GameStatus powerUp;
    bool slowTime;
    float slowCountdown = 3f;


    // Use this for initialization
    void Start () {
	}

    public void Update()
    {
        /*
        Debug.Log(slowTime);
        if(slowTime == true)
        {
            Debug.Log("anjka");

           slowCountdown -= 1f * Time.deltaTime;
           Debug.Log(slowCountdown);
            */
        

    }

    // Update is called once per frame
    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
        Destroy(gameObject);
        Time.timeScale = 0.5f;
        slowTime = true;
        /*    if(slowTime == true)
            {
                Debug.Log("omma");

            }*/
    }




    

