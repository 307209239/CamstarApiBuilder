// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarUpdateCalShiftMaint_Info
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
  public class MfgCalendarUpdateCalShiftMaint_Info : MfgCalendarMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarUpdateCalShiftMaint_Info_ShiftEnd")]
    protected Info _ShiftEnd;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarUpdateCalShiftMaint_Info_ShiftStart")]
    protected Info _ShiftStart;

    public Info ShiftEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftEnd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShiftEnd));
      }
    }

    public Info ShiftStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftStart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShiftStart));
      }
    }
  }
}
