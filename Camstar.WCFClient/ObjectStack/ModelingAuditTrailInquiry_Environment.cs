// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrailInquiry_Environment
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
  public class ModelingAuditTrailInquiry_Environment : AuditTrailInquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ObjectTypeName")]
    [Metadata("MaintainableObjectName", "MaintainableObjectEnum", false, false, false, "String", 1050776, false, false, true, null)]
    protected Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_SelectedHeader")]
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, false, "SubentityRef", 1050771, false, false, false, null)]
    protected new Environment _SelectedHeader;
    [Metadata("Details of the Audit Trail information captured during maintenance of modeling data objects", "ModelingAuditTrail", false, false, true, "ModelingAuditTrail", 1050769, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_AuditTrailDetail")]
    protected ModelingAuditTrail_Environment _AuditTrailDetail;
    [Metadata("DisplayName", "", false, false, false, "String", 1050774, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ObjectName")]
    protected Environment _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_Headers")]
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, true, "ModelingAuditTrailHeader", 1050770, false, true, false, null)]
    protected ModelingAuditTrailHeader_Environment _Headers;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050779, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_Recursive")]
    protected Environment _Recursive;
    [Metadata("Generic String", "", false, false, false, "String", 1050773, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [Metadata("Generic String", "", false, false, false, "String", 1050775, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ObjectRevisionOrParent")]
    protected Environment _ObjectRevisionOrParent;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ModelingAuditListSize")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052598, false, false, false, "-1")]
    protected Environment _ModelingAuditListSize;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052599, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ModelingAuditStartRow")]
    protected Environment _ModelingAuditStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ObjectType")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050797, false, false, true, null)]
    protected Environment _ObjectType;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050798, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ParentType")]
    protected Environment _ParentType;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051349, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_DateToFilter")]
    protected Environment _DateToFilter;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_SelectedObjectId")]
    [Metadata("Generic String", "", false, false, false, "String", 1050780, false, false, false, null)]
    protected Environment _SelectedObjectId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_DateFromFilter")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052316, false, false, false, null)]
    protected Environment _DateFromFilter;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050777, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_ParentRevision")]
    protected Environment _ParentRevision;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Environment_PackageName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777354, false, false, false, null)]
    protected Environment _PackageName;

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

    public new Environment SelectedHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeader), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHeader));
      }
    }

    public ModelingAuditTrail_Environment AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (ModelingAuditTrail_Environment) this.PropertyGet(nameof (AuditTrailDetail));
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

    public ModelingAuditTrailHeader_Environment Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Environment) this.PropertyGet(nameof (Headers));
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

    public Environment ObjectRevisionOrParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevisionOrParent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectRevisionOrParent));
      }
    }

    public Environment ModelingAuditListSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingAuditListSize), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingAuditListSize));
      }
    }

    public Environment ModelingAuditStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingAuditStartRow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingAuditStartRow));
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

    public Environment ParentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentType));
      }
    }

    public Environment DateToFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateToFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateToFilter));
      }
    }

    public Environment SelectedObjectId
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObjectId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedObjectId));
      }
    }

    public Environment DateFromFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateFromFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateFromFilter));
      }
    }

    public Environment ParentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentRevision));
      }
    }

    public Environment PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageName));
      }
    }
  }
}
