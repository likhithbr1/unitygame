using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    Gamemanager gm;

    int score =10;

    void Start()
    {
        gm=FindObjectOfType<Gamemanager>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            gm.AddCoin(score);
            Destroy(gameObject);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
