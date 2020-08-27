// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeActualBulk
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
  public class CompDistributeActualBulk : ActualsBulk
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Vendor")]
    protected new NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_FromContainer")]
    protected new ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_ToContainer")]
    protected new ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_ToLocation")]
    protected new NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_FromLocation")]
    protected new NamedSubentityRef _FromLocation;

    public override bool Equals(object obj)
    {
      return obj is CompDistributeActualBulk && object.Equals((object) this._Vendor, (object) ((CompDistributeActualBulk) obj)._Vendor) && (object.Equals((object) this._FromContainer, (object) ((CompDistributeActualBulk) obj)._FromContainer) && object.Equals((object) this._ToContainer, (object) ((CompDistributeActualBulk) obj)._ToContainer)) && (object.Equals((object) this._ToLocation, (object) ((CompDistributeActualBulk) obj)._ToLocation) && object.Equals((object) this._FromLocation, (object) ((CompDistributeActualBulk) obj)._FromLocation)) && base.Equals(obj);
    }

    public new NamedObjectRef Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Vendor));
      }
    }

    public new ContainerRef FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromContainer));
      }
    }

    public new ContainerRef ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ToContainer));
      }
    }

    public new NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }

    public new NamedSubentityRef FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}
