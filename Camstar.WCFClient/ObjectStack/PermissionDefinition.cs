// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDefinition
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
  public class PermissionDefinition : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_DisplayMode")]
    protected Enumeration<PermissionDisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_ServicePermission")]
    protected Primitive<bool> _ServicePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_PagePermission")]
    protected Primitive<bool> _PagePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinition_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is PermissionDefinition && object.Equals((object) this._ExportImportKey, (object) ((PermissionDefinition) obj)._ExportImportKey) && (object.Equals((object) this._DisplayMode, (object) ((PermissionDefinition) obj)._DisplayMode) && object.Equals((object) this._ServicePermission, (object) ((PermissionDefinition) obj)._ServicePermission)) && (object.Equals((object) this._PagePermission, (object) ((PermissionDefinition) obj)._PagePermission) && object.Equals((object) this._IsFrozen, (object) ((PermissionDefinition) obj)._IsFrozen)) && base.Equals(obj);
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

    public Enumeration<PermissionDisplayModeEnum, int> DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Enumeration<PermissionDisplayModeEnum, int>) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public Primitive<bool> ServicePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServicePermission), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ServicePermission));
      }
    }

    public Primitive<bool> PagePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (PagePermission), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PagePermission));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
