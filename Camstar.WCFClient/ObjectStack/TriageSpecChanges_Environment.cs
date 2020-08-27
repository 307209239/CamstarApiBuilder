// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecChanges_Environment
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
  public class TriageSpecChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Environment_TriageSpecDetails")]
    [Metadata("The TriageSpecDetail identifies the default values to assign to the Event or CAR as part of the Escalation process.", "TriageSpecDetailChanges", false, false, false, "TriageSpecDetailChanges", 1051447, false, true, false, null)]
    protected TriageSpecDetailChanges_Environment _TriageSpecDetails;
    [Metadata("The specifications for Triaging an Event or CAR.  The Triage process handles escalating or closing the Event or CAR.", "TriageSpec", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Environment_BusinessRules")]
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1051737, false, true, true, null)]
    protected Environment _BusinessRules;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051425, false, false, false, null)]
    protected new Environment _Name;

    public TriageSpecDetailChanges_Environment TriageSpecDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetails), (object) value);
      }
      get
      {
        return (TriageSpecDetailChanges_Environment) this.PropertyGet(nameof (TriageSpecDetails));
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

    public Environment BusinessRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRules), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRules));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
