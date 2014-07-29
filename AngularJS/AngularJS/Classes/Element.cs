﻿using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Reflection;
using System.Diagnostics;

namespace AngularJS
{             
   [Imported]
   public sealed class Element
   {
      public object controller(string name) { return null; }
      public Injector injector() { return null; }
      public object scope() { return null; }
      public object inherithedData() { return null; }
            
      public void bind(JsDictionary events) {}      
      public void bind(string eventType, Action eventHandler) {}
      public void bind(string eventType, bool preventBubble) {}      
      public void bind(string eventType, object eventData, Action<object> eventHandler) {}      
      public void bind(string eventType, object eventData, bool preventBubble) {}            

      public object append(object arg) { return null; }

      public object replaceWith(object arg) { return null; }
   }      
}

