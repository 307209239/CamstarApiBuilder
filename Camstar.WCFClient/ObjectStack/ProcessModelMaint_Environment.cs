// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelMaint_Environment
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
  public class ProcessModelMaint_Environment : ProcessObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Environment_ParentDataObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1050488, false, false, false, null)]
    protected new Environment _ParentDataObject;
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A ProcessModel describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModelChanges", false, false, false, "ProcessModelChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Environment_ObjectChanges")]
    protected ProcessModelChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Environment_Template")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplate", false, false, false, "RevisionedObjectRef", 1051395, false, false, true, null)]
    protected new Environment _Template;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Environment_ObjectListInquiry")]
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Environment_ValidChildTypes")]
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    protected new Environment _ValidChildTypes;

    public new Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
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

    public ProcessModelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessModelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Template));
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

    public new Environment ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
