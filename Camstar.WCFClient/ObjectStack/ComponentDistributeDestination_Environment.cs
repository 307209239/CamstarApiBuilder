// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistributeDestination_Environment
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
  public class ComponentDistributeDestination_Environment : ServiceDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049692, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Environment_ActualQty2Issued")]
    protected Environment _ActualQty2Issued;
    [Metadata("Contains the defined BOM requirements for a particular level of the BOM. These requirements are loaded by the method <GetRequirements>\r\n", "IssueDetails", false, false, false, "IssueDetails", 1049844, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Environment_IssueDetails")]
    protected IssueDetails_Environment _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Environment_AllowZeroQtys")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051471, false, false, false, "1")]
    protected Environment _AllowZeroQtys;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049463, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Environment_IssueControl")]
    protected Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Environment_ToContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049400, false, false, true, null)]
    protected Environment _ToContainer;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049691, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Environment_ActualQtyIssued")]
    protected Environment _ActualQtyIssued;

    public Environment ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public IssueDetails_Environment IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Environment) this.PropertyGet(nameof (IssueDetails));
      }
    }

    public Environment AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Environment ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToContainer));
      }
    }

    public Environment ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }
  }
}
