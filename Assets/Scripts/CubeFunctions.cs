using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFunctions : MonoBehaviour
{
    private float horizantalInput;
    private float verticalInput;
    public float speed=100;
    public bool keypressed = false;
    public Transform size;
    private Vector3 basevector=new Vector3(1,1,1);
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //rotation of cube
        horizantalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * speed * Time.deltaTime * horizantalInput);
        transform.Rotate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //Scale increase when space pressed and decrease when released
        if (Input.GetKey(KeyCode.Space))
        {
            size.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            keypressed = true;
        }
        else if (keypressed && size.localScale.x>basevector.x && size.localScale.y>basevector.y && size.localScale.z>basevector.z)
        {
                size.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
        
    }
        
}
