using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class GameLogics : MonoBehaviour
{
    public TMP_Text resultText;
    public TMP_Text option1;
    public TMP_Text option2;
    public TMP_Text option3;
    public TMP_Text option4;

    [SerializeField] TMP_Text text_Score;

    public GameObject _player,_enemy;
    public HealthBar healthBar;
    [SerializeField] AudioSource audio_sc;
    [SerializeField] AudioSource audio_sc_clap;
    [SerializeField] AudioSource audio_sc_oh_no;
    // [SerializeField] AudioClip[] audio_clip;

    private int Audioindex;
    public static int finalValue;
    private int score;

    public float maxHealth;
    public float currentHealth;

    //   public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        RandomValueGenerator();
        audio_sc.Play();
        Audioindex = 0;
        /*        currentHealth = maxHealth;
                healthBar.SetMaxHealth(maxHealth);*/
    }


   /* public void AppreciateAudio()
    {
        audio_sc_clip.clip = audio_clip[Audioindex];
        audio_sc_clip.Play();
        Audioindex++;
        if (Audioindex == 5)
        {
            Audioindex = 0;
        }

    }
*/


    int firstValue, secondValue;
    public void RandomValueGenerator()
    {
        bool isAdd = true;
        firstValue = Random.Range(0, 5);
        Debug.Log(firstValue);

        secondValue = Random.Range(6, 10);
        Debug.Log(secondValue);

        finalValue = firstValue + secondValue;
        Debug.Log(finalValue);

        int Range = Random.Range(1, 4);


        if (Range == 1 && (isAdd == true))
        {
            resultText.text = firstValue + " + " + secondValue + " = ".ToString();
            option1.text = finalValue.ToString();
        }
        else
        {

            option1.text = Random.Range(1, 3).ToString();

        }

        if (Range == 2 && (isAdd == true))
        {
            resultText.text = firstValue + " + " + secondValue + " = ".ToString();
            option2.text = finalValue.ToString();
        }
        else
        {

            option2.text = Random.Range(4, 5).ToString();

        }
        if (Range == 3 && (isAdd == true))
        {
            resultText.text = firstValue + " + " + secondValue + " = ".ToString();
            option3.text = finalValue.ToString();
        }
        else
        {

            option3.text = Random.Range(6, 10).ToString();

        }
        if (Range == 4 && (isAdd == true))
        {
            resultText.text = firstValue + " + " + secondValue + " = ".ToString();
            option4.text = finalValue.ToString();
        }
        else
        {

            option4.text = Random.Range(11, 12).ToString();

        }


    }

    public void check(TextMeshProUGUI _selectedValue)
    {
        if(_selectedValue.text == finalValue.ToString())
        {
            _player.transform.DOLocalMoveX(_player.transform.localPosition.x + 2.5f, 1);
            RandomValueGenerator();
            UpdateScore();
            currentHealth = currentHealth + 0.2f;
            healthBar.SetHealth(currentHealth);
            audio_sc_clap.Play();
        }
        else
        {
            _enemy.transform.DOLocalMoveX(_enemy.transform.localPosition.x + 2.5f, 1);
            RandomValueGenerator();
            lossScore();
            audio_sc_oh_no.Play();
            currentHealth = currentHealth - 0.2f; 
            healthBar.SetHealth(currentHealth);

        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           
        }
    }
    public void UpdateScore()
    {
        score++;
        text_Score.text = "Score : " + score;
    }
    public void lossScore()
    {
        score--;
        text_Score.text = "Score : " + score;
    }


    public void OnClickBtn1()
    {
        Player1Controller.PlayerController1.GetComponent<Rigidbody2D>().AddForce(new Vector2(5f, 0f));
        Debug.Log("Onclick");
    }



}


