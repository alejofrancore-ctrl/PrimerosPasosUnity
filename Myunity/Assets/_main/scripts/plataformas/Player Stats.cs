
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _puntosVida = 100.0f;
    [SerializeField] private UImanager _uimanager;
    public void RestarVida(int daño)
    {
        _puntosVida= _puntosVida-daño;
        

       
    }
    public void SumarVida(int salud)
    {
        _puntosVida= _puntosVida+salud;
        
    }
    private void Update()
    {
        if (_puntosVida>=70.0f)
        {
            _uimanager.ColorBarra(Color.green);
        }
        if (_puntosVida>40 && _puntosVida<=70)
        {
            _uimanager.ColorBarra(new Color(1f, 0.64f, 0f,1f));
        }
            if (_puntosVida<=30.0f)
        {
            _uimanager.ColorBarra(Color.red);
        }
        }
    }

 // + - / *
        // = == ! && ||
        //!= += -= ++ --
