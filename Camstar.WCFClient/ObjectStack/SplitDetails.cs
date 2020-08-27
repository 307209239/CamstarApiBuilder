// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SplitDetails
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
  public class SplitDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_AttributeChanges")]
    protected SubentityRef[] _AttributeChanges;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_ToContainerName")]
    protected Primitive<string> _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_ToContainer")]
    protected ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_ChildContainers")]
    protected ContainerRef[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_AdjustThruput")]
    protected Primitive<bool> _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is SplitDetails && object.Equals((object) this._Qty2, (object) ((SplitDetails) obj)._Qty2) && (this.CompareArrays((Array) this._AttributeChanges, (Array) ((SplitDetails) obj)._AttributeChanges) && object.Equals((object) this._ToContainerName, (object) ((SplitDetails) obj)._ToContainerName)) && (object.Equals((object) this._ToContainer, (object) ((SplitDetails) obj)._ToContainer) && this.CompareArrays((Array) this._ChildContainers, (Array) ((SplitDetails) obj)._ChildContainers) && (object.Equals((object) this._AdjustThruput, (object) ((SplitDetails) obj)._AdjustThruput) && object.Equals((object) this._Qty, (object) ((SplitDetails) obj)._Qty))) && base.Equals(obj);
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public SubentityRef[] AttributeChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeChanges), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (AttributeChanges));
      }
    }

    public Primitive<string> ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public ContainerRef ToContainer
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

    public Primitive<bool> AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
