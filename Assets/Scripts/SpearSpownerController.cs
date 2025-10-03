using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class SpearSpownerController : MonoBehaviour
{
    [SerializeField] private GameObject Spear;

    [SerializeField] private float HightOffset = 10;
    [SerializeField] private float SpownRate = 2;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spowner();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < SpownRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            Spowner();
            time = 0;
        }
        
    }

    void Spowner()
    {

        float lowestPoint = transform.position.y - HightOffset;
        float highestPoint = transform.position.y + HightOffset;
        Instantiate(Spear, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);

    }
    


}
