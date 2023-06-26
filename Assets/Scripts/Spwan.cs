using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Spwan : MonoBehaviour
{
    public  Bird bird;
    public  GameObject Borular;
     

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnBoru), 0f, 1.5f);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnBoru));
    }
    public  void SpawnBoru()
    {
        if (!bird.birdDead)
        {

            Instantiate(Borular, new Vector3(3, Random.Range(0.5f, 4.5f), 0), Quaternion.identity);

            
        }

    }
   


}