// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgKeyChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (WIPMsgLabelKeyChanges_Environment))]
  [KnownType(typeof (WIPMsgOperationKeyChanges_Environment))]
  [Serializable]
  public class WIPMsgKeyChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_Environment_WIPMsgDetails")]
    [Metadata("Changes CDO for WIPMsgDetail.", "WIPMsgDetailChanges", false, false, false, "WIPMsgDetailChanges", 1049065, false, true, false, null)]
    protected WIPMsgDetailChanges_Environment _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_Environment_ObjectToChange")]
    [Metadata("A WIPMsgKey is used to refer to a WIPMsgDetails Object.  This object is refered to in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key will apply to all steps.", "WIPMsgKey", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKeyChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public WIPMsgDetailChanges_Environment WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges_Environment) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
