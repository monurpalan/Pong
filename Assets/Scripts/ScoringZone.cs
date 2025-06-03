using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>() == null)
            return;

        var eventData = new BaseEventData(EventSystem.current);
        scoreTrigger.Invoke(eventData);
    }
}