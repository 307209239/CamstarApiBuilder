// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDefinition_Info
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
  public class PermissionDefinition_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_Info_DisplayMode")]
    protected Info _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_Info_ServicePermission")]
    protected Info _ServicePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_Info_PagePermission")]
    protected Info _PagePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public Info ServicePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServicePermission), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServicePermission));
      }
    }

    public Info PagePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (PagePermission), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PagePermission));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
