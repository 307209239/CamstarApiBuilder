// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistributeDestination_Info
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
  public class ComponentDistributeDestination_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Info_ActualQty2Issued")]
    protected Info _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Info_IssueDetails")]
    protected IssueDetails_Info _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Info_ToContainer")]
    protected Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeDestination_Info_ActualQtyIssued")]
    protected Info _ActualQtyIssued;

    public Info ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public IssueDetails_Info IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Info) this.PropertyGet(nameof (IssueDetails));
      }
    }

    public Info AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainer));
      }
    }

    public Info ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }
  }
}
