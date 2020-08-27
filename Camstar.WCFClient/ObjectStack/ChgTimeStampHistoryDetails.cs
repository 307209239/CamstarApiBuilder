// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampHistoryDetails
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
  public class ChgTimeStampHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampHistoryDetails_NewTimeStampValue")]
    protected Primitive<DateTime> _NewTimeStampValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampHistoryDetails_OldTimeStampValue")]
    protected Primitive<DateTime> _OldTimeStampValue;

    public override bool Equals(object obj)
    {
      return obj is ChgTimeStampHistoryDetails && object.Equals((object) this._NewTimeStampValue, (object) ((ChgTimeStampHistoryDetails) obj)._NewTimeStampValue) && object.Equals((object) this._OldTimeStampValue, (object) ((ChgTimeStampHistoryDetails) obj)._OldTimeStampValue) && base.Equals(obj);
    }

    public Primitive<DateTime> NewTimeStampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewTimeStampValue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NewTimeStampValue));
      }
    }

    public Primitive<DateTime> OldTimeStampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldTimeStampValue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OldTimeStampValue));
      }
    }
  }
}
