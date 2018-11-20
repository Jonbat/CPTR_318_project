using UnityEngine;
using UnityEngine.SceneManagement;

public class CancelEvent : MonoBehaviour {

	public void Return_to_calendar () {
        SceneManager.LoadScene("CalendarView");
    }
}