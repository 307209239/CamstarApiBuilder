// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDetail_Info
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
  public class PermissionDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Info_RoleMaint")]
    protected RoleMaint_Info _RoleMaint;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Info_Modes")]
    protected Info _Modes;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Info_ExecuteAction")]
    protected Info _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;

    public RoleMaint_Info RoleMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleMaint), (object) value);
      }
      get
      {
        return (RoleMaint_Info) this.PropertyGet(nameof (RoleMaint));
      }
    }

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info Modes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Modes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Modes));
      }
    }

    public Info ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecuteAction));
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
  }
}
