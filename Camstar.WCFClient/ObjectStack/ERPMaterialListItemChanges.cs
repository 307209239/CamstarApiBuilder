// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPMaterialListItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BOMMaterialListItemChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MfgOrderMaterialListItmChanges))]
  [Serializable]
  public class ERPMaterialListItemChanges : MaterialListItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_PhantomBill")]
    protected new RevisionedObjectRef _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_RouteStep")]
    protected NamedSubentityRef _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_ERPReportingFlag")]
    protected Primitive<bool> _ERPReportingFlag;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_DefaultLot")]
    protected Primitive<string> _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_ERPLineItem")]
    protected Primitive<string> _ERPLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_DefaultStockPoint")]
    protected Primitive<string> _DefaultStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_SubFactory")]
    protected Primitive<string> _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ERPMaterialListItemChanges && object.Equals((object) this._ListItemToChange, (object) ((ERPMaterialListItemChanges) obj)._ListItemToChange) && (object.Equals((object) this._PhantomBill, (object) ((ERPMaterialListItemChanges) obj)._PhantomBill) && object.Equals((object) this._ObjectToChange, (object) ((ERPMaterialListItemChanges) obj)._ObjectToChange)) && (object.Equals((object) this._RouteStep, (object) ((ERPMaterialListItemChanges) obj)._RouteStep) && object.Equals((object) this._IssueControl, (object) ((ERPMaterialListItemChanges) obj)._IssueControl) && (object.Equals((object) this._ERPReportingFlag, (object) ((ERPMaterialListItemChanges) obj)._ERPReportingFlag) && object.Equals((object) this._DefaultLot, (object) ((ERPMaterialListItemChanges) obj)._DefaultLot))) && (object.Equals((object) this._ERPLineItem, (object) ((ERPMaterialListItemChanges) obj)._ERPLineItem) && object.Equals((object) this._DefaultStockPoint, (object) ((ERPMaterialListItemChanges) obj)._DefaultStockPoint) && (object.Equals((object) this._SubFactory, (object) ((ERPMaterialListItemChanges) obj)._SubFactory) && object.Equals((object) this._Name, (object) ((ERPMaterialListItemChanges) obj)._Name))) && base.Equals(obj);
    }

    public new NamedSubentityRef ListItemToChange
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

    public new RevisionedObjectRef PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PhantomBill));
      }
    }

    public new NamedSubentityRef ObjectToChange
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

    public NamedSubentityRef RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Primitive<bool> ERPReportingFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPReportingFlag), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ERPReportingFlag));
      }
    }

    public Primitive<string> DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public Primitive<string> ERPLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPLineItem), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ERPLineItem));
      }
    }

    public Primitive<string> DefaultStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultStockPoint));
      }
    }

    public Primitive<string> SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubFactory));
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
