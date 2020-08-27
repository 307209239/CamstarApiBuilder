// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserCodeWithWMChanges_Info
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
  public class UserCodeWithWMChanges_Info : UserCodeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Info_ChangeHistory")]
    protected new ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Info_Name")]
    protected new Info _Name;

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new ChangeHistoryChanges_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
