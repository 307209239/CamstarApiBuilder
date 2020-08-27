// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarUpdateCalShiftMaint_Environment
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
  public class MfgCalendarUpdateCalShiftMaint_Environment : MfgCalendarMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarUpdateCalShiftMaint_Environment_ShiftEnd")]
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1049942, false, false, false, null)]
    protected Environment _ShiftEnd;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarUpdateCalShiftMaint_Environment_ShiftStart")]
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1049943, false, false, false, null)]
    protected Environment _ShiftStart;

    public Environment ShiftEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftEnd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShiftEnd));
      }
    }

    public Environment ShiftStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftStart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShiftStart));
      }
    }
  }
}
