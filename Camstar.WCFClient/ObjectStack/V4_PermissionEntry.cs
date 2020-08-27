// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_PermissionEntry
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
  public class V4_PermissionEntry : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Access")]
    protected Primitive<int> _Access;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_ListItemToChange")]
    protected SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_ResolvedPermission")]
    protected Primitive<string> _ResolvedPermission;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_AccessBit")]
    protected Primitive<int> _AccessBit;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is V4_PermissionEntry && object.Equals((object) this._Access, (object) ((V4_PermissionEntry) obj)._Access) && (object.Equals((object) this._ListItemToChange, (object) ((V4_PermissionEntry) obj)._ListItemToChange) && object.Equals((object) this._ResolvedPermission, (object) ((V4_PermissionEntry) obj)._ResolvedPermission)) && (object.Equals((object) this._AccessBit, (object) ((V4_PermissionEntry) obj)._AccessBit) && object.Equals((object) this._Description, (object) ((V4_PermissionEntry) obj)._Description)) && base.Equals(obj);
    }

    public Primitive<int> Access
    {
      [param: In] set
      {
        this.PropertySet(nameof (Access), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Access));
      }
    }

    public SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<string> ResolvedPermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedPermission), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResolvedPermission));
      }
    }

    public Primitive<int> AccessBit
    {
      [param: In] set
      {
        this.PropertySet(nameof (AccessBit), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AccessBit));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
