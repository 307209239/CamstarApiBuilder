// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerListHistoryDetails
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
  public class ChgIntegerListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListHistoryDetails_NewIntegerListValue")]
    protected Primitive<int>[] _NewIntegerListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListHistoryDetails_OldIntegerListValue")]
    protected Primitive<int>[] _OldIntegerListValue;

    public override bool Equals(object obj)
    {
      return obj is ChgIntegerListHistoryDetails && this.CompareArrays((Array) this._NewIntegerListValue, (Array) ((ChgIntegerListHistoryDetails) obj)._NewIntegerListValue) && this.CompareArrays((Array) this._OldIntegerListValue, (Array) ((ChgIntegerListHistoryDetails) obj)._OldIntegerListValue) && base.Equals(obj);
    }

    public Primitive<int>[] NewIntegerListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewIntegerListValue), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (NewIntegerListValue));
      }
    }

    public Primitive<int>[] OldIntegerListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldIntegerListValue), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (OldIntegerListValue));
      }
    }
  }
}
