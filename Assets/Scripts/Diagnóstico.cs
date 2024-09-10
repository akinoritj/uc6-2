using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diagnóstico : MonoBehaviour
{
    // Referências aos botões e às estrelas no Unity Editor
    public Button correctButton1;
    public Button correctButton2;
    public Button wrongButton1A;
    public Button wrongButton1B;
    public Button wrongButton2A;
    public Button wrongButton2B;
    public Button verifyButton;
    public GameObject star1;
    public GameObject star2;

    // Variáveis para verificar se os botões foram clicados corretamente
    private bool isCorrectButton1Selected = false;
    private bool isCorrectButton2Selected = false;
    private bool isAnyWrongButtonSelected = false;

    void Start()
    {
        // Associa os métodos de verificação ao clicar nos botões
        correctButton1.onClick.AddListener(() => OnCorrectButtonClick(1));
        correctButton2.onClick.AddListener(() => OnCorrectButtonClick(2));
        wrongButton1A.onClick.AddListener(OnWrongButtonClick);
        wrongButton1B.onClick.AddListener(OnWrongButtonClick);
        wrongButton2A.onClick.AddListener(OnWrongButtonClick);
        wrongButton2B.onClick.AddListener(OnWrongButtonClick);
        verifyButton.onClick.AddListener(OnVerifyButtonClick);

        // Inicialmente, as estrelas não são exibidas
        star1.SetActive(false);
        star2.SetActive(false);
    }

    void OnCorrectButtonClick(int buttonNumber)
    {
        // Marca o botão correto como selecionado
        if (buttonNumber == 1)
        {
            isCorrectButton1Selected = true;
        }
        else if (buttonNumber == 2)
        {
            isCorrectButton2Selected = true;
        }
    }

    void OnWrongButtonClick()
    {
        // Marca que um botão errado foi selecionado
        isAnyWrongButtonSelected = true;
    }

    void OnVerifyButtonClick()
    {
        // Verifica as seleções e exibe as estrelas correspondentes
        if (isCorrectButton1Selected && isCorrectButton2Selected && !isAnyWrongButtonSelected)
        {
            ShowStars(2); // Mostra duas estrelas
        }
        else if ((isCorrectButton1Selected || isCorrectButton2Selected) && !isAnyWrongButtonSelected)
        {
            ShowStars(1); // Mostra uma estrela
        }
        else
        {
            ShowStars(0); // Não mostra nenhuma estrela
        }

        // Reseta as seleções para nova tentativa
        ResetSelection();
    }

    void ShowStars(int starCount)
    {
        // Exibe as estrelas com base no número de acertos
        star1.SetActive(starCount >= 1);
        star2.SetActive(starCount == 2);
    }

    void ResetSelection()
    {
        // Reseta as seleções para que uma nova verificação possa ser feita
        isCorrectButton1Selected = false;
        isCorrectButton2Selected = false;
        isAnyWrongButtonSelected = false;
    }
}
