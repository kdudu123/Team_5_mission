using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
       if (col.gameObject.tag == "Player")
        {
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    void Update()
    {
        
    }
}
