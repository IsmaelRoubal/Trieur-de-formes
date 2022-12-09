using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class colliderd : MonoBehaviour
{
    [SerializeField]
    private GameObject package;

    [SerializeField]
    private GameObject enemy;

    private bool activated = false;

    [SerializeField]
    public AudioClip audio1;

    [SerializeField]
    public AudioClip audio2;

    private AudioSource _audioSource;


    // Start is called before the first frame update
    void Start()
    {
        _audioSource = this.GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Transform[] allTagObjects = other.GetComponentsInChildren<Transform>();

        foreach (Transform tagObject in allTagObjects)
        {
            if (other.tag.Contains("Sphere"))
            {
                Scorescript.scoreValue += 1;
                _audioSource.clip = audio1;
                _audioSource.PlayOneShot(audio1,0.7F);
            }
            if (other.tag.Contains("Rouge"))
            {
                Scorescript.scoreValue -= 1;
                _audioSource.clip = audio2;
                _audioSource.PlayOneShot(audio2,0.7F);
            }
        }

    }

}
