// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CPModelingInstanceDtl_Environment
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
  public class CPModelingInstanceDtl_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_ObjectTypeValue")]
    [Metadata("Label Value.", "", false, false, true, "String", 1050776, false, false, false, null)]
    protected Environment _ObjectTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_ObjectName")]
    [Metadata("DisplayName", "", false, false, false, "String", 1050774, false, false, false, null)]
    protected Environment _ObjectName;
    [Metadata("DisplayName", "", false, false, false, "String", 16778478, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_DisplayedName")]
    protected Environment _DisplayedName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("MaintainableObjectName", "MaintainableObjectEnum", false, false, false, "String", 1050776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_LastUpdatedDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    protected Environment _LastUpdatedDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778010, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_AddedToPackageGMT")]
    protected Environment _AddedToPackageGMT;
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, false, "RevisionedObjectRef", 16777330, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_RDORef")]
    protected Environment _RDORef;
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 16777331, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_NDORef")]
    protected Environment _NDORef;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053259, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_IsROR")]
    protected Environment _IsROR;
    [Metadata("Generic String", "", false, false, false, "String", 1050773, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_IsBadReference")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777333, false, false, false, "0")]
    protected Environment _IsBadReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_IsReference")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053258, false, false, false, "0")]
    protected Environment _IsReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_ObjectType")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050572, false, false, false, null)]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_LastUpdatedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16777332, false, false, false, null)]
    protected Environment _LastUpdatedBy;
    [Metadata("Message text.", "", false, false, false, "String", 16777334, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_ErrorMessage")]
    protected Environment _ErrorMessage;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_Revision")]
    protected Environment _Revision;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Environment_Description")]
    protected Environment _Description;

    public Environment ObjectTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeValue));
      }
    }

    public Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Environment DisplayedName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayedName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayedName));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Environment LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Environment AddedToPackageGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddedToPackageGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AddedToPackageGMT));
      }
    }

    public Environment RDORef
    {
      [param: In] set
      {
        this.PropertySet(nameof (RDORef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RDORef));
      }
    }

    public Environment NDORef
    {
      [param: In] set
      {
        this.PropertySet(nameof (NDORef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NDORef));
      }
    }

    public Environment IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsROR));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Environment IsBadReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsBadReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsBadReference));
      }
    }

    public Environment IsReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsReference));
      }
    }

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Environment LastUpdatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedBy));
      }
    }

    public Environment ErrorMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ErrorMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ErrorMessage));
      }
    }

    public Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
