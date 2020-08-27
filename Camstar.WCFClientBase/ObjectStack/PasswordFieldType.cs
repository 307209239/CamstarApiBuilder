// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PasswordFieldType
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class PasswordFieldType : Primitive<string>
  {
    public PasswordFieldType()
    {
    }

    public PasswordFieldType(string value)
      : base(value)
    {
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator ==(PasswordFieldType ref1, PasswordFieldType ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(PasswordFieldType ref1, PasswordFieldType ref2)
    {
      return !(ref1 == ref2);
    }

    public static implicit operator PasswordFieldType(string value)
    {
      PasswordFieldType passwordFieldType = (PasswordFieldType) null;
      if (value != null)
        passwordFieldType = new PasswordFieldType(value);
      return passwordFieldType;
    }

    public static explicit operator string(PasswordFieldType value)
    {
      string empty = string.Empty;
      if (value != (PasswordFieldType) null)
        empty = value.Value;
      return empty;
    }

    protected override void OnSetValue(object obj)
    {
      PasswordFieldType passwordFieldType = obj as PasswordFieldType;
      if (passwordFieldType != (PasswordFieldType) null)
      {
        this._IsEmpty = passwordFieldType.IsEmpty;
        this.Value = (string) passwordFieldType;
      }
      else
        base.OnSetValue(obj);
    }
  }
}
