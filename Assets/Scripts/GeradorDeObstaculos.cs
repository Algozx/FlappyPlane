using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField] float tempoParaGerar;
    [SerializeField] GameObject obstaculo;
    
    float cronometro;

    private void Start() {
        cronometro = tempoParaGerar;
    }

    void Update()
    {
        cronometro -= Time.deltaTime;
        if(cronometro < 0){
            Instantiate(obstaculo, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
