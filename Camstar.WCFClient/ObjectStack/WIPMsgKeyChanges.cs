// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgKeyChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (WIPMsgOperationKeyChanges))]
  [KnownType(typeof (WIPMsgLabelKeyChanges))]
  [Serializable]
  public class WIPMsgKeyChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_WIPMsgDetails")]
    protected WIPMsgDetailChanges[] _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgKeyChanges && this.CompareArrays((Array) this._WIPMsgDetails, (Array) ((WIPMsgKeyChanges) obj)._WIPMsgDetails) && (object.Equals((object) this._ObjectToChange, (object) ((WIPMsgKeyChanges) obj)._ObjectToChange) && object.Equals((object) this._IsFrozen, (object) ((WIPMsgKeyChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public WIPMsgDetailChanges[] WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges[]) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
