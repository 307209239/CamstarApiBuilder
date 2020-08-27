// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMaint_Environment
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
  public class WIPMsgMaint_Environment : Maintenance_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_LabelToFind")]
    [Metadata("Identifier for relating a WIP Message to one or more Steps. WIP Messages defined for all Modeling Entities except a Step or Operation can be qualified with a WIP Message Label. This allows the same message to be associated with multiple Steps.", "", false, false, false, "String", 1049359, false, false, false, null)]
    protected Environment _LabelToFind;
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_ObjectChanges")]
    protected WIPMsgDefMgrChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_OperationKeyToChange")]
    [Metadata("A WIPMsgLabelKey is used to refer to a WIPMsgDetails Object.  A list of these is specified in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key are filtered based on the current operation.", "WIPMsgOperationKey", false, false, false, "SubentityRef", 1049358, false, false, false, null)]
    protected Environment _OperationKeyToChange;
    [Metadata("A WIPMsgLabelKey is used to refer to a WIPMsgDetails Object.  A list of these is specified in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key are filtered based on the label in the current step.", "WIPMsgLabelKey", false, false, false, "SubentityRef", 1049357, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_LabelKeyToChange")]
    protected Environment _LabelKeyToChange;
    [Metadata("Changes CDO for WIPMsgDetail.", "WIPMsgDetailChanges", false, false, false, "SubentityRef", 1049356, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_DetailToChange")]
    protected Environment _DetailToChange;
    [Metadata("Type of WIP message:\r\nOperation Keys\r\nAll Keys\r\nLabel Keys", "WIPMsgTypeEnum", false, false, false, "Integer", 1048891, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_WIPMsgType")]
    protected Environment _WIPMsgType;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049930, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_ObjectWithWIPMsg")]
    protected Environment _ObjectWithWIPMsg;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_OperationToFind")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1049360, false, false, true, null)]
    protected Environment _OperationToFind;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMaint_Environment_ObjectToChange")]
    [Metadata("Attached to an instance of a modeling entity, this contains the messages that apply to the entity.  When asked to supply its WIP Messages, a modeling entity will ask its WIPMsgDefMgr to supply a list of WIP Messages that have been filtered to include only the messages that apply to the current circumstances (step, operation and label).\r\nThe WIPMsgDefMgr will check the AllKey WIPMsgKey (which contains a message that applies to all steps) if specified, and run through the entries in the OperationKeys and LabelKeys lists and filter each message found.", "WIPMsgDefMgr", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;

    public Environment LabelToFind
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelToFind), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelToFind));
      }
    }

    public WIPMsgDefMgrChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment OperationKeyToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeyToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationKeyToChange));
      }
    }

    public Environment LabelKeyToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeyToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelKeyToChange));
      }
    }

    public Environment DetailToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetailToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DetailToChange));
      }
    }

    public Environment WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public Environment ObjectWithWIPMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectWithWIPMsg), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectWithWIPMsg));
      }
    }

    public Environment OperationToFind
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationToFind), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationToFind));
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
  }
}
