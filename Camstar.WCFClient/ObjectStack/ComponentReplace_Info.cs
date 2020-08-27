// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplace_Info
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
  public class ComponentReplace_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Info_IssueActualHistory")]
    protected Info _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Info_ServiceDetails")]
    protected ComponentReplaceDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Info_BillControl")]
    protected Info _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplace_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;

    public Info IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public ComponentReplaceDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentReplaceDetail_Info) this.PropertyGet(nameof (ServiceDetails));
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
  }
}
