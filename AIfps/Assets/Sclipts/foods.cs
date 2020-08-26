using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foods : MonoBehaviour
{
    public float calory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<life>().heel_stamina(calory);
            Destroy(this.gameObject);
        }
    }
}
