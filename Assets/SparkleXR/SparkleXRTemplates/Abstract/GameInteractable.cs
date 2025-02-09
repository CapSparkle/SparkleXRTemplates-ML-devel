﻿using System.Collections;
using System.Collections.Generic;
//using Sirenix.OdinInspector;
//using Sirenix.Serialization;
using UnityEngine;

namespace SparkleXRTemplates
{
    public abstract class GameInteractable : MonoBehaviour
    {
        [SerializeField]
        List<ControlsDescriptor> myControlls;

        public void Interact(GameInteractor interactor)
        {
            foreach (ControlsDescriptor controls in myControlls)
            {
                controls.StartHandling(interactor);
            }
        }

        public void UnInteract(GameInteractor interactor)
        {
            foreach (ControlsDescriptor controls in myControlls)
            {
                controls.StopHandling(interactor);
            }
        }
    }
}