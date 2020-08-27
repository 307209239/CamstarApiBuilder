// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters
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
  public class ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters : ProcessObjectTemplateMaint_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Employee")]
    protected string _Employee;
    [DataMember(EmitDefaultValue = false, Name = "Organization")]
    protected string _Organization;
    [DataMember(EmitDefaultValue = false, Name = "Role")]
    protected string _Role;

    public string Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Employee));
      }
    }

    public string Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Organization));
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
