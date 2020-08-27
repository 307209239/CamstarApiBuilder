// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectDataPoints_Environment
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
  public class CollectDataPoints_Environment : GenericTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Environment_DataPointCollection")]
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollection", false, false, false, "NamedSubentityRef", 1052416, false, false, false, null)]
    protected Environment _DataPointCollection;
    [Metadata("The DPCollectionGroupDetail is used to collect data points for a group within the DataPointCollectionDef.", "DPCollectionGroupDetail", false, false, false, "DPCollectionGroupDetail", 1052432, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Environment_ServiceDetails")]
    protected DPCollectionGroupDetail_Environment _ServiceDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Environment_Submit")]
    protected Environment _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Environment_Instructions")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051642, false, false, false, null)]
    protected Environment _Instructions;

    public Environment DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public DPCollectionGroupDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DPCollectionGroupDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
      }
    }

    public Environment Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instructions));
      }
    }
  }
}
