// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Associate
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
  public class Associate : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Associate_EligibleContainersInquiry")]
    protected EligibleContainersInquiry _EligibleContainersInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Associate_ChildContainers")]
    protected ContainerRef[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "Associate_AssociatedContainers")]
    protected ContainerRef _AssociatedContainers;

    public override bool Equals(object obj)
    {
      return obj is Associate && object.Equals((object) this._EligibleContainersInquiry, (object) ((Associate) obj)._EligibleContainersInquiry) && (this.CompareArrays((Array) this._ChildContainers, (Array) ((Associate) obj)._ChildContainers) && object.Equals((object) this._Container, (object) ((Associate) obj)._Container)) && object.Equals((object) this._AssociatedContainers, (object) ((Associate) obj)._AssociatedContainers) && base.Equals(obj);
    }

    public EligibleContainersInquiry EligibleContainersInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainersInquiry), (object) value);
      }
      get
      {
        return (EligibleContainersInquiry) this.PropertyGet(nameof (EligibleContainersInquiry));
      }
    }

    public ContainerRef[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public ContainerRef AssociatedContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedContainers), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (AssociatedContainers));
      }
    }
  }
}
