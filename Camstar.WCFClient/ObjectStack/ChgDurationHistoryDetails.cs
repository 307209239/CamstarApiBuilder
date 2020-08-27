// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationHistoryDetails
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
  public class ChgDurationHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationHistoryDetails_NewDurationValue")]
    protected Primitive<double> _NewDurationValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationHistoryDetails_OldDurationValue")]
    protected Primitive<double> _OldDurationValue;

    public override bool Equals(object obj)
    {
      return obj is ChgDurationHistoryDetails && object.Equals((object) this._NewDurationValue, (object) ((ChgDurationHistoryDetails) obj)._NewDurationValue) && object.Equals((object) this._OldDurationValue, (object) ((ChgDurationHistoryDetails) obj)._OldDurationValue) && base.Equals(obj);
    }

    public Primitive<double> NewDurationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDurationValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NewDurationValue));
      }
    }

    public Primitive<double> OldDurationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDurationValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (OldDurationValue));
      }
    }
  }
}
