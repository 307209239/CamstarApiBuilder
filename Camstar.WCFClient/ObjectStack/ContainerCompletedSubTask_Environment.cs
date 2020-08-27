// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerCompletedSubTask_Environment
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
  public class ContainerCompletedSubTask_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Material Container", "MaterialContainer", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_Container")]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_Pass")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050546, false, false, false, "0")]
    protected Environment _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_CompletionTimestamp")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051881, false, false, false, null)]
    protected Environment _CompletionTimestamp;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051882, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_CompletionTimestampGMT")]
    protected Environment _CompletionTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_NbrTimesProcessed")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050552, false, false, false, null)]
    protected Environment _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedSubTask_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Pass));
      }
    }

    public Environment CompletionTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionTimestamp));
      }
    }

    public Environment CompletionTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestampGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionTimestampGMT));
      }
    }

    public Environment NbrTimesProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (NbrTimesProcessed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NbrTimesProcessed));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
