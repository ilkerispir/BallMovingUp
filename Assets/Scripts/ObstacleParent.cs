using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleParent : MonoBehaviour
{
    GameObject playerObj;

    void Start()
    {
        playerObj = GameObject.Find("Player");
        StartCoroutine(CalculateDistanceToPlayer());
    }

    IEnumerator CalculateDistanceToPlayer()
    {
        while (true)
        {
            if (playerObj.transform.position.y - transform.position.y > 50)
            {
                Destroy(this.gameObject);
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
