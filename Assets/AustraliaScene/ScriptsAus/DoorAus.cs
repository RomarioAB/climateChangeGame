using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAus : MonoBehaviour

{
    Animator m_animator;
    bool m_open;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            m_open = !m_open;
            if (m_animator)
            {
                m_animator.SetBool("SaloonOpen", m_open);
            }
            Debug.Log("Door Opened");
        }
    }

    public bool Open()
    {
        return m_open;
    }


}

