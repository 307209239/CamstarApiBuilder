// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecMaint_Environment
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
  public class TriageSpecMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("The specifications for Triaging an Event or CAR.  The Triage process handles escalating or closing the Event or CAR.", "TriageSpec", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("The specifications for Triaging an Event or CAR.  The Triage process handles escalating or closing the Event or CAR.", "TriageSpec", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecMaint_Environment_ObjectChanges")]
    [Metadata("The specifications for Triaging an Event or CAR.  The Triage process handles escalating or closing the Event or CAR.", "TriageSpecChanges", false, false, false, "TriageSpecChanges", 1048873, true, false, false, null)]
    protected TriageSpecChanges_Environment _ObjectChanges;

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

    public TriageSpecChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TriageSpecChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
