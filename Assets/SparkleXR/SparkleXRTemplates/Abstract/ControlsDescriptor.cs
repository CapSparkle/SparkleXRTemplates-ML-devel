﻿using System;
using System.Collections;
using System.Collections.Generic;
//using Sirenix.OdinInspector;
//using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.XR;


namespace SparkleXRTemplates
{
    // One or more ControlsDescriptors to one GameInteractables
    
    // ControllsDescriptor can be assigned to only one type of XRNodeOne ControlsDescriptor to one XRNode.
    // Surjective mapping from ControlsDescriptors to GameInteractables
    
    public abstract class ControlsDescriptor : MonoBehaviour
    {
        //TODO: "SteamVR_Input Actions" like feature
        //Something like: autogenerated list of actions i can assign Methods of Advanced method handling wrapper

        // The required characteristics of device to controll
        [SerializeField]
        protected XRNodeType requiredXRNodetypeOfInputProvider;


        protected bool CheckInputProvider(GameInteractor interactor)
        {
            if (interactor.myXRInputProvider.xrNodeType == requiredXRNodetypeOfInputProvider)
                return true;
            else
                return false;
        }

        public virtual bool StartHandling(GameInteractor interactor) {
            return CheckInputProvider(interactor);
        }

        public virtual bool StopHandling(GameInteractor interactor) {
            return true;
        }
    }
}

