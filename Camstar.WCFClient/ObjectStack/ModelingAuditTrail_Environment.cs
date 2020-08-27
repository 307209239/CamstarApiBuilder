// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrail_Environment
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
  public class ModelingAuditTrail_Environment : AuditTrail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Encapsulates CDO Field's metadata captured for Audit Trail ", "AuditTrailField", false, false, true, "AuditTrailField", 1050785, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_Fields")]
    protected AuditTrailField_Environment _Fields;
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, true, "SubentityRef", 1050770, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_Header")]
    protected new Environment _Header;
    [Metadata("Fully Qualified Name", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_ObjectDisplayName")]
    protected Environment _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_PackageName")]
    [Metadata("Generic String", "", false, false, true, "String", 16777354, false, false, false, null)]
    protected Environment _PackageName;
    [Metadata("Generic String", "", false, false, true, "String", 1050773, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_ObjectTypeId")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050784, false, false, false, null)]
    protected Environment _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Environment_ObjectTypeName")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1050776, false, false, false, null)]
    protected Environment _ObjectTypeName;

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

    public AuditTrailField_Environment Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (AuditTrailField_Environment) this.PropertyGet(nameof (Fields));
      }
    }

    public new Environment Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Header));
      }
    }

    public Environment ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectDisplayName));
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

    public Environment ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeId));
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
  }
}
