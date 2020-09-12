using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;

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
}
