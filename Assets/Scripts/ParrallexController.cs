using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrallexController : MonoBehaviour
{
    private float startPos;

    private float Length;

    public GameObject cam;

    [SerializeField] private float parallaxEffect;


    private void Start()

    {

      //  cam = GameObject.Find("MainCamera");

        startPos = transform.position.x;

        Length = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;

    }



    private void Update()

    {

        float temporary = (cam.transform.position.x * (1 - parallaxEffect));

        float distance = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);



        if (temporary > startPos + Length)

        {

            startPos += Length;

        }

        else if (temporary < startPos - Length)

        {

            startPos -= Length;

        }

    }

}

