// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerContactChanges_Info
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
  public class CustomerContactChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_EmailAddress")]
    protected Info _EmailAddress;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_PrimaryContact")]
    protected Info _PrimaryContact;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_FaxNumber")]
    protected Info _FaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_PhoneNumber")]
    protected Info _PhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_CellPhoneNumber")]
    protected Info _CellPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Info_Name")]
    protected new Info _Name;

    public Info EmailAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailAddress), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmailAddress));
      }
    }

    public new Info ListItemToChange
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

    public Info PrimaryContact
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrimaryContact), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrimaryContact));
      }
    }

    public Info FaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (FaxNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FaxNumber));
      }
    }

    public Info PhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhoneNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhoneNumber));
      }
    }

    public Info CellPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CellPhoneNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CellPhoneNumber));
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
  }
}
