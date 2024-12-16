using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public Enemy enemyPrefab; 

    public Transform[] spawnPoints; 

    public float damageMax = 40f; 
    public float damageMin = 20f; 

    public float healthMax = 200f; 
    public float healthMin = 100f; 

    public float speedMax = 3f; 
    public float speedMin = 1f; 

    public Color strongEnemyColor = Color.red; 

    private List<Enemy> enemies = new List<Enemy>(); 
    private int wave; 

    private void Update() {
        if (GameManager.instance != null && GameManager.instance.isGameover)
        {
            return;
        }

        if (enemies.Count <= 0)
        {
            SpawnWave();
        }

        UpdateUI();
    }

    private void UpdateUI() {
        UIManager.instance.UpdateWaveText(wave, enemies.Count);
    }

    private void SpawnWave() {
        
    }

    private void CreateEnemy(float intensity) {
        
    }
}