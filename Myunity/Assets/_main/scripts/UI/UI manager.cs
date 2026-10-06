using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    [SerializeField] private PlayerStats _playerstats;
    [SerializeField] private GameObject _gameover;
    [SerializeField] private GameObject _pantallavictoria;
    
   
    // Start is called before the first frame update
    void Start()
    {
        _barra.color = Color.cyan;
        _barra.fillAmount=1f;
        _gameover.SetActive(false);
        _pantallavictoria.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void Sumarfillamount(float amount)
    {
     _barra.fillAmount += amount;
     
     
    }
    public void Restarfillamount(float amount)
    {
     _barra.fillAmount -= amount;
      
    }
    public void ColorBarra(Color color)
    {
        _barra.color= color;
    }

    public void gameover()
    {
        _gameover.SetActive(true);
    }

    public void Wincondition()
    {
        _pantallavictoria.SetActive(true);
         Time.timeScale= 0;
    }
    }
