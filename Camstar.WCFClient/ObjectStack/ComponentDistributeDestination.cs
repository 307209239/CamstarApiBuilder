// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistributeDestination
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
  public class ComponentDistributeDestination : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_ActualQty2Issued")]
    protected Primitive<double> _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_IssueDetails")]
    protected Camstar.WCF.ObjectStack.IssueDetails[] _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_IssueControl")]
    protected Primitive<int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_ToContainer")]
    protected ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_ActualQtyIssued")]
    protected Primitive<double> _ActualQtyIssued;

    public override bool Equals(object obj)
    {
      return obj is ComponentDistributeDestination && object.Equals((object) this._ActualQty2Issued, (object) ((ComponentDistributeDestination) obj)._ActualQty2Issued) && (this.CompareArrays((Array) this._IssueDetails, (Array) ((ComponentDistributeDestination) obj)._IssueDetails) && object.Equals((object) this._AllowZeroQtys, (object) ((ComponentDistributeDestination) obj)._AllowZeroQtys)) && (object.Equals((object) this._IssueControl, (object) ((ComponentDistributeDestination) obj)._IssueControl) && object.Equals((object) this._ToContainer, (object) ((ComponentDistributeDestination) obj)._ToContainer) && object.Equals((object) this._ActualQtyIssued, (object) ((ComponentDistributeDestination) obj)._ActualQtyIssued)) && base.Equals(obj);
    }

    public Primitive<double> ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public Camstar.WCF.ObjectStack.IssueDetails[] IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.IssueDetails[]) this.PropertyGet(nameof (IssueDetails));
      }
    }

    public Primitive<bool> AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Primitive<int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public ContainerRef ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ToContainer));
      }
    }

    public Primitive<double> ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }
  }
}
