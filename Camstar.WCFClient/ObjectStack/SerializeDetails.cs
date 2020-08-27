// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeDetails
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
  public class SerializeDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_StartDetails")]
    protected SerializedStartDetails _StartDetails;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_ActualChildCount")]
    protected Primitive<int> _ActualChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_ChildContainerLevel")]
    protected NamedObjectRef _ChildContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_ContainerNames")]
    protected Primitive<string>[] _ContainerNames;

    public override bool Equals(object obj)
    {
      return obj is SerializeDetails && object.Equals((object) this._StartDetails, (object) ((SerializeDetails) obj)._StartDetails) && (object.Equals((object) this._ActualChildCount, (object) ((SerializeDetails) obj)._ActualChildCount) && object.Equals((object) this._ChildContainerLevel, (object) ((SerializeDetails) obj)._ChildContainerLevel)) && (object.Equals((object) this._Product, (object) ((SerializeDetails) obj)._Product) && this.CompareArrays((Array) this._ContainerNames, (Array) ((SerializeDetails) obj)._ContainerNames)) && base.Equals(obj);
    }

    public SerializedStartDetails StartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDetails), (object) value);
      }
      get
      {
        return (SerializedStartDetails) this.PropertyGet(nameof (StartDetails));
      }
    }

    public Primitive<int> ActualChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ActualChildCount));
      }
    }

    public NamedObjectRef ChildContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChildContainerLevel));
      }
    }

    public RevisionedObjectRef Product
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

    public Primitive<string>[] ContainerNames
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNames), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (ContainerNames));
      }
    }
  }
}
