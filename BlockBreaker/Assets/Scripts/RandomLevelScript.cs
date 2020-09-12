using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevelScript : MonoBehaviour {
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject set1;
    level Level;
    GameStatus score;
    float x = 0;
    float y;
    // Use this for initialization
    void Start () {
     prefabList.Add(set1);
        spawnTiles();

        //spawnTiles();

    }

    // Update is called once per frame
    void Update () {
		
	}
    void spawnTiles()
    {

            x = x + 6f;
            y = 0.65f; // Random.Range(-0.25f, -0.5f);
            int prefabIndex = Random.Range(0, 5);
            Instantiate(set1); //will instantie a random tile from the index
        }
    
}
