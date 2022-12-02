using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startHelpText;

    void Start()
    {
        startHelpText.SetActive(false);
    }

    public void switchHelp(GameObject helpText)
    {
        if (helpText.activeSelf)
        {
            helpText.SetActive(false);
        }
        else
        {
            helpText.SetActive(true);
        }
    }
}