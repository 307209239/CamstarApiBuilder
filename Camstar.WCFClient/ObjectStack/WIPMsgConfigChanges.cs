// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgConfigChanges
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
  public class WIPMsgConfigChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_WIPMsgCntrEntities")]
    protected Primitive<string>[] _WIPMsgCntrEntities;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_CheckChildWIPMsgs")]
    protected Primitive<bool> _CheckChildWIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_OperationsExcluded")]
    protected NamedObjectRef[] _OperationsExcluded;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgConfigChanges && this.CompareArrays((Array) this._WIPMsgCntrEntities, (Array) ((WIPMsgConfigChanges) obj)._WIPMsgCntrEntities) && (object.Equals((object) this._ListItemToChange, (object) ((WIPMsgConfigChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((WIPMsgConfigChanges) obj)._ObjectToChange)) && (object.Equals((object) this._CheckChildWIPMsgs, (object) ((WIPMsgConfigChanges) obj)._CheckChildWIPMsgs) && this.CompareArrays((Array) this._OperationsExcluded, (Array) ((WIPMsgConfigChanges) obj)._OperationsExcluded) && object.Equals((object) this._IsFrozen, (object) ((WIPMsgConfigChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Primitive<string>[] WIPMsgCntrEntities
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgCntrEntities), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (WIPMsgCntrEntities));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
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

    public Primitive<bool> CheckChildWIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CheckChildWIPMsgs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CheckChildWIPMsgs));
      }
    }

    public NamedObjectRef[] OperationsExcluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationsExcluded), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (OperationsExcluded));
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
