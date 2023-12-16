using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnpool : MonoBehaviour
{
    public int columnpoolSize = 5;
    public GameObject columnprefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnpoolSize]; 
        for (int i =0; i < columnpoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnprefab, objectPoolPosition, Quaternion.identity); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        
        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range (columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= columnpoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}
