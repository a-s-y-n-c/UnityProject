using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderMoveHandler : MonoBehaviour, IMoveHandler, IEndDragHandler
{
    public float step = 1f; // the desired step

    Slider slider;
    float previousSliderValue = 0f;

    void Awake()
    {
        slider = GetComponent<Slider>();
        if (slider)
            previousSliderValue = slider.value;
    }

    public void OnMove(AxisEventData eventData)
    {
        // override the slider value using our previousSliderValue and the desired step
        if (eventData.moveDir == MoveDirection.Up) // Change to MoveDirection.Up for up arrow
        {
            slider.value = previousSliderValue + step;
        }

        if (eventData.moveDir == MoveDirection.Down) // Change to MoveDirection.Down for down arrow
        {
            slider.value = previousSliderValue - step;
        }

        // keep the slider value for future use
        previousSliderValue = slider.value;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // keep the last slider value if the slider was dragged by mouse
        previousSliderValue = slider.value;
    }
}
