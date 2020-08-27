// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportItem_Info
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
  public class ExportImportItem_Info : ObjectAlternateKey_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Info_ObjectType")]
    protected new Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Info_ObjectTypeName")]
    protected new Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Info_ObjectName")]
    protected new Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Info_ObjectInstanceId")]
    protected new Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Info_Revision")]
    protected new Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Info_IsROR")]
    protected new Info _IsROR;

    public new Info ObjectType
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

    public new Info ObjectTypeName
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

    public new Info ObjectName
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

    public new Info ObjectInstanceId
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

    public new Info Revision
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

    public new Info IsROR
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
  }
}
