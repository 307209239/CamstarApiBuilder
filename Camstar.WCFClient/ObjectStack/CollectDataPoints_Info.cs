// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectDataPoints_Info
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
  public class CollectDataPoints_Info : GenericTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Info_DataPointCollection")]
    protected Info _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Info_ServiceDetails")]
    protected DPCollectionGroupDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPoints_Info_Instructions")]
    protected Info _Instructions;

    public Info DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public DPCollectionGroupDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DPCollectionGroupDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
      }
    }

    public Info Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instructions));
      }
    }
  }
}
