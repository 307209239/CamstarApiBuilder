// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedHistoryDetails
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
  public class ChgFixedHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedHistoryDetails_OldFixedValue")]
    protected Primitive<double> _OldFixedValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedHistoryDetails_NewFixedValue")]
    protected Primitive<double> _NewFixedValue;

    public override bool Equals(object obj)
    {
      return obj is ChgFixedHistoryDetails && object.Equals((object) this._OldFixedValue, (object) ((ChgFixedHistoryDetails) obj)._OldFixedValue) && object.Equals((object) this._NewFixedValue, (object) ((ChgFixedHistoryDetails) obj)._NewFixedValue) && base.Equals(obj);
    }

    public Primitive<double> OldFixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFixedValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (OldFixedValue));
      }
    }

    public Primitive<double> NewFixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFixedValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NewFixedValue));
      }
    }
  }
}
