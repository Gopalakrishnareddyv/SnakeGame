using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject Foodobject;


    void Start()
    {
        InvokeRepeating(nameof(FoodSpawns), 1.0f,3.0f);


    }
    private void FoodSpawns()
    {
        float x = Random.Range(-4.0f,4.0f);
        float z = Random.Range(4.0f, -4.0f);
        Vector3 foodposition = new Vector3(x,1, z);
        Instantiate(Foodobject, foodposition, Quaternion.identity);
        //transform.position = foodposition;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
