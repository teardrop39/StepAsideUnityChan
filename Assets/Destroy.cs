using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private GameObject unitychan;


    // Use this for initialization
    void Start()
    {

        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.unitychan.transform.position.z > this.gameObject.transform.position.z)
        {
            Destroy(this.gameObject, 2);
        }
    }
}
