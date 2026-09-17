
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // cargar una escena
    //reiniciar pausar o salir del juego
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
     public void cargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    } 
}
