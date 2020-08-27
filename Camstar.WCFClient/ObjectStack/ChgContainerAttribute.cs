// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttribute
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
  public class ChgContainerAttribute : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_ChildProcessingMode")]
    protected Enumeration<ChildProcessingEnum, int> _ChildProcessingMode;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_RecordDetailPostHistory")]
    protected Primitive<bool> _RecordDetailPostHistory;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_RecordDetailPreHistory")]
    protected Primitive<bool> _RecordDetailPreHistory;

    public override bool Equals(object obj)
    {
      return obj is ChgContainerAttribute && object.Equals((object) this._ChildProcessingMode, (object) ((ChgContainerAttribute) obj)._ChildProcessingMode) && (object.Equals((object) this._RecordDetailPostHistory, (object) ((ChgContainerAttribute) obj)._RecordDetailPostHistory) && object.Equals((object) this._RecordDetailPreHistory, (object) ((ChgContainerAttribute) obj)._RecordDetailPreHistory)) && base.Equals(obj);
    }

    public Enumeration<ChildProcessingEnum, int> ChildProcessingMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildProcessingMode), (object) value);
      }
      get
      {
        return (Enumeration<ChildProcessingEnum, int>) this.PropertyGet(nameof (ChildProcessingMode));
      }
    }

    public Primitive<bool> RecordDetailPostHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPostHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordDetailPostHistory));
      }
    }

    public Primitive<bool> RecordDetailPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPreHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordDetailPreHistory));
      }
    }
  }
}
