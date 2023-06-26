using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{

    public bool birdDead = false;

    public TMPro.TextMeshProUGUI text;
    Rigidbody2D rig;
    float velocity = 5f;
    public GameObject GameOver;
    public GameObject GameAgain;
    public GameObject Borular;
    int puan;
    int kontrol;
    void Start()
    {
        puan = 0;
        kontrol = 1;
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * velocity;
        }
        if (puan == kontrol)
        {
            text.text = puan.ToString();
            kontrol++;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
            birdDead = true;
            Time.timeScale = 0f;
            GameOver.SetActive(true);
            GameAgain.SetActive(true);
        }
        if (collision.gameObject.tag == "Coin")
        {
            puan++;
            GameObject gameobj = collision.gameObject;
            Destroy(gameobj);
        }
    }
}


