// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsBulk
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompDistributeActualBulk))]
  [Serializable]
  public class ActualsBulk : IssueActuals
  {
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_Vendor")]
    protected new NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_FromCarrier")]
    protected NamedObjectRef _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_FromBatch")]
    protected ContainerRef _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_ToContainer")]
    protected new ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_ToLocation")]
    protected new NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ActualsBulk_FromLocation")]
    protected NamedSubentityRef _FromLocation;

    public override bool Equals(object obj)
    {
      return obj is ActualsBulk && object.Equals((object) this._Vendor, (object) ((ActualsBulk) obj)._Vendor) && (object.Equals((object) this._FromCarrier, (object) ((ActualsBulk) obj)._FromCarrier) && object.Equals((object) this._FromBatch, (object) ((ActualsBulk) obj)._FromBatch)) && (object.Equals((object) this._ToContainer, (object) ((ActualsBulk) obj)._ToContainer) && object.Equals((object) this._FromContainer, (object) ((ActualsBulk) obj)._FromContainer) && (object.Equals((object) this._ToLocation, (object) ((ActualsBulk) obj)._ToLocation) && object.Equals((object) this._Product, (object) ((ActualsBulk) obj)._Product))) && object.Equals((object) this._FromLocation, (object) ((ActualsBulk) obj)._FromLocation) && base.Equals(obj);
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

    public NamedObjectRef FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public ContainerRef FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromBatch));
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

    public ContainerRef FromContainer
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

    public new RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public NamedSubentityRef FromLocation
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
