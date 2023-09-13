using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField]
    List<AudioClip> clicksClips;

    [SerializeField]
    AudioSource clicksSound;

    private void Start()
    {
        clicksSound = GetComponent<AudioSource>();
    }

    public void PlayButton()
    {
        clicksSound.PlayOneShot(clicksClips[0]);
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        clicksSound.PlayOneShot(clicksClips[0]);
        Debug.Log("Abbruch");
        Application.Quit();
    }
}
