// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.Primitive`1
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Name = "PrimitiveOf{0}", Namespace = "Camstar.WCF.ObjectStack")]
  public class Primitive<T> : DCObject, IPrimitive
  {
    [DataMember(EmitDefaultValue = false)]
    public T Value;
    [DataMember(EmitDefaultValue = false)]
    public bool IsEmpty;

    public Primitive()
    {
      this.IsEmpty = true;
    }

    public Primitive(T value)
    {
      this.Value = value;
    }

    public override string ToString()
    {
      string str = string.Empty;
      if (!this.IsEmpty)
      {
        if (typeof (T) == typeof (DateTime))
        {
          DateTime dateTime = (DateTime) (object) this.Value;
          str = dateTime.ToString("s") + "." + (object) dateTime.Millisecond;
        }
        else if ((object) this.Value != null)
          str = this.Value.ToString();
      }
      return str;
    }

    public static implicit operator Primitive<T>(T value)
    {
      return new Primitive<T>(value);
    }

    public static explicit operator T(Primitive<T> value)
    {
      T obj = default (T);
      if (value != null)
        obj = value.Value;
      return obj;
    }

    void IPrimitive.SetValue(object obj)
    {
      this.IsEmpty = false;
      if (string.IsNullOrEmpty((string) obj))
        this.IsEmpty = true;
      else
        this.Value = (T) Convert.ChangeType(obj, typeof (T));
    }
  }
}
