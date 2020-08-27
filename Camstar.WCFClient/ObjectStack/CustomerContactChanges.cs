// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerContactChanges
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
  public class CustomerContactChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_EmailAddress")]
    protected Primitive<string> _EmailAddress;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_PrimaryContact")]
    protected Primitive<bool> _PrimaryContact;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_FaxNumber")]
    protected Primitive<string> _FaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_PhoneNumber")]
    protected Primitive<string> _PhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_CellPhoneNumber")]
    protected Primitive<string> _CellPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is CustomerContactChanges && object.Equals((object) this._EmailAddress, (object) ((CustomerContactChanges) obj)._EmailAddress) && (object.Equals((object) this._ListItemToChange, (object) ((CustomerContactChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((CustomerContactChanges) obj)._ObjectToChange)) && (object.Equals((object) this._PrimaryContact, (object) ((CustomerContactChanges) obj)._PrimaryContact) && object.Equals((object) this._FaxNumber, (object) ((CustomerContactChanges) obj)._FaxNumber) && (object.Equals((object) this._PhoneNumber, (object) ((CustomerContactChanges) obj)._PhoneNumber) && object.Equals((object) this._CellPhoneNumber, (object) ((CustomerContactChanges) obj)._CellPhoneNumber))) && object.Equals((object) this._Name, (object) ((CustomerContactChanges) obj)._Name) && base.Equals(obj);
    }

    public Primitive<string> EmailAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailAddress), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EmailAddress));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<bool> PrimaryContact
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrimaryContact), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PrimaryContact));
      }
    }

    public Primitive<string> FaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (FaxNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FaxNumber));
      }
    }

    public Primitive<string> PhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhoneNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PhoneNumber));
      }
    }

    public Primitive<string> CellPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CellPhoneNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CellPhoneNumber));
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
  }
}
