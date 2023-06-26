using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public GameObject redBird;
    public GameObject yellowBird;
    public GameObject blueBird;
    public int sayac = 1;

    

    // Update is called once per frame
    void Update()
    {
      
            
           if (sayac==0)
           {
               blueBird.GetComponent<SpriteRenderer>().sortingOrder = 1;
               redBird.GetComponent<SpriteRenderer>().sortingOrder = 0;
               yellowBird.GetComponent<SpriteRenderer>().sortingOrder = 0;

           }
           else if (sayac==1)
           {
            yellowBird.GetComponent<SpriteRenderer>().sortingOrder = 1;
            blueBird.GetComponent<SpriteRenderer>().sortingOrder = 0;
                redBird.GetComponent<SpriteRenderer>().sortingOrder = 0;

           }
           else if (sayac==2)
           {
                redBird.GetComponent<SpriteRenderer>().sortingOrder = 1;
                blueBird.GetComponent<SpriteRenderer>().sortingOrder = 0;
                yellowBird.GetComponent<SpriteRenderer>().sortingOrder = 0;

           }
            
      
        
            
    }  
    
    public void Oyna() 
    {
        SceneManager.LoadScene(0);
    }
    public void Right()
    {
        
        if (sayac<2)
        {
            sayac++;
        }
        
    }
    public void Left() 
    {
        
        if (sayac >0)
        {
            sayac--;
        }
    }
}
