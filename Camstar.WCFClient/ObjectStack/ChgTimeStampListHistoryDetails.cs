// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampListHistoryDetails
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
  public class ChgTimeStampListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListHistoryDetails_OldTimeStampListValue")]
    protected Primitive<DateTime>[] _OldTimeStampListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListHistoryDetails_NewTimeStampListValue")]
    protected Primitive<DateTime>[] _NewTimeStampListValue;

    public override bool Equals(object obj)
    {
      return obj is ChgTimeStampListHistoryDetails && this.CompareArrays((Array) this._OldTimeStampListValue, (Array) ((ChgTimeStampListHistoryDetails) obj)._OldTimeStampListValue) && this.CompareArrays((Array) this._NewTimeStampListValue, (Array) ((ChgTimeStampListHistoryDetails) obj)._NewTimeStampListValue) && base.Equals(obj);
    }

    public Primitive<DateTime>[] OldTimeStampListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldTimeStampListValue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>[]) this.PropertyGet(nameof (OldTimeStampListValue));
      }
    }

    public Primitive<DateTime>[] NewTimeStampListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewTimeStampListValue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>[]) this.PropertyGet(nameof (NewTimeStampListValue));
      }
    }
  }
}
