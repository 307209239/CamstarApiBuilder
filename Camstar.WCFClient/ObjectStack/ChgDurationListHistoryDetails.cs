// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationListHistoryDetails
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
  public class ChgDurationListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListHistoryDetails_OldDurationListValue")]
    protected Primitive<double>[] _OldDurationListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListHistoryDetails_NewDurationListValue")]
    protected Primitive<double>[] _NewDurationListValue;

    public override bool Equals(object obj)
    {
      return obj is ChgDurationListHistoryDetails && this.CompareArrays((Array) this._OldDurationListValue, (Array) ((ChgDurationListHistoryDetails) obj)._OldDurationListValue) && this.CompareArrays((Array) this._NewDurationListValue, (Array) ((ChgDurationListHistoryDetails) obj)._NewDurationListValue) && base.Equals(obj);
    }

    public Primitive<double>[] OldDurationListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDurationListValue), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (OldDurationListValue));
      }
    }

    public Primitive<double>[] NewDurationListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDurationListValue), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (NewDurationListValue));
      }
    }
  }
}
