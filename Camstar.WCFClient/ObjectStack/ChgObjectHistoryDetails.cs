// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectHistoryDetails
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
  public class ChgObjectHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectHistoryDetails_OldObject")]
    protected BaseObjectRef _OldObject;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectHistoryDetails_NewObject")]
    protected BaseObjectRef _NewObject;

    public override bool Equals(object obj)
    {
      return obj is ChgObjectHistoryDetails && object.Equals((object) this._OldObject, (object) ((ChgObjectHistoryDetails) obj)._OldObject) && object.Equals((object) this._NewObject, (object) ((ChgObjectHistoryDetails) obj)._NewObject) && base.Equals(obj);
    }

    public BaseObjectRef OldObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (OldObject));
      }
    }

    public BaseObjectRef NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
