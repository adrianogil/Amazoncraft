using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageCreator : MonoBehaviour {

    string modelo = MapConstructor.text;
    string valor;
    public float cubeLengthX;
    public float cubeLengthY;

    int line = 1;
    int column = 0;

    public GameObject[] availableObjects;
    
    void Start () {

        foreach (char c in modelo) {
            valor = c.ToString();
            if (valor == "*") {
                line += 1;
                column = 0;
            }
            else if (valor == " ") {       
                column += 1;
            }
            else {
                GameObject obj = Instantiate(availableObjects[System.Int32.Parse(valor)]);
                obj.transform.position = new Vector3(column*cubeLengthX, line*cubeLengthY, 0);
                column += 1;
            }
       }
    
	}

}
