// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInquiry_Environment
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
  public class CDOInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_ObjectReferences")]
    [Metadata("Contains all the object reference type fields information. Includes owned subentities as well.", "ObjectReferencesInfo", false, false, true, "ObjectReferencesInfo", 1050851, false, false, false, null)]
    protected ObjectReferencesInfo_Environment _ObjectReferences;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_CDODefId")]
    [Metadata("MaintainableObject", "MaintainableObjectEnum", false, false, false, "Integer", 1050843, false, false, false, null)]
    protected Environment _CDODefId;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_ObjectReferencesList")]
    [Metadata("Contains all the object reference type fields information. Includes owned subentities as well.", "ObjectReferencesInfo", false, false, false, "ObjectReferencesInfo", 1053089, false, true, false, null)]
    protected ObjectReferencesInfo_Environment _ObjectReferencesList;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_CDODefName")]
    [Metadata("MaintainableObjectName", "MaintainableObjectEnum", false, false, false, "String", 1050844, false, false, false, null)]
    protected Environment _CDODefName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_ObjectsToResolve")]
    [Metadata("Name or Name/Rev to be resolved as instances.", "ObjectToResolve", false, false, false, "ObjectToResolve", 1053196, false, true, false, null)]
    protected ObjectToResolve_Environment _ObjectsToResolve;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050779, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_Recursive")]
    protected Environment _Recursive;
    [Metadata("Generic String", "", false, false, false, "String", 1053209, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_SufixIncludeFilter")]
    protected Environment _SufixIncludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_SufixExcludeFilter")]
    [Metadata("Generic String", "", false, false, false, "String", 1053208, false, false, false, null)]
    protected Environment _SufixExcludeFilter;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053204, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_IsRDO")]
    protected Environment _IsRDO;
    [Metadata("Generic String", "", false, false, false, "String", 1053206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_PrefixIncludeFilter")]
    protected Environment _PrefixIncludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_PrefixExcludeFilter")]
    [Metadata("Generic String", "", false, false, false, "String", 1053205, false, false, false, null)]
    protected Environment _PrefixExcludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_BeginDateFilter")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053201, false, false, false, null)]
    protected Environment _BeginDateFilter;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053195, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_IncludeData")]
    protected Environment _IncludeData;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049286, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_CDOFilteredInstances")]
    protected Environment _CDOFilteredInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_RORFilter")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053207, false, false, false, "0")]
    protected Environment _RORFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_FilterReferences")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779041, false, false, false, "0")]
    protected Environment _FilterReferences;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_EndDateFilter")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053203, false, false, false, null)]
    protected Environment _EndDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_SelectedInstance")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050850, false, false, false, null)]
    protected Environment _SelectedInstance;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1053090, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_SelectedInstances")]
    protected Environment _SelectedInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_CDOInstances")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049286, false, true, true, null)]
    protected Environment _CDOInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_StatusFilter")]
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, null)]
    protected Environment _StatusFilter;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1053202, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Environment_EmployeeFilter")]
    protected Environment _EmployeeFilter;

    public ObjectReferencesInfo_Environment ObjectReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReferences), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo_Environment) this.PropertyGet(nameof (ObjectReferences));
      }
    }

    public Environment CDODefId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDODefId));
      }
    }

    public ObjectReferencesInfo_Environment ObjectReferencesList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReferencesList), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo_Environment) this.PropertyGet(nameof (ObjectReferencesList));
      }
    }

    public Environment CDODefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDODefName));
      }
    }

    public ObjectToResolve_Environment ObjectsToResolve
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectsToResolve), (object) value);
      }
      get
      {
        return (ObjectToResolve_Environment) this.PropertyGet(nameof (ObjectsToResolve));
      }
    }

    public Environment Recursive
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recursive), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Recursive));
      }
    }

    public Environment SufixIncludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SufixIncludeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SufixIncludeFilter));
      }
    }

    public Environment SufixExcludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SufixExcludeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SufixExcludeFilter));
      }
    }

    public Environment IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Environment PrefixIncludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrefixIncludeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrefixIncludeFilter));
      }
    }

    public Environment PrefixExcludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrefixExcludeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrefixExcludeFilter));
      }
    }

    public Environment BeginDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginDateFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BeginDateFilter));
      }
    }

    public Environment IncludeData
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeData));
      }
    }

    public Environment CDOFilteredInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOFilteredInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDOFilteredInstances));
      }
    }

    public Environment RORFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (RORFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RORFilter));
      }
    }

    public Environment FilterReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterReferences), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterReferences));
      }
    }

    public Environment EndDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDateFilter));
      }
    }

    public Environment SelectedInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedInstance));
      }
    }

    public Environment SelectedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedInstances));
      }
    }

    public Environment CDOInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDOInstances));
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

    public Environment EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeFilter));
      }
    }
  }
}
