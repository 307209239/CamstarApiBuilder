// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgConfigChanges_Environment
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
  public class WIPMsgConfigChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1049412, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Environment_WIPMsgCntrEntities")]
    protected Environment _WIPMsgCntrEntities;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Environment_ListItemToChange")]
    [Metadata("Changes CDO for WIPMsgConfig.", "WIPMsgConfigChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Environment_ObjectToChange")]
    [Metadata("A WIPMsgConfig object is attached to a container level.  It is used to determine what entities in a container should be checked for WIP Messages.  The list (WIPMsgCntrEntities) is a list of strings that is resolved during the GetWIPMsgs function, and each resulting object is asked to supply its applicable WIP Messages.  In addition, a list of ExcludedOperations may limit the processing even further.", "WIPMsgConfig", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Environment_CheckChildWIPMsgs")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049635, false, false, false, "0")]
    protected Environment _CheckChildWIPMsgs;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1049074, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Environment_OperationsExcluded")]
    protected Environment _OperationsExcluded;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgConfigChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public Environment WIPMsgCntrEntities
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgCntrEntities), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgCntrEntities));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment CheckChildWIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CheckChildWIPMsgs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CheckChildWIPMsgs));
      }
    }

    public Environment OperationsExcluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationsExcluded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationsExcluded));
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
