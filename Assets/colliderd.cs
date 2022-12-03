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

    // Start is called before the first frame update
    void Start()
    {
        
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
            }
            if (other.tag.Contains("Rouge"))
            {
                Scorescript.scoreValue -= 1;
            }
        }

    }

}
