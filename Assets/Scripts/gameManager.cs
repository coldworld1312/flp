using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{   
    public Text scoreText;
    public GameObject gameOver;
    public GameObject playButton;
    public Player player;

    public AudioSource go;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        gameOver.SetActive(false);

        Pause();
    }

    public void Play()
    {
        score=0;
        scoreText.text=score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale=1f;
        player.enabled=true;

        icicle[] icicles = FindObjectsOfType<icicle>();
        for (int i=0; i< icicles.Length;i++){
            Destroy(icicles[i].gameObject);
        }
    }

    public void Pause()
    {
        Debug.Log("Pause");
        Time.timeScale =0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        go.Play();
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
