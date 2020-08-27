// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPBOMChanges
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
  public class ERPBOMChanges : BillChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_ERPRoute")]
    protected RevisionedObjectRef _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_MaterialListItem")]
    protected BOMMaterialListItemChanges _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_MaterialList")]
    protected BOMMaterialListItemChanges[] _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_ExternallyControlled")]
    protected Primitive<bool> _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Status")]
    protected new Enumeration<StatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is ERPBOMChanges && object.Equals((object) this._Base, (object) ((ERPBOMChanges) obj)._Base) && (object.Equals((object) this._ERPRoute, (object) ((ERPBOMChanges) obj)._ERPRoute) && object.Equals((object) this._MaterialListItem, (object) ((ERPBOMChanges) obj)._MaterialListItem)) && (this.CompareArrays((Array) this._MaterialList, (Array) ((ERPBOMChanges) obj)._MaterialList) && object.Equals((object) this._ObjectToChange, (object) ((ERPBOMChanges) obj)._ObjectToChange) && (object.Equals((object) this._ExternallyControlled, (object) ((ERPBOMChanges) obj)._ExternallyControlled) && object.Equals((object) this._IsFrozen, (object) ((ERPBOMChanges) obj)._IsFrozen))) && (object.Equals((object) this._Name, (object) ((ERPBOMChanges) obj)._Name) && object.Equals((object) this._Description, (object) ((ERPBOMChanges) obj)._Description) && (object.Equals((object) this._IsRevOfRcd, (object) ((ERPBOMChanges) obj)._IsRevOfRcd) && object.Equals((object) this._Status, (object) ((ERPBOMChanges) obj)._Status))) && base.Equals(obj);
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public RevisionedObjectRef ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public BOMMaterialListItemChanges MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (BOMMaterialListItemChanges) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public BOMMaterialListItemChanges[] MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (BOMMaterialListItemChanges[]) this.PropertyGet(nameof (MaterialList));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<bool> ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
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

    public new Primitive<string> Description
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

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public new Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }
  }
}
