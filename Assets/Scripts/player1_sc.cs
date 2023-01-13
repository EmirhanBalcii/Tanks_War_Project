using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class player1_sc : MonoBehaviour
{

    [SerializeField] private GameObject winnerPanel;
    [SerializeField] private TextMeshProUGUI winnerText;

    [SerializeField]
    private AudioSource tank_sound;

    [SerializeField]
    private float speed = 10;

    public int lives = 3;

    public static player1_sc Instance;
    [HideInInspector] public int score = 0;


    void Start()
    {
        if (Instance == null)
            Instance = this;

        if (PlayerPrefs.GetInt("Continue") == 1)
        {
            LoadData();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Vertical");
        float verticalInput = Input.GetAxis("Horizontal");
        tankControl(horizontalInput, verticalInput);
        tankSound(horizontalInput, verticalInput);

    }

    private void LoadData()
    {
        if (PlayerPrefs.HasKey("Player1Lives"))
        {
            lives = PlayerPrefs.GetInt("Player1Lives");
            transform.position = new Vector3(PlayerPrefs.GetFloat("Player1XPosition"), PlayerPrefs.GetFloat("Player1YPosition"), PlayerPrefs.GetFloat("Player1ZPosition"));
            transform.eulerAngles = new Vector3(PlayerPrefs.GetFloat("Player1XRotation"), PlayerPrefs.GetFloat("Player1YRotation"), PlayerPrefs.GetFloat("Player1ZRotation"));
        }
    }

    public void Damage()
    {
        lives--;
        if (lives == 0)
        {
            player2_sc.Instance.score++;
            
            if(SceneManager.GetActiveScene().buildIndex < 2){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            else{
                if(player2_sc.Instance.score < score)
                    winnerText.text = "Yeşil Tank Kazandı!";
                else if(player2_sc.Instance.score > score)
                    winnerText.text = "Kırmızı Tank Kazandı!";
                else
                    winnerText.text = "Berabere!";
                winnerPanel.SetActive(true);
                StartCoroutine(WaitSeconds());

            }
        }
    }

    IEnumerator WaitSeconds(){
            yield return new WaitForSeconds(3.0f);
            SceneManager.LoadScene(0);

        }

    void tankControl(float horizontalInput, float verticalInput)
    {
        Vector3 direction = new Vector3(0, 0, horizontalInput);
        transform.Translate(direction * speed * Time.deltaTime);//add force

        if (verticalInput > 0)
        {
            transform.rotation *= Quaternion.Euler(new Vector3(0, 0.01f, 0) * Time.timeScale);
            transform.rotation = transform.rotation * Quaternion.Euler(new Vector3(0, 0.01f, 0) * speed * Time.timeScale);

        }
        if (verticalInput < 0)
        {
            transform.rotation *= Quaternion.Euler(new Vector3(0, -0.01f, 0) * Time.timeScale);
            transform.rotation = transform.rotation * Quaternion.Euler(new Vector3(0, -0.01f, 0) * speed * Time.timeScale);
        }
    }

    void tankSound(float horizontalInput, float verticalInput)
    {

        if (verticalInput != 0 || horizontalInput != 0)
        {
            if (!tank_sound.isPlaying)
            {
                tank_sound.volume = 0.5f;
                tank_sound.Play();
            }
        }
        else
        {
            if (tank_sound.isPlaying && tank_sound.volume > 0.1)
            {
                tank_sound.volume -= tank_sound.volume * Time.deltaTime * 2f;
            }

            else if (tank_sound.volume < 0.1)
            {
                tank_sound.Stop();
            }
        }
    }
    public void speedBuff()
    {
        speed += 5;
    }
    public void lifeBuff()
    {
        lives += 1;
    }

}
