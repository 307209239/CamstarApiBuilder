// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssue
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
  public class ComponentIssue : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_ServiceDetails")]
    protected IssueDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_IssueActualDetails")]
    protected IssueActualDetail[] _IssueActualDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_BillControl")]
    protected Primitive<bool> _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Operation")]
    protected new NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is ComponentIssue && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ComponentIssue) obj)._ServiceDetails) && (object.Equals((object) this._Carrier, (object) ((ComponentIssue) obj)._Carrier) && this.CompareArrays((Array) this._IssueActualDetails, (Array) ((ComponentIssue) obj)._IssueActualDetails)) && (object.Equals((object) this._AllowZeroQtys, (object) ((ComponentIssue) obj)._AllowZeroQtys) && object.Equals((object) this._Container, (object) ((ComponentIssue) obj)._Container) && (object.Equals((object) this._BillControl, (object) ((ComponentIssue) obj)._BillControl) && object.Equals((object) this._Operation, (object) ((ComponentIssue) obj)._Operation))) && base.Equals(obj);
    }

    public IssueDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (IssueDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public IssueActualDetail[] IssueActualDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualDetails), (object) value);
      }
      get
      {
        return (IssueActualDetail[]) this.PropertyGet(nameof (IssueActualDetails));
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

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<bool> BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BillControl));
      }
    }

    public new NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
