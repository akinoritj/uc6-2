using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diagnósticos : MonoBehaviour
{
     public void VoltarE()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Diagnostico()
    {
        SceneManager.LoadScene("Mauricio");
    }

    public void Calculadora()
    {
        SceneManager.LoadScene("Calculadora");
    }

    public void Livro()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("Thiago");
    }

    public void Tratamento()
    {
        SceneManager.LoadScene("Tratamentos");
    }

    public void Jogo()
    {
        SceneManager.LoadScene("Minigame");
    }

     public void Play()
    {
        SceneManager.LoadScene("Thiago");
    }
}
