// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerHistoryDetails
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
  public class ChgIntegerHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerHistoryDetails_OldIntegerValue")]
    protected Primitive<int> _OldIntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerHistoryDetails_NewIntegerValue")]
    protected Primitive<int> _NewIntegerValue;

    public override bool Equals(object obj)
    {
      return obj is ChgIntegerHistoryDetails && object.Equals((object) this._OldIntegerValue, (object) ((ChgIntegerHistoryDetails) obj)._OldIntegerValue) && object.Equals((object) this._NewIntegerValue, (object) ((ChgIntegerHistoryDetails) obj)._NewIntegerValue) && base.Equals(obj);
    }

    public Primitive<int> OldIntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldIntegerValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (OldIntegerValue));
      }
    }

    public Primitive<int> NewIntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewIntegerValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NewIntegerValue));
      }
    }
  }
}
