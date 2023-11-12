using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChoice : MonoBehaviour
{
    public GameObject QuizQuestions;

    void OnTriggerEnter(Collider other)
    {
        QuizQuestions.SetActive(true);
    }

}
