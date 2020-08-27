// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgConfigChanges_Info
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
  public class WIPMsgConfigChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Info_WIPMsgCntrEntities")]
    protected Info _WIPMsgCntrEntities;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Info_CheckChildWIPMsgs")]
    protected Info _CheckChildWIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Info_OperationsExcluded")]
    protected Info _OperationsExcluded;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info WIPMsgCntrEntities
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgCntrEntities), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgCntrEntities));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info CheckChildWIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CheckChildWIPMsgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CheckChildWIPMsgs));
      }
    }

    public Info OperationsExcluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationsExcluded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationsExcluded));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
