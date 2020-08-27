// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WCFExtensions
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace Camstar.WCF.ObjectStack
{
  public static class WCFExtensions
  {
    public static bool IsNullOrEmpty(this WCFObjectBase obj)
    {
      return obj == null || obj.IsEmpty;
    }

    public static bool IsNullOrEmpty(this WCFObjectBase[] obj)
    {
      return obj == null || obj.Length == 0 || ((IEnumerable<WCFObjectBase>) obj).All<WCFObjectBase>((Func<WCFObjectBase, bool>) (c => c.IsNullOrEmpty()));
    }

    public static void ToKeyValueCollection(
      this CDOObject obj,
      ref KeyValueConfigurationCollection keys)
    {
      if (keys == null)
        throw new ArgumentNullException(nameof (keys));
      if (obj == null)
        return;
      foreach (PropertyInfo property in obj.GetType().GetProperties())
      {
        if (property.CanRead && !property.DeclaringType.IsArray)
        {
          object obj1 = property.GetValue((object) obj, (object[]) null);
          if (obj1 is CDOObject cdoObject)
          {
            cdoObject.ToKeyValueCollection(ref keys);
          }
          else
          {
            string name = property.Name;
            string empty = string.Empty;
            if (obj1 != null)
              empty = obj1.ToString();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(empty))
            {
              if (keys[name] == null)
                keys.Add(name, empty);
              else
                keys[name].Value = empty;
            }
          }
        }
      }
    }
  }
}
