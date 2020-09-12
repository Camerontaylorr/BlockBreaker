using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    level Level;
    GameStatus score;
    public void Start()
    {
        Level = FindObjectOfType<level>();
        Level.countBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Level.deleteBreakableBlocks();
        score = FindObjectOfType<GameStatus>();
        score.AddToScore();
    }

}