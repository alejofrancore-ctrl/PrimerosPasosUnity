
using UnityEngine;

public class Camarafollowtarget : MonoBehaviour

{
    // Start is called before the first frame update
    [SerializeField] private Transform _target;
    private void Update()
    {
        this.transform.position= new Vector3(_target.position.x,this.transform.position.y,this.transform.position.z);
    }
}
