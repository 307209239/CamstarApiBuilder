// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgKeyChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (WIPMsgOperationKeyChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (WIPMsgLabelKeyChanges_Info))]
  [Serializable]
  public class WIPMsgKeyChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_Info_WIPMsgDetails")]
    protected WIPMsgDetailChanges_Info _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public WIPMsgDetailChanges_Info WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges_Info) this.PropertyGet(nameof (WIPMsgDetails));
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
