﻿ 

using System;

namespace FIRS.AIModules.BehaviourTree.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class TreeNodeContentAttribute : Attribute
    {
        public readonly string Name;
        public readonly string Path;

        public TreeNodeContentAttribute(string name, string path)
        {
            Name = name;
            Path = path;
            Hide = false;
        }

        #region [Optional Parameters]
        public bool Hide { get; set; }
        #endregion
    }
}