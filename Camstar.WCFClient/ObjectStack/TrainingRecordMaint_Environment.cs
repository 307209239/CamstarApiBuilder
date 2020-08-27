// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRecordMaint_Environment
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
  public class TrainingRecordMaint_Environment : SubentityMaintenance_Environment
  {
    [Metadata("Item that tracks the status of a particular user for a specific training requirement", "TrainingRecordChanges", false, false, false, "TrainingRecordChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Environment_ObjectChanges")]
    protected TrainingRecordChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Environment_TrainingRequirement")]
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, true, false, "RevisionedObjectRef", 1050485, false, false, true, null)]
    protected Environment _TrainingRequirement;
    [Metadata("Item that tracks the status of a particular user for a specific training requirement", "TrainingRecord", false, false, false, "SubentityRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Environment_StatusFilter")]
    [Metadata("Status codes for the Employee Training Records", "TrainingRecordStatus", false, false, false, "NamedObjectRef", 1050484, false, false, true, null)]
    protected Environment _StatusFilter;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1048861, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Environment_ParentDataObject")]
    protected new Environment _ParentDataObject;

    public TrainingRecordChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TrainingRecordChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingRequirement));
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

    public Environment StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusFilter));
      }
    }

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
  }
}
