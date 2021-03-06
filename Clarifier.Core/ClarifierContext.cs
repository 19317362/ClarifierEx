﻿using dnlib.DotNet;
using dnlib.DotNet.Writer;
using SherlockEngine;
using System;

namespace Clarifier.Core
{
    public class MWListener : IModuleWriterListener
    {
        public void OnWriterEvent(ModuleWriterBase writer, ModuleWriterEvent evt)
        {
            OnWriter?.Invoke(writer, evt);
        }

        public event EventHandler<ModuleWriterEvent> OnWriter;
    }

    public class ClarifierContext
    {
        public ModuleDefMD CurrentModule { get; set; }
        public SherlockNode ILLanguage { get; set; }

        public MWListener WriterListener;
    }
}