// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrail
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
  public class ModelingAuditTrail : AuditTrail
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Fields")]
    protected AuditTrailField[] _Fields;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_Header")]
    protected new SubentityRef _Header;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_ObjectDisplayName")]
    protected Primitive<string> _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_PackageName")]
    protected Primitive<string> _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrail_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;

    public override bool Equals(object obj)
    {
      return obj is ModelingAuditTrail && object.Equals((object) this._ExportImportKey, (object) ((ModelingAuditTrail) obj)._ExportImportKey) && (this.CompareArrays((Array) this._Fields, (Array) ((ModelingAuditTrail) obj)._Fields) && object.Equals((object) this._Header, (object) ((ModelingAuditTrail) obj)._Header)) && (object.Equals((object) this._ObjectDisplayName, (object) ((ModelingAuditTrail) obj)._ObjectDisplayName) && object.Equals((object) this._PackageName, (object) ((ModelingAuditTrail) obj)._PackageName) && (object.Equals((object) this._ObjectInstanceId, (object) ((ModelingAuditTrail) obj)._ObjectInstanceId) && object.Equals((object) this._HistoryId, (object) ((ModelingAuditTrail) obj)._HistoryId))) && (object.Equals((object) this._ObjectTypeId, (object) ((ModelingAuditTrail) obj)._ObjectTypeId) && object.Equals((object) this._ObjectTypeName, (object) ((ModelingAuditTrail) obj)._ObjectTypeName)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public AuditTrailField[] Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (AuditTrailField[]) this.PropertyGet(nameof (Fields));
      }
    }

    public new SubentityRef Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (Header));
      }
    }

    public Primitive<string> ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public Primitive<string> PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageName));
      }
    }

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
