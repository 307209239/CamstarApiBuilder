// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanHistoryDetails
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
  public class ChgBooleanHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanHistoryDetails_NewBooleanValue")]
    protected Primitive<bool> _NewBooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanHistoryDetails_OldBooleanValue")]
    protected Primitive<bool> _OldBooleanValue;

    public override bool Equals(object obj)
    {
      return obj is ChgBooleanHistoryDetails && object.Equals((object) this._NewBooleanValue, (object) ((ChgBooleanHistoryDetails) obj)._NewBooleanValue) && object.Equals((object) this._OldBooleanValue, (object) ((ChgBooleanHistoryDetails) obj)._OldBooleanValue) && base.Equals(obj);
    }

    public Primitive<bool> NewBooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewBooleanValue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (NewBooleanValue));
      }
    }

    public Primitive<bool> OldBooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldBooleanValue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OldBooleanValue));
      }
    }
  }
}
