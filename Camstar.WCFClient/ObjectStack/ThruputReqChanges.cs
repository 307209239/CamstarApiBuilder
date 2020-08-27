// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputReqChanges
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
  public class ThruputReqChanges : MaintenanceReqChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_ToleranceQty2")]
    protected Primitive<double> _ToleranceQty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_WarningQty2")]
    protected Primitive<double> _WarningQty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_WarningQty")]
    protected Primitive<double> _WarningQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_ToleranceQty")]
    protected Primitive<double> _ToleranceQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is ThruputReqChanges && object.Equals((object) this._ObjectToChange, (object) ((ThruputReqChanges) obj)._ObjectToChange) && (object.Equals((object) this._UOM2, (object) ((ThruputReqChanges) obj)._UOM2) && object.Equals((object) this._UOM, (object) ((ThruputReqChanges) obj)._UOM)) && (object.Equals((object) this._Base, (object) ((ThruputReqChanges) obj)._Base) && object.Equals((object) this._Qty2, (object) ((ThruputReqChanges) obj)._Qty2) && (object.Equals((object) this._ToleranceQty2, (object) ((ThruputReqChanges) obj)._ToleranceQty2) && object.Equals((object) this._WarningQty2, (object) ((ThruputReqChanges) obj)._WarningQty2))) && (object.Equals((object) this._WarningQty, (object) ((ThruputReqChanges) obj)._WarningQty) && object.Equals((object) this._ToleranceQty, (object) ((ThruputReqChanges) obj)._ToleranceQty) && (object.Equals((object) this._Name, (object) ((ThruputReqChanges) obj)._Name) && object.Equals((object) this._Qty, (object) ((ThruputReqChanges) obj)._Qty))) && base.Equals(obj);
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

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
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

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public Primitive<double> ToleranceQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToleranceQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ToleranceQty2));
      }
    }

    public Primitive<double> WarningQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (WarningQty2));
      }
    }

    public Primitive<double> WarningQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (WarningQty));
      }
    }

    public Primitive<double> ToleranceQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToleranceQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ToleranceQty));
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

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
