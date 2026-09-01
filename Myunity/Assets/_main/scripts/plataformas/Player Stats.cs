using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _puntosVida = 100.0f;
    public void RestarVida(int daño)
    {
        _puntosVida= _puntosVida-daño;

        // + - / *
        // = == ! && ||
        //!= += -= ++ --
    }
}
