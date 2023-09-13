using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Was gespawnt wird
    [SerializeField]
    GameObject ciga;

    // The value that "start" has to reach to activate the if-statement
    [SerializeField]
    float end;

    [SerializeField]
    float start;

    // To avoid harcorednumbers
    [SerializeField]
    float nadaDeNada;

    // The seconds after which the gameObjects will be destroyed
    [SerializeField]
    float untilDestroyed;

    // Y value for Vector3
    [SerializeField]
    float yDistance;

    // X value for Vector3
    [SerializeField]
    float xDistance;

    // Z value for Vector3
    [SerializeField]
    float zDistance;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newCiga = Instantiate(ciga);

        newCiga.transform.position = transform.position + 
            new Vector3(xDistance, Random.Range(-yDistance, yDistance), zDistance);
        Destroy(newCiga, 10);
    }

    /* Everytime start reaches end a new Object will be instantiated in the
     * given position. After "untilDestroyed" seconds the Object will be 
     * destroyed. Infinite Loop.*/
    private void Update()
    {
        if(start > end)
        {
            GameObject newCiga = Instantiate(ciga);

            newCiga.transform.position = transform.position +
                new Vector3(xDistance, Random.Range(-yDistance, yDistance), zDistance);

            Destroy(newCiga, untilDestroyed);

            start = nadaDeNada;
        }

        start += Time.deltaTime;
    }
}
