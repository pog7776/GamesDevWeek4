using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour {
    private int i;
    private int j;
    public Renderer rend;

    // Start is called before the first frame update
    void Start() {
        i = 0;
        j = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(gameObject.name + ": " + i);
        i++;
        if(gameObject.tag == "Red" && i == 100) {
            gameObject.SetActive(false);
        }
        if(gameObject.tag == "Blue" && i == j) {
            rend.enabled = false;
        }
    }
}
