using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
    float time  =0;
    float timer =2;
    public GameObject pipa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time<=0)
        {
            Instantiate(pipa, transform.position,Quaternion.identity);
            time = timer ;
        }
        else
        {
            time -=Time.deltaTime;
        }
    }
}
