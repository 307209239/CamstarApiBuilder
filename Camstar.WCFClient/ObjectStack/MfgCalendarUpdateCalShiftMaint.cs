// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarUpdateCalShiftMaint
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
  public class MfgCalendarUpdateCalShiftMaint : MfgCalendarMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarUpdateCalShiftMaint_ShiftEnd")]
    protected Primitive<DateTime> _ShiftEnd;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarUpdateCalShiftMaint_ShiftStart")]
    protected Primitive<DateTime> _ShiftStart;

    public override bool Equals(object obj)
    {
      return obj is MfgCalendarUpdateCalShiftMaint && object.Equals((object) this._ShiftEnd, (object) ((MfgCalendarUpdateCalShiftMaint) obj)._ShiftEnd) && object.Equals((object) this._ShiftStart, (object) ((MfgCalendarUpdateCalShiftMaint) obj)._ShiftStart) && base.Equals(obj);
    }

    public Primitive<DateTime> ShiftEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftEnd), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ShiftEnd));
      }
    }

    public Primitive<DateTime> ShiftStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftStart), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ShiftStart));
      }
    }
  }
}
