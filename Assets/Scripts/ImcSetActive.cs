using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImcSetActive : MonoBehaviour
{   
    public GameObject imc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        imc.SetActive(true);
    } 
    
    void OnMouseClose()
    {
        imc.SetActive(false);
    }
}
