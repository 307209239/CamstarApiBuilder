// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplace_Environment
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
  public class ComponentReplace_Environment : ContainerTxn_Environment
  {
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "SubentityRef", 1049765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Environment_IssueActualHistory")]
    protected Environment _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Environment_ServiceDetails")]
    [Metadata("The details of replacing a component from a container", "ComponentReplaceDetail", false, true, false, "ComponentReplaceDetail", 1049843, false, true, false, null)]
    protected ComponentReplaceDetail_Environment _ServiceDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049449, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Environment_BillControl")]
    protected Environment _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Environment_AllowZeroQtys")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051471, false, false, false, "1")]
    protected Environment _AllowZeroQtys;

    public Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public ComponentReplaceDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentReplaceDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillControl));
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
  }
}
