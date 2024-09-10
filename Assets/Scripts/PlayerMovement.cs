using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    private float velocidade;
    private Vector2 direcao;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10;
        direcao = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem();
        transform.Translate(direcao * velocidade * Time.deltaTime);
        if(transform.position.x < -7.50f)
            transform.position = new Vector3 (-7.50f, -4, 0);
        if(transform.position.x > 7.50f)
            transform.position = new Vector3 (7.50f, -4, 0);
    }

    void InputPersonagem()
     {
        direcao = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Fruit")
        {
            Destroy(other.gameObject);
        }

        if(other.tag == "Damage")
        {
            Destroy(gameObject);
            Time.timeScale = 0; // Pausa o jogo
        }
    }
}
