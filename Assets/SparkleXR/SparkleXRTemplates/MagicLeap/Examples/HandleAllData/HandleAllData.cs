﻿using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using UnityEngine.XR;

#if PLATFORM_LUMIN

using UnityEngine.XR.MagicLeap;
namespace SparkleXRLib.MagicLeap
{
    public class HandleAllData : MonoBehaviour
    {
        List<InputFeatureUsage> ifus = new List<InputFeatureUsage>()
        {
            (InputFeatureUsage)CommonUsages.deviceRotation,
            (InputFeatureUsage)CommonUsages.devicePosition
        };

        void Start()
        {
            foreach (InputFeatureUsage IFUsage in ifus)
            {
                print("Feature(name: \"" + IFUsage.name + "\", type: \"" + IFUsage.type + "\"");
            }


            //All hard devices data
            var inputDevices = new List<UnityEngine.XR.InputDevice>();
            UnityEngine.XR.InputDevices.GetDevices(inputDevices);
            foreach (var device in inputDevices)
            {
                List<InputFeatureUsage> oifus = new List<InputFeatureUsage>();
                device.TryGetFeatureUsages(oifus);
                //((IEnumerable<InputFeatureUsage>)ifus).Intersect<InputFeatureUsage>((IEnumerable<InputFeatureUsage>)oifus)
               
                Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", 
                          device.name, device.characteristics.ToString()));
                List<InputFeatureUsage> featureUsages = new List<InputFeatureUsage>();
                device.TryGetFeatureUsages(featureUsages);
                foreach(InputFeatureUsage IFUsage in featureUsages)
                {
                    print(device.name + "__Feature(name: \"" + IFUsage.name + "\", type: \"" + IFUsage.type + "\"");
                }
                    
            }

            //All ML hand data
            print(MLHandTracking.Left);
            print(MLHandTracking.Right);
            print(MLHandTracking.KeyPoseManager);

            print(MLHeadTracking.TrackingState);
            print(MLHeadTracking.TrackingState);
            //print(MLHandTracking.Right);
            //print(MLHandTracking.KeyPoseManager);
        }
    }
}
#endif
