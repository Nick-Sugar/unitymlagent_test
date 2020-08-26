using System;
using UnityEngine;

public class life : MonoBehaviour
{

    public float lifes = 100;//命
    public float stamina = 100;//スタミナ
    public float Thirst = 100;//のどの渇き

    float timer;
    float stamina_timer = 10.0f;
    float Thirst_timer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        move();


        if (lifes <= 0 )
        {
            Debug.Log("死んだ");
        }
        else
        {
            if (stamina <= 0)
            {
                stamina_timer -= Time.deltaTime;
                if (stamina_timer <= 0)
                {
                    lifes--;
                    stamina_timer = 10.0f;
                }

            }
            else
            {
                if (Thirst <= 0)
                {
                    Thirst_timer -= Time.deltaTime;
                    if (Thirst_timer <= 0)
                    {
                        stamina--;
                        Thirst_timer = 5.0f;
                    }
                }
            }
        }
    }
    public void heel_life(float lifeheelPoint)
    {
        lifes += lifeheelPoint;
    }
    public void heel_stamina(float staminaheelPoint)
    {
        stamina += staminaheelPoint;
    }
    void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1), ForceMode.Impulse);
            //this.gameObject.transform.position += new Vector3(1,0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1), ForceMode.Impulse);
            //this.gameObject.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);
            //this.gameObject.transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
            //this.gameObject.transform.position += new Vector3(0, 0, -1);
        }
    }
}