// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageQualityObjectHistory_Environment
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
  public class TriageQualityObjectHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_QualityObjectRole")]
    protected Environment _QualityObjectRole;
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, true, "Integer", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_Category")]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_PriorityLevel")]
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, true, "NamedObjectRef", 1051051, false, false, false, null)]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_TriageSpecDetail")]
    [Metadata("The TriageSpecDetail identifies the default values to assign to the Event or CAR as part of the Escalation process.", "TriageSpecDetail", false, false, true, "NamedSubentityRef", 1051443, false, false, false, null)]
    protected Environment _TriageSpecDetail;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_ProcessModelTemplate")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplate", false, false, true, "RevisionedObjectRef", 1051400, false, false, false, null)]
    protected Environment _ProcessModelTemplate;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052178, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_RouteProcessModel")]
    protected Environment _RouteProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_TriageComplete")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051655, false, false, false, "0")]
    protected Environment _TriageComplete;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051445, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_IsCARRequiredToClose")]
    protected Environment _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Environment_QualityObjectOwner")]
    protected Environment _QualityObjectOwner;

    public Environment QualityObjectRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectRole));
      }
    }

    public Environment Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Category));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Environment TriageSpecDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageSpecDetail));
      }
    }

    public Environment ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public Environment RouteProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteProcessModel));
      }
    }

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Environment IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment QualityObjectOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectOwner));
      }
    }
  }
}
