// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueR2
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
  public class ComponentIssueR2 : ComponentIssue
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_ServiceDetails")]
    protected new IssueDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_PhantomBillDetails")]
    protected IssueDetails _PhantomBillDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_zMaterialListItemSettings")]
    protected MaterialListItemSettings _zMaterialListItemSettings;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_PhantomBillId")]
    protected Primitive<string> _PhantomBillId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_ContainerQty")]
    protected Primitive<int> _ContainerQty;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_CalculateQtyRequired")]
    protected Primitive<bool> _CalculateQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_SelectedDetailsIndex")]
    protected Primitive<int> _SelectedDetailsIndex;

    public override bool Equals(object obj)
    {
      return obj is ComponentIssueR2 && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ComponentIssueR2) obj)._ServiceDetails) && (object.Equals((object) this._PhantomBillDetails, (object) ((ComponentIssueR2) obj)._PhantomBillDetails) && object.Equals((object) this._zMaterialListItemSettings, (object) ((ComponentIssueR2) obj)._zMaterialListItemSettings)) && (object.Equals((object) this._PhantomBillId, (object) ((ComponentIssueR2) obj)._PhantomBillId) && object.Equals((object) this._ContainerQty, (object) ((ComponentIssueR2) obj)._ContainerQty) && (object.Equals((object) this._CalculateQtyRequired, (object) ((ComponentIssueR2) obj)._CalculateQtyRequired) && object.Equals((object) this._SelectedDetailsIndex, (object) ((ComponentIssueR2) obj)._SelectedDetailsIndex))) && base.Equals(obj);
    }

    public new IssueDetails[] ServiceDetails
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

    public IssueDetails PhantomBillDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBillDetails), (object) value);
      }
      get
      {
        return (IssueDetails) this.PropertyGet(nameof (PhantomBillDetails));
      }
    }

    public MaterialListItemSettings zMaterialListItemSettings
    {
      [param: In] set
      {
        this.PropertySet(nameof (zMaterialListItemSettings), (object) value);
      }
      get
      {
        return (MaterialListItemSettings) this.PropertyGet(nameof (zMaterialListItemSettings));
      }
    }

    public Primitive<string> PhantomBillId
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBillId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PhantomBillId));
      }
    }

    public Primitive<int> ContainerQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ContainerQty));
      }
    }

    public Primitive<bool> CalculateQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalculateQtyRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CalculateQtyRequired));
      }
    }

    public Primitive<int> SelectedDetailsIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedDetailsIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedDetailsIndex));
      }
    }
  }
}
