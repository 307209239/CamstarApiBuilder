// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GroupStart_Info
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
  public class GroupStart_Info : Start_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GroupStart_Info_Details")]
    protected GroupStartDetails_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "GroupStart_Info_CurrentStatusDetails")]
    protected V3_CurrentStatusStartDetails_Info _CurrentStatusDetails;

    public GroupStartDetails_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (GroupStartDetails_Info) this.PropertyGet(nameof (Details));
      }
    }

    public V3_CurrentStatusStartDetails_Info CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (V3_CurrentStatusStartDetails_Info) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }
  }
}
