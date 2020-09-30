using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "slowPowerUp")
            Destroy(collision.gameObject);
            //   Application.LoadLevel(Application.loadedLevel);
        }
    }
