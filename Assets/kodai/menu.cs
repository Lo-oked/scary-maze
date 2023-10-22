using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject blackvoid;



    void OnTriggerStay2D(Collider2D other)
    {
        if (blackvoid)
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
