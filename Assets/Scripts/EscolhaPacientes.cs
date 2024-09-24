using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EscolhaPacientes : MonoBehaviour
{
   public Button buttonPaciente1;
    public Button buttonPaciente2;
    public Button buttonPaciente3; 
    public Button buttonBack; 
    public Button buttonTratamento;
    public GameObject Clarencio;
    public GameObject EmBreve;
    public Text resultadoText;

    void Start()
    {
        
        Clarencio.SetActive(false);
        buttonPaciente1.onClick.AddListener(() => MostrarPaciente(Clarencio, "Tratamento para Clarencio iniciado!"));
        buttonPaciente2.onClick.AddListener(() => MostrarPaciente(EmBreve, "Em Breve"));
        Clarencio.SetActive(false);
        buttonPaciente3.onClick.AddListener(() => MostrarPaciente(EmBreve, "Em Breve"));
        buttonBack.onClick.AddListener(HidePacientes);
    }

    void MostrarPaciente(GameObject pacienteObject, string mensagem)
    {
        pacienteObject.SetActive(true); // Ativa o GameObject correspondente
        resultadoText.text = mensagem;
    }

    void HidePacientes()
    {
        Clarencio.SetActive(false); // Esconde o Paciente 1
        EmBreve.SetActive(false); // Esconde os Em Breve
        
    }
}