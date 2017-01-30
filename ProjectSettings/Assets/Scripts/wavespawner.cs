using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wavespawner : MonoBehaviour {

    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;

    private float countDown = 2f;
    private int WaveIndex = 1;

    public Text waveCountdownText; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (countDown <= 0f) {
            StartCoroutine(spanWave());
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countDown).ToString();
	
	}

    IEnumerator spanWave() {
        WaveIndex++;

        for (int i = 0; i < WaveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
         }

    }

    void SpawnEnemy()
 	{
 		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
 	}

}
