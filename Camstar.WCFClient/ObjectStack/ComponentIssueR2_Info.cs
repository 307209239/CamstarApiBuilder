// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueR2_Info
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
  public class ComponentIssueR2_Info : ComponentIssue_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_ServiceDetails")]
    protected new IssueDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_PhantomBillDetails")]
    protected IssueDetails_Info _PhantomBillDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_zMaterialListItemSettings")]
    protected MaterialListItemSettings_Info _zMaterialListItemSettings;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_PhantomBillId")]
    protected Info _PhantomBillId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_ContainerQty")]
    protected Info _ContainerQty;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_CalculateQtyRequired")]
    protected Info _CalculateQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Info_SelectedDetailsIndex")]
    protected Info _SelectedDetailsIndex;

    public new IssueDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public IssueDetails_Info PhantomBillDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBillDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Info) this.PropertyGet(nameof (PhantomBillDetails));
      }
    }

    public MaterialListItemSettings_Info zMaterialListItemSettings
    {
      [param: In] set
      {
        this.PropertySet(nameof (zMaterialListItemSettings), (object) value);
      }
      get
      {
        return (MaterialListItemSettings_Info) this.PropertyGet(nameof (zMaterialListItemSettings));
      }
    }

    public Info PhantomBillId
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBillId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhantomBillId));
      }
    }

    public Info ContainerQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerQty));
      }
    }

    public Info CalculateQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalculateQtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalculateQtyRequired));
      }
    }

    public Info SelectedDetailsIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedDetailsIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedDetailsIndex));
      }
    }
  }
}
