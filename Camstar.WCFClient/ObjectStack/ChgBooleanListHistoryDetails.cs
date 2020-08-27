// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanListHistoryDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChgBooleanListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListHistoryDetails_OldBooleanListValue")]
    protected Primitive<bool>[] _OldBooleanListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListHistoryDetails_NewBooleanListValue")]
    protected Primitive<bool>[] _NewBooleanListValue;

    public override bool Equals(object obj)
    {
      return obj is ChgBooleanListHistoryDetails && this.CompareArrays((Array) this._OldBooleanListValue, (Array) ((ChgBooleanListHistoryDetails) obj)._OldBooleanListValue) && this.CompareArrays((Array) this._NewBooleanListValue, (Array) ((ChgBooleanListHistoryDetails) obj)._NewBooleanListValue) && base.Equals(obj);
    }

    public Primitive<bool>[] OldBooleanListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldBooleanListValue), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (OldBooleanListValue));
      }
    }

    public Primitive<bool>[] NewBooleanListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewBooleanListValue), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (NewBooleanListValue));
      }
    }
  }
}
