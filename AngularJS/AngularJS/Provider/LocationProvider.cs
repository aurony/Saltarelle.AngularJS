﻿using System;

//using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Reflection;
using System.Diagnostics;

namespace AngularJS
{       
   [Imported]
   public sealed class LocationProvider
   {
      [InlineCode("{this}.html5Mode({mode})")]    public LocationProvider Html5Mode(bool mode)      { return null; }
      [InlineCode("{this}.hashPrefix({prefix})")] public LocationProvider HashPrefix(string prefix) { return null; }
   } 
}

