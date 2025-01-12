﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu_tester : MonoBehaviour
{
    // Start is called before the first frame update
    string[] menu_items = { "Difficulty", "Main Menu Button", "Settings", "Extras", "Quit" };
    [SerializeField] string selected_item_name;
    GameObject selected_gameobject;
    [SerializeField] GameObject room_manager;
    bool completed = false;

    void Start()
    {
        //set seed to Random   
        Random.InitState((int)System.DateTime.Now.Ticks);
        // choose one random int inbetween 0-5        
        int random_int = Random.Range(0, 4);
        selected_item_name = menu_items[random_int];
        selected_gameobject = GameObject.Find(selected_item_name);        
        TextMeshPro text = transform.Find("Instructions").GetComponent<TextMeshPro>();
        if(selected_item_name == "Main Menu Button")
        {
            text.text += "Ana Menu";
        }
        else if(selected_item_name == "Difficulty")
        {
            text.text += "Zorluk";
        }
        else if (selected_item_name == "Settings")
        {
            text.text += "Ayarlar";
        }
        else if (selected_item_name == "Extras")
        {
            text.text += "Ekstralar";
        }
        else if (selected_item_name == "Quit")
        {
            text.text += "Cikis";
        }
        else
        {
            text.text += "ERROR";
        }
        //text.text += selected_item_name ;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void check_if_correct_button(GameObject button)
    {
        if (selected_gameobject == button && completed == false)
        {
            room_manager.GetComponent<Room_manager_script>().set_teleportation_active(true);
            completed = true;
        }
        else
        {
            Debug.Log("Incorrect button pressed");
        }

    }
}
