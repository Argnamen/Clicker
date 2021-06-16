using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordsScript : MonoBehaviour
{
    static string RecordsText;
    static int lastRecord;
    public static void setRecords(int str)
    {
        if (lastRecord < str)
        {
            RecordsText += ("\n" + str);
            lastRecord = str;
        }
    }
    void Start()
    {
        this.GetComponent<TMP_Text>().text = RecordsText;
    }
}
