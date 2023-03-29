using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtk : MonoBehaviour
{

    public Transform firePosition;
    public GameObject Redprojectile;
    public GameObject Greenprojectile;
    public GameObject Blueprojectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(Redprojectile, firePosition.position, firePosition.rotation);
        }


        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(Greenprojectile, firePosition.position, firePosition.rotation);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            Instantiate(Blueprojectile, firePosition.position, firePosition.rotation);
        }
    }
}
