using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject slowBlock;
    float powerUpTimer = 10f;
    float x = 0;
    float y;
    bool slowOn = false;

    public void Update()
    {
        countDown();
        if (slowOn == true)
        {
            spawnTiles();
            slowOn = false;
            powerUpTimer = Random.Range(7f, 20f);
        }
        Debug.Log("Time: " + powerUpTimer);
    }
    public void countBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void deleteBreakableBlocks()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            Debug.Log("Game Over NOW");
        }
    }

    void countDown()
    {
        powerUpTimer -= 1 * Time.deltaTime;
        if(powerUpTimer <= 0)
        {
            slowOn = true;
        }
      //  if (powerUpTimer <0)
      //  powerUpTimer += 1f * Time.deltaTime;

    }

    void spawnTiles()
    {
            x = Random.Range(x + -1f, x+ 5f);
        y = y + 10f; // Random.Range(-0.25f, -0.5f);
        //    int prefabIndex = Random.Range(0, 5);
            Instantiate(slowBlock, new Vector2(x, y), Quaternion.identity); //will instantie a random tile from the index
            if (powerUpTimer < 5f)
            {
                powerUpTimer =+ 1f * Time.deltaTime;
            }
        }
    }
