using UnityEngine;
using TMPro;

public class Block{
    public float xValue;
    public float yValue;
    int number;
    public GameObject spawnedBlock;
    TextMeshProUGUI textNumber;

    public Block(float newxValue,float newyValue,GameObject newspawnedBlock,TextMeshProUGUI newtextNumber) {
        xValue = newxValue;
        yValue = newyValue;
        spawnedBlock = newspawnedBlock;
        textNumber = newtextNumber;
    }

    public Block BlockStartValue(float newxValue, float newyValue, GameObject newspawnedBlock, TextMeshProUGUI newtextNumber) {
        xValue = newxValue;
        yValue = newyValue;
        spawnedBlock = newspawnedBlock;
        textNumber = newtextNumber;
        return this;
    }

    public void SetTextNumber(int newNumber) {
        textNumber.text = newNumber.ToString();
    }

    public void SetNumber(int newNumber) {
        number = newNumber;
    }

    public void SetSpawnedBlock(GameObject newSpawnedBlock) {
        spawnedBlock = newSpawnedBlock;
    }

    public int GetNumber() { return number; }
    public TextMeshProUGUI GetTextNumber() { return textNumber; }
    public GameObject GetSpawnedBlock() { return spawnedBlock; }
}
