using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(myPrefab);
        Instantiate(myPrefab, transform.position, Quaternion.identity);
    }
}
