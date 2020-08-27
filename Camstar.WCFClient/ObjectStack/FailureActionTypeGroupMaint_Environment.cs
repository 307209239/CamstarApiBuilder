// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureActionTypeGroupMaint_Environment
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
  public class FailureActionTypeGroupMaint_Environment : UserCodeGroupMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureActionTypeGroupMaint_Environment_ObjectChanges")]
    [Metadata("Grouping mechanism for the FailureActionTypes.  Identifies the possible FailureActionTypes that can be assigned to an Event or Cause.", "FailureActionTypeGroupChanges", false, false, false, "FailureActionTypeGroupChanges", 1048873, true, false, false, null)]
    protected FailureActionTypeGroupChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "FailureActionTypeGroupMaint_Environment_ObjectToChange")]
    [Metadata("Grouping mechanism for the FailureActionTypes.  Identifies the possible FailureActionTypes that can be assigned to an Event or Cause.", "FailureActionTypeGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Grouping mechanism for the FailureActionTypes.  Identifies the possible FailureActionTypes that can be assigned to an Event or Cause.", "FailureActionTypeGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureActionTypeGroupMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public FailureActionTypeGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (FailureActionTypeGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
