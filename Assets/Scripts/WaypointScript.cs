using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaypointScript : MonoBehaviour
{

    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;

    public int MarkTracker;
    public int lapTracker = 1;

    public GameObject car;
    public GameObject enableText;
    public GameObject disableText00;
    public GameObject disableText01;

    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.GetComponent<BoxCollider>().enabled = true;
            TheMarker.transform.position = Mark01.transform.position;
            TheMarker.transform.rotation = Mark01.transform.rotation;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Mark02.transform.position;
            TheMarker.transform.rotation = Mark02.transform.rotation;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Mark03.transform.position;
            TheMarker.transform.rotation = Mark03.transform.rotation;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Mark04.transform.position;
            TheMarker.transform.rotation = Mark04.transform.rotation;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Mark05.transform.position;
            TheMarker.transform.rotation = Mark05.transform.rotation;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Mark06.transform.position;
            TheMarker.transform.rotation = Mark06.transform.rotation;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Mark07.transform.position;
            TheMarker.transform.rotation = Mark07.transform.rotation;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = Mark08.transform.position;
            TheMarker.transform.rotation = Mark08.transform.rotation;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = Mark09.transform.position;
            TheMarker.transform.rotation = Mark09.transform.rotation;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = Mark10.transform.position;
            TheMarker.transform.rotation = Mark10.transform.rotation;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = Mark11.transform.position;
            TheMarker.transform.rotation = Mark11.transform.rotation;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = Mark12.transform.position;
            TheMarker.transform.rotation = Mark12.transform.rotation;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Mark13.transform.position;
            TheMarker.transform.rotation = Mark13.transform.rotation;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Mark14.transform.position;
            TheMarker.transform.rotation = Mark14.transform.rotation;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = Mark15.transform.position;
            TheMarker.transform.rotation = Mark15.transform.rotation;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = Mark16.transform.position;
            TheMarker.transform.rotation = Mark16.transform.rotation;
        }
        if (MarkTracker == 15)
        {
            TheMarker.transform.position = Mark17.transform.position;
            TheMarker.transform.rotation = Mark17.transform.rotation;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == car)
        {
            Debug.Log("car detected");
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 16)
            {
                lapTracker++;
                //Debug.Log(lapTracker);
                MarkTracker = 0;
                disableText00.GetComponent<Text>().text = "Laps: "+ lapTracker +"/3";

                TheMarker.GetComponent<BoxCollider>().enabled = true;

                if(lapTracker == 4)
                {
                    disableText00.SetActive(false);
                    disableText01.SetActive(false);
                    enableText.SetActive(true);

                    yield return new WaitForSeconds(7.0f);

                    WinnerStart();
                }
            }
            yield return new WaitForSeconds(0.5f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
    public void WinnerStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}