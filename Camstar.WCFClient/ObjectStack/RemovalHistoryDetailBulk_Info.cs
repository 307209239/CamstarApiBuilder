// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailBulk_Info
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
  public class RemovalHistoryDetailBulk_Info : RemovalHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailBulk_Info_IssueActualsHistory")]
    protected new Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailBulk_Info_OpenClosedContainer")]
    protected Info _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailBulk_Info_DestinationContainer")]
    protected Info _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailBulk_Info_DestinationLocation")]
    protected Info _DestinationLocation;

    public new Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Info OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public Info DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public Info DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationLocation));
      }
    }
  }
}
