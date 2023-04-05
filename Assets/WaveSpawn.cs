using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveSpawn : MonoBehaviour
{
    //{
    //    public int WaveSize;

    //    public GameObject EnemyPrefab;

    //    public float EnemyIntervel;

    //    public Transform spawnPoint;

    //    public float startTime;

    //    int enemyCount = 0;

    //    // Start is called before the first frame update
    //    void Start()
    //    {
    //        InvokeRepeating("SpewnEnemy", startTime, EnemyIntervel);  
    //    }
    //     void Update()
    //    {
    //        if(enemyCount == WaveSize)
    //        {
    //            CancelInvoke("SpawnEnemy");
    //        }
    //    }

    //    void SpawnEnemy()
    //    {
    //        enemyCount++;
    //        GameObject enemy = GameObject.Instantiate(EnemyPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
    //    }
    //}
    //    public Wave[] waves;
    //    public int timeBetweenWaves = 5;
    //    private WaveSpawn gameManager;
    //    private float lastSpawnTime;
    //    private int enemiesSpawned = 0;
    //    void SpawnEnemy()
    //    {

    //    }
    //    void Start()
    //    {
    //        lastSpawnTime = Time.time;
    //        gameManager =
    //            GameObject.Find("GameManager").GetComponent<WaveSpawn>();
    //    }
    //    void Update()
    //    // 1
    //    {
    //        int currentWave = gameManager.Wave;
    //        if (currentWave < waves.Length)
    //        {
    //            // 2
    //            float timeInterval = Time.time - lastSpawnTime;
    //            float spawnInterval = waves[currentWave].spawnInterval;
    //            if (((enemiesSpawned == 0 && timeInterval > timeBetweenWaves) ||
    //                 timeInterval > spawnInterval) &&
    //                enemiesSpawned < waves[currentWave].maxEnemies)
    //            {
    //                // 3  
    //                lastSpawnTime = Time.time;
    //                GameObject newEnemy = (GameObject)
    //                    Instantiate(waves[currentWave].enemyPrefab);
    //                newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
    //                enemiesSpawned++;
    //            }
    //            // 4 
    //            if (enemiesSpawned == waves[currentWave].maxEnemies &&
    //                GameObject.FindGameObjectWithTag("Enemy") == null)
    //            {
    //                gameManager.Wave++;
    //                gameManager.Gold = Mathf.RoundToInt(gameManager.Gold * 1.1f);
    //                enemiesSpawned = 0;
    //                lastSpawnTime = Time.time;
    //            }
    //            // 5 
    //        }
    //        else
    //        {
    //            gameManager.gameOver = true;
    //            GameObject gameOverText = GameObject.FindGameObjectWithTag("GameWon");
    //            gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
    //        }
    //    }
    //}
    //public class Wave
    //{
    //    public GameObject enemyPrefab;
    //    public float spawnInterval = 2;
    //    public int maxEnemies = 20;
    //}


    //public GameObject enemy1;
    //public GameObject enemy2;
    public GameObject enemyPrefab; // ссылка на префаб врага
    public float spawnInterval = 2.0f; // интервал времени между спауном врагов
    public int maxEnemies = 10; // максимальное количество врагов на карте
    private float lastSpawnTime; // время последнего спауна
    private int enemiesSpawned = 0; // количество созданных врагов // Вызывается при запуске сцены 
void Start () 
{ 
lastSpawnTime = Time.time; // инициализируем последнее время спауна
 } // Вызывается каждый кадр 
void Update()
{
    if (enemiesSpawned < maxEnemies)
    { // проверяем, что мы не достигли максимального количества врагов 
        float timeSinceLastSpawn = Time.time - lastSpawnTime;
        if (timeSinceLastSpawn > spawnInterval)
        { // проверяем, прошло ли достаточно времени для спауна новой волны 
            SpawnEnemy(); // спауним нового врага
            lastSpawnTime = Time.time; // обновляем время последнего спауна 
        }
    }
} // Создает нового врага 
void SpawnEnemy()
{
    GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity); // создаем новый экземпляр врага из префаба 
    enemiesSpawned++; // увеличиваем количество созданных врагов 
        //GameObject child = Instantiate(enemy1, newEnemy);
        //GameObject child1 = Instantiate(enemy2, newEnemy);
    }
}
