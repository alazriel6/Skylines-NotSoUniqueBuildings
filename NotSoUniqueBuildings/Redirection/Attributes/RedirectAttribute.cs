﻿using System;

namespace NotSoUniqueBuildings.Redirection.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class RedirectAttribute : Attribute
    {
        protected RedirectAttribute(bool onCreated = false)
        {
            OnCreated = onCreated;
        }

        public bool OnCreated { get; }
    }
}