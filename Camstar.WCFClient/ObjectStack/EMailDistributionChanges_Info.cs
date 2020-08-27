// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailDistributionChanges_Info
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
  public class EMailDistributionChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Info_RoleRecipients")]
    protected Info _RoleRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Info_ExternalRecipients")]
    protected Info _ExternalRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Info_EmployeeRecipients")]
    protected Info _EmployeeRecipients;

    public Info RoleRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleRecipients), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RoleRecipients));
      }
    }

    public Info ExternalRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternalRecipients), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExternalRecipients));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info EmployeeRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeRecipients), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeRecipients));
      }
    }
  }
}
