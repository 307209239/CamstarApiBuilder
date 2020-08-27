// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerCompletedSubTask_Info
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
  public class ContainerCompletedSubTask_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_Pass")]
    protected Info _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_CompletionTimestamp")]
    protected Info _CompletionTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_CompletionTimestampGMT")]
    protected Info _CompletionTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_NbrTimesProcessed")]
    protected Info _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Pass));
      }
    }

    public Info CompletionTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionTimestamp));
      }
    }

    public Info CompletionTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestampGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionTimestampGMT));
      }
    }

    public Info NbrTimesProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (NbrTimesProcessed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NbrTimesProcessed));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
