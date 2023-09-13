using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float velocity;

    [SerializeField]
    private bool isAlive = true;

    public bool enraged = false;

    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    private int score, scoreToWin;

    [SerializeField]
    Text scoreText;

    public List<AudioClip> sfxClips;

    public AudioSource sfxSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sfxSource = GetComponent<AudioSource>();
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
        scoreText.text = "Punkte: " + score.ToString();

        // Win condition, the amount to reach is written in the Inspector.
        if(score >= scoreToWin)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D _collision)
    {
        /* Score collection everytime that the Player will collide with the
         * ScorePoint Object (tagged with "ScorePoint") a score will be added. */
        if (_collision.gameObject.tag == "ScorePoint")
        {
            score++;
            sfxSource.PlayOneShot(sfxClips[0]);
        }

        /* Colliding with an Object tagged "Pickup" the code will change based
         * on which ScriptableObject is picked */
        if(_collision.gameObject.tag == "Pickup")
        {
            var pickupScript = _collision.gameObject.GetComponent<Pickup>();
            //pickupScript.Interact(this);

            StartCoroutine(pickupScript.Interact(this));
        }
    }

    private void OnCollisionEnter2D(Collision2D _collision)
    {
        /* Only the collision with the Obstacles won't kill the Player,
         * the Ground and the Ceiling will still kill him. */
        if(enraged == true && _collision.gameObject.tag == "Death"
            && _collision.gameObject.tag != "GroundDeath")
        {
            Object.Destroy(_collision.gameObject);
            //return;
        }
        /* If Enraged is false, as soon as the Player will collide with
         * Objects tagged with "Death" or "GroundDeath" he will die. */
        if(enraged == false && _collision.gameObject.tag == "Death" 
            || _collision.gameObject.tag == "GroundDeath")
        {
            sfxSource.PlayOneShot(sfxClips[4]);
            isAlive = false;
            SceneManager.LoadScene(3);
        }
    }
    


}
