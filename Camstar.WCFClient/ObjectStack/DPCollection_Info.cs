// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollection_Info
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
  public class DPCollection_Info : ParametricData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollection_Info_DPCollectionGroups")]
    protected DPCollectionGroupDetail_Info _DPCollectionGroups;

    public DPCollectionGroupDetail_Info DPCollectionGroups
    {
      [param: In] set
      {
        this.PropertySet(nameof (DPCollectionGroups), (object) value);
      }
      get
      {
        return (DPCollectionGroupDetail_Info) this.PropertyGet(nameof (DPCollectionGroups));
      }
    }
  }
}
