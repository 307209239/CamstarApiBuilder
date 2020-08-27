// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgOperationKeyChanges_Environment
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
  public class WIPMsgOperationKeyChanges_Environment : WIPMsgKeyChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgOperationKeyChanges_Environment_ObjectToChange")]
    [Metadata("A WIPMsgLabelKey is used to refer to a WIPMsgDetails Object.  A list of these is specified in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key are filtered based on the current operation.", "WIPMsgOperationKey", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgOperationKeyChanges_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    protected Environment _Operation;

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

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
