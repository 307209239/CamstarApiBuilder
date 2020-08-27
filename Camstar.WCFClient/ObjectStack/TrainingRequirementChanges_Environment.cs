// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRequirementChanges_Environment
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
  public class TrainingRequirementChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirementBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048744, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_EffectiveFromDate")]
    protected Environment _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_EffectiveThruDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049027, false, false, false, null)]
    protected Environment _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_ExpirationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050479, false, false, false, null)]
    protected Environment _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_ExpirationPeriod")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050480, false, false, false, null)]
    protected Environment _ExpirationPeriod;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1050482, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_Trainers")]
    protected Environment _Trainers;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1050481, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_SOPDoc")]
    protected Environment _SOPDoc;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050483, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
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

    public Environment EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Environment EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Environment ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Environment ExpirationPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationPeriod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationPeriod));
      }
    }

    public Environment Trainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Trainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Trainers));
      }
    }

    public Environment SOPDoc
    {
      [param: In] set
      {
        this.PropertySet(nameof (SOPDoc), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SOPDoc));
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
