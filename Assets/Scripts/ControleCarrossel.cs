using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCarrossel : MonoBehaviour
{
    [SerializeField] float velocidadePiso = 10f;


    float tamanhoDoPiso;
    float tamanhoRealPiso;
    float escala;
    float deslocamento;
    Vector3 posicaoInicial;


    private void Awake() {
        posicaoInicial = transform.position;
    }

    private void Start() {
        
        tamanhoDoPiso = GetComponent<SpriteRenderer>().size.x;
        escala = transform.localScale.x;
        tamanhoRealPiso = tamanhoDoPiso * escala;
        
    }


    void Update()
    {
        deslocamento = Mathf.Repeat(velocidadePiso * Time.time, tamanhoRealPiso);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
