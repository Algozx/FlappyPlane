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
        fluxoDeJogo = FindAnyObjectByType<FluxoDeJogo>();
        pontuacao = FindAnyObjectByType<ControlePontuacao>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Jogo pausado (game over): o clique serve só para o botão de reiniciar.
        if(Time.timeScale == 0) return;

        if(ComandoDePulo()){
            Impulsionar();
        }
    }

    // Espaço, clique do mouse ou toque na tela.
    bool ComandoDePulo()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) return true;

        for(int i = 0; i < Input.touchCount; i++){
            if(Input.GetTouch(i).phase == TouchPhase.Began) return true;
        }
        return false;
    }

    private void Impulsionar()
    {
        fisica.linearVelocity = Vector2.up * forçaDoImpulso;
        audioSource.pitch = Random.Range(0.95f, 1.05f);
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
