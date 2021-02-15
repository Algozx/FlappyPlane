using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePontuacao : MonoBehaviour
{
    [SerializeField] Text textoPontuacao;

    int pontos;

    public void AdicionarPontos(){
        pontos++;
        textoPontuacao.text = pontos.ToString();
    }
}
