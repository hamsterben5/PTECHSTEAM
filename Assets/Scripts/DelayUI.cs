using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DelayUI : MonoBehaviour {

    public GameObject canvasOpening;



    void Start ()
    {
        DisableCanvas();
    }
	
	void Update ()
    {
        StartCoroutine(DisableCanvas());
    }


    IEnumerator DisableCanvas()
    {
        yield return new WaitForSeconds(3.5f);
        canvasOpening.SetActive(false);
    }

}
