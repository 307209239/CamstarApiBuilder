// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollection_Environment
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
  public class DPCollection_Environment : ParametricData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollection_Environment_DPCollectionGroups")]
    [Metadata("The DPCollectionGroupDetail is used to collect data points for a group within the DataPointCollectionDef.", "DPCollectionGroupDetail", false, false, false, "DPCollectionGroupDetail", 1052962, false, true, false, null)]
    protected DPCollectionGroupDetail_Environment _DPCollectionGroups;

    public DPCollectionGroupDetail_Environment DPCollectionGroups
    {
      [param: In] set
      {
        this.PropertySet(nameof (DPCollectionGroups), (object) value);
      }
      get
      {
        return (DPCollectionGroupDetail_Environment) this.PropertyGet(nameof (DPCollectionGroups));
      }
    }
  }
}
