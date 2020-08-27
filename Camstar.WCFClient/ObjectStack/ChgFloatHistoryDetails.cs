// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatHistoryDetails
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
  public class ChgFloatHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatHistoryDetails_OldFloatValue")]
    protected Primitive<double> _OldFloatValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatHistoryDetails_NewFloatValue")]
    protected Primitive<double> _NewFloatValue;

    public override bool Equals(object obj)
    {
      return obj is ChgFloatHistoryDetails && object.Equals((object) this._OldFloatValue, (object) ((ChgFloatHistoryDetails) obj)._OldFloatValue) && object.Equals((object) this._NewFloatValue, (object) ((ChgFloatHistoryDetails) obj)._NewFloatValue) && base.Equals(obj);
    }

    public Primitive<double> OldFloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFloatValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (OldFloatValue));
      }
    }

    public Primitive<double> NewFloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFloatValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NewFloatValue));
      }
    }
  }
}
