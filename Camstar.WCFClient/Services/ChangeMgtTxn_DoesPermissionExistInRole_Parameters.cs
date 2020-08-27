// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtTxn_DoesPermissionExistInRole_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangeMgtTxn_DoesPermissionExistInRole_Parameters : ChangeMgtTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Permission")]
    protected string _Permission;
    [DataMember(EmitDefaultValue = false, Name = "Role")]
    protected string _Role;

    public string Permission
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permission), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Permission));
      }
    }

    public string Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Role));
      }
    }
  }
}
