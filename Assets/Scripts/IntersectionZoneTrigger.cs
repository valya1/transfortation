using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionZoneTrigger : MonoBehaviour {

    public Camera camera;
    
    [SerializeField]
    int targetTurnDirection;

    [SerializeField]
    bool isIntersection = false;

    [SerializeField]
    float turnDuration;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Car")
        {
            Debug.Log("entered");
            if(isIntersection) ResizeCamera(Camera.main.orthographicSize, Camera.main.orthographicSize + 5, 0.7f);
        }
        else
        {
            var bot = other.gameObject.GetComponent<Car>();
            bot.Turn(targetTurnDirection);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Car")
        {
            Debug.Log("Exit trigger");
            if (isIntersection)
            ResizeCamera(Camera.main.orthographicSize, Camera.main.orthographicSize - 5, 0.7f);
        }
    }

    private void ResizeCamera(float oldSize, float newSize, float time)
    {
        StartCoroutine(resizeRoutine(oldSize, newSize, time));
    }

    private IEnumerator resizeRoutine(float oldSize, float newSize, float time)
    {
        float elapsed = 0;

        while (elapsed < time)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / time);
            Debug.Log(camera.orthographicSize.ToString());
            camera.orthographicSize = Mathf.Lerp(oldSize, newSize, t);
            yield return null;
        }
    }


}
