// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssue_Info
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
  public class ComponentIssue_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_ServiceDetails")]
    protected IssueDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_IssueActualDetails")]
    protected IssueActualDetail_Info _IssueActualDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_BillControl")]
    protected Info _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Info_Operation")]
    protected new Info _Operation;

    public IssueDetails_Info ServiceDetails
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

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public IssueActualDetail_Info IssueActualDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualDetails), (object) value);
      }
      get
      {
        return (IssueActualDetail_Info) this.PropertyGet(nameof (IssueActualDetails));
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

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillControl));
      }
    }

    public new Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
