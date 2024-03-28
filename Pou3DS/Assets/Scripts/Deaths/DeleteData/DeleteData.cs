using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour
{
    string Pref = "Borrar";
    public GameObject Confirm;
    public GameObject Cancel;
    public float[] timer;

    public GameObject deleteText;
    public GameObject noDeleteText;

    public GameObject Buttons;

    void Start()
    {
        Confirm.SetActive(false);
        Cancel.SetActive(false);
    }

    void Update()
    {
        timer[0] += Time.deltaTime;
        if (timer[0] >= timer[1]) {Confirm.SetActive(true); Cancel.SetActive(true);}
    }

    public void DeleteCancel()
    {
        StartCoroutine(NoDeleteData());
    }

    public void DeleteConfirm()
    {
        StartCoroutine(DeleteAllData());
    }

    IEnumerator DeleteAllData()
    {
        //PlayerPrefs.DeleteAll();
        Buttons.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        PlayerPrefs.SetInt(Pref, 1);
        yield return new WaitForSeconds(0.02f);
        Instantiate(deleteText);
        Destroy(gameObject);
    }

    IEnumerator NoDeleteData()
    {
        Buttons.SetActive(false);
        yield return new WaitForSeconds(0.07f);
        Instantiate(noDeleteText);
        Destroy(gameObject);
    }
}
