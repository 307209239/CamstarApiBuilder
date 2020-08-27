// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetailBulk_Info
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
  public class RemovalDetailBulk_Info : RemovalDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Info_IssueControl")]
    protected new Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Info_IssueActualHistory")]
    protected new Info _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Info_OpenClosedContainer")]
    protected Info _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Info_DestinationContainer")]
    protected Info _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Info_ScrapContainer")]
    protected Info _ScrapContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Info_DestinationLocation")]
    protected Info _DestinationLocation;

    public new Info IssueControl
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

    public new Info IssueActualHistory
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

    public Info ScrapContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScrapContainer));
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
