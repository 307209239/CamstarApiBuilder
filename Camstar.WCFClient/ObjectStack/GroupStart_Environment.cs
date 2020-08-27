// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GroupStart_Environment
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
  public class GroupStart_Environment : Start_Environment
  {
    [Metadata("Group start details.", "GroupStartDetails", false, true, false, "GroupStartDetails", 1049090, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GroupStart_Environment_Details")]
    protected GroupStartDetails_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "GroupStart_Environment_CurrentStatusDetails")]
    [Metadata("V3_CurrentStatusUnitStartDetails are subclassed from CurrentStatusStartDetails for compatibility only and should be used in GroupStart and UnitStart as CurrentStatusDetails field type.", "V3_CurrentStatusStartDetails", false, false, false, "V3_CurrentStatusStartDetails", 1049869, true, false, false, null)]
    protected V3_CurrentStatusStartDetails_Environment _CurrentStatusDetails;

    public GroupStartDetails_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (GroupStartDetails_Environment) this.PropertyGet(nameof (Details));
      }
    }

    public V3_CurrentStatusStartDetails_Environment CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (V3_CurrentStatusStartDetails_Environment) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }
  }
}
