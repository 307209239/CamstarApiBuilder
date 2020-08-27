// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_PermissionEntry_Info
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
  public class V4_PermissionEntry_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Info_Access")]
    protected Info _Access;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Info_ListItemToChange")]
    protected Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Info_ResolvedPermission")]
    protected Info _ResolvedPermission;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Info_AccessBit")]
    protected Info _AccessBit;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Info_Description")]
    protected Info _Description;

    public Info Access
    {
      [param: In] set
      {
        this.PropertySet(nameof (Access), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Access));
      }
    }

    public Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info ResolvedPermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedPermission), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedPermission));
      }
    }

    public Info AccessBit
    {
      [param: In] set
      {
        this.PropertySet(nameof (AccessBit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AccessBit));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
