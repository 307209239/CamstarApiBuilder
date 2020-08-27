// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrail_Info
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
  public class ModelingAuditTrail_Info : AuditTrail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_Fields")]
    protected AuditTrailField_Info _Fields;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_Header")]
    protected new Info _Header;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_ObjectDisplayName")]
    protected Info _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_PackageName")]
    protected Info _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public AuditTrailField_Info Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (AuditTrailField_Info) this.PropertyGet(nameof (Fields));
      }
    }

    public new Info Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Header));
      }
    }

    public Info ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectDisplayName));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

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
  }
}
