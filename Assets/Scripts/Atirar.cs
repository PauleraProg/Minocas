using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Atirar : MonoBehaviour
{
    public GameObject fireballPrefab;

    static public Transform offset;

    public Transform offsetDirection;
    // Start is called before the first frame update
    void Start()
    {
        offsetDirection = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fireballPrefab, offset.position, transform.rotation);
        }
    }

}
