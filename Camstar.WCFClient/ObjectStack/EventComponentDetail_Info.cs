// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventComponentDetail_Info
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
  public class EventComponentDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Info_EventComponent")]
    protected Info _EventComponent;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Info_ProductRev")]
    protected Info _ProductRev;

    public Info EventComponent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventComponent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventComponent));
      }
    }

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }
  }
}
