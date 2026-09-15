
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _puntosVidaactuales = 100.0f;
    [SerializeField] private UImanager _uimanager;
    public void RestarVida(int daño)
    {
        _puntosVidaactuales= _puntosVidaactuales-daño;
        

       
    }
    public void SumarVida(int salud)
    {
        _puntosVidaactuales= _puntosVidaactuales+salud;
        
    }
    private void Update()
    {
        if (_puntosVidaactuales>=70.0f)
        {
            _uimanager.ColorBarra(Color.green);
        }
        if (_puntosVidaactuales>40 && _puntosVidaactuales<=70)
        {
            _uimanager.ColorBarra(new Color(1f, 0.64f, 0f,1f));
        }
            if (_puntosVidaactuales<=30.0f)
        {
            _uimanager.ColorBarra(Color.red);
        }
        //igualar vida a 100
        if (_puntosVidaactuales > 100)
        {
            _puntosVidaactuales=100;
        }
        //vida 0 = muerte
       if (_puntosVidaactuales <= 0)
        {
            Destroy(this.gameObject);
        }
        }
    }

 // + - / *
        // = == ! && ||
        //!= += -= ++ --
