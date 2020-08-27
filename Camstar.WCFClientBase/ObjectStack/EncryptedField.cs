// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EncryptedField
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.Util;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class EncryptedField : DCObject
  {
    private bool _isEncrypted;
    private string _value;

    [DataMember(EmitDefaultValue = false, Name = "Value")]
    public string Value
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
      }
    }

    [DataMember(EmitDefaultValue = false, Name = "IsEncrypted")]
    public bool IsEncrypted
    {
      get
      {
        return this._isEncrypted;
      }
      set
      {
        this._isEncrypted = value;
      }
    }

    public override bool IsEmpty
    {
      get
      {
        return string.IsNullOrEmpty(this.Value);
      }
    }

    public EncryptedField()
    {
    }

    public EncryptedField(string value)
      : this(value, false)
    {
    }

    public EncryptedField(string value, bool isEncrypted)
    {
      this.Value = value;
      this.IsEncrypted = isEncrypted;
    }

    public static EncryptedField CreateEncryptedField(string value)
    {
      return new EncryptedField(CryptUtil.Encrypt(value), true);
    }

    public static string GetPlainValue(EncryptedField field)
    {
      if (field == null)
        return (string) null;
      return !field.IsEncrypted ? field.Value : CryptUtil.Decrypt(field.Value);
    }

    public static implicit operator EncryptedField(string value)
    {
      return new EncryptedField(value);
    }

    public override bool Equals(object obj)
    {
      obj = (object) (obj as EncryptedField);
      return obj != null && string.Equals(this.Value, ((EncryptedField) obj).Value);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
