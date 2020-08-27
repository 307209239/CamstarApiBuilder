// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SystemSecurityGroupChanges_Info
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
  public class V4_SystemSecurityGroupChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Info_FullName")]
    protected Info _FullName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Info_DomainName")]
    protected Info _DomainName;

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

    public Info FullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FullName));
      }
    }

    public Info DomainName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DomainName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DomainName));
      }
    }
  }
}
