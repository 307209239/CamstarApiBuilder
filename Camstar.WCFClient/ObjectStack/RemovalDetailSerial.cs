// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetailSerial
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
  public class RemovalDetailSerial : RemovalDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_IssueActualHistory")]
    protected new SubentityRef _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_Qty2Removed")]
    protected new Primitive<double> _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_DestinationContainer")]
    protected ContainerRef _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_NewParentContainer")]
    protected ContainerRef _NewParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_OpenClosedContainer")]
    protected Primitive<bool> _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_ScrapContainer")]
    protected Primitive<bool> _ScrapContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_DestinationLocation")]
    protected NamedSubentityRef _DestinationLocation;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailSerial_QtyRemoved")]
    protected new Primitive<double> _QtyRemoved;

    public override bool Equals(object obj)
    {
      return obj is RemovalDetailSerial && object.Equals((object) this._IssueActualHistory, (object) ((RemovalDetailSerial) obj)._IssueActualHistory) && (object.Equals((object) this._Qty2Removed, (object) ((RemovalDetailSerial) obj)._Qty2Removed) && object.Equals((object) this._IssueControl, (object) ((RemovalDetailSerial) obj)._IssueControl)) && (object.Equals((object) this._DestinationContainer, (object) ((RemovalDetailSerial) obj)._DestinationContainer) && object.Equals((object) this._NewParentContainer, (object) ((RemovalDetailSerial) obj)._NewParentContainer) && (object.Equals((object) this._OpenClosedContainer, (object) ((RemovalDetailSerial) obj)._OpenClosedContainer) && object.Equals((object) this._ScrapContainer, (object) ((RemovalDetailSerial) obj)._ScrapContainer))) && (object.Equals((object) this._DestinationLocation, (object) ((RemovalDetailSerial) obj)._DestinationLocation) && object.Equals((object) this._QtyRemoved, (object) ((RemovalDetailSerial) obj)._QtyRemoved)) && base.Equals(obj);
    }

    public new SubentityRef IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public new Primitive<double> Qty2Removed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Removed), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Removed));
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

    public ContainerRef DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public ContainerRef NewParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewParentContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (NewParentContainer));
      }
    }

    public Primitive<bool> OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public Primitive<bool> ScrapContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ScrapContainer));
      }
    }

    public NamedSubentityRef DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DestinationLocation));
      }
    }

    public new Primitive<double> QtyRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemoved), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRemoved));
      }
    }
  }
}
