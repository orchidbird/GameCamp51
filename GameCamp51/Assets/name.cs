using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(0.8f);
            GetComponent<MeshRenderer>().enabled = true;
            yield return new WaitForSeconds(0.8f);
        }
    }
}
