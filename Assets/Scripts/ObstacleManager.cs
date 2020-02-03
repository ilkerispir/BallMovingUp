using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject PlayerObj;
    public GameObject[] ObstaclesArray;

    int obstacleCount;

    int playerDistanceIndex = -1;
    int obstacleIndex = 0;
    int distanceToNext = 50;

    void Start()
    {
        obstacleCount = ObstaclesArray.Length;
        InstantiateObstacle();
    }

    void Update()
    {
        int playerDistance = (int)(PlayerObj.transform.position.y / distanceToNext);

        if (playerDistanceIndex != playerDistance)
        {
            InstantiateObstacle();
            playerDistanceIndex = playerDistance;
        }
    }

    public void InstantiateObstacle()
    {
        int RandomInt = Random.Range(0, obstacleCount);
        GameObject newObstacle = Instantiate(ObstaclesArray[RandomInt], new Vector3(0, obstacleIndex*distanceToNext), Quaternion.identity);
        newObstacle.transform.SetParent(transform);
        obstacleIndex++;  
    }
}
