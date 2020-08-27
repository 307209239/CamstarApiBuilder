// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseDisposition_Info
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
  public class PhaseDisposition_Info : Phase_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseDisposition_Info_EventLots")]
    protected Info _EventLots;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDisposition_Info_AssignedLots")]
    protected AvailableLotDetail_Info _AssignedLots;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDisposition_Info_Name")]
    protected new Info _Name;

    public Info EventLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLots), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventLots));
      }
    }

    public AvailableLotDetail_Info AssignedLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail_Info) this.PropertyGet(nameof (AssignedLots));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
