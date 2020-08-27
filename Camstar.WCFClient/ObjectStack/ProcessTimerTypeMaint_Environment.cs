// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerTypeMaint_Environment
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
  public class ProcessTimerTypeMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerTypeMaint_Environment_ObjectChanges")]
    [Metadata("Process Timer Type", "ProcessTimerTypeChanges", false, false, false, "ProcessTimerTypeChanges", 1048873, true, false, false, null)]
    protected ProcessTimerTypeChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerTypeMaint_Environment_ObjectToChange")]
    [Metadata("Process Timer Type", "ProcessTimerType", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Process Timer Type", "ProcessTimerType", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerTypeMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public ProcessTimerTypeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessTimerTypeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
