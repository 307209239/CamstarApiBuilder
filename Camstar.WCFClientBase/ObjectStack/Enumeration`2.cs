// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Enumeration`2
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Name = "EnumerationOf{0}", Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Enumeration<E, T> : Primitive<T> where E : struct
  {
    public const string UndefinedValueExceptionMessage = "Cannot cast from value type to enumeration type";

    public Enumeration()
    {
    }

    public Enumeration(E value)
    {
      this.Value = this.ConvertToValue(value);
    }

    public Enumeration(T value)
      : base(value)
    {
    }

    public static implicit operator Enumeration<E, T>(E value)
    {
      return new Enumeration<E, T>(value);
    }

    public static explicit operator E(Enumeration<E, T> value)
    {
      if (value == (Enumeration<E, T>) null)
        throw new WCFServiceException("Cannot cast from value type to enumeration type");
      E e1 = default (E);
      bool isMissed;
      E e2 = Enumeration<E, T>.ConvertToEnum(value.Value, out isMissed);
      if (isMissed)
        throw new WCFServiceException("Cannot cast from value type to enumeration type");
      return e2;
    }

    public static E ConvertToEnum(T value, out bool isMissed)
    {
      E e = default (E);
      isMissed = true;
      if ((object) value != null)
      {
        FieldInfo fieldInfo = ((IEnumerable<FieldInfo>) typeof (E).GetFields()).Where<FieldInfo>((Func<FieldInfo, bool>) (f => f.IsLiteral)).SingleOrDefault<FieldInfo>((Func<FieldInfo, bool>) (f => (f.GetCustomAttributes(typeof (EnumerationAttribute), false)[0] as EnumerationAttribute).DefaultValue == value.ToString()));
        if (fieldInfo != (FieldInfo) null)
        {
          e = (E) Enum.Parse(typeof (E), fieldInfo.Name, false);
          isMissed = false;
        }
      }
      return e;
    }

    public T ConvertToValue(E value)
    {
      T obj = default (T);
      this._IsEmpty = true;
      EnumerationAttribute customAttribute = ((IEnumerable<FieldInfo>) typeof (E).GetFields()).Where<FieldInfo>((Func<FieldInfo, bool>) (f => f.IsLiteral)).Single<FieldInfo>((Func<FieldInfo, bool>) (f => f.Name == value.ToString())).GetCustomAttributes(typeof (EnumerationAttribute), false)[0] as EnumerationAttribute;
      if (!string.IsNullOrEmpty(customAttribute.DefaultValue))
      {
        obj = (T) Convert.ChangeType((object) customAttribute.DefaultValue, typeof (T), (IFormatProvider) null);
        this._IsEmpty = false;
      }
      return obj;
    }

    protected override void OnSetValue(object obj)
    {
      if (obj != null && obj.GetType().IsEnum)
        this.Value = this.ConvertToValue((E) obj);
      else
        base.OnSetValue(obj);
    }

    public static bool operator ==(Enumeration<E, T> ref1, Enumeration<E, T> ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(Enumeration<E, T> ref1, Enumeration<E, T> ref2)
    {
      return !(ref1 == ref2);
    }

    public override string ToString()
    {
      bool isMissed;
      E e = Enumeration<E, T>.ConvertToEnum(this.Value, out isMissed);
      return !isMissed ? e.ToString() : "Undefined {" + base.ToString() + "}";
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }
  }
}
