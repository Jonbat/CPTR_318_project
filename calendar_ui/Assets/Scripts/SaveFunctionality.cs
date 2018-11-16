using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveFunctionality : MonoBehaviour {

    public InputField title;
    public InputField date;
    public InputField start_time;
    public InputField end_time;

    public void create_event () {

        string[] new_event_data = { title.text, date.text, start_time.text, end_time.text };

        // TODO: send new_event_data to calendar with protocol
    }
}
