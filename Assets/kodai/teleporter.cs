using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporter : MonoBehaviour
{
    public GameObject selectedObject;

    void OnTriggerStay2D(Collider2D other)
    {
        if (selectedObject)
        {
            SceneManager.LoadScene("level-2");
        }
    }

}
