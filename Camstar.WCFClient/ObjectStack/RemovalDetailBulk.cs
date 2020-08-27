// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetailBulk
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
  public class RemovalDetailBulk : RemovalDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_IssueActualHistory")]
    protected new SubentityRef _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_OpenClosedContainer")]
    protected Primitive<bool> _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_DestinationContainer")]
    protected ContainerRef _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_ScrapContainer")]
    protected Primitive<bool> _ScrapContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_DestinationLocation")]
    protected NamedSubentityRef _DestinationLocation;

    public override bool Equals(object obj)
    {
      return obj is RemovalDetailBulk && object.Equals((object) this._IssueControl, (object) ((RemovalDetailBulk) obj)._IssueControl) && (object.Equals((object) this._IssueActualHistory, (object) ((RemovalDetailBulk) obj)._IssueActualHistory) && object.Equals((object) this._OpenClosedContainer, (object) ((RemovalDetailBulk) obj)._OpenClosedContainer)) && (object.Equals((object) this._DestinationContainer, (object) ((RemovalDetailBulk) obj)._DestinationContainer) && object.Equals((object) this._ScrapContainer, (object) ((RemovalDetailBulk) obj)._ScrapContainer) && object.Equals((object) this._DestinationLocation, (object) ((RemovalDetailBulk) obj)._DestinationLocation)) && base.Equals(obj);
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public new SubentityRef IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Primitive<bool> OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public ContainerRef DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public Primitive<bool> ScrapContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ScrapContainer));
      }
    }

    public NamedSubentityRef DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DestinationLocation));
      }
    }
  }
}
