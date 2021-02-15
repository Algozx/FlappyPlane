using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    [SerializeField] float velocidadeObstaculo = 0.08f;
    [SerializeField] float variacaoDePosicao = 2f;

    private void Awake() {
        transform.Translate(Vector3.up * Random.Range(-variacaoDePosicao, variacaoDePosicao));
    }

    void Update()
    {
        transform.Translate(Vector3.left * velocidadeObstaculo * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other == GameObject.FindWithTag("barreira")){
            DestruidorDeObstaculo();  
        }
        
    }

    public void DestruidorDeObstaculo(){
        Destroy(gameObject);
    }
}
