// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportItem
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
  public class ExportImportItem : ObjectAlternateKey
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_ObjectType")]
    protected Enumeration<ExportableObjectEnum, string> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_ObjectTypeName")]
    protected Enumeration<ExportableObjectEnum, string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_ObjectName")]
    protected new Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_ObjectInstanceId")]
    protected new Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Revision")]
    protected new Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_IsROR")]
    protected new Primitive<bool> _IsROR;

    public override bool Equals(object obj)
    {
      return obj is ExportImportItem && object.Equals((object) this._ObjectType, (object) ((ExportImportItem) obj)._ObjectType) && (object.Equals((object) this._ObjectTypeName, (object) ((ExportImportItem) obj)._ObjectTypeName) && object.Equals((object) this._ObjectName, (object) ((ExportImportItem) obj)._ObjectName)) && (object.Equals((object) this._ObjectInstanceId, (object) ((ExportImportItem) obj)._ObjectInstanceId) && object.Equals((object) this._Revision, (object) ((ExportImportItem) obj)._Revision) && object.Equals((object) this._IsROR, (object) ((ExportImportItem) obj)._IsROR)) && base.Equals(obj);
    }

    public Enumeration<ExportableObjectEnum, string> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Enumeration<ExportableObjectEnum, string>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Enumeration<ExportableObjectEnum, string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Enumeration<ExportableObjectEnum, string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
      }
    }

    public new Primitive<string> ObjectInstanceId
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

    public new Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public new Primitive<bool> IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsROR));
      }
    }
  }
}
