using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class escribirNumeros : MonoBehaviour {

    private string textoimprimir;
    public Text resultado;

    public void colocar0()
    {
        textoimprimir = "0";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar1()
    {
        textoimprimir = "1";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar2()
    {
        textoimprimir = "2";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar3()
    {
        textoimprimir = "3";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar4()
    {
        textoimprimir = "4";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar5()
    {
        textoimprimir = "5";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar6()
    {
        textoimprimir = "6";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar7()
    {
        textoimprimir = "7";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar8()
    {
        textoimprimir = "8";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar9()
    {
        textoimprimir = "9";
        resultado.text = resultado.text + textoimprimir;
    }
    
public void colocarVirgula()
    {
        textoimprimir = ",";
        resultado.text = resultado.text + textoimprimir;
    }

    // Use this for initialization
    void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            colocar1();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            colocar2();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            colocar3();
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            colocar4();
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            colocar5();
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            colocar6();
        }
        if(Input.GetKeyDown(KeyCode.Alpha7))
        {
            colocar7();
        }
        if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            colocar8();
        }
        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            colocar9();
        }
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            colocar0();
        }
        if(Input.GetKeyDown(KeyCode.Comma))
        {
            colocarVirgula();
        }

         if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            colocar1();
        }
        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            colocar2();
        }
        if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            colocar3();
        }
        if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            colocar4();
        }
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            colocar5();
        }
        if(Input.GetKeyDown(KeyCode.Keypad6))
        {
            colocar6();
        }
        if(Input.GetKeyDown(KeyCode.Keypad7))
        {
            colocar7();
        }
        if(Input.GetKeyDown(KeyCode.Keypad8))
        {
            colocar8();
        }
        if(Input.GetKeyDown(KeyCode.Keypad9))
        {
            colocar9();
        }
        if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            colocar0();
        }
        if(Input.GetKeyDown(KeyCode.KeypadPeriod))
        {
            colocarVirgula();
        }
    }
}
	



