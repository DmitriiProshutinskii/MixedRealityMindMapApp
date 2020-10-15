using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class NeuronFeedback : MonoBehaviour, IMixedRealityFocusHandler, IMixedRealityPointerHandler, IMixedRealityTouchHandler
{

    #region Private Fields
    private bool selected = false;
    private Color defaultColor;
    private Color hoverColor = Color.red;

    private Animator animator;
    #endregion

    #region Serializable Fields
    #endregion

    #region MonoBehaviour implementation
    void Start()
    {
        defaultColor = GetComponent<MeshRenderer>().material.color;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    #region Visual Feedback Methods
    void VisualFeedbackGazeOn()
    {
        if (!selected)
        {
            GetComponent<MeshRenderer>().material.color = hoverColor;
        }
        //animator.Play("ScaleUpFeedBack");
    }

    void VisualFeedbackGazeOff()
    {
        if (!selected)
        {
            GetComponent<MeshRenderer>().material.color = defaultColor;
        }
        //animator.Play("ScaleUpFeedBack");
    }

    void VisualFeedbackSelection()
    {

    }

    #endregion

    #region Transformations over neuron
    #endregion



    #region Focus Handler Implementation
    public void OnFocusEnter(FocusEventData eventData) { VisualFeedbackGazeOn(); }

    public void OnFocusExit(FocusEventData eventData) { VisualFeedbackGazeOff(); }
    #endregion

    #region Pointer Handler Implementation
    public void OnPointerClicked(MixedRealityPointerEventData eventData) { }

    public void OnPointerDown(MixedRealityPointerEventData eventData) { VisualFeedbackGazeOff(); }

    public void OnPointerDragged(MixedRealityPointerEventData eventData) { }

    public void OnPointerUp(MixedRealityPointerEventData eventData) { VisualFeedbackGazeOn(); }
    #endregion

    #region Touch Handler Implementation
    public void OnTouchCompleted(HandTrackingInputEventData eventData) { VisualFeedbackGazeOn(); }

    public void OnTouchStarted(HandTrackingInputEventData eventData) { }

    public void OnTouchUpdated(HandTrackingInputEventData eventData) { }
    #endregion
}
