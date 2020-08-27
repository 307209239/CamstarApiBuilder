// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueR2_Environment
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
  public class ComponentIssueR2_Environment : ComponentIssue_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_ServiceDetails")]
    [Metadata("Contains the defined BOM requirements for a particular level of the BOM. These requirements are loaded by the method <GetRequirements>\r\n", "IssueDetails", false, true, false, "IssueDetails", 1049643, false, true, true, null)]
    protected new IssueDetails_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_PhantomBillDetails")]
    [Metadata("Contains the defined BOM requirements for a particular level of the BOM. These requirements are loaded by the method <GetRequirements>\r\n", "IssueDetails", false, false, false, "IssueDetails", 1049844, false, false, true, null)]
    protected IssueDetails_Environment _PhantomBillDetails;
    [Metadata("Holds default information for the Component Issue Light transaction's Material List", "MaterialListItemSettings", false, false, false, "MaterialListItemSettings", 16779175, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_zMaterialListItemSettings")]
    protected MaterialListItemSettings_Environment _zMaterialListItemSettings;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_PhantomBillId")]
    [Metadata("Generic String", "", false, false, false, "String", 16779183, false, false, false, null)]
    protected Environment _PhantomBillId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779250, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_ContainerQty")]
    protected Environment _ContainerQty;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779182, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_CalculateQtyRequired")]
    protected Environment _CalculateQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueR2_Environment_SelectedDetailsIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779184, false, false, false, "0")]
    protected Environment _SelectedDetailsIndex;

    public new IssueDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public IssueDetails_Environment PhantomBillDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBillDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Environment) this.PropertyGet(nameof (PhantomBillDetails));
      }
    }

    public MaterialListItemSettings_Environment zMaterialListItemSettings
    {
      [param: In] set
      {
        this.PropertySet(nameof (zMaterialListItemSettings), (object) value);
      }
      get
      {
        return (MaterialListItemSettings_Environment) this.PropertyGet(nameof (zMaterialListItemSettings));
      }
    }

    public Environment PhantomBillId
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBillId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhantomBillId));
      }
    }

    public Environment ContainerQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerQty));
      }
    }

    public Environment CalculateQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalculateQtyRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CalculateQtyRequired));
      }
    }

    public Environment SelectedDetailsIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedDetailsIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedDetailsIndex));
      }
    }
  }
}
