using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    int Keys = 3;

    void Start(){}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var go = FindClosestObjectWithTag("Door");

            if(Keys > 0)
            {
                Keys--;
                GameObject.Destroy(go);
                var keytestText = GameObject.Find("KeyCountText").GetComponent<Text>();
                keytestText.text = "Keys: " + Keys;
            }
        }
    }

    public GameObject FindClosestObjectWithTag(string tagName)
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(tagName);
        GameObject closest = null;
        float distance = 10;

        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - transform.position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}