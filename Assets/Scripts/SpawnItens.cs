using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItens : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Itens;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObject", 1.50f, 1.50f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateObject()
    {
        Instantiate(Itens[Random.Range(0,5)], new Vector3(Random.Range(-7.50f, 7.50f), 10, 0 ), Quaternion.identity);
    }
}
