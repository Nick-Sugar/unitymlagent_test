using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drink : MonoBehaviour
{
    public float ml;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<life>().heel_Thirst(ml);
            Destroy(this.gameObject);
        }
    }
}
