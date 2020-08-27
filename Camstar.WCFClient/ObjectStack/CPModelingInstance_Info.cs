// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CPModelingInstance_Info
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
  public class CPModelingInstance_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_ObjectName")]
    protected Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_IsReference")]
    protected Info _IsReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_IsROR")]
    protected Info _IsROR;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_AddedToPackageGMT")]
    protected Info _AddedToPackageGMT;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstance_Info_Revision")]
    protected Info _Revision;

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

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
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

    public Info IsReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsReference));
      }
    }

    public Info IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsROR));
      }
    }

    public Info AddedToPackageGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddedToPackageGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AddedToPackageGMT));
      }
    }

    public Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }
  }
}
