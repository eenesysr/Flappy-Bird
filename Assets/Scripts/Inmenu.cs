using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inmenu : MonoBehaviour
{
    
    
    public void TekrarOyna()
    {
       
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;  
        
    }
}

