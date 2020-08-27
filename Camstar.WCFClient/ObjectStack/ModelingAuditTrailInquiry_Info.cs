// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrailInquiry_Info
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
  public class ModelingAuditTrailInquiry_Info : AuditTrailInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_SelectedHeader")]
    protected new Info _SelectedHeader;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_AuditTrailDetail")]
    protected ModelingAuditTrail_Info _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ObjectName")]
    protected Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_Headers")]
    protected ModelingAuditTrailHeader_Info _Headers;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_Recursive")]
    protected Info _Recursive;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ObjectRevisionOrParent")]
    protected Info _ObjectRevisionOrParent;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ModelingAuditListSize")]
    protected Info _ModelingAuditListSize;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ModelingAuditStartRow")]
    protected Info _ModelingAuditStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ParentType")]
    protected Info _ParentType;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_DateToFilter")]
    protected Info _DateToFilter;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_SelectedObjectId")]
    protected Info _SelectedObjectId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_DateFromFilter")]
    protected Info _DateFromFilter;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_ParentRevision")]
    protected Info _ParentRevision;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Info_PackageName")]
    protected Info _PackageName;

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Info SelectedHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeader), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHeader));
      }
    }

    public ModelingAuditTrail_Info AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (ModelingAuditTrail_Info) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public Info ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ModelingAuditTrailHeader_Info Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Info) this.PropertyGet(nameof (Headers));
      }
    }

    public Info Recursive
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recursive), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Recursive));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Info ObjectRevisionOrParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevisionOrParent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectRevisionOrParent));
      }
    }

    public Info ModelingAuditListSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingAuditListSize), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingAuditListSize));
      }
    }

    public Info ModelingAuditStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingAuditStartRow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingAuditStartRow));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Info ParentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentType));
      }
    }

    public Info DateToFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateToFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateToFilter));
      }
    }

    public Info SelectedObjectId
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObjectId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedObjectId));
      }
    }

    public Info DateFromFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateFromFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateFromFilter));
      }
    }

    public Info ParentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentRevision));
      }
    }

    public Info PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageName));
      }
    }
  }
}
