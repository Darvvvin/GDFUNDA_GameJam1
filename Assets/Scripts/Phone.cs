using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Phone : MonoBehaviour {
    float throwForce = 600;
    float distance;

    Vector3 objectPos;

    public bool canHold = true;
    public bool isHolding = false;

    public GameObject tempParent;

    public static float timer = 0;
    public bool isTimerRunning = false;

    void Start() {
        isTimerRunning = true;
    }

    void Update() {
        if(isTimerRunning == true){
            timer += Time.deltaTime;
        }
        distance = Vector3.Distance(this.transform.position, tempParent.transform.position);
        if (distance >= 3f) {
            isHolding = false;
        }
        //Check if isholding
        if (isHolding == true) {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.transform.SetParent(tempParent.transform);

            Debug.Log("Congratulations, you found the phone!");
            isTimerRunning = false;
            SceneManager.LoadScene("GameOverScene");

            if (Input.GetMouseButtonDown(1)) {
                this.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }
        }
        else {
            objectPos = this.transform.position;
            this.transform.SetParent(null);
            this.GetComponent<Rigidbody>().useGravity = true;
            this.transform.position = objectPos;
        }
    }

    void OnMouseDown() {
        if (distance <= 3f) {
            isHolding = true;
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
}