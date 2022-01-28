using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player"){
            Invoke("LoadScene",2f);
        }
        
    }
    void LoadScene(){
        SceneManager.LoadScene(0);
    }
}