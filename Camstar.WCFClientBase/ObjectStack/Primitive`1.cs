// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Primitive`1
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Name = "PrimitiveOf{0}", Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Primitive<T> : DCObject, IPrimitive
  {
    protected bool _IsEmpty;
    private T _Value;

    [DataMember(EmitDefaultValue = false, Name = "Value")]
    public T Value
    {
      get
      {
        return this._Value;
      }
      set
      {
        this._Value = value;
        this._IsEmpty = (object) value == null;
      }
    }

    public override bool IsEmpty
    {
      get
      {
        return this._IsEmpty;
      }
    }

    [DataMember(EmitDefaultValue = true, Name = "IsEmpty")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsPrimitiveEmpty
    {
      get
      {
        return this._IsEmpty;
      }
      set
      {
        this._IsEmpty = value;
      }
    }

    public Primitive()
    {
      this._IsEmpty = true;
    }

    public Primitive(T value)
    {
      this._IsEmpty = (object) value == null;
      this.Value = value;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as Primitive<T>) != null)
      {
        if (this.IsEmpty)
          flag = (obj as Primitive<T>).IsEmpty;
        else if (!(obj as Primitive<T>).IsEmpty)
        {
          if ((object) this.Value is string)
            flag = string.Compare((object) this.Value as string, (object) (obj as Primitive<T>).Value as string, StringComparison.CurrentCultureIgnoreCase) == 0;
          else if ((object) this.Value != null)
            flag = this.Value.Equals((object) (obj as Primitive<T>).Value);
        }
      }
      return flag;
    }

    public static bool operator ==(Primitive<T> ref1, Primitive<T> ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(Primitive<T> ref1, Primitive<T> ref2)
    {
      return !(ref1 == ref2);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      string empty = string.Empty;
      return !this._IsEmpty && (object) this.Value != null ? this.Value.ToString() : empty;
    }

    public static implicit operator Primitive<T>(T value)
    {
      Primitive<T> primitive = (Primitive<T>) null;
      if ((object) value != null)
        primitive = new Primitive<T>(value);
      return primitive;
    }

    public static explicit operator T(Primitive<T> value)
    {
      T obj = default (T);
      if (value != (Primitive<T>) null)
        obj = value.Value;
      return obj;
    }

    protected virtual void OnSetValue(object obj)
    {
      if (obj == null)
        return;
      this._IsEmpty = false;
      this.Value = (T) obj;
    }

    protected virtual object OnGetValue()
    {
      object obj = (object) null;
      if (!this._IsEmpty)
        obj = (object) this.Value;
      return obj;
    }

    void IPrimitive.SetValue(object obj)
    {
      this.OnSetValue(obj);
    }

    object IPrimitive.GetValue()
    {
      return this.OnGetValue();
    }
  }
}
