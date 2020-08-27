// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectDataPoints
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
  public class CollectDataPoints : GenericTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_DataPointCollection")]
    protected NamedSubentityRef _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_ServiceDetails")]
    protected DPCollectionGroupDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Instructions")]
    protected Primitive<string> _Instructions;

    public override bool Equals(object obj)
    {
      return obj is CollectDataPoints && object.Equals((object) this._DataPointCollection, (object) ((CollectDataPoints) obj)._DataPointCollection) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((CollectDataPoints) obj)._ServiceDetails) && object.Equals((object) this._Submit, (object) ((CollectDataPoints) obj)._Submit)) && object.Equals((object) this._Instructions, (object) ((CollectDataPoints) obj)._Instructions) && base.Equals(obj);
    }

    public NamedSubentityRef DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public DPCollectionGroupDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DPCollectionGroupDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }

    public Primitive<string> Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instructions));
      }
    }
  }
}
