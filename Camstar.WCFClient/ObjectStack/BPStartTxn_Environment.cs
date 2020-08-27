// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPStartTxn_Environment
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
  public class BPStartTxn_Environment : BusinessProcessTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    protected Environment _Workflow;
    [Metadata("Start details for a trackable object.", "TrackObjCurrentStatusStartDtls", false, false, false, "TrackObjCurrentStatusStartDtls", 1049869, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Environment_CurrentStatusDetails")]
    protected TrackObjCurrentStatusStartDtls_Environment _CurrentStatusDetails;
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Environment_TrackableName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    protected Environment _TrackableName;

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public TrackObjCurrentStatusStartDtls_Environment CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (TrackObjCurrentStatusStartDtls_Environment) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Environment TrackableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableName));
      }
    }
  }
}
