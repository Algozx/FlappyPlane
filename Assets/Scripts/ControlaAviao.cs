using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAviao : MonoBehaviour
{
    [SerializeField] float forçaDoImpulso = 100f;
    [SerializeField] AudioClip sompulo;

    AudioSource audioSource;
    FluxoDeJogo fluxoDeJogo;
    Rigidbody2D fisica;
    ControlePontuacao pontuacao;

    private void Start() {
        fisica = GetComponent<Rigidbody2D>();
        fluxoDeJogo = GameObject.FindObjectOfType<FluxoDeJogo>();
        pontuacao = GameObject.FindObjectOfType<ControlePontuacao>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        fisica.velocity = Vector2.up * forçaDoImpulso;
        audioSource.PlayOneShot(sompulo);
    }

   private void OnCollisionEnter2D(Collision2D other) {
       fisica.simulated = false;
       fluxoDeJogo.GameOver();
   }

   private void OnTriggerEnter2D(Collider2D other) {
       pontuacao.AdicionarPontos();
   }
}
