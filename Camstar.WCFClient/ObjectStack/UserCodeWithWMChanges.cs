// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserCodeWithWMChanges
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
  public class UserCodeWithWMChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_ChangeHistory")]
    protected new ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UserCodeWithWMChanges && object.Equals((object) this._WIPMsgDefMgr, (object) ((UserCodeWithWMChanges) obj)._WIPMsgDefMgr) && (object.Equals((object) this._ChangeHistory, (object) ((UserCodeWithWMChanges) obj)._ChangeHistory) && object.Equals((object) this._ObjectToChange, (object) ((UserCodeWithWMChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((UserCodeWithWMChanges) obj)._Name) && base.Equals(obj);
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
