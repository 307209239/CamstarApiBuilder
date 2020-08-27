// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailDistributionChanges
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
  public class EMailDistributionChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_RoleRecipients")]
    protected NamedObjectRef[] _RoleRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_ExternalRecipients")]
    protected Primitive<string>[] _ExternalRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_EmployeeRecipients")]
    protected NamedObjectRef[] _EmployeeRecipients;

    public override bool Equals(object obj)
    {
      return obj is EMailDistributionChanges && this.CompareArrays((Array) this._RoleRecipients, (Array) ((EMailDistributionChanges) obj)._RoleRecipients) && (this.CompareArrays((Array) this._ExternalRecipients, (Array) ((EMailDistributionChanges) obj)._ExternalRecipients) && object.Equals((object) this._ObjectToChange, (object) ((EMailDistributionChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Name, (object) ((EMailDistributionChanges) obj)._Name) && this.CompareArrays((Array) this._EmployeeRecipients, (Array) ((EMailDistributionChanges) obj)._EmployeeRecipients)) && base.Equals(obj);
    }

    public NamedObjectRef[] RoleRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleRecipients), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (RoleRecipients));
      }
    }

    public Primitive<string>[] ExternalRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternalRecipients), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (ExternalRecipients));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public NamedObjectRef[] EmployeeRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeRecipients), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (EmployeeRecipients));
      }
    }
  }
}
