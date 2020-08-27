// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailSerial
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
  public class RemovalHistoryDetailSerial : RemovalHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_IssueActualsHistory")]
    protected new SubentityRef _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_DestinationContainer")]
    protected ContainerRef _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_OpenClosedContainer")]
    protected Primitive<bool> _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_DestinationLocation")]
    protected NamedSubentityRef _DestinationLocation;

    public override bool Equals(object obj)
    {
      return obj is RemovalHistoryDetailSerial && object.Equals((object) this._IssueActualsHistory, (object) ((RemovalHistoryDetailSerial) obj)._IssueActualsHistory) && (object.Equals((object) this._DestinationContainer, (object) ((RemovalHistoryDetailSerial) obj)._DestinationContainer) && object.Equals((object) this._OpenClosedContainer, (object) ((RemovalHistoryDetailSerial) obj)._OpenClosedContainer)) && object.Equals((object) this._DestinationLocation, (object) ((RemovalHistoryDetailSerial) obj)._DestinationLocation) && base.Equals(obj);
    }

    public new SubentityRef IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualsHistory));
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
