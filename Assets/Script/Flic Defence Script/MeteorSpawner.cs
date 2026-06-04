using UnityEngine;
public class MeteorSpawner : MonoBehaviour
{

    public GameObject meteorPrefab;



    public float spawnInterval = 1.5f;

    public float spawnXRange = 2.5f;

    public float spawnY = 6f;



    private float timer;



    void Update()
    {

        if (GameManager2.instance.isGameOver) return;



        timer += Time.deltaTime;



        if (timer >= spawnInterval)
        {

            SpawnMeteor();

            timer = 0f;

        }

    }



    void SpawnMeteor()
    {

        float x = Random.Range(-spawnXRange, spawnXRange);

        Vector2 pos = new Vector2(x, spawnY);



        Instantiate(meteorPrefab, pos, Quaternion.identity);

    }

}

