﻿using UnityEngine;
//using UnityEngine;
using System.Collections;
using System;
using System.Reflection;

namespace Cirrus.UnityEditorExt
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ObjectSelectorAttribute : PropertyAttribute
    {
        //public 
        public ObjectSelectorAttribute()
        {

        }


    }

}