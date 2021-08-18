using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    [Header("Target Prefab")]
    public GameObject[] targetPrefabs;
   
    [Header("Spawn Points")]
    public GameObject[] SpawnPoints;
    private int spawnIndex;
    Vector3 spawnTransform;

    [Header("Music Settings 60/Bpm * 2")]
    public float beats;
    private float timer;

    [Header("End Canvas")]
    public GameObject menuCanvas;
    public Text scoreText;
    public Text timerText;

    // private references
    Countdown countdownTimer;
    GameObject objSpawner;
    ScoreManager scoreManager;
    float canvasTimer = 5;

    private void Awake()
    {
       
        menuCanvas.SetActive(false);
        countdownTimer = GameObject.FindObjectOfType<Countdown>();
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        objSpawner = GameObject.Find("ObjSpawner");
      
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTargets();
    }

    private void SpawnTargets()
    {
        
        if (timer > beats && countdownTimer.CountDownStartValue > 0)
        {
            spawnIndex = Random.Range(0, SpawnPoints.Length);
            spawnTransform = SpawnPoints[spawnIndex].transform.position;

            // Instantiate()
            GameObject target = Instantiate(targetPrefabs[Random.Range(0,2)], spawnTransform, Quaternion.Euler(0, 0, Random.Range(0, 3) * 90));
            target.transform.position += Time.deltaTime * transform.forward * 2;
           
            timer -= beats;

        }
        else if (countdownTimer.CountDownStartValue == 0)
        {
            StartCoroutine("CanvasData");
            //CanvasData();
        }
        timer += Time.deltaTime;
    }
    public IEnumerator CanvasData()
    {
        yield return new WaitForSeconds(5);
        objSpawner.SetActive(false);
        menuCanvas.SetActive(true);
        scoreText.text = "YOUR SCORE " + scoreManager.Score.ToString();

        //Timer
        canvasTimer -= Time.deltaTime;
        timerText.text = "RETURNING TO MENU IN " + canvasTimer.ToString("f0");
        if (canvasTimer < 0)
        {
            SceneManager.LoadScene("Menu");
        }
       
    }

   
}

