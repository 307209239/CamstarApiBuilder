// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerCompletedSubTask
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
  public class ContainerCompletedSubTask : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Pass")]
    protected Primitive<bool> _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_CompletionTimestamp")]
    protected Primitive<DateTime> _CompletionTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_CompletionTimestampGMT")]
    protected Primitive<DateTime> _CompletionTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_NbrTimesProcessed")]
    protected Primitive<int> _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ContainerCompletedSubTask && object.Equals((object) this._ExportImportKey, (object) ((ContainerCompletedSubTask) obj)._ExportImportKey) && (object.Equals((object) this._Container, (object) ((ContainerCompletedSubTask) obj)._Container) && object.Equals((object) this._Pass, (object) ((ContainerCompletedSubTask) obj)._Pass)) && (object.Equals((object) this._CompletionTimestamp, (object) ((ContainerCompletedSubTask) obj)._CompletionTimestamp) && object.Equals((object) this._CompletionTimestampGMT, (object) ((ContainerCompletedSubTask) obj)._CompletionTimestampGMT) && (object.Equals((object) this._NbrTimesProcessed, (object) ((ContainerCompletedSubTask) obj)._NbrTimesProcessed) && object.Equals((object) this._IsFrozen, (object) ((ContainerCompletedSubTask) obj)._IsFrozen))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<bool> Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Pass));
      }
    }

    public Primitive<DateTime> CompletionTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionTimestamp));
      }
    }

    public Primitive<DateTime> CompletionTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestampGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionTimestampGMT));
      }
    }

    public Primitive<int> NbrTimesProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (NbrTimesProcessed), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NbrTimesProcessed));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
