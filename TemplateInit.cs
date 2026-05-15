using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;

namespace TemplateMod
{
    // Minimal mod entry implementing IPuckMod. Initializes Harmony patches on enable.
    public class TemplateModInit : IPuckPlugin
    {
        public bool OnEnable()
        {
            try
            {
                Debug.Log("Template mod enabled.");
                return true;
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return false;
            }
        }

        public bool OnDisable()
        {
            try
            {
                Debug.Log("Template mod disabled.");
                return true;
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                return false;
            }
        }
    }
}