using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFruit : MonoBehaviour
{
    [Header ("ID")]
    public float fruitID;

    [Header ("Values")]
    public float energyValue;
    public float fullnessValue;
    public float healthValue;
    public float funValue;

    [Header ("GameObjects")]
    public GameObject canvas;
    public GameObject fruit;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.CompareTag("Pou"))
        {
            if (Status.sEnergyLevel <= -1) {Status.sEnergyLevel = 0;}
            if (Status.sFullnessLevel <= -1) {Status.sFullnessLevel = 0;}
            if (Status.sHealthLevel <= -1) {Status.sHealthLevel = 0;}
            if (Status.sFunLevel <= -1) {Status.sFunLevel = 0;}

            if (fruitID == 0) {Fruits.sA--;}
            if (fruitID == 1) {Fruits.sB--;}
            if (fruitID == 2) {Fruits.sP--;}
            if (fruitID == 3) {Fruits.sN--;}
            if (fruitID == 4) {Fruits.sU--;}
            if (fruitID == 5) {Fruits.sC--;}
            if (fruitID == 6) {Fruits.sPz--;}
            if (fruitID == 7) {Fruits.sH--;}
            if (fruitID == 8) {Fruits.sCh--;}

            Status.sEnergyLevel += energyValue * 1728;
            Status.sFullnessLevel += fullnessValue * 864; 
            Status.sHealthLevel += healthValue * 1728;
            Status.sFunLevel += funValue * 864;

            FruitSelector.sActualFruit = 0;

            Destroy(gameObject);
        }
    }

    private void OnDestroy() 
    {
        Destroy(canvas);
    }
}
